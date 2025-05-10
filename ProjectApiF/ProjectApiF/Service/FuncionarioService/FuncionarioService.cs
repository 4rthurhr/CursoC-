using ProjectApiF.Models;

namespace ProjectApiF.Service.FuncionarioService
{
    public class FuncionarioService : IFuncionarioInterface
    {
        private readonly ApplicationDbContext _context;
        public FuncionarioService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<ServiceResponse<List<FuncionarioModels>>> CreateFuncionarios(FuncionarioModels novoFuncionario)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModels>>> DeleteFuncionario(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<FuncionarioModels>> GetFuncionarioByTd(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModels>>> GetFuncionarios()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModels>>> InativaFuncionario(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModels>>> UpdateFuncionario(FuncionarioModels editadoFuncionario)
        {
            throw new NotImplementedException();
        }
    }
}
