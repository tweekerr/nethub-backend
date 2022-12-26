using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeerCore.Exceptions;
using NetHub.Admin.Abstractions;
using NetHub.Admin.Infrastructure.Models.Users;
using NetHub.Application.Extensions;
using NetHub.Data.SqlServer.Context;
using NetHub.Data.SqlServer.Entities.Identity;

namespace NetHub.Admin.Endpoints.Users;

[ApiVersion(Versions.V1)]
[Tags(TagNames.Users)]
// [Authorize(Policy = Policies.HasManageUsersPermission)]
[AllowAnonymous]
public sealed class UserCreateEndpoint : Endpoint<UserCreate, User>
{
    private readonly ISqlServerDatabase _database;
    private readonly UserManager<AppUser> _userManager;

    public UserCreateEndpoint(ISqlServerDatabase database, UserManager<AppUser> userManager)
    {
        _database = database;
        _userManager = userManager;
    }


    [HttpPost("users")]
    public override async Task<User> HandleAsync([FromBody] UserCreate request, CancellationToken ct = default)
    {
        if (await _database.Set<AppUser>().Where(e => e.NormalizedUserName == request.UserName.ToUpper()).AnyAsync(ct))
            throw new ValidationFailedException($"User with given username '{nameof(UserCreate.UserName)}' already exists.");

        var user = request.Adapt<AppUser>();

        IdentityResult result = await _userManager.CreateAsync(user, "Test1234");
        if (!result.Succeeded)
            throw new ValidationFailedException("User not created.", result.ToErrorDetails());

        // await _userManager.AddToRoleAsync(user, "Admin");

        await _database.SaveChangesAsync(ct);

        return user.Adapt<User>();
    }
}