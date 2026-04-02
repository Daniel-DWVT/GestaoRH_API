using GestaoRH_API.DTOs;
using GestaoRH_API.Models;
using GestaoRH_API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoRH_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private readonly IFuncionarioRepository _repository;
        public FuncionariosController(IFuncionarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllList()
        {
            var funcionarioEncontrado = await _repository.GetAllListAsync();
            if (funcionarioEncontrado == null)
            {
                return NotFound(new {mensagem = "Nenhum funcionário encontrado." });
            }
            return Ok(funcionarioEncontrado);
        }
        public async Task<IActionResult> GetById(int id)
        {
            var funcionarioEncontrado = await _repository.GetByIdAsync(id);
            if (funcionarioEncontrado == null)
            {
                return NotFound(new { mensagem = "Funcionário não encontrado." });
            }
            return Ok(funcionarioEncontrado);
        }
        public async Task<IActionResult> Create(int id, FuncionarioCreateDto dto)
        {
            var novoFuncionario = new Funcionario
            {
                Nome = dto.Nome,
                Cargo = dto.Cargo,
                Salario = dto.Salario
            };
            await _repository.CreateAsync(novoFuncionario);
            return CreatedAtAction(nameof(GetById), new { Id = id }, novoFuncionario);
            
        }
        public async Task<IActionResult> Update(int id, FuncionarioUpdateDto dto)
        {
            var funcionarioEncontrado = await _repository.GetByIdAsync(id);
            if (funcionarioEncontrado == null)
            {
                return NotFound (new { mensagem = "Funcionário não encontrado." });
            }
            var funcionarioNovosDados = new Funcionario
            {
                Nome = dto.Nome,
                Cargo = dto.Cargo,
                Salario = dto.Salario
            };
            var funcionarioAtualizado = await _repository.UpdateAsync(id, funcionarioNovosDados);
            return Ok(funcionarioAtualizado);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var funcionarioEncontrado = await _repository.GetByIdAsync(id);
            if (funcionarioEncontrado == null)
            {
                return NotFound (new {mensagem = "Funcionário não encontrado." });
            }
            await _repository.DeleteAsync(id);
            return NoContent();
        }






    }
}
