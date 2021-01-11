using BlackboardWebApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace BlackboardWebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class UserInfoController : Controller
    {
        private const string UserIdPropertyName = "preferred_username";

        static readonly Dictionary<string, UserInfo> s_userStore = new Dictionary<string, UserInfo>();

        /// <summary>
        /// The Web API will only accept tokens 1) for users, and 
        /// 2) having the access_as_user scope for this API
        /// </summary>
        static readonly string[] scopeRequiredByApi = new string[] { "access_as_user" };

        internal static string GetUserId(ClaimsPrincipal user)
        {
            string userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return userId;
        }

        // GET: api/values
        [HttpGet]
        public ActionResult<UserInfo> Get()
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(scopeRequiredByApi);

            string userId = GetUserId(User);
            if (s_userStore.TryGetValue(userId, out var userInfo))
            {
                return userInfo;
            }

            userInfo = new UserInfo();
            userInfo.Name = User.Claims.Where(item => item.Type == "name").FirstOrDefault()?.Value;
            userInfo.UserId = userId;
            userInfo.PreferredUserName = User.Claims.Where(item => item.Type == UserIdPropertyName).FirstOrDefault()?.Value;
            var blackboardHeadline = $"{userInfo.Name}'s Blackboard Created at {DateTimeOffset.Now}";
            blackboardHeadline += $"\n\r{(new string('*', blackboardHeadline.Length))}";
            userInfo.FrontPage = blackboardHeadline;
            s_userStore.Add(userId, userInfo);
            return userInfo;
        }

        // POST api/values
        [HttpPut]
        public ActionResult Put(string frontPage)
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(scopeRequiredByApi);
            string userId = GetUserId(User);
            if (s_userStore.TryGetValue(userId, out var userInfo))
            {
                userInfo.FrontPage = frontPage;
                return StatusCode(StatusCodes.Status200OK);
            }

            return StatusCode(StatusCodes.Status404NotFound);
        }
    }
}
