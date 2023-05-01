using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Calculadora.Models
{
   public static class Calculadora
   {
      public static double numero1 {get;set;}

      public static double numero2 {get;set;}

      public static double multiplicacion(double numero1, double numero2)
      {
        double resultado = 0;
        resultado = numero1 * numero2;
        return resultado;
      }

      public static double division(double numero1, double numero2)
      {
        double resultado = 0;
        resultado = numero1 / numero2;
        return resultado;
      }

      public static double suma(double numero1, double numero2)
      {
        double resultado = 0;
        resultado = numero1 + numero2;
        return resultado;
      }

      public static double resta(double numero1, double numero2)
      {
        double resultado = 0;
        resultado = numero1 - numero2;
        return resultado;
      }
   }
}