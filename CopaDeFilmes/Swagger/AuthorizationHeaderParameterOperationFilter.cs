using Microsoft.AspNetCore.Mvc.Authorization;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Linq;

namespace BgmRodotec.Escala.Api.Swagger
{
    /// <summary>
    /// 
    /// </summary>
    public class AuthorizationHeaderParameterOperationFilter : IOperationFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="context"></param>
        public void Apply(Operation operation, OperationFilterContext context)
        {
            var filterPipeline = context.ApiDescription.ActionDescriptor.FilterDescriptors;
            var isAuthorized = filterPipeline.Select(filterInfo => filterInfo.Filter).Any(filter => filter is AuthorizeFilter);
            var allowAnonymous = filterPipeline.Select(filterInfo => filterInfo.Filter).Any(filter => filter is IAllowAnonymousFilter);

            if (!isAuthorized || allowAnonymous) return;
            //if (operation.Parameters == null)
            //    operation.Parameters = new List<IParameter>();

            //operation.Parameters.Add(new NonBodyParameter
            //{
            //    Name = "Authorization",
            //    In = "header",
            //    Description = "access token",
            //    Required = true,
            //    Type = "string"
            //});

            if (operation.Security == null)
                operation.Security = new List<IDictionary<string, IEnumerable<string>>>();

           
        }
    }
}
