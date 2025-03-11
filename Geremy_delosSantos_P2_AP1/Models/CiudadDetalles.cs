using System.ComponentModel.DataAnnotations;

namespace Geremy_delosSantos_P2_AP1.Models;

public class CiudadDetalles
{
    [Key]
    public int CiudadId { get; set; }
    public int Nombre { get; set; }
    public int Monto { get; set; }
}
