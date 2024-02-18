using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Nail.Data.Entityframework.Configuracoes.Turmas;

namespace Nail.Data.Entityframework.Configuracoes.Alunos;

[Table("aluno")]
public class Aluno
{
    [Key, Column("cod_serial_id")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("idade")]
    public int Idade { get; set; }

    [Column("matricula")]
    public string? Matricula { get; set; }
    
    [Column("cpf")]
    public string? Cpf { get; set; }

    [Column("ativo")]
    public bool Active { get; set; }

    [Column("iniciomatricula")]
    public DateTime InicioMatricula { get; set; }

    public ICollection<Turma>? Turmas { get; set; }
}
