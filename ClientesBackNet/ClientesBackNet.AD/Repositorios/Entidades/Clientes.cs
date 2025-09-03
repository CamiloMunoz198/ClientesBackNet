using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClientesBackNet.AD.Repositorios.Entidades;

public partial class Clientes
{
    [Key]
    public long Identificacion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NombreCompleto { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [Column(TypeName = "numeric(10, 0)")]
    public decimal? Celular { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UsuarioCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaActualizacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UsuarioActualizacion { get; set; }

    public bool? Activo { get; set; }
}
