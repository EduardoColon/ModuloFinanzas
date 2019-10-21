using System;
using System.Collections.Generic;
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
    }
}
