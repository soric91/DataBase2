using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase2
{
    public class BaseDatos
    {
        private MySqlConnection conetion = null;

        public BaseDatos () 
        {
            this.conetion = new MySqlConnection("server = localhost; database = h2; Uid = root; pwd =;  ");
        } 

        public MySqlConnection Conectar()
        {
            try
            {
              conetion.Open ();
            }catch(Exception ex)
            {
                Console.WriteLine (ex.Message); 
            }

            return conetion;
        }
        public void Desconectar()
        {
           conetion.Close();
        }
    }
}
