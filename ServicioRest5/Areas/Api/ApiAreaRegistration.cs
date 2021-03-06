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
                "AccesoUsuario",
                "Api/Usuarios/Usuario/{email}",
                new
                {
                    controller = "Usuarios",
                    action = "Usuario",
                    email = UrlParameter.Optional
                }
            );

            context.MapRoute(
                "AccesoUsuarios",
                "Api/Usuarios",
                new
                {
                    controller = "Usuarios",
                    action = "Usuarios"
                }
            );
            context.MapRoute("AccesoAlimento",
                "Api/Alimentos",
                new
                {                                               
                    controller = "Alimentos",
                    action = "Alimentos",

                });
            context.MapRoute("AccesoAlimentos",
                "Api/Alimentos/Alimento/{codigo}",
                new
                {
                    controller = "Alimentos",
                    action = "Alimento",
                    codigo = UrlParameter.Optional
                });
            //para tabla calorías
            context.MapRoute("AccesoCaloria",
                "Api/Calorias",
                new
                {
                    controller = "Calorias",
                    action = "Calorias",

                });
            context.MapRoute("AccesoCalorias",
                "Api/Calorias/Caloria/{codigo}",
                new
                {
                    controller = "Calorias",
                    action = "Caloria",
                    codigo = UrlParameter.Optional
                });

            context.MapRoute(
                "Api_default",
                "Api/{controller}/{action}/{email}",
                new
                {
                    action = "Index",
                    email = UrlParameter.Optional,
                    codigo = UrlParameter.Optional
                }
            );
        }
    }
}
