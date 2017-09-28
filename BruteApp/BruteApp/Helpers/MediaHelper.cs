using Umbraco.Core.Models;

namespace BruteApp.Helpers
{
    public class MediaHelper
    {
        public static string GetPropertyImageUrl(IPublishedContent property)
        {
            return property?.Url;
        }
    }
}