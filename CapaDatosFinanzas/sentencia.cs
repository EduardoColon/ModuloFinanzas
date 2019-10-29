using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosFinanzas
{
    public class sentencia
    {
        conexion con = new conexion();

        public object MessageBox { get; private set; }

        public List<string> consultarIdDivisa()
        {
            List<String> resultado = new List<string>();

            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT KidDivisa FROM tbl_divisa", con.conectar());

                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    resultado.Add(almacena.GetString(0));
                }
                almacena.Close();
                sql.Connection.Close();

            }
            catch (Exception ex)
            {

            }

            return resultado;
        }

        public List<string> consultarNombreDivisa()
        {
            List<String> resultado = new List<string>();

            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT Nombre FROM tbl_divisa", con.conectar());

                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    resultado.Add(almacena.GetString(0));
                }
                almacena.Close();
                sql.Connection.Close();

            }
            catch (Exception ex)
            {

            }
          
            return resultado;

        }

        public string obtenerTipoCambio(string sMonedaBase, string sMonedaObjetivo)
        {
            string url = "https://free.currconv.com/api/v7/convert?q=" + sMonedaBase + "_" + sMonedaObjetivo + "&compact=ultra&apiKey=e9c22965a0221aae8dfe";
            var json = new WebClient().DownloadString(url);

            string sJSon = json.ToString();

            int pFrom = sJSon.IndexOf(":") + ":".Length;
            int pTo = sJSon.LastIndexOf("}");

            String result = sJSon.Substring(pFrom, pTo - pFrom).Trim();

            string fecha = DateTime.Now.ToString("yyy/MM/dd");

            try
            {

                OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_tipocambio VALUES ('"
                    + sMonedaBase + "' ,'" +
                    sMonedaObjetivo + "' , " +
                    result + " , '" +
                    fecha +
                    "')", con.conectar());
                sql.ExecuteNonQuery();
                sql.Connection.Close();

            }
            catch(Exception ex)
            {

            }
            

            return result;
        }


        /*--------------------------------------------------- Allan Letona -----------------------------------------------------------------------*/

        public OdbcDataAdapter consultarPolizas(string fechaInicial, string fechaFinal, string TipoDePoliza)
        {
            try
            {
                
                string sqlConsultarPolizas = "SELECT PE.KidPoliza, PD.KidCuenta, PD.Debe, PD.Haber FROM tbl_poliza_encabezado PE INNER JOIN tbl_poliza_detalle PD ON PE.KidPoliza = PD.KidPoliza WHERE PE.KidTipoDePoliza = '"+TipoDePoliza+"' AND (PE.fecha_poliza BETWEEN '"+fechaInicial+"' AND '"+fechaFinal+"');";
                OdbcDataAdapter dataPolizas = new OdbcDataAdapter(sqlConsultarPolizas, con.conectar());
                return dataPolizas;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter consultarTipoPolizas()
        {
            try
            {
                string sqlTiposPolizas = "SELECT KidTipoDePoliza FROM tbl_tipo_poliza WHERE estado = 1";
                OdbcDataAdapter dataTipoPolizas = new OdbcDataAdapter(sqlTiposPolizas, con.conectar());
                return dataTipoPolizas;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            
        }

        public string obtenerNombreCuentaContable(string sCodigoCuentaContable)
        {
            string sNombreCuenta = "";
            try
            {
                OdbcCommand sqlCodigoCuenta = new OdbcCommand("SELECT nombre FROM tbl_cuentas WHERE KidCuenta = '" + sCodigoCuentaContable + "' ", con.conectar());
                OdbcDataReader almacena = sqlCodigoCuenta.ExecuteReader();

                while (almacena.Read() == true)
                {
                    sNombreCuenta = almacena.GetString(0);
                }

                return sNombreCuenta;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        /*--------------------------------------------------- Diego Gomez -----------------------------------------------------------------------*/

        public DataSet consultarBitacora()
        {
            OdbcDataAdapter dat = null;
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("select Kidpresupuesto as Id,KidDivisa as Divisa,KidArea as Area,KidCuenta as Cuenta,nombre as Nombre,fecha as Fecha,descripcion as Descripcion,monto as Monto,estado as Estado from tbl_presupuesto"
                , con.conectar());
                dat.Fill(ds);
            }
            catch (OdbcException ex)
            {
               
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }

            return ds;
        }
    }
}
