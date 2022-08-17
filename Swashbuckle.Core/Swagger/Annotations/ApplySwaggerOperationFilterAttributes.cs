﻿using System;
using System.Web.Http.Description;

namespace Swashbuckle.Swagger.Annotations
{
    public class ApplySwaggerOperationFilterAttributes : IOperationFilter
    {
        public void Apply(string apiVersion, Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            var attributes = apiDescription.GetControllerAndActionAttributes<SwaggerOperationFilterAttribute>();

            foreach (var attribute in attributes)
            {
                var filter = (IOperationFilter)Activator.CreateInstance(attribute.FilterType);
                filter.Apply(apiVersion, operation, schemaRegistry, apiDescription);
            }
        }
    }
}
