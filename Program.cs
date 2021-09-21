using System;

namespace Pantalla_de_Logeo
{
    class Program
    {
        static void Main(string[] args)
        {
            string U1, U2, U3, Login;
            int P1, P2, P3, Pass;
            int UsuarioLogeado = 0;
            U1 = "Wcelada"; U2 = "JCaballeros"; U3 = "RGonzalez";
            P1 = 12345; P2 = 67890; P3 = 54321;
            Console.WriteLine("Ingresa tu Usuario");
            Login = Console.ReadLine();
            Console.WriteLine("Ingresa tu Password");
            Pass = int.Parse(Console.ReadLine());

            if (Login == U1 & Pass == P1)
            {
                UsuarioLogeado = 1;
                Console.WriteLine("Datos Correctos");
            }
            else if (Login == U2 & Pass == P2)
            {
                UsuarioLogeado = 2;
                Console.WriteLine("Datos Correctos");
            }
            else if (Login == U3 & Pass == P3)
            {
                UsuarioLogeado = 3;
                Console.WriteLine("Datos Correctos");
            }
            else
                Console.WriteLine("Los datos son Incorrectos");
        }
    }
}
