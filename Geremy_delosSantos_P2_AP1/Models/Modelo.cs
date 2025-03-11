using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Geremy_delosSantos_P2_AP1.Models;

public class Modelo
{
    [Key]
    [Range(1, int.MaxValue, ErrorMessage = "El ID debe ser mayor o igual que 1.")]
    public int ModeloId { get; set; }
    [Required(ErrorMessage = "Fecha es Requerida")]
    public DateTime Fecha { get; set; }
    [Required(ErrorMessage = "Asignatura es Requerido")]
    [StringLength(maximumLength: 5000, ErrorMessage = "Es muy largo")]
    public string Asignatura { get; set; }
    [Required(ErrorMessage = "Monto es Requerido")]
    [Range(minimum: 0.01, maximum: double.MaxValue, ErrorMessage = "El Monto debe ser mayor a 0.01")]
    public int Monto { get; set; }

    [ForeignKey("CiudadId")]
    public ICollection<CiudadDetalles> CiudadDetalles { get; set; } = new List<CiudadDetalles>();
}
