﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServicioRest5.Areas.Api.Models;
using ServicioRest5;

namespace ServicioRest5.Areas.Api.Controllers
{
    public class AlimentosController : Controller
    {
        private AlimentoManager alimentosManager;

        public AlimentosController()
        {
         alimentosManager = new AlimentoManager();
        }

        //el GET /Api/Alimentos
        [HttpGet]
        public JsonResult Alimentos()
        {
            return Json(alimentosManager.ObtenerAlimentos(),
                JsonRequestBehavior.AllowGet);
        }

        // POST    /Api/Alimentos/Alimento    { Nombre:"nombre", Telefono:123456789 }
        // PUT     /Api/Alimentos/Alimento/3  { Id:3, Nombre:"nombre", Telefono:123456789 }
        // GET     /Api/Alimentos/Alimento/3
        // DELETE  /Api/Alimentos/Alimento/3
        public JsonResult Alimento(int codigo, Alimento item) //quitado string?
        {
            switch (Request.HttpMethod)
            {
                case "POST":
                    return Json(alimentosManager.InsertarAlimento(item));
                case "PUT":
                    return Json(alimentosManager.ActualizarAlimento(item));
                case "GET":
                    if (codigo != null)//esto nunca va a ser null, ya se obtienen todos más arriba
                    {
                        return Json(alimentosManager.ObtenerAlimento(codigo), //quitado GetValueOrDefault()
                        JsonRequestBehavior.AllowGet);
                    }
                    else
                    {                        
                        return Json(alimentosManager.ObtenerAlimentos(),
                        JsonRequestBehavior.AllowGet);
                    }


                case "DELETE":
                    return Json(alimentosManager.EliminarAlimento(codigo),
                        JsonRequestBehavior.AllowGet);
            }

            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }
        //
        // GET: /Api/Alimentos/

        public ActionResult Index()
        {
            return View();
        }
    }
}