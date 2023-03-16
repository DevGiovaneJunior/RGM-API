using Microsoft.AspNetCore.Mvc;
using RgmTeste.Domain.DTOs;
using RgmTeste.Domain.Interfaces;

namespace RgmTeste.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ProdutoDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<ActionResult> Get()
        {

            var result = await _produtoService.Get();

            return Ok(result);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ProdutoDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<ActionResult> Post([FromBody] ProdutoDto produtoDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(produtoDto);

            var result = await _produtoService.Add(produtoDto);

            return Created("Created", result);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ProdutoDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public async Task<ActionResult> Put([FromBody] ProdutoDto produtoDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(produtoDto);

            var result = await _produtoService.Update(produtoDto);

            return Ok(result);
        }
    }
}
