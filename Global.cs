using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaProjeto
{
    public static class Global
    {
        public static string strConexao;
        public static int intCodigoUsuario;
        public static string strNomeUsuario;
        public static decimal decMulta = 0;
        public static decimal decMora = 0;
        public static string strLogin;
        public static string strSenha;

        public static void LerAppConfig()
        {
            strConexao = string.Format(
                "Data Source={0};Initial Catalog={1};Integrated Security=true;",
                ConfigurationManager.AppSettings["servidor"],
                ConfigurationManager.AppSettings["banco"]);
            decMulta = Convert.ToDecimal(ConfigurationManager.AppSettings["Multa"]);
            decMora = Convert.ToDecimal(ConfigurationManager.AppSettings["Mora"]);
            strLogin = ConfigurationManager.AppSettings["login"];
            strSenha = ConfigurationManager.AppSettings["senha"];
        }
        public static DataTable ConsultarEstado()
        {
            try
            {
                string strSql = "SELECT EST_CODIGO, EST_ESTADO FROM TB_ESTADO_EST";
                AcessoBD oAcessoBD = new AcessoBD();
                return oAcessoBD.ConsultarSQL(strSql, new List<SqlParameter>());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable ConsultarCargo(int intCodigo = 0)
        {
            try
            {
                string strSql = "SELECT CAR_CODIGO, CAR_CARGO, CAR_ATIVO FROM TB_CARGO_CAR \n";
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                if(intCodigo != 0)
                {
                    oParametros.Add(new SqlParameter("@p_Codigo", intCodigo));
                    strSql += "WHERE CAR_CODIGO = @p_Codigo \n";
                }
                strSql += "order by CAR_CARGO";
                return oAcessoBD.ConsultarSQL(strSql, oParametros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable ConsultarCidade(int pEstado)
        {
            try
            {
                string strSql = "SELECT CID_CODIGO, CID_CIDADE FROM TB_CIDADE_CID WHERE EST_CODIGO = @pEstado";
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                oParametros.Add(new SqlParameter("@pEstado", pEstado));
                return oAcessoBD.ConsultarSQL(strSql, oParametros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable ConsultarGenero(int intCodigo = 0)
        {
            try
            {
                string strSql = "SELECT GEN_CODIGO, GEN_GENERO FROM TB_GENERO_GEN \n";
                AcessoBD oAcessoBD = new AcessoBD();
                List<SqlParameter> oParametros = new List<SqlParameter>();
                if (intCodigo != 0)
                {
                    oParametros.Add(new SqlParameter("@p_Codigo", intCodigo));
                    strSql += "WHERE GEN_CODIGO = @p_Codigo \n";
                }
                strSql += "order by GEN_GENERO";
                return oAcessoBD.ConsultarSQL(strSql, oParametros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

