using System;
using BooksApi.Models;
using BooksApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Net.Http.Headers;
using MongoDB.Bson;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<User>> Get() =>
            _userService.Get();

        [Authorize]
        [HttpGet("{id:length(24)}", Name = "GetUser")]
        public ActionResult<User> Get(string id)
        {
            var authHeader = Request.Headers[HeaderNames.Authorization];
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(authHeader.ToString().Remove(0, 7));
            var sub = token.Payload.Sub.Remove(0,6);

            Console.WriteLine(sub);

            var user = _userService.Get(id);

            if (user == null) {
                return NotFound();
            }

            if (user.Auth0Id == sub) {
                return user;
            }

            return Unauthorized();
        }

        [HttpPost]
        public ActionResult<User> Create(User user)
        {
            User userCreated = _userService.Create(user);

            return CreatedAtRoute("GetUser", new { id = userCreated.Id.ToString() }, user);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, User userIn)
        {
            var user = _userService.Get(id);

            if (user == null)
            {
                return NotFound();
            }

            _userService.Update(id, userIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var user = _userService.Get(id);

            if (user == null)
            {
                return NotFound();
            }

            _userService.Remove(user.Id);

            return NoContent();
        }
    }
}