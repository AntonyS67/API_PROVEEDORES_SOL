using Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/suppliers")]
    public class SupplierController : Controller
    {
        private readonly ISupplierUseCase supplierUseCase;

        public SupplierController(ISupplierUseCase supplierUseCase)
        {
            this.supplierUseCase = supplierUseCase;
        }

        [HttpGet]
        [Route("/list")]
        public async Task<IActionResult> List()
        {
            try
            {
                var suppliers = await this.supplierUseCase.ListSuppliers();
                return Ok(suppliers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [Route("/create")]
        public async Task<IActionResult> Create([FromBody] Supplier request)
        {
            try
            {
                var supplier = await this.supplierUseCase.CreateSupplier(request);
                return Ok(supplier);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/show")]
        public async Task<IActionResult> Show([FromQuery] int id)
        {
            try
            {
                var supplier = await this.supplierUseCase.GetSupplier(id);
                return Ok(supplier);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("/update")]
        public async Task<IActionResult> Update([FromBody] Supplier request)
        {
            try
            {
                var supplier = await this.supplierUseCase.UpdateSupplier(request);
                return Ok(supplier);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("/delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            try
            {
                var supplier = await this.supplierUseCase.DeleteSupplier(id);
                return Ok(supplier);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
