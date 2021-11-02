using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PhotoVoir.API.Models.Requests.User;
using PhotoVoir.Application.Common.Apiroutes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoVoir.API.Controllers
{
    [ApiController]
    public class UserController : BaseController
    {
        public UserController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }
        [HttpPost(UserRoutes.Base)]
        public async Task<IActionResult> Post([FromBody] CreateUserRequest request)
        {
            var query = _mapper.Map<CreateUserRequest, CreateUserCommand>(request);
            var result = await _mediator.Send(query);
            return result != null ? (IActionResult) Ok(result) : NotFound();
        }

        [HttpPost(UserRoutes.Base)]
        public async Task<IActionResult> GetAll()
        {
            return View();
        }

        [HttpPost(UserRoutes.GetById)]
        public async Task<IActionResult> GetById()
        {
            return View();
        }

        [HttpPost(UserRoutes.UpdateAll)]
        public async Task<IActionResult> Update()
        {
            return View();
        }

        [HttpPost(UserRoutes.Delete)]
        public async Task<IActionResult> DeleteAll()
        {
            return View();
        }
    }
}
