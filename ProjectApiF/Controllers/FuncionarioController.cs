using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectApiF.DataContext;
using ProjectApiF.Models;

namespace ProjectApiF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public FuncionarioController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddFuncionario(FuncionarioModels funcionarios)
        {
            _appDbContext.Funcionarios.Add(funcionarios);
            await _appDbContext.SaveChangesAsync();

            return Ok(funcionarios);

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FuncionarioModels>>> GetFuncionarios() {

            var funcionarios = await _appDbContext.Funcionarios.ToListAsync();

            return Ok(funcionarios);

        }

        [HttpGet("{Id}")]

        public async Task<ActionResult<FuncionarioModels>> GetFuncionario(int Id)
        {

            var funcionario = await _appDbContext.Funcionarios.FindAsync(Id);

            if (funcionario == null)
            {
                return NotFound("Funcionario não encotrado!");
            }

            return Ok(funcionario);

        }

        [HttpPut]
        public async Task<IActionResult> UpdateFuncuinario(int Id, [FromBody] FuncionarioModels funcionarioatualizado)
        {
            var funcionarioexistente = await _appDbContext.Funcionarios.FindAsync(Id);

            if (funcionarioexistente == null)
            {
                return NotFound("Funcionario não encotrado!");

            }

            _appDbContext.Entry(funcionarioexistente).CurrentValues.SetValues(funcionarioatualizado);

            await _appDbContext.SaveChangesAsync();

            return StatusCode(201, funcionarioatualizado);

        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> FuncionarioAtivo(int Id, [FromBody] FuncionarioModels funcionarioativo)
        {
            var funcionarioexistente = await _appDbContext.Funcionarios.FindAsync(Id);

            if (funcionarioexistente == null)
            {
                return NotFound("Funcionario não encotrado!");

            }

            _appDbContext.Entry(funcionarioexistente).CurrentValues.SetValues(funcionarioativo);

            await _appDbContext.SaveChangesAsync();

            return StatusCode(201, funcionarioativo);

        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteFuncionario (int Id)
        {
            var funcionario = await _appDbContext.Funcionarios.FindAsync(Id);

            if (funcionario == null)
            {
                return NotFound("Funcionario não encotrado!");

            }

            _appDbContext.Funcionarios.Remove(funcionario);

            await _appDbContext.SaveChangesAsync();

            return Ok("Funcionario Deletado!");



        }

    }

    
}
