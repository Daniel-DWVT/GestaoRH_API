using GestaoRH_API.Data;
using GestaoRH_API.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoRH_API.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly AppDbContext _context;

        public FuncionarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Funcionario>> GetAllListAsync()
        {
            return await _context.Funcionarios.ToListAsync();
        }
        public async Task<Funcionario> GetByIdAsync(int id)
        {
            return await _context.Funcionarios.FindAsync(id);

        }
        public async Task<Funcionario> CreateAsync(Funcionario funcionario)
        {
            funcionario.DataContratacao = DateTime.Now;

            _context.Funcionarios.Add(funcionario);
            await _context.SaveChangesAsync();
            return funcionario;
        }
        public async Task<Funcionario> UpdateAsync(int id, Funcionario funcionario)
        {
            var funcionarioEncontrado = await _context.Funcionarios.FindAsync(id);

            funcionarioEncontrado.Nome = funcionario.Nome;
            funcionarioEncontrado.Cargo = funcionario.Cargo;
            funcionarioEncontrado.Salario = funcionario.Salario;
            funcionarioEncontrado.DataContratacao = funcionario.DataContratacao;

            await _context.SaveChangesAsync();
            return funcionario;


        }
        public async Task<Funcionario> DeleteAsync(int id)
        {
            var funcionarioEncontrado = await _context.Funcionarios.FindAsync(id);
            _context.Funcionarios.Remove(funcionarioEncontrado);
            await _context.SaveChangesAsync();
            return funcionarioEncontrado;
        }

    }
}
