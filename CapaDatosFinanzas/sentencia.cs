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
                Console.WriteLine(ex);
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
                Console.WriteLine(ex);
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

        

        //Eduardo Colon Conciliacion Bancaria Version 2

        public OdbcDataAdapter consultarBancos()
        {
            string sqlModulos = "SELECT KidBanco, nombre FROM tbl_bancos WHERE estado = 1";
            OdbcDataAdapter dataModulos = new OdbcDataAdapter(sqlModulos, con.conectar());
            return dataModulos;
        }

        public OdbcDataAdapter consultarMonedas()
        {
            string sqlModulos = "SELECT KidDivisa, nombre FROM tbl_divisa WHERE estado = 1";
            OdbcDataAdapter dataModulos = new OdbcDataAdapter(sqlModulos, con.conectar());
            return dataModulos;
        }


        public DataSet consultarLibroBancos(string idBanco, string periodo, string idMoneda)
        {
            DataSet ds;
            try
            {
                ds = new DataSet();
                OdbcDataAdapter dat = new OdbcDataAdapter("SELECT KidMovimientoBancario, cuenta_debito, cuenta_credito, monto, tipo_movimiento, fecha_movimiento " +
        " FROM tbl_libro_bancos WHERE estado = 1 " +
        " AND ( EXISTS (  SELECT tbl_cuentabancaria.KidBanco FROM tbl_cuentabancaria WHERE tbl_cuentabancaria.KidBanco = " + idBanco + " AND " +
        " tbl_cuentabancaria.KidCuentaBancaria = cuenta_debito AND tbl_cuentabancaria.KidMoneda= '" + idMoneda + "') " +
        " OR EXISTS (  SELECT tbl_cuentabancaria.KidBanco FROM tbl_cuentabancaria WHERE tbl_cuentabancaria.KidBanco =  " + idBanco + " AND " +
        " tbl_cuentabancaria.KidCuentaBancaria = cuenta_credito AND tbl_cuentabancaria.KidMoneda= '" + idMoneda + "') ) " +
        " AND fecha_movimiento LIKE '" + periodo + "%' " +
        " AND movimiento_conciliado = 0" 
    , con.conectar()); ;
                dat.Fill(ds);
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                return null;
            }

            return ds;
        }

        public bool consultarCuentaBanco(string idCuenta, string idBanco)
        {
            try
            {
                OdbcCommand sqlCodigoCuenta = new OdbcCommand("SELECT KidCuentaBancaria FROM tbl_cuentabancaria " +
                    " WHERE KidCuentaBancaria = '" + idCuenta + "' AND " +
                    " KidBanco = '" + idBanco + "'", con.conectar());
                OdbcDataReader almacena = sqlCodigoCuenta.ExecuteReader();

                if (almacena.HasRows)
                    return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            return false;
        }

        public void actualizarMovmientoBancario(string idMovimiento)
        {

            try
            {
                OdbcCommand sql = new OdbcCommand("UPDATE tbl_libro_bancos SET " +
                    " movimiento_conciliado = 1 WHERE KidMovimientoBancario = " + idMovimiento, con.conectar());
                sql.ExecuteNonQuery();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void insertarConciliacionBancaria(string idBanco, string idMoneda, string periodo, string saldo)
        {
            OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_conciliacion_bancaria (KidBanco, moneda, mes_conciliacion, diferencia_total, estado) VALUES ("
                  + idBanco + " ,'" +
                  idMoneda + "' , '" +
                  periodo + "' , " +
                  saldo +  " , 1" +
                  ")  ON DUPLICATE KEY UPDATE diferencia_total=" + saldo, con.conectar());
            sql.ExecuteNonQuery();
            sql.Connection.Close();
        }
    }
}
