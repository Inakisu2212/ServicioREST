﻿using System.Web.Mvc;

namespace ServicioRest5.Areas.Api
{
    public class ApiAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Api";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)//hace falta ??
        {
            context.MapRoute(
                "AccesoCliente",
                "Api/Clientes/Cliente/{id}",
                new
                {
                    controller = "Clientes",
                    action = "Cliente",
                    id = UrlParameter.Optional
                }
            );

            context.MapRoute(
                "AccesoClientes",
                "Api/Clientes",
                new
                {
                    controller = "Clientes",
                    action = "Clientes"
                }
            );

            context.MapRoute(
                "Api_default",
                "Api/{controller}/{action}/{id}",
                new
                {
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}
