using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIO_Aulas_API.Models.Usuarios;
using Swashbuckle.AspNetCore.Annotations;
using DIO_Aulas_API.Models;
using DIO_Aulas_API.Filters;

namespace DIO_Aulas_API.Controllers
{

    [Route("api/v1/usuario/")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /// <summary>
        /// Seerviço responsável por autenticar o usuário cadastratido e ativo.
        /// </summary>
        /// <param name="loginViewModelInput"></param>
        /// <returns>Retorna status OK e os dados do usuário</returns>
        [SwaggerResponse(statusCode: 200, description: "Sucesso na autenticação",  Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos obrigatórios ", Type = typeof(ValidaCampoViewModelOutPut))]
        [SwaggerResponse(statusCode: 500, description: "Erro interno", Type = typeof(ErroGenericoViewModel))]

        [HttpPost]
        [Route("logar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
   
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("registrar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Registrar(RegistroViewModelInput registroViewModelInput)
        {
            return Created("", registroViewModelInput);
        }
    }
}
