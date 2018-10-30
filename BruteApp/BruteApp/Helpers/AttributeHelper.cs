using System.Reflection;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.ModelsBuilder;

namespace BruteApp.Helpers
{
    public class AttributeHelper
    {
        public static string GetTypeAlias<TType>()
            where TType : PublishedContentModel
        {
            return typeof(TType).GetCustomAttribute<PublishedContentModelAttribute>().ContentTypeAlias;
        }

        public static string GetPropertyAlias<TType>(string propertyName)
            where TType : PublishedContentModel
        {
            return typeof(TType).GetProperty(propertyName).GetCustomAttribute<ImplementPropertyTypeAttribute>().Alias;
        }

    }
}