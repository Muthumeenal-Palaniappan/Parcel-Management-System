using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LogicsWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id1}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.EnableCors();
            config.Routes.MapHttpRoute(
        name: "UserDetail",
        routeTemplate: "api/{controller}/{sidx}/{sord}/{page}/{rows}",
        defaults: new {sidx = RouteParameter.Optional,sord = RouteParameter.Optional,page = RouteParameter.Optional,rows = RouteParameter.Optional}
        );
        }
    }
}
