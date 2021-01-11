using BlackboardWebApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

        static Dictionary<string, UserInfo> s_userStore = new Dictionary<string, UserInfo>();

        /// <summary>
        /// The Web API will only accept tokens 1) for users, and 
        /// 2) having the access_as_user scope for this API
        /// </summary>
        static readonly string[] scopeRequiredByApi = new string[] { "access_as_user" };
        static bool s_dataLoaded;

        private IWebHostEnvironment _webHostEnvironment;

        public UserInfoController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: api/values
        [HttpGet]
        public ActionResult<UserInfo> Get()
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(scopeRequiredByApi);

            string userId = GetUserId(User);
            EnsureDataLoaded();
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
            SaveData();
            return userInfo;
        }

        // POST api/values
        [HttpPut]
        public ActionResult Put([FromBody] UserInfo remoteUserInfo)
        {
            HttpContext.VerifyUserHasAnyAcceptedScope(scopeRequiredByApi);

            string userId = GetUserId(User);
            if (s_userStore.TryGetValue(userId, out var userInfo))
            {
                userInfo.FrontPage = remoteUserInfo.FrontPage;
                userInfo.LastUpdated = remoteUserInfo.LastUpdated;
                SaveData();
                return StatusCode(StatusCodes.Status200OK);
            }

            return StatusCode(StatusCodes.Status404NotFound);
        }

        internal static string GetUserId(ClaimsPrincipal user)
        {
            string userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return userId;
        }

        internal void SaveData()
        {
            string docPath = Path.Combine(_webHostEnvironment.ContentRootPath, "App_Data/docs");
            // serialize JSON directly to a file
            var fileInfo = new FileInfo(docPath + "\\data.json");
            if (!fileInfo.Directory.Exists)
            {
                fileInfo.Directory.Create();
            }

            using (StreamWriter file = System.IO.File.CreateText($"{docPath}\\data.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, s_userStore);
            }
        }

        internal void EnsureDataLoaded()
        {
            if (!s_dataLoaded)
            {
                string docPath = Path.Combine(_webHostEnvironment.ContentRootPath, "App_Data/docs");
                var fileInfo = new FileInfo(docPath + "\\data.json");
                if (!fileInfo.Exists)
                {
                    return;
                }

                // serialize JSON directly to a file
                using (TextReader file = System.IO.File.OpenText($"{docPath}\\data.json"))
                {
                    JsonReader jsonReader = new JsonTextReader(file);

                    JsonSerializer serializer = new JsonSerializer();
                    s_userStore = serializer.Deserialize<Dictionary<string, UserInfo>>(jsonReader);
                }

                s_dataLoaded = true;
            }
        }
    }
}
