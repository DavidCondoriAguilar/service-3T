using pe.com.registro.bo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.tiendita.dal;

namespace pe.com.registro.dal
{
    public class DALDistrito
    {
        public List<BODistrito> MostrarDistritos()
        {
            Conexion objconexion = new Conexion();
            List<BODistrito> distritos = new List<BODistrito>();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarDistritoTodo";
                cmd.Connection = objconexion.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BODistrito objDistrito = new BODistrito();

                    objDistrito.codigodistrito = Convert.ToInt32(dr["codigodistrito"]);
                    objDistrito.nombredistrito = dr["nombredistrito"].ToString();
                    objDistrito.estadodistrito = Convert.ToInt32(dr["estadodistrito"]);

                    distritos.Add(objDistrito);
                }

                return distritos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }

        public bool RegistrarDistrito(BODistrito distrito)
        {
            Conexion objconexion = new Conexion();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarDistrito";
                cmd.Connection = objconexion.Conectar();

                // Agregar parámetros al procedimiento almacenado
                cmd.Parameters.AddWithValue("@codigodistrito", distrito.codigodistrito);
                cmd.Parameters.AddWithValue("@nombredistrito", distrito.nombredistrito);
                cmd.Parameters.AddWithValue("@estadodistrito", distrito.estadodistrito);

                int filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }


        public bool ActualizarDistrito(BODistrito distrito)
        {
            Conexion objconexion = new Conexion();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarDistrito";
                cmd.Connection = objconexion.Conectar();

                // Agregar parámetros al procedimiento almacenado
                cmd.Parameters.AddWithValue("@codigodistrito", distrito.codigodistrito);
                cmd.Parameters.AddWithValue("@nombredistrito", distrito.nombredistrito);
                cmd.Parameters.AddWithValue("@estadodistrito", distrito.estadodistrito);

                int filasAfectadas = cmd.ExecuteNonQuery();

                // Si se ejecuta correctamente y afecta al menos una fila, devuelve true
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }


        public bool EliminarDistrito(int codigodistrito)
        {
            Conexion objconexion = new Conexion();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarDistrito";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@codigodistrito", codigodistrito);

                int filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }

    }
}
