// GraphQL/Types/AutorType.cs
using HotChocolate.Types;
using graphQL.Models;

namespace graphQL.GraphQL.Types
{
    public class AutorType : ObjectType<Autor>
    {
        protected override void Configure(IObjectTypeDescriptor<Autor> descriptor)
        {
            descriptor.Field(a => a.Id).Type<NonNullType<IdType>>(); // Define el campo Id como obligatorio
            descriptor.Field(a => a.Nombre).Type<NonNullType<StringType>>(); // Nombre obligatorio
            descriptor.Field(a => a.Apellido).Type<NonNullType<StringType>>(); // Apellido obligatorio
            descriptor.Field(a => a.FechaNacimiento).Type<DateTimeType>(); // Fecha de nacimiento opcional
            descriptor.Field(a => a.Nacionalidad).Type<StringType>(); // Nacionalidad opcional
            descriptor.Field(a => a.Biografia).Type<StringType>(); // Biografía opcional
        }
    }
}
