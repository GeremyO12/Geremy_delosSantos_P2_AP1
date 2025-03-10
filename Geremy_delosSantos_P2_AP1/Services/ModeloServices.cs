using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Geremy_delosSantos_P2_AP1.Models;
using Geremy_delosSantos_P2_AP1.DAL;
using System.Linq.Expressions;


namespace Geremy_delosSantos_P2_AP1.Services;

public class ModeloServices
{
    private async Task<bool> Existe(int Id)
    {
        return true;
    }

    private async Task<bool> Insertar(Modelo modelo)
    {
        return true;
    }

    private async Task<bool> Modificar(Modelo modelo)
    {
        return true;
    }

    public async Task<bool> Guardar(Modelo modelo)
    {
        return true;
    }

    public async Task<Modelo> Buscar(int Id)
    {

    }

    public async Task<bool> Eliminar(int modeloId)
    {
        return true;
    }

    public async Task<List<Modelo>> GetList(Expression<Func<Modelo, bool>> criterio)
    {

    }
    public async Task<List<Modelo>> GetModelo(int modeloId)
    {

    }
    public async Task<Modelo?> BuscarModelo(int modeloid)
    {

    }

}
