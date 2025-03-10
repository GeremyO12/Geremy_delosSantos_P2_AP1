using Geremy_delosSantos_P2_AP1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Geremy_delosSantos_P2_AP1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public virtual DbSet<Modelo> Modelo { get; set; }

}
