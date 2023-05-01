using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using TP_Calculadora.Models;

namespace TP_Calculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult Calculo(string operacion, double numero1, double numero2)
        {
            switch(operacion){
                case "Multiplicacion":
                    ViewBag.resultado = Calculadora.multiplicacion(numero1, numero2);
                break;
                case "Division":
                    ViewBag.resultado = Calculadora.division(numero1, numero2);
                break;
                case "Suma":
                    ViewBag.resultado = Calculadora.suma(numero1, numero2);
                break;
                case "Resta":
                    ViewBag.resultado = Calculadora.resta(numero1, numero2);
                break;
            }
            return View();
        }
        
    }
}