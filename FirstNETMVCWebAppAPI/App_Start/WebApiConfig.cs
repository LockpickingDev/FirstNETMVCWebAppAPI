using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FirstNETMVCWebAppAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //The route for DefaultApi is "api/{controller}/{id}"
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional } //id Parameter is optional
            );
        }
    }
}
