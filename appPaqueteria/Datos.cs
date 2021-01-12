using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Npgsql;


namespace appPaqueteria
{
    public class Datos
    {
        public static string server;
        private static string cadenaConexion; /* = "Server = localhost\\SQLEXPRESS; Database = Paqueteria; Trusted_Connection = True;"; */
        public static SqlConnection conexionSQL; /* = new SqlConnection(cadenaConexion); */
        public static MySqlConnection conexionMySQL;
        public static NpgsqlConnection conexionPOSTGRE;


        public static int EjecutarConsulta(string consulta)
        {
            if (server == "SQL Server elegido")
            {
                int registrosAfectados = 0;
                SqlCommand comando = new SqlCommand(consulta, conexionSQL);
                conexionSQL.Open();
                registrosAfectados = comando.ExecuteNonQuery();
                conexionSQL.Close();
                return registrosAfectados;
            }
            else if (server == "Maria DB elegido")
            {
                int registrosAfectados = 0;
                MySqlCommand comando = new MySqlCommand(consulta, conexionMySQL);
                conexionMySQL.Open();
                registrosAfectados = comando.ExecuteNonQuery();
                conexionMySQL.Close();
                return registrosAfectados;
            }
            else if (server == "Postgre SQL elegido")
            {
                int registrosAfectados = 0;
                NpgsqlCommand comando = new NpgsqlCommand(consulta, conexionPOSTGRE);
                conexionPOSTGRE.Open();
                registrosAfectados = comando.ExecuteNonQuery();
                conexionPOSTGRE.Close();
                return registrosAfectados;
            }
            else
            {
                return -1;
            }
            
        }
        public static void AgregarDataTable(DataSet ds, string consulta, string nombreTabla, DataGridView dataGridView1)
        {
            if (server == "SQL Server elegido")
            {
                SqlDataAdapter da = new SqlDataAdapter(consulta, cadenaConexion);
                ds = new DataSet();
                da.Fill(ds, nombreTabla);
                dataGridView1.DataSource = ds.Tables["Paqueteria"];
            }
            else if (server == "Maria DB elegido")
            {
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, cadenaConexion);
                ds = new DataSet();
                da.Fill(ds, nombreTabla);
                dataGridView1.DataSource = ds.Tables["Paqueteria"];
            }
            else if (server == "Postgre SQL elegido")
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(consulta, cadenaConexion);
                ds = new DataSet();
                da.Fill(ds, nombreTabla);
                dataGridView1.DataSource = ds.Tables["Paqueteria"];
            }
            

        }
        public static void EstablecerConexion(string conexionSolicitada)
        {
            switch (conexionSolicitada)
            {
                case "SQLServer":
                cadenaConexion = "Server=localhost\\SQLEXPRESS;Database = Paqueteria; Trusted_Connection = true;";
                conexionSQL = new SqlConnection(cadenaConexion);
                //MessageBox.Show("Exito");
                server = "SQL Server elegido";
                    break;

                case "MariaDB":
                cadenaConexion = "Server=localhost; Port = 3306; Database = Paqueteria;Uid = root; Pwd = Agricultura; SslMode = Preferred;";
                conexionMySQL = new MySqlConnection(cadenaConexion);
                //MessageBox.Show("Exito");
                server = "Maria DB elegido";
                    break;

                case "PostgreSQL":
                    cadenaConexion = "Server=localhost;User id = postgres;Password = Agricultura; Database = Paqueteria;";
                    conexionPOSTGRE = new NpgsqlConnection(cadenaConexion);
                    //MessageBox.Show("Exito");
                    server = "Postgre SQL elegido";
                    break;

                default:
                    break;
            }
        }
        //ejemplos del otro ejercicio
        //consulta = "INSERT INTO Compañia(NumeroCompañia, actividad, estatus) VALUES('c#', 'c sharp', 1);";
        //consulta = "UPDATE Compañia SET actividad='HOLA'where idCompañia=6";
        //consulta = "DELETE FROM Compañia where idCompañia = 6";
    }
}
