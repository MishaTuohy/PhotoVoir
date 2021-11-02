using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PhotoVoir.API.Controllers
{
    public class BaseController : Controller
    {
        public readonly IMediator _mediator;
        public readonly IMapper _mapper;

        public BaseController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
    }
}
