using System.Collections.Generic;

    using BlackboardWebApi.Model;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Identity.Web.Resource;
    using System;
    using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace BlackboardWebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class BlackboardContentController : Controller
    {
        static readonly Dictionary<string, Dictionary<DateTime, BlackboardContent>> s_blackboardContentStore =
            new Dictionary<string, Dictionary<DateTime, BlackboardContent>>();

        /// <summary>
        /// The Web API will only accept tokens 1) for users, and 
        /// 2) having the access_as_user scope for this API
        /// </summary>
        static readonly string[] scopeRequiredByApi = new string[] { "access_as_user" };

        [HttpGet]
        public ActionResult<List<BlackboardContent>> Get()
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(scopeRequiredByApi);
            if (s_blackboardContentStore.TryGetValue(UserInfoController.GetUserId(User), out var usersBlackboards))
            {
                return usersBlackboards.Values.ToList();
            }

            return StatusCode(StatusCodes.Status404NotFound);
        }

        [HttpGet]
        public ActionResult<BlackboardContent> Get(DateTime date)
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(scopeRequiredByApi);
            if (s_blackboardContentStore.TryGetValue(UserInfoController.GetUserId(User), out var usersBlackboards))
            {
                if (usersBlackboards.TryGetValue(date.Date, out var userBlackboardForDate))
                {
                    return userBlackboardForDate;
                }
            }

            return StatusCode(StatusCodes.Status404NotFound);
        }

        // Create a new blackboard entry for a particular date.
        [HttpPost]
        public ActionResult<BlackboardContent> Post([FromBody] BlackboardContent blackboardContent)
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(scopeRequiredByApi);
            if (s_blackboardContentStore.TryGetValue(UserInfoController.GetUserId(User), out var usersBlackboards))
            {
                if (!usersBlackboards.ContainsKey(blackboardContent.ContentDate))
                {
                    usersBlackboards.Add(blackboardContent.ContentDate, blackboardContent);
                    return StatusCode(StatusCodes.Status200OK);
                }
            }

            return StatusCode(StatusCodes.Status409Conflict);
        }

        // Update an existing blackboard entry for a particular date.
        [HttpPut]
        public ActionResult Put(DateTime contentDate, string blackboardContent)
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(scopeRequiredByApi);
            if (s_blackboardContentStore.TryGetValue(UserInfoController.GetUserId(User), out var usersBlackboards))
            {
                if (usersBlackboards.TryGetValue(contentDate.Date, out var userBlackboardForDate))
                {
                    userBlackboardForDate.Content = blackboardContent;
                }
            }

            return StatusCode(StatusCodes.Status404NotFound);
        }
    }
}
