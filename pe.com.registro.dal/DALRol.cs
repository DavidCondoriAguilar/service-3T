using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using pe.com.registro.bo;
using pe.com.tiendita.dal;

namespace pe.com.registro.dal
{
    public class DALRol
    {
        public List<BORol> MostrarRoles()
        {
            Conexion objconexion = new Conexion();
            List<BORol> roles = new List<BORol>();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarRolTodo";
                cmd.Connection = objconexion.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BORol objRol = new BORol();

                    objRol.codigorol = Convert.ToInt32(dr["codigorol"]);
                    objRol.nombrerol = dr["nombrerol"].ToString();
                    objRol.estadorol = Convert.ToInt32(dr["estadorol"]);

                    roles.Add(objRol);
                }

                return roles;
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

        public bool RegistrarRol(BORol rol)
        {
            Conexion objconexion = new Conexion();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarRol";
                cmd.Connection = objconexion.Conectar();

                // Agregar parámetros al procedimiento almacenado
                cmd.Parameters.AddWithValue("@codigorol", rol.codigorol);
                cmd.Parameters.AddWithValue("@nombrerol", rol.nombrerol);
                cmd.Parameters.AddWithValue("@estadorol", rol.estadorol);

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

        public bool ActualizarRol(BORol rol)
        {
            Conexion objconexion = new Conexion();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarRol";
                cmd.Connection = objconexion.Conectar();

                // Agregar parámetros al procedimiento almacenado
                cmd.Parameters.AddWithValue("@codigorol", rol.codigorol);
                cmd.Parameters.AddWithValue("@nombrerol", rol.nombrerol);
                cmd.Parameters.AddWithValue("@estadorol", rol.estadorol);

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

        public bool EliminarRol(int codigorol)
        {
            Conexion objconexion = new Conexion();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarRol";
                cmd.Connection = objconexion.Conectar();

                cmd.Parameters.AddWithValue("@codigorol", codigorol);

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
