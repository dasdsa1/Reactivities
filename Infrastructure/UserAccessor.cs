using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

public class UserAccessor : IUserAccessor
{
    private readonly IHttpContextAccessor _httpContextAcessor;

    public UserAccessor(IHttpContextAccessor httpContextAcessor)
    {
        _httpContextAcessor = httpContextAcessor;
    }

    public string GetUsername()
    {
        return _httpContextAcessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
    }
}
