// GraphQL/Types/AutorInputType.cs
using HotChocolate.Types;
using graphQL.Models;

namespace graphQL.GraphQL.Types
{
    public class AutorInputType : InputObjectType<Autor>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Autor> descriptor)
        {
            descriptor.Field(a => a.Id).Ignore(); // Ignora el campo Id en el input
            descriptor.Field(a => a.Nombre).Type<NonNullType<StringType>>();
            descriptor.Field(a => a.Apellido).Type<NonNullType<StringType>>();
            descriptor.Field(a => a.FechaNacimiento).Type<DateTimeType>();
            descriptor.Field(a => a.Nacionalidad).Type<StringType>();
            descriptor.Field(a => a.Biografia).Type<StringType>();
        }
    }
}
