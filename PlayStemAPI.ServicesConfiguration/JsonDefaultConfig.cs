using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PlayStemAPI.ServicesConfiguration
{
    public static class JsonDefaultConfig
    {
        public static void GetConfig(MvcNewtonsoftJsonOptions options)
        {
            options.SerializerSettings.Formatting = Formatting.None;
            options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            options.SerializerSettings.NullValueHandling = NullValueHandling.Include;
            options.SerializerSettings.DefaultValueHandling = DefaultValueHandling.Include;
            //options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        }
    }
}
