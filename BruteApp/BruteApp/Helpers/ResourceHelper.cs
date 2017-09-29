using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace BruteApp.Helpers
{
    public class ResourceHelper
    {

        public static string Get(string resources)
        {
            var allRessources = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"BruteApp.Resources.{resources}";
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                var result = reader.ReadToEnd();
                return result;
            }
        }

    }
}