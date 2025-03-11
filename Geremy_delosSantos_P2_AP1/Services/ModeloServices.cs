using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Geremy_delosSantos_P2_AP1.Models;
using Geremy_delosSantos_P2_AP1.DAL;
using System.Linq.Expressions;


namespace Geremy_delosSantos_P2_AP1.Services;

public class ModeloServices(IDbContextFactory<Contexto> Dbfactory)
{
    private async Task<bool> Existe(int Id)
    {
        await using var contexto = await Dbfactory.CreateDbContextAsync();
        return await contexto.Modelo.AnyAsync(i => i.ModeloId == Id);
    }

    private async Task<bool> Insertar(Modelo modelo)
    {
        await using var contexto = await Dbfactory.CreateDbContextAsync();
        contexto.Modelo.Add(modelo);
        return await contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(Modelo modelo)
    {
        await using var contexto = await Dbfactory.CreateDbContextAsync();
        contexto.Entry(modelo).State = EntityState.Modified;
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Modelo modelo)
    {
        if (await Existe(modelo.ModeloId))
            return await Modificar(modelo);
        else
            return await Insertar(modelo);
    }

    public async Task<Modelo?> Buscar(int Id)
    {
        await using var contexto = await Dbfactory.CreateDbContextAsync();
        return await contexto.Modelo.FirstOrDefaultAsync(i => i.ModeloId == Id);
    }

    public async Task<bool> Eliminar(int modeloId)
    {
        await using var contexto = await Dbfactory.CreateDbContextAsync();
        return await contexto.Modelo
            .AsNoTracking()
            .Where(i => i.ModeloId == modeloId)
            .ExecuteDeleteAsync() > 0;
    }

    public async Task<List<Modelo>> Listar(Expression<Func<Modelo, bool>> criterio)
    {
        await using var contexto = await Dbfactory.CreateDbContextAsync();
        return await contexto.Modelo
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();
    }
    public async Task<List<Modelo>> GetModelo(int modeloId)
    {
        await using var contexto = await Dbfactory.CreateDbContextAsync();
        return await contexto.Modelo
            .Where(m => m.ModeloId == modeloId)
            .AsNoTracking()
            .ToListAsync();
    }
    public async Task<Modelo?> BuscarModelo(int modeloid)
    {
        await using var contexto = await Dbfactory.CreateDbContextAsync();
        return await contexto.Modelo.FirstOrDefaultAsync(m => m.ModeloId == modeloid);
    }

}
