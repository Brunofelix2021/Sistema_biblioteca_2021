using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace BibliotecaProjeto
{
    class Emprestimo
    {
        public int intCodigo { get; set; }
        public int intCodigoLivro { get; set; }
        public int intCodigoCliente { get; set; }
        public decimal decValorEmprestimo { get; set; }
        public string strNomeLivro { get; set; }
        public string strValorLivro { get; set; }
        public string strAutorLivro { get; set; }
        public string strExemplaresLivro { get; set; }
        public string strCPF { get; set; }
        public string strNomeCliente { get; set; }
        public bool blnStatusCliente { get; set; }
        public string strStatus { get; set; }
        public string strStatusEmprestimo { get; set; }
        public string strDataEmprestimo { get; set; }
        public string strDataDevolucao { get; set; }
        public bool blnStatus { get; set; }
        public string strNumeroemprestimo { get; set; }
        public string strObservacao { get; set; }
        public string strIdentificacao { get; set; }

        public Emprestimo()
        {
            intCodigo = 0;
            intCodigoLivro = 0;
            intCodigoCliente = 0;
            strNomeLivro = string.Empty;
            strValorLivro = string.Empty;
            strAutorLivro = string.Empty;
            strExemplaresLivro = string.Empty;
            strIdentificacao = string.Empty;
            strCPF = string.Empty;
            strNomeCliente = string.Empty;
            blnStatusCliente = false;
            strStatus = string.Empty;
            decValorEmprestimo = 0;
            strStatusEmprestimo = string.Empty;
            strDataEmprestimo = string.Empty;
            strNumeroemprestimo = string.Empty;
            strDataDevolucao = string.Empty;
            strObservacao = string.Empty;
            if(strStatus == "Devolvidos")
            {
                blnStatus = false;
            }
            else
            {
                blnStatus = true;
            }
        }
        AcessoBD oAcessoBD = new AcessoBD();
        DataTable dtUsuario = new DataTable();
        List<SqlParameter> oParametros = new List<SqlParameter>();
        string strSql = string.Empty;

        public void Gravar()
        {
            try
            {
                oParametros.Clear();
                {
                    strSql = "INSERT INTO TB_EMPRESTIMO_EMP \n";
                    strSql += "(EMP_DATAEMPRESTIMO, EMP_DATADEVOLUCAO, EMP_STATUS, EMP_OBSERVACAO, EMP_NUMEROEMPRESTIMO, LIV_CODIGO, CLI_CODIGO, EMP_VALOR) \n";
                    strSql += "VALUES\n";
                    strSql += "(@p_DataEmprestimo, @p_DataDevolucao, @p_Status, @p_Observacao, @p_NumeroEmprestimo, @p_LivCodigo, @p_CliCodigo, @p_ValorEmprestimo)";
                }
                oParametros.Add(new SqlParameter("@p_DataEmprestimo", strDataEmprestimo));
                oParametros.Add(new SqlParameter("@p_DataDevolucao", strDataDevolucao));
                oParametros.Add(new SqlParameter("@p_Status", strStatusEmprestimo));
                oParametros.Add(new SqlParameter("@p_Observacao", strObservacao));
                oParametros.Add(new SqlParameter("@p_LivCodigo", intCodigoLivro));
                oParametros.Add(new SqlParameter("@p_CliCodigo", intCodigoCliente));
                oParametros.Add(new SqlParameter("@p_NumeroEmprestimo", strNumeroemprestimo));
                oParametros.Add(new SqlParameter("@p_ValorEmprestimo", decValorEmprestimo));
                oAcessoBD.ExecutarSQL(strSql, oParametros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Consultar()
        {
            try
            {
                oParametros.Clear();
                strSql += "SELECT EMP_NUMEROEMPRESTIMO, EMP_DATAEMPRESTIMO, EMP_DATADEVOLUCAO, \n";
                strSql += "EMP_STATUS, EMP_OBSERVACAO, CLI.CLI_CODIGO, CLI_CPF, CLI_NOME, CLI_STATUS, \n";
                strSql += "LIV_IDENTIFICACAO, LIV.LIV_CODIGO, LIV_NOME, LIV_EXEMPLARES, LIV_VALOR, EMP_VALOR \n";
                strSql += "FROM TB_EMPRESTIMO_EMP EMP \n";
                strSql += "INNER JOIN TB_LIVRO_LIV LIV ON LIV.LIV_CODIGO = EMP.LIV_CODIGO \n";
                strSql += "INNER JOIN TB_CLIENTE_CLI CLI ON CLI.CLI_CODIGO = EMP.CLI_CODIGO \n";

                if (strNumeroemprestimo != string.Empty)
                {
                    strSql += "WHERE EMP_NUMEROEMPRESTIMO = @p_NumeroEmprestimo";                   
                }
                else if (strIdentificacao != string.Empty)
                {
                    strSql += "WHERE LIV_IDENTIFICACAO = @p_LivIdentificacao";   
                }
                else if (strCPF != string.Empty)
                {
                    strSql += "WHERE CLI_CPF = @p_CliCPF";
                }
                else if (strStatusEmprestimo != string.Empty)
                {
                    strSql += "WHERE EMP_STATUS = @_EmpStatus";
                }

                oParametros.Add(new SqlParameter("@p_NumeroEmprestimo", strNumeroemprestimo));
                oParametros.Add(new SqlParameter("@p_LivIdentificacao", strIdentificacao));
                oParametros.Add(new SqlParameter("@p_CliCPF", strCPF));
                oParametros.Add(new SqlParameter("@_EmpStatus", strStatusEmprestimo));

                dtUsuario = oAcessoBD.ConsultarSQL(strSql, oParametros);

                if (dtUsuario.Rows.Count == 1)
                {
                    strValorLivro = dtUsuario.Rows[0]["LIV_VALOR"].ToString();
                    strExemplaresLivro = dtUsuario.Rows[0]["LIV_EXEMPLARES"].ToString();
                    strNomeLivro = dtUsuario.Rows[0]["LIV_NOME"].ToString();
                    intCodigoLivro = Convert.ToInt32(dtUsuario.Rows[0]["LIV_CODIGO"]);
                    strIdentificacao = dtUsuario.Rows[0]["LIV_IDENTIFICACAO"].ToString();
                    blnStatusCliente = Convert.ToBoolean(dtUsuario.Rows[0]["CLI_STATUS"]);
                    strNomeCliente = dtUsuario.Rows[0]["CLI_NOME"].ToString();
                    strCPF = dtUsuario.Rows[0]["CLI_CPF"].ToString();
                    strObservacao = dtUsuario.Rows[0]["EMP_OBSERVACAO"].ToString();
                    strStatusEmprestimo = dtUsuario.Rows[0]["EMP_STATUS"].ToString();
                    strDataDevolucao = dtUsuario.Rows[0]["EMP_DATADEVOLUCAO"].ToString();
                    strDataEmprestimo = dtUsuario.Rows[0]["EMP_DATAEMPRESTIMO"].ToString();
                    strNumeroemprestimo = dtUsuario.Rows[0]["EMP_NUMEROEMPRESTIMO"].ToString();
                    intCodigoCliente = Convert.ToInt32(dtUsuario.Rows[0]["CLI_CODIGO"]);
                    decValorEmprestimo = Convert.ToDecimal(dtUsuario.Rows[0]["EMP_VALOR"]);

                }
                return dtUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Alterar()
        {
            try
            {
                oParametros.Clear();
                {
                    strSql = "UPDATE TB_EMPRESTIMO_EMP SET \n";
                    strSql += "EMP_STATUS = @p_EmpStatus, \n";
                    strSql += "EMP_OBSERVACAO = @p_Observacao, \n";
                    strSql += "EMP_VALOR = @p_Valor \n";
                    strSql += "WHERE EMP_NUMEROEMPRESTIMO = @p_NumeroEmprestimo";
                }

                oParametros.Add(new SqlParameter("@p_EmpStatus", strStatusEmprestimo));
                oParametros.Add(new SqlParameter("@p_Observacao", strObservacao));
                oParametros.Add(new SqlParameter("@p_Valor", decValorEmprestimo));
                oParametros.Add(new SqlParameter("@p_NumeroEmprestimo", strNumeroemprestimo));

                oAcessoBD.ExecutarSQL(strSql, oParametros);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
