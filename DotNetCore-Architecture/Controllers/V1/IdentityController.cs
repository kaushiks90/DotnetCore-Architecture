﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore_Architecture.Contracts;
using DotNetCore_Architecture.Contracts.V1.Requests;
using DotNetCore_Architecture.Contracts.V1.Responses;
using DotNetCore_Architecture.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_Architecture.Controllers.V1
{
    public class IdentityController : Controller
    {
        private readonly IIdentityService _identityService;
        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost(ApiRoutes.Identity.Register)]
        public async Task<IActionResult> Register([FromBody] UserRegistrationRequest request)
        {
            var authResponse = await _identityService.RegisterAsync(request.Email, request.Password);
            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = authResponse.Errors
                });
            }
            return Ok(new AuthSuccessResponse {Token=authResponse.Token });
        }
    }
}