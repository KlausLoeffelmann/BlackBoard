using BlackBoardWebApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace BlackBoardWebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class UserLoginInfoController : Controller
    {
        static readonly ConcurrentBag<UserLoginInfo> UserLoginInfoStore = new ConcurrentBag<UserLoginInfo>();

        /// <summary>
        /// The Web API will only accept tokens 1) for users, and 
        /// 2) having the access_as_user scope for this API
        /// </summary>
        static readonly string[] scopeRequiredByApi = new string[] { "access_as_user" };

        // GET: api/values
        [HttpGet]
        public UserLoginInfo Get()
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(scopeRequiredByApi);
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userLoginInfo = UserLoginInfoStore.Where(t => t.UserId == userId).FirstOrDefault();
            if (userLoginInfo is null)
            {
                userLoginInfo.Name = userId;
                userLoginInfo.UserId = userId;
                userLoginInfo.Blackboard = $"Created at {DateTimeOffset.Now} ";
                UserLoginInfoStore.Add(userLoginInfo);
            }

            return userLoginInfo;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] UserLoginInfo passedLoginInfo)
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(scopeRequiredByApi);
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userLoginInfo = UserLoginInfoStore.Where(t => t.UserId == userId).FirstOrDefault();

            if (userLoginInfo is null)
            {
                userLoginInfo.Name = userId;
                userLoginInfo.UserId = userId;
                userLoginInfo.Blackboard = passedLoginInfo.Blackboard;
                UserLoginInfoStore.Add(userLoginInfo);
            }
            else
            {
                userLoginInfo.Blackboard = passedLoginInfo.Blackboard;
            }
        }
    }
}
