using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nail.Data.Entityframework.Configuracoes.Funcionarios;

[Table("funcionario")]
public class Funcionario
{
    [Key, Column("cod_serial_id")]
    public int Id { get; set; }

    [Column("nome")]
    public string? Name { get; set; }

    [Column("cpf")]
    public string? Cpf { get; set; }

    [Column("registro")]
    public string? Registro { get; set; }

    [Column("idade")]
    public int Idade { get; set; }

    [Column("materia")]
    public string? Materia { get; set; }

    [Column("situacao")]
    public string? Situacao { get; set; }
}