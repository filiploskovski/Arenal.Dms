using System.Threading.Tasks;
using Arenal.Dms.Core.Models;
using Arenal.Dms.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Arenal.Dms.WebApp.Controllers
{
    [Route("api/document-type")]
    [ApiController]
    public class DocumentTypeController : ControllerBase
    {
        private readonly IDocumentTypeService _documentTypeService;

        public DocumentTypeController(IDocumentTypeService documentTypeService)
        {
            _documentTypeService = documentTypeService;
        }

        [HttpPost]
        public async Task<IActionResult> Init(DocumentTypeModel model)
        {
            return Ok(await _documentTypeService.Init(model));
        }

        [HttpPost]
        public async Task<IActionResult> Create(DocumentTypeModel model)
        {
            await _documentTypeService.Create(model);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(DocumentTypeModel model)
        {
            await _documentTypeService.Update(model);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _documentTypeService.Delete(id);
            return Ok();
        }
    }
}