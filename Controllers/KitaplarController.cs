using BootcampAPIProje.Queries;
using BootcampAPIProje.Queries.GetAll;
using BootcampAPIProje.Commands.KitapInsert;
using BootcampAPIProje.Commands.KitapUpdate;
using BootcampAPIProje.Commands.KitapDelete;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BootcampAPIProje.Controllers
{
    public class KitaplarController : ControllerCustomBase
    {
        private readonly IMediator _mediator;

        public KitaplarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new KitapGetAllQuery());

            return CreateActionResult(response);
        }

        [HttpGet("pages/{page}/{pagesize}")]
        public async Task<IActionResult> GetAllWithPage(int page, int pagesize)
        {

            var response = await _mediator.Send(new KitapWithPageQuery() { Page = page, PageSize = pagesize });

            return CreateActionResult(response);

        }


        [HttpPost]
        public async Task<IActionResult> Save(KitapInsertCommand kitapInsertCommand)
        {

            return CreateActionResult(await _mediator.Send(kitapInsertCommand));
        }


        [HttpPut]
        public async Task<IActionResult> Update(KitapUpdateCommand kitapUpdateCommand)
        {

            return CreateActionResult(await _mediator.Send(kitapUpdateCommand));
        }



        [HttpDelete("{isbn}")]
        public async Task<IActionResult> Delete(int isbn)
        {

            return CreateActionResult(await _mediator.Send(new KitapDeleteCommand() { Isbn = isbn }));
        }
    }
}