using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NeerCore.Exceptions;
using NetHub.Admin.Abstractions;
using NetHub.Application.Features.Public.Users.Dto;
using NetHub.Application.Interfaces;
using NetHub.Application.Options;

namespace NetHub.Admin.Endpoints.Jwt;

[Tags(TagNames.Jwt)]
[ApiVersion(Versions.V1)]
public class JwtRefreshEndpoint : ResultEndpoint<AuthResult>
{
	private readonly IJwtService _jwtService;
	private readonly JwtOptions _jwtOptions;

	public JwtRefreshEndpoint(IJwtService jwtService,
		IOptions<JwtOptions> jwtOptionsAccessor)
	{
		_jwtService = jwtService;
		_jwtOptions = jwtOptionsAccessor.Value;
	}


	[HttpPost("jwt/refresh")]
	public override async Task<AuthResult> HandleAsync(CancellationToken ct = default)
	{
		if (HttpContext.Request.Cookies.TryGetValue(_jwtOptions.RefreshTokenCookieName, out var refreshToken))
			return await _jwtService.RefreshAsync(refreshToken, ct);
		
		throw new UnauthorizedException("Refresh token doesn't exist");
	}
}