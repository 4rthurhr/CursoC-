using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using ProjectApiF.Enums;

namespace ProjectApiF.Models
{
    public class FuncionarioModels
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        public TurnoEnum Turno { get; set; }
        public bool Ativo { get; set; }

        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();

        public DateTime DataDeAlteracao { get; set; } =  DateTime.Now.ToLocalTime(); 



    }
}
