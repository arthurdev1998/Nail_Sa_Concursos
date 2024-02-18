using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Nail.Common.Enums;
using Nail.Data.Entityframework.Configuracoes.Alunos;
using Nail.Data.Entityframework.Configuracoes.Funcionarios;

namespace Nail.Data.Entityframework.Configuracoes.Turmas;

[Table("turma")]
public class Turma
{
    [Key, Column("cod_serial_id")]
    public int Id { get; set; }

    [Column("turma_codigo")]
    public string? TurmaCodigo { get; set; }

    [Column("professor")]
    public Funcionario? Professor { get; set; }

    [ForeignKey("funcionario"), Column("cod_serial_professor")]
    public int ProfessorId { get; set; }

    [Column("turno")]
    public Turnos Turno { get; set; } = Turnos.undefinied;

    [Column("quantidadealunos")]
    public int QuantidadeAlunos{get; set;}

    [Column("quantidade_max_alunos")]
    public int QuantidadeMaxAlunos{get;set;}
    public virtual List<Aluno>? Alunos { get; set; }

    [Column("ativo")]
    public bool Active { get; set; }

    [Column("horarioinicio")]
    public DateTime HorarioInicio { get; set; }

    [Column("horariotermino")]
    public DateTime HorarioTermino { get; set; }

    public Semestres SemestreAtual {get; set;} = Semestres.undefinied;
}