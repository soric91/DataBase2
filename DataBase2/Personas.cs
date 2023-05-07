using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase2
{
    public class Personas
    {
        private string user;
        private string pass;

        public Personas(string _user, string _pass)
        {
            this.user = _user;
            this.pass = _pass;
        }

        public string getUser()
        {
            return this.user;
        }
        public string getPass()
        {
            return this.pass;
        }


        public bool Validad()
        {
            bool valor=false;
            string sql = $"SELECT id FROM usuario WHERE usuario = '{this.user}'";
            BaseDatos db = new BaseDatos();
            MySqlCommand cmd = new MySqlCommand(sql,db.Conectar());
            MySqlDataReader dr = cmd.ExecuteReader();   
            if (dr.Read()) 
            { 
              valor = true;
            }
            db.Desconectar();
            return valor;
        }

        public void Crear()
        {
            string sql = $"INSERT INTO usuario (usuario, contrasena) VALUES ('{this.user}','{this.pass}')";
            BaseDatos db = new BaseDatos();
            MySqlCommand cmd = new MySqlCommand(sql, db.Conectar());
            cmd.ExecuteNonQuery();
            db.Desconectar();
        }
    }
}
