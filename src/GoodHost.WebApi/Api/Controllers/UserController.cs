using Abp.WebApi.Controllers;
using GoodHost.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GoodHost.Api.Controllers
{
    public class UserController : AbpApiController
    {
        /// <summary>
        /// Returns all movies.
        /// </summary>
        /// <returns>A JSON list of all movies.</returns>
        ///[Route("users/all")]
        [HttpGet]
        public IHttpActionResult All()
        {
            List<User> users = new List<User>()
        {
            new User()
            {
                Id = 5,
                Name = "Mujo",
                Surname = "Mujic",
                UserName = "mmujic",
                EmailAddress = "test",
            },
            new User()
            {
                Id = 6,
                Name = "Selma",
                Surname = "Skopljakovic",
                UserName = "selma",
                EmailAddress = "test1"
            },
            new User()
            {
                Id = 7,
                Name = "Sejla",
                Surname = "Selimovic",
                UserName = "sejlas",
                EmailAddress = "test2"
            }
        };

            return Ok(users);
        }
    }
}
