using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevIO.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/produtos")]
    public class ProdutosController : MainController
    {
        public ProdutosController()
        {
            
        }

        [HttpGet]
        public async Task<IEnumerable<ProdutoViewModel>> ObterTodos()
        {

        }

        [HttpGet("{id:guid}")]
        public async Task<ProdutoViewModel> ObterPorId()
        {

        }

        [HttpPost]
        public async Task<ActionResult<ProdutoViewModel>> Adicionar(ProdutoViewModel produtoViewModel)
        {

        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Adicionar(Guid id, ProdutoViewModel produtoViewModel)
        {

        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ProdutoViewModel>> Excluir(Guid id)
        {

        }
    }
}
