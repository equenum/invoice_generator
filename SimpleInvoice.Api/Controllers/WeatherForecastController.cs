using Microsoft.AspNetCore.Mvc;

namespace SimpleInvoice.Api.Controllers;

[ApiController]
[Route("public/api/invoices")]
public class InvoicesController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok();
    }
}
