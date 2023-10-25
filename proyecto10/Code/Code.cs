using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10.Code
{
    internal class Code
    {
         public  static int MenuPrincipal()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Productos de mPhone");
            Console.WriteLine("================================");
            Console.WriteLine("1. Ventas de mPhone 3000");
            Console.WriteLine("2. Ventas de mPad 3500");
            Console.WriteLine("3. Ventas de MAPBrook 3800");
            Console.WriteLine("4. Ventas de mWatch 8000");
            Console.WriteLine("5. Salir");
            Console.WriteLine("================================");
            Console.Write("Elija una opción: ");
            return int.Parse(Console.ReadLine());
        }

      public  static void MPhone_3000_1()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar Venta de mPhone 3000");
            Console.WriteLine("================================");
            Console.WriteLine("1. Registrar Venta");
            Console.WriteLine("2. Registrar Devolución");
            Console.WriteLine("3: Menu Principal");
            Console.WriteLine("================================");
            Console.Write("Elija una opción: ");
        }

       public static void MPad_3500_1()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar Venta de mPad 3500:");
            Console.WriteLine("================================");
            Console.WriteLine("1. Registrar Venta");
            Console.WriteLine("2. Registrar Devolución");
            Console.WriteLine("3: Menu Principal");
            Console.WriteLine("================================");
            Console.Write("Elija una opción: ");
        }

       public static void MAPBrook_3800_1()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar Venta de MAPBrook 3800:");
            Console.WriteLine("================================");
            Console.WriteLine("1. Registrar Venta");
            Console.WriteLine("2. Registrar Devolución");
            Console.WriteLine("3: Menu Principal");
            Console.WriteLine("================================");
            Console.Write("Elija una opción: ");
        }

       public static void MWatch_8000_1()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar Venta de mWatch 8000:");
            Console.WriteLine("================================");
            Console.WriteLine("1. Registrar Venta");
            Console.WriteLine("2. Registrar Devolución");
            Console.WriteLine("3: Menu Principal");
            Console.WriteLine("================================");
            Console.Write("Elija una opción: ");
        }
        public static void ResultadoFinal()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Productos de mPhone");
            Console.WriteLine("================================");
            Console.WriteLine("1. Ventas de mPhone 3000");
            Console.WriteLine("2. Ventas de mPad 3500");
            Console.WriteLine("3. Ventas de MAPBrook 3800");
            Console.WriteLine("4. Ventas de mWatch 8000");
            Console.WriteLine("5. Salir");
            Console.WriteLine("================================");
            Console.Write("Elija una opción: 5\n ");
            Console.WriteLine("================================");
            Console.WriteLine("Reporte Final");
            Console.WriteLine("================================");
            Console.WriteLine("Productos Vendidos | Cantidad");
     
        }



        public static void console_1() {

            Console.WriteLine("================================\n"
                + "Registrar venta de:\n" +
                "================================\n"
                + "Se va a registrar la venta de\n" +
                "Un mPhone 3000 ¿Desea Continuar?\n" +
                "1.Si\n" +
                "2.No\n" +
                "================================\n" +
               "Ingrese una opción:\r");

        }

        public static void console_1_2()
        {

            Console.WriteLine("================================\n"+ 
            "Registrar venta de:\n" +
            "================================\n"+
            "Se va a registrar la devolucion de\n" +
             "Un  mPhone 3000 ¿Desea Continuar?\n" +
             "1.Si\n" +
             "2.No\n" +
             "================================\n" +
             "Ingrese una opción:\r");

        }

        public static void console_2_1()
        {

            Console.WriteLine("================================\n"
              + "Registrar venta de:\n" +
             "================================\n"
             + "Se va a registrar la venta de\n" +
             "Un mPad 3500 ¿Desea Continuar?\n" +
             "1.Si\n" +
             "2.No\n" +
             "================================\n" +
             "Ingrese una opción:\r");

        }
        public static void console_2_2()
        {

            Console.WriteLine("================================\n"
          + "Registrar venta de:\n" +
          "================================\n"
         + "Se va a registrar la devolucion de\n" +
         "Un mPad 3500 ¿Desea Continuar?\n" +
         "1.Si\n" +
            "2.No\n" +
          "================================\n" +
           "Ingrese una opción:\r");

        }


        public static void console_3_1()
        {
            Console.WriteLine("================================\n"
         + "Registrar venta de:\n" +
          "================================\n"
          + "Se va a registrar la venta de\n" +
           "Un MAPBrook 3800 ¿Desea Continuar?\n" +
          "1.Si\n" +
            "2.No\n" +
            "================================\n" +
           "Ingrese una opción:\r");
        }

        public static void console_3_2()
        {

            Console.WriteLine("================================\n"
             + "Registrar venta de:\n" +
             "================================\n"
              + "Se va a registrar la devolucion de\n" +
             "Un MAPBrook 3800 ¿Desea Continuar?\n" +
              "1.Si\n" +
               "2.No\n" +
              "================================\n" +
             "Ingrese una opción:\r");

        }
        public static void console_4_1()
        {

            Console.WriteLine("================================\n"
             + "Registrar venta de:\n" +
             "================================\n"
              + "Se va a registrar la venta de\n" +
             "Un mWatch 8000 ¿Desea Continuar?\n" +
             "1.Si\n" +
              "2.No\n" +
               "================================\n" +
               "Ingrese una opción:\r");

        }

        public static void console_4_2()
        {
            Console.WriteLine("================================\n"
             + "Registrar venta de:\n" +
             "================================\n"
              + "Se va a registrar la devolucion de\n" +
              "Un mWatch 8000. ¿Desea Continuar?\n" +
              "1.Si\n" +
               "2.No\n" +
              "================================\n" +
              "Ingrese una opción:\r");

        }
       

    }
}
