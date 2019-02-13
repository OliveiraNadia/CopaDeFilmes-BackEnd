using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;

namespace BgmRodotec.Escala.Api.Swagger
{
    /// <summary>
    /// 
    /// </summary>
    public class SwaggerAddEnumDescriptions : IDocumentFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="swaggerDoc"></param>
        /// <param name="context"></param>
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            // add enum descriptions to result models
            foreach (KeyValuePair<string, Schema> schemaDictionaryItem in swaggerDoc.Definitions)
            {
                Schema schema = schemaDictionaryItem.Value;
                foreach (KeyValuePair<string, Schema> propertyDictionaryItem in schema.Properties)
                {
                    Schema property = propertyDictionaryItem.Value;
                    IList<object> propertyEnums = property.Enum;
                    if (propertyEnums != null && propertyEnums.Count > 0)
                        property.Description += DescribeEnum(propertyEnums);
                }
            }

            //// add enum descriptions to input parameters
            if (swaggerDoc.Paths.Count > 0)
            {
                foreach (PathItem pathItem in swaggerDoc.Paths.Values)
                {
                    DescribeEnumParameters(pathItem.Parameters);
                    List<Operation> possibleParameterisedOperations = new List<Operation> { pathItem.Get, pathItem.Post, pathItem.Put, pathItem.Patch };
                    possibleParameterisedOperations.FindAll(x => x != null).ForEach(x => DescribeEnumParameters(x.Parameters));
                }
            }
        }

        private void DescribeEnumParameters(IList<IParameter> parameters)
        {
            if (parameters == null)
                return;

            foreach (var param in parameters)
            {
                var nonBodyParameter = param as NonBodyParameter;
                if (nonBodyParameter != null)
                {
                    IList<object> paramEnums = nonBodyParameter.Enum;
                    if (paramEnums != null && paramEnums.Count > 0)
                        param.Description += DescribeEnum(paramEnums);
                }
            }
        }

        private string DescribeEnum(IList<object> enums)
        {
            List<string> enumDescriptions = new List<string>();
            foreach (object enumOption in enums)
                enumDescriptions.Add(string.Format("{0} = {1}", (byte)enumOption, Enum.GetName(enumOption.GetType(), enumOption)));

            return string.Join(", ", enumDescriptions.ToArray());
        }
    }
}
