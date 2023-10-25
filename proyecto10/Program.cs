using proyecto10.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalVentasMPhones = 0;
            int totaldevueltasmphones = 0;
            int totalVentasMPads = 0;
            int totaldevueltasmpads = 0;
            int totalVentasMAPBrooks = 0;
            int totaldevueltasmapbrooks = 0;
            int totalVentasMWatches = 0;
            int totaldevueltasmwatches = 0;
            int opcion;
            int opcion_1;
            int opcion2;
            int opcion2_1;

            do
            {
                opcion = Code.Code.MenuPrincipal();
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Code.Code.MPhone_3000_1();
                        opcion_1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcion_1)
                        {
                            case 1:
                                Code.Code.console_1();
                                opcion2 = int.Parse(Console.ReadLine());

                                if (opcion2 == 1)
                                {
                                    totalVentasMPhones++;
                                }

                                Console.Clear();
                                break;

                            case 2:
                                Code.Code.console_1();
                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totaldevueltasmphones++;
                                }
                                break;
                        }
                        break;

                    case 2:
                        Code.Code.MPad_3500_1();
                        opcion_1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcion_1)
                        {
                            case 1:
                                Code.Code.console_2_1();

                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totalVentasMPads++;
                                }
                                break;

                            case 2:
                                Code.Code.console_2_2();
                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totaldevueltasmpads++;
                                }
                                break;
                        }
                        break;

                    case 3:
                        Code.Code.MAPBrook_3800_1();
                        opcion_1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcion_1)
                        {
                            case 1:
                                Code.Code.console_3_1();

                                opcion2 = int.Parse(Console.ReadLine());

                                if (opcion2 == 1)
                                {
                                    totalVentasMAPBrooks++;
                                }

                                Console.Clear();
                                break;

                            case 2:
                                Code.Code.console_3_2();
                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totaldevueltasmapbrooks++;
                                }
                             
                                break;
                        }
                        
                        break;

                    case 4:
                        Code.Code.MWatch_8000_1();
                        opcion_1 = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (opcion_1)
                        {
                            case 1:
                                Code.Code.console_4_1();

                                opcion2 = int.Parse(Console.ReadLine());

                                if (opcion2 == 1)
                                {
                                    totalVentasMWatches++;
                                }

                                Console.Clear();
                                break;

                            case 2:
                                Code.Code.console_4_2();


                                opcion2_1 = int.Parse(Console.ReadLine());
                                Console.Clear();

                                if (opcion2_1 == 1)
                                {
                                    totaldevueltasmwatches++;
                                }
                               
                                break;
                        }
                        break;
                       
                    case 5:
                        Code.Code.ResultadoFinal();
                        Console.WriteLine("mPhones            | " + totalVentasMPhones);
                        Console.WriteLine("mPads              | " + totalVentasMPads);
                        Console.WriteLine("MAPBrooks          | " + totalVentasMAPBrooks);
                        Console.WriteLine("mWatches           | " + totalVentasMWatches);
                        int totalVentasProductos = totalVentasMPhones + totalVentasMPads + totalVentasMAPBrooks + totalVentasMWatches;
                        Console.WriteLine("================================\n");
                        Console.WriteLine("Total              | " + totalVentasProductos);
                        Console.WriteLine("================================\n" +
                            "¡Hasta Luego!\n" +
                        "Diseñado Por:Carlos Angeles Santa Cruz\n" ); 
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != 5);
        }
  }
}

