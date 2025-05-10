using ProjectApiF.Models;

namespace ProjectApiF.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModels>>> GetFuncionarios();
        Task<ServiceResponse<List<FuncionarioModels>>> CreateFuncionarios(FuncionarioModels novoFuncionario);
        Task<ServiceResponse<FuncionarioModels>> GetFuncionarioByTd(int Id);
        Task<ServiceResponse<List<FuncionarioModels>>> UpdateFuncionario(FuncionarioModels editadoFuncionario);
        Task<ServiceResponse<List<FuncionarioModels>>> DeleteFuncionario(int Id);
        Task<ServiceResponse<List<FuncionarioModels>>> InativaFuncionario(int Id);


    }
}
