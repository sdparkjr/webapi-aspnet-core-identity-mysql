using System;
using AspNetCoreIdentityMysql.API.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIdentityMysql.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Base")]
    public abstract class BaseController : Controller
    {       

        protected Guid UsuarioId { get; set; }

        public BaseController()
        {


        }

        protected new IActionResult Response(object result = null)
        {

            if (Valido())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = "" //add erro dos Notitifactions
            });
        }

        protected bool Valido()
        {
            //IMPLEMENTAR O  FLUENTEVALIDANTION DO DOMAIN
            return true;
        }
    }
}