using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC1.Models;

namespace PC1.Controllers
{
    public class MatriculaController : Controller
    {
        private readonly ILogger<MatriculaController> _logger;

        public MatriculaController(ILogger<MatriculaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Registrar(Matricula objMatricula)
        {   
            String? nombres=objMatricula.Nombres;
            String? apellidos=objMatricula.Apellidos;
            String? correo=objMatricula.Correo;
            bool mate=objMatricula.Matematica;
            bool leng=objMatricula.Lenguaje;
            bool hist=objMatricula.Historia;
            if(mate==false && leng==false && hist==false){
                ViewData["Error"]="Debe elegir al menos un curso";
            }else{
                double precioM=0,precioL=0,precioH=0;
                if(mate==true){
                    precioM=300;
                }
                if(leng==true){
                    precioL=300;
                }
                if(hist==true){
                    precioH=300;
                }
                double subTotal,IGV,total;
                subTotal=precioM+precioL+precioH;
                IGV=(subTotal*18)/100;
                total=subTotal+IGV;
                ViewData["Mensaje"]="Se ha registrado Satisfactoriamente";
                ViewData["SubTotal"]="Sub Total: S/."+subTotal;
                ViewData["IGV"]="IGV(18%): S/."+IGV;
                ViewData["Total"]="Total: S/."+total;
            }
            return View("Index");
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}