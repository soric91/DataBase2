using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataBase2
{
    internal class Program
    {
        static Personas usuario;
        static void Main(string[] args)
        {
            int opc = 0;

            do
            {
                Console.WriteLine("Digite \n1.Registro\n 2.Ingresar \n C/T para salir,");
                opc = int.Parse(Console.ReadLine());

                    switch(opc)
                    {
                    case 1:
                        string[] informacion = new string[2];
                        Console.WriteLine("Digite su nombre de usuario: ");
                        informacion[0]= Console.ReadLine();
                        Console.WriteLine("Digite su contraseña: ");
                        informacion[1] = Console.ReadLine();
                        usuario = new Personas(informacion[0], informacion[1]);
                        if (usuario.Validad()==false)
                        {
                            usuario.Crear();
                            Console.WriteLine("Usuario registrado");
                        }
                        else
                        {
                            Console.WriteLine("No voy a registrar");
                        }
                        break;

                    case 2:
                        break;

                    default
                        : Console.WriteLine("Saliendo...");
                        break; 
                    
                    }



            }while(opc == 1 || opc == 2);

        }
    }
}
