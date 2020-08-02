using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTredaApi.Data;
using WebTredaApi.DataProcess;

namespace WebTredaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForStoreController : ControllerBase
    {
            private readonly ForStoreId _DBSP;

            public ForStoreController(ForStoreId DBSP)
            {
                this._DBSP = DBSP ?? throw new ArgumentNullException(nameof(DBSP));
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<IEnumerable<ForStore>>> Get(int id)
            {
                var response = await _DBSP.SPProductosPorTienda(id);
                if (response == null) { return NotFound(); }
                return response;
            }

    }
    
}