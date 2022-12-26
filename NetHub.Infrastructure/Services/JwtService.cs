﻿using Microsoft.EntityFrameworkCore;
using NeerCore.Data.EntityFramework.Extensions;
using NeerCore.DependencyInjection;
using NeerCore.Exceptions;
using NetHub.Application.Features.Public.Users.Dto;
using NetHub.Application.Interfaces;
using NetHub.Application.Services;
using NetHub.Data.SqlServer.Context;
using NetHub.Data.SqlServer.Entities;
using NetHub.Data.SqlServer.Entities.Identity;

namespace NetHub.Infrastructure.Services;

[Service]
internal sealed class JwtService : IJwtService
{
    private readonly ISqlServerDatabase _database;
    private readonly RefreshTokenGenerator _refreshTokenGenerator;
    private readonly AccessTokenGenerator _accessTokenGenerator;

    public JwtService(ISqlServerDatabase database, AccessTokenGenerator accessTokenGenerator,
        RefreshTokenGenerator refreshTokenGenerator)
    {
        _database = database;
        _refreshTokenGenerator = refreshTokenGenerator;
        _accessTokenGenerator = accessTokenGenerator;
    }

    public async Task<AuthResult> GenerateAsync(AppUser user, CancellationToken ct)
    {
        (string? accessToken, DateTime accessTokenExpires) = await _accessTokenGenerator.GenerateAsync(user, ct);
        (string? refreshToken, DateTime refreshTokenExpires) = await _refreshTokenGenerator.GenerateAsync(user, ct);

        return new AuthResult
        {
            Username = user.UserName,
            Token = accessToken,
            TokenExpires = accessTokenExpires,
            RefreshToken = refreshToken,
            RefreshTokenExpires = refreshTokenExpires
        };
    }

    public async Task<AuthResult> RefreshAsync(string refreshToken, CancellationToken ct)
    {
        var refreshTokens = _database.Set<RefreshToken>();

        var token = await refreshTokens
            .Where(rt => rt.Value == refreshToken)
            .Include(rt => rt.User)
            .FirstOr404Async(ct);

        if (!_refreshTokenGenerator.IsValid(token))
            throw new ValidationFailedException("Refresh token is invalid.");

        var result = await GenerateAsync(token.User!, ct);
        token.User = null;

        refreshTokens.Remove(token);
        await _database.SaveChangesAsync(cancel: ct);

        return result;
    }
}