using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoVoir.API.Controllers
{
    public class ProductController : BaseController
    {
        public ProductController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
{
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
