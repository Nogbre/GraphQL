// GraphQL/Queries/AutorQuery.cs
using HotChocolate;
using HotChocolate.Data;
using graphQL.Data;
using graphQL.Models;
using System.Linq;
using graphQL.GraphQL.Mutations;

namespace graphQL.GraphQL.Queries
{
    public class AutorQuery
    {
        [UseFiltering]
        [UseSorting]
        public IQueryable<Autor> GetAutores([ScopedService] AppDbContext context) =>
            context.Autores;

        public Autor GetAutorById(int id, [ScopedService] AppDbContext context) =>
            context.Autores.FirstOrDefault(a => a.Id == id);
    }
}
