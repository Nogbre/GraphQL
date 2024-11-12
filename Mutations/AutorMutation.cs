// GraphQL/Mutations/AutorMutation.cs
using HotChocolate;
using graphQL.Data;
using graphQL.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace graphQL.GraphQL.Mutations
{
    public class AutorMutation
    {
        public async Task<Autor> AddAutor(Autor autorInput, [ScopedService] AppDbContext context)
        {
            var autor = new Autor
            {
                Nombre = autorInput.Nombre,
                Apellido = autorInput.Apellido,
                FechaNacimiento = autorInput.FechaNacimiento,
                Nacionalidad = autorInput.Nacionalidad,
                Biografia = autorInput.Biografia
            };

            context.Autores.Add(autor);
            await context.SaveChangesAsync();
            return autor;
        }

        public async Task<Autor> UpdateAutor(int id, Autor autorInput, [ScopedService] AppDbContext context)
        {
            var autor = await context.Autores.FirstOrDefaultAsync(a => a.Id == id);
            if (autor == null)
            {
                return null; 
            }

            autor.Nombre = autorInput.Nombre;
            autor.Apellido = autorInput.Apellido;
            autor.FechaNacimiento = autorInput.FechaNacimiento;
            autor.Nacionalidad = autorInput.Nacionalidad;
            autor.Biografia = autorInput.Biografia;

            await context.SaveChangesAsync();
            return autor;
        }

        public async Task<bool> DeleteAutor(int id, [ScopedService] AppDbContext context)
        {
            var autor = await context.Autores.FirstOrDefaultAsync(a => a.Id == id);
            if (autor == null)
            {
                return false; 
            }

            context.Autores.Remove(autor);
            await context.SaveChangesAsync();
            return true; 
        }
    }

    internal class ScopedServiceAttribute : Attribute
    {
    }
}
