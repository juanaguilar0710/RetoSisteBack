using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RetoSisteBack.Application.DTO;
using RetoSisteBack.Infraestructure.DataModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetoSisteBack.Controllers
{
    [Route("api/v1/credit")]
    [ApiController]
    public class CreditController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<CreditController> _logger;

        public CreditController(IMediator mediator, ILogger<CreditController> logger)
        {
            _mediator = mediator;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        [HttpPost]
        [Route("create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ResponseContentDTO))]
        public async Task<ActionResult<string>> createCredit([FromBody] CreditDataEntity objCredit)
        {
            try
            {

                return await _mediator.Send(new createCredit
                {
                    Id = objCredit.Id,
                    Nombres = objCredit.Nombres,
                    Apellidos = objCredit.Apellidos,
                    Celular = objCredit.Celular,
                    Correo = objCredit.Correo,
                    TipoID = objCredit.TipoID,
                    NumeroID = objCredit.NumeroID,
                    DireccionResidencia = objCredit.DireccionResidencia,
                    Ciudad = objCredit.Ciudad,
                    Valor = objCredit.Valor,
                    Cuotas = objCredit.Cuotas,
                    Estado = objCredit.Estado
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error al editar la informacion del credito ={objCredit.Id}");
                throw;
            }
        }

        [HttpGet("{platform}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ResponseContentDTO))]
        public async Task<ActionResult<List<CreditDataEntity>>> GetCredits(string platform)
        {
            try
            {
                return await _mediator.Send(new CreditsPlatform { Platform = platform});
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error al consultar los creditos");
                throw;
            }
        }

        [HttpPut]
        [Route("update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ResponseContentDTO))]
        public async Task<ActionResult<string>> updateCredit([FromBody] CreditDataEntity objCredit)
        {
            try
            {
                return await _mediator.Send(new updateCredit
                {
                    Id = objCredit.Id,
                    Nombres= objCredit.Nombres,
                    Apellidos = objCredit.Apellidos,
                    Celular = objCredit.Celular,
                    Correo = objCredit.Correo,
                    TipoID = objCredit.TipoID,
                    NumeroID = objCredit.NumeroID,
                    DireccionResidencia = objCredit.DireccionResidencia,
                    Ciudad = objCredit.Ciudad,
                    Valor = objCredit.Valor,
                    Cuotas = objCredit.Cuotas,
                    Estado = objCredit.Estado
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error al editar la informacion del credito ={objCredit.Id}");
                throw;
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ResponseContentDTO))]
        public async Task<ActionResult<string>> deleteCredit(string id)
        {           
                try
                {
                    return await _mediator.Send(new deleteCredit { id = id });
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, $"Error al eliminar el credito");
                    throw;
                }            

        }





    }
}
