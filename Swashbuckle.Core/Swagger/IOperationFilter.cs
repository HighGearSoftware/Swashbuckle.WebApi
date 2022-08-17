using System.Web.Http.Description;

namespace Swashbuckle.Swagger
{
    public interface IOperationFilter
    {
        void Apply(string apiVersion, Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription);
    }
}
