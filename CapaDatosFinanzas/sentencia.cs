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

        public OdbcDataAdapter consultarPolizas(string fechaInicial, string fechaFinal)
        {
            try
            {
                string sqlConsultarPolizas = "SELECT PE.KidPoliza,PE.KidTipoDePoliza ,PD.KidCuenta, PD.Debe, PD.Haber FROM tbl_poliza_encabezado PE INNER JOIN tbl_poliza_detalle PD ON PE.KidPoliza = PD.KidPoliza LEFT JOIN tbl_librodiario LD ON PE.KidPoliza = LD.KidPoliza WHERE LD.KidPoliza IS NULL AND (PE.fecha_poliza BETWEEN '"+fechaInicial+"' AND '"+fechaFinal+"');";
                OdbcDataAdapter dataPolizas = new OdbcDataAdapter(sqlConsultarPolizas, con.conectar());
                return dataPolizas;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter consultarActualizacionPolizas(string fechaInicial, string fechaFinal)
        {
            try
            {
                string sqlConsultarPolizas = "SELECT PE.KidPoliza,PE.KidTipoDePoliza, PD.KidCuenta, PD.Debe, PD.Haber FROM tbl_poliza_encabezado PE INNER JOIN tbl_poliza_detalle PD ON PE.KidPoliza = PD.KidPoliza RIGHT JOIN tbl_librodiario LD ON PE.KidPoliza = LD.KidPoliza WHERE (PE.fecha_poliza BETWEEN '" + fechaInicial + "' AND '" + fechaFinal + "');";
                OdbcDataAdapter dataPolizas = new OdbcDataAdapter(sqlConsultarPolizas, con.conectar());
                return dataPolizas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public OdbcDataAdapter consultarTipoPolizas()
        {
            try
            {
                string sqlTiposPolizas = "SELECT descripcion FROM tbl_tipo_poliza WHERE estado = 1";
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


        public OdbcDataAdapter IngresarPolizasLibroDiario(int iCodigoPoliza, string sFecha, double dTotalDebe, double dTotalHaber)
        {
            try
            {

                string sqlInsertarLibroDiario = "INSERT INTO tbl_librodiario(KidPoliza, fecha, total_debe,total_haber, estado) VALUES ('"+iCodigoPoliza+"', '"+sFecha+"', '"+dTotalDebe+"', '"+dTotalHaber+"', 1) ";
                OdbcDataAdapter dataLibroDiario = new OdbcDataAdapter(sqlInsertarLibroDiario, con.conectar());
                return dataLibroDiario;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter ObtenerTotalPoliza(int iCodigoPoliza)
        {
            try
            {
                string sqlObtenerTotalPoliza = "SELECT total_poliza FROM tbl_poliza_encabezado WHERE KidPoliza='"+iCodigoPoliza+"'";
                OdbcDataAdapter dataTotalPoliza = new OdbcDataAdapter(sqlObtenerTotalPoliza, con.conectar());
                return dataTotalPoliza;

            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public DataSet ConsultarCuentasContables()
        {
            OdbcDataAdapter dat = null;
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT C.KidCuenta AS Codigo, TP.nombre_tipoCuenta AS Tipo, C.nombre AS Nombre, C.descripcion AS Descripcion, C.estado AS Estado FROM tbl_cuentas C INNER JOIN tbl_tipocuenta TP ON C.KidTipoCuenta = TP.KidTipoCuenta", con.conectar());
                dat.Fill(ds);
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex);
            }
            return ds;
        }

        public OdbcDataAdapter consultarTipoCuentaContable()
        {
            try
            {
                string sqlTiposCuentasContables = "SELECT nombre_tipoCuenta FROM tbl_tipocuenta WHERE estado = 1";
                OdbcDataAdapter dataTipoCuentasContables = new OdbcDataAdapter(sqlTiposCuentasContables, con.conectar());
                return dataTipoCuentasContables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }


        public OdbcDataAdapter IngresarCuentasContables(string sCodigoCuenta, string sNombreTipoCuenta, int identificador ,string sNombre, string sDescripcion, string sEstado)
        {
            string sCodigoTipoDeCuenta = "";
            try
            {
                OdbcCommand sqlCodigoTipoCuenta = new OdbcCommand("SELECT KidTipoCuenta FROM tbl_tipocuenta WHERE nombre_tipoCuenta = '" + sNombreTipoCuenta + "' ", con.conectar());
                OdbcDataReader almacena = sqlCodigoTipoCuenta.ExecuteReader();

                while (almacena.Read() == true)
                {
                    sCodigoTipoDeCuenta = almacena.GetString(0);
                }

                string sqlInsertarCuentaContable = "INSERT INTO tbl_cuentas(KidCuenta, KidTipoCuenta, Kidentificador,nombre, descripcion, estado) VALUES ('"+sCodigoCuenta+"', '"+sCodigoTipoDeCuenta+"','"+identificador+"' ,'"+sNombre+"', '"+sDescripcion+"','"+sEstado+"');";
                OdbcDataAdapter dataCuentasContables = new OdbcDataAdapter(sqlInsertarCuentaContable, con.conectar());
                return dataCuentasContables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public string obtenerCodigoDeTipoDeCuenta(string sNombreTipoCuenta)
        {
            string sCodigoTipoCuenta = "";
            try
            {
                OdbcCommand sqlCodigoCuenta = new OdbcCommand("SELECT KidTipoCuenta FROM tbl_tipocuenta WHERE nombre_tipoCuenta = '" + sNombreTipoCuenta + "' ", con.conectar());
                OdbcDataReader almacena = sqlCodigoCuenta.ExecuteReader();

                while (almacena.Read() == true)
                {
                    sCodigoTipoCuenta = almacena.GetString(0);
                }

                return sCodigoTipoCuenta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public OdbcDataAdapter obtenerMaximoCodigoCuentaContable(string sCodigoTipoCuenta)
        {
            try
            {
                string sqlMaxCuentaContable = "SELECT MAX(C.Kidentificador) FROM tbl_cuentas C INNER JOIN tbl_tipocuenta TP ON C.KidTipoCuenta = TP.KidTipoCuenta WHERE TP.KidTipoCuenta ='" + sCodigoTipoCuenta + "'";
                OdbcDataAdapter dataMaxCuentaContable = new OdbcDataAdapter(sqlMaxCuentaContable, con.conectar());
                return dataMaxCuentaContable;
            }
            catch (Exception ex)
            {   
                Console.WriteLine(ex);
                return null;
            }

        }

        public OdbcDataAdapter obtenerMaximoCodigoCuentaContable2(int Identificador)
        {
            try
            {
                string sqlMaxCuentaContable = "SELECT KidCuenta FROM tbl_cuentas WHERE Kidentificador ='" + Identificador + "'";
                OdbcDataAdapter dataMaxCuentaContable = new OdbcDataAdapter(sqlMaxCuentaContable, con.conectar());
                return dataMaxCuentaContable;
            }
            catch (Exception ex)    
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        public OdbcDataAdapter ModificarCuentaContable(string sCodigoCuenta, string sNombre, string sDescripcion, string sEstado)
        {
            try
            {
                string sqlModificarCuentaContable = "UPDATE tbl_cuentas SET nombre = '"+sNombre+"', descripcion='"+sDescripcion+"', estado='"+sEstado+"' WHERE KidCuenta = '"+sCodigoCuenta+"';";
                OdbcDataAdapter dataModificarCuentaContable = new OdbcDataAdapter(sqlModificarCuentaContable, con.conectar());
                return dataModificarCuentaContable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        public OdbcDataAdapter EliminarCuentaContable(string sCodigoCuenta)
        {
            try
            {
                string sqlModificarCuentaContable = "UPDATE tbl_cuentas SET estado=0 WHERE KidCuenta = '" + sCodigoCuenta + "';";
                OdbcDataAdapter dataModificarCuentaContable = new OdbcDataAdapter(sqlModificarCuentaContable, con.conectar());
                return dataModificarCuentaContable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

        }

        public OdbcDataAdapter obtenerTotalesDeCuentasContablesDePartidas(string sFechaInicial, string sFechaFinal)
        {
            try
            {
                string sqlTotalesCuentasContables = "SELECT PD.KidCuenta, SUM(PD.debe), SUM(PD.haber) FROM tbl_librodiario LD INNER JOIN tbl_poliza_encabezado PE ON LD.KidPoliza = PE.KidPoliza INNER JOIN tbl_poliza_detalle PD ON PE.KidPoliza = PD.KidPoliza WHERE LD.fecha BETWEEN '"+sFechaInicial+"' AND '"+sFechaFinal+"' GROUP BY PD.KidCuenta";
                OdbcDataAdapter dataTotalesCuentasContables = new OdbcDataAdapter(sqlTotalesCuentasContables, con.conectar());
                return dataTotalesCuentasContables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public OdbcDataAdapter ActualizarDebe_HaberCuentasContables(string sCodigoCuenta, double debe, double haber)
        {
            try
            {
                string sqlActualizarCuentasContables = "UPDATE tbl_cuentas SET debe = debe + '"+debe+"', haber = haber + '"+haber+"' WHERE KidCuenta = '"+sCodigoCuenta+"'";
                OdbcDataAdapter dataActualizarCuentasContables = new OdbcDataAdapter(sqlActualizarCuentasContables, con.conectar());
                return dataActualizarCuentasContables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }



        /*--------------------------------------------------- Diego Gomez -----------------------------------------------------------------------*/

        public DataSet consultarPresupuesto()
        {
            OdbcDataAdapter dat = null;
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                dat = new OdbcDataAdapter("select Kidpresupuesto as Id,KidMoneda as Divisa,KidArea as Area,KidCuenta as Cuenta,nombre as Nombre,fecha as Fecha,descripcion as Descripcion,monto as Monto,estado as Estado from tbl_presupuesto"
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

        public OdbcDataAdapter ConsultarPerfil(string consulta)
        {

            /* string sqlbusqueda = "SELECT tblp.nombre, tblp.fecha, tblp.descripcion, tblp.monto, tblp.estado,tblm.nombre_moneda,tbla.nombreArea, tblc.nombre " +
                  "from tbl_presupuesto as tblp " +
                  "inner join tbl_moneda tblm" +
                  "on tblp.KidMoneda = tblm.kidmoneda" +
                  "inner join tbl_areas tbla" +
                  "on tblp.KidArea = tbla.KidArea" +
                  "inner join tbl_cuentas tblc" +
                  "on tblp.KidCuenta = tblc.KidCuenta" +
                  "where tblp.nombre = '"+consulta+"'";*/

            string sqlbusqueda = "SELECT *from tbl_presupuesto as tblp " +
                "inner join tbl_moneda tblm on tblp.KidMoneda = tblm.kidmoneda " +
                "inner join tbl_areas tbla on tblp.KidArea = tbla.KidArea " +
                "inner join tbl_cuentas tblc on tblp.KidCuenta = tblc.KidCuenta " +
                "where tblp.nombre = '" + consulta + "'";


            OdbcDataAdapter dataTable = new OdbcDataAdapter(sqlbusqueda, con.conectar());
            return dataTable;
        }

        /* --------------------------------------------------------------------------------------------------------------------------------------------------------------*/




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
