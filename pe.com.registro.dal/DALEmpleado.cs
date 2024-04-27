using pe.com.registro.bo;
using pe.com.tiendita.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.registro.dal
{
    public class DALEmpleado
    {
        Conexion objconexion = new Conexion();

        private SqlCommand cmd;
        private SqlDataReader dr;

        public List<BOEmpleado> MostrarEmpleados()
        {
            List<BOEmpleado> empleados = new List<BOEmpleado>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarEmpleadoTodo";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BOEmpleado objEmpleado = new BOEmpleado();

                    // Populate employee properties based on table columns
                    objEmpleado.codigoempleado = dr["codigoempleado"].ToString();
                    objEmpleado.nombreempleado = dr["nombreempleado"].ToString();
                    objEmpleado.apellidopempleado = dr["apellidopempleado"].ToString();
                    objEmpleado.apellidomempleado = dr["apellidomempleado"].ToString();
                    objEmpleado.documentoempleado = dr["documentoempleado"].ToString();
                    objEmpleado.fechaempleado = Convert.ToDateTime(dr["fechaempleado"]);
                    objEmpleado.direccionempleado = dr["direccionempleado"].ToString();
                    objEmpleado.telefonoempleado = dr["telefonoempleado"].ToString();
                    objEmpleado.celularempleado = dr["celularempleado"].ToString();
                    objEmpleado.correoempleado = dr["correoempleado"].ToString();
                    objEmpleado.sexoempleado = dr["sexoempleado"].ToString();
                    objEmpleado.usuarioempleado = dr["usuarioempleado"].ToString();
                    objEmpleado.claveempleado = dr["claveempleado"].ToString();
                    objEmpleado.estadoempleado = Convert.ToInt32(dr["estadoempleado"]);
                    objEmpleado.codigorol = Convert.ToInt32(dr["codigorol"]);
                    objEmpleado.codigodistrito = Convert.ToInt32(dr["codigodistrito"]);

                    empleados.Add(objEmpleado);
                }

                return empleados;
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

        public List<BOEmpleado> MostrarEmpleadoActivo()
        {
            List<BOEmpleado> empleados = new List<BOEmpleado>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_MostrarEmpleadoActivo";
                cmd.Connection = objconexion.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    BOEmpleado objEmpleado = new BOEmpleado();

                    // Populate employee properties based on table columns
                    objEmpleado.codigoempleado = dr["codigoempleado"].ToString();
                    objEmpleado.nombreempleado = dr["nombreempleado"].ToString();
                    objEmpleado.apellidopempleado = dr["apellidopempleado"].ToString();
                    objEmpleado.apellidomempleado = dr["apellidomempleado"].ToString();
                    objEmpleado.documentoempleado = dr["documentoempleado"].ToString();
                    objEmpleado.fechaempleado = Convert.ToDateTime(dr["fechaempleado"]);
                    objEmpleado.direccionempleado = dr["direccionempleado"].ToString();
                    objEmpleado.telefonoempleado = dr["telefonoempleado"].ToString();
                    objEmpleado.celularempleado = dr["celularempleado"].ToString();
                    objEmpleado.correoempleado = dr["correoempleado"].ToString();
                    objEmpleado.sexoempleado = dr["sexoempleado"].ToString();
                    objEmpleado.usuarioempleado = dr["usuarioempleado"].ToString();
                    objEmpleado.claveempleado = dr["claveempleado"].ToString();
                    objEmpleado.estadoempleado = Convert.ToInt32(dr["estadoempleado"]);
                    objEmpleado.codigorol = Convert.ToInt32(dr["codigorol"]);
                    objEmpleado.codigodistrito = Convert.ToInt32(dr["codigodistrito"]);

                    empleados.Add(objEmpleado);
                }

                return empleados;
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


        public bool RegistrarEmpleado(BOEmpleado empleado)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_RegistrarEmpleado";
                cmd.Connection = objconexion.Conectar();

                // Agregar parámetros al procedimiento almacenado
                cmd.Parameters.AddWithValue("@nombreempleado", empleado.nombreempleado);
                cmd.Parameters.AddWithValue("@apellidopempleado", empleado.apellidopempleado);
                cmd.Parameters.AddWithValue("@apellidomempleado", empleado.apellidomempleado);
                cmd.Parameters.AddWithValue("@documentoempleado", empleado.documentoempleado);
                cmd.Parameters.AddWithValue("@fechaempleado", empleado.fechaempleado);
                cmd.Parameters.AddWithValue("@direccionempleado", empleado.direccionempleado);
                cmd.Parameters.AddWithValue("@telefonoempleado", empleado.telefonoempleado);
                cmd.Parameters.AddWithValue("@celularempleado", empleado.celularempleado);
                cmd.Parameters.AddWithValue("@correoempleado", empleado.correoempleado);
                cmd.Parameters.AddWithValue("@sexoempleado", empleado.sexoempleado);
                cmd.Parameters.AddWithValue("@usuarioempleado", empleado.usuarioempleado);
                cmd.Parameters.AddWithValue("@claveempleado", empleado.claveempleado);
                cmd.Parameters.AddWithValue("@estadoempleado", empleado.estadoempleado);
                cmd.Parameters.AddWithValue("@codigorol", empleado.codigorol);
                cmd.Parameters.AddWithValue("@codigodistrito", empleado.codigodistrito);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
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


        public bool ActualizarEmpleado(BOEmpleado empleado)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ActualizarEmpleado";
                cmd.Connection = objconexion.Conectar();

                // Agregar parámetros al procedimiento almacenado
                cmd.Parameters.AddWithValue("@codigoempleado", empleado.codigoempleado);
                cmd.Parameters.AddWithValue("@nombreempleado", empleado.nombreempleado);
                cmd.Parameters.AddWithValue("@apellidopempleado", empleado.apellidopempleado);
                cmd.Parameters.AddWithValue("@apellidomempleado", empleado.apellidomempleado);
                cmd.Parameters.AddWithValue("@documentoempleado", empleado.documentoempleado);
                cmd.Parameters.AddWithValue("@fechaempleado", empleado.fechaempleado);
                cmd.Parameters.AddWithValue("@direccionempleado", empleado.direccionempleado);
                cmd.Parameters.AddWithValue("@telefonoempleado", empleado.telefonoempleado);
                cmd.Parameters.AddWithValue("@celularempleado", empleado.celularempleado);
                cmd.Parameters.AddWithValue("@correoempleado", empleado.correoempleado);
                cmd.Parameters.AddWithValue("@sexoempleado", empleado.sexoempleado);
                cmd.Parameters.AddWithValue("@usuarioempleado", empleado.usuarioempleado);
                cmd.Parameters.AddWithValue("@claveempleado", empleado.claveempleado);
                cmd.Parameters.AddWithValue("@estadoempleado", empleado.estadoempleado);
                cmd.Parameters.AddWithValue("@codigorol", empleado.codigorol);
                cmd.Parameters.AddWithValue("@codigodistrito", empleado.codigodistrito);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
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


        public bool EliminarEmpleado(string codigoEmpleado)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_EliminarEmpleado";
                cmd.Connection = objconexion.Conectar();

                // Agregar parámetro al procedimiento almacenado
                cmd.Parameters.AddWithValue("@codigoempleado", codigoEmpleado);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
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

        public bool EliminarEmpleado(BOEmpleado bc)
        {
            throw new NotImplementedException();
        }
    }
}
