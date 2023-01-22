﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetHub.Api.Shared.Abstractions;
using NetHub.Application.Features.Public.Users.ChangeUsername;
using NetHub.Application.Features.Public.Users.CheckUserExists;
using NetHub.Application.Features.Public.Users.CheckUsername;
using NetHub.Application.Features.Public.Users.Dashboard;
using NetHub.Application.Features.Public.Users.Dto;
using NetHub.Application.Features.Public.Users.Info;
using NetHub.Application.Features.Public.Users.Me;
using NetHub.Application.Features.Public.Users.Me.Dashboard;
using NetHub.Application.Features.Public.Users.Profile;

namespace NetHub.Api.Areas.Public.Controllers;

public class UserController : ApiController
{
    [HttpGet("me")]
    public async Task<UserDto> GetMe()
    {
        var user = await Mediator.Send(new GetUserRequest());
        return user;
    }

    [AllowAnonymous]
    [HttpGet("me/dashboard")]
    public async Task<DashboardDto> GetMyDashboardInfo()
    {
        var result = await Mediator.Send(new GetMyDashboardRequest());
        return result;
    }

    [AllowAnonymous]
    [HttpGet("users-info")]
    public async Task<UserDto[]> GetUsersInfo([FromQuery] GetUsersInfoRequest request)
    {
        var users = await Mediator.Send(request);
        return users;
    }

    [AllowAnonymous]
    [HttpGet("{username:alpha}/dashboard")]
    public async Task<DashboardDto> GetUserDashboardInfo(string username)
    {
        var result = await Mediator.Send(new GetUserDashboardRequest(username));
        return result;
    }

    [HttpPut("username")]
    public async Task<IActionResult> ChangeUsername([FromBody] ChangeUsernameRequest request)
    {
        await Mediator.Send(request);
        return NoContent();
    }

    [HttpPut("profile")]
    public async Task<IActionResult> ChangeProfile([FromBody] UpdateUserProfileRequest request)
    {
        await Mediator.Send(request);
        return NoContent();
    }

    [AllowAnonymous]
    [HttpPost("check-username")]
    public async Task<IActionResult> CheckUsername([FromBody] CheckUsernameRequest request)
    {
        var result = await Mediator.Send(request);
        return Ok(result);
    }

    [AllowAnonymous]
    [HttpPost("check-user-exists")]
    public async Task<IActionResult> CheckUserExists([FromBody] CheckUserExistsRequest request)
    {
        var result = await Mediator.Send(request);
        return Ok(result);
    }
}