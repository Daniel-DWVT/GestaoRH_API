using GestaoRH_API.Models;

namespace GestaoRH_API.Repositories
{
    public interface IFuncionarioRepository
    {
        Task<IEnumerable<Funcionario>> GetAllListAsync();
        Task<Funcionario> GetByIdAsync(int id);
        Task<Funcionario> CreateAsync(Funcionario funcionario);
        Task<Funcionario> UpdateAsync(int id, Funcionario funcionario);
        Task<Funcionario> DeleteAsync(int id);


    }
}
