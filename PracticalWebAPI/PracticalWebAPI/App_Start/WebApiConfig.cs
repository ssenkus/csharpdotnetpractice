﻿// using PracticalWebAPI.Tracing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
// using System.Web.Http.Tracing;
using System.Web.Http.Validation;
using System.Web.Http.Validation.Providers;
using PracticalWebAPI.Filters;

namespace PracticalWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            //config.Routes.MapHttpRoute(
            //    name: "RpcApi",
            //    routeTemplate: "api/{controller}/{action}/{id}",
            //    defaults: new { id = RouteParameter.Optional }

            //    );


            config.Filters.Add(new ValidationErrorHandlerFilterAttribute());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
              
            );

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{orgid}/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional },
            //    constraints: new { orgid = @"\d+" }
            //);

            // Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
            // To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
            // For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
            //config.EnableQuerySupport();

            // To disable tracing in your application, please comment out or remove the following line of code
            // For more information, refer to: http://www.asp.net/web-api
            //config.EnableSystemDiagnosticsTracing();
          //  config.Services.RemoveAll(typeof(ModelValidatorProvider), v => v is InvalidModelValidatorProvider);
//            config.Services.Replace(typeof(ITraceWriter), new WebApiTracer());
        }
    }
}
