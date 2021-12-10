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
    class CCliente
    {
        public int intCodigo { get; set; }
        public string strCPF { get; set; }
        public string strNome { get; set; }
        public string strEndereco { get; set; }
        public string strNumero { get; set; }
        public string strComplemento { get; set; }
        public string strCEP { get; set; }
        public string strBairro { get; set; }
        public string strTelefone { get; set; }
        public string strCelular { get; set; }
        public string strEmail { get; set; }
        public bool blnStatus { get; set; }
        public byte[] bytImagem { get; set; }
        public int intCodigoCidade { get; set; }
        public int intCodigoEstado { get; set; }
        public CCliente()
        {
            strCPF = string.Empty;
            strNome = string.Empty;
            strEndereco = string.Empty;
            strNumero = string.Empty;
            strComplemento = string.Empty;
            strCEP = string.Empty;
            strBairro = string.Empty;
            strTelefone = string.Empty;
            strCelular = string.Empty;
            strEmail = string.Empty;
            blnStatus = false;
            intCodigoCidade = 0;
            intCodigoEstado = 0;
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
                    strSql = "INSERT INTO TB_CLIENTE_CLI \n";
                    strSql += "(CLI_CPF, CLI_NOME, CLI_ENDEREÇO, CLI_NUMERO, CLI_COMPLEMENTO, CLI_CEP, CLI_BAIRRO, CLI_TELEFONE, CLI_CELULAR, \n";
                    strSql += "CLI_EMAIL, CLI_FOTO, CLI_STATUS, CID_CODIGO) \n";
                    strSql += "VALUES\n";
                    strSql += "(@p_CPF, @p_Nome, @p_Endereco, @p_Numero, @p_Complemento, @p_CEP, @p_Bairro, @p_Telefone, @p_Celular, \n";
                    strSql += "@p_Email, @p_Foto, @p_Status, @p_CidCodigo)";
                }

                oParametros.Add(new SqlParameter("@p_CPF", strCPF));
                oParametros.Add(new SqlParameter("@p_Nome", strNome));
                oParametros.Add(new SqlParameter("@p_Endereco", strEndereco));
                oParametros.Add(new SqlParameter("@p_Numero", strNumero));
                oParametros.Add(new SqlParameter("@p_Complemento", strComplemento));
                oParametros.Add(new SqlParameter("@p_CEP", strCEP));
                oParametros.Add(new SqlParameter("@p_Bairro", strBairro));
                oParametros.Add(new SqlParameter("@p_Telefone", strTelefone));
                oParametros.Add(new SqlParameter("@p_Celular", strCelular));
                oParametros.Add(new SqlParameter("@p_Email", strEmail));
                oParametros.Add(new SqlParameter("@p_Status", blnStatus));
                oParametros.Add(new SqlParameter("@p_CidCodigo", intCodigoCidade));
                oParametros.Add(new SqlParameter("@p_Foto", bytImagem));
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
                strSql = "SELECT CLI_CPF, CLI_CODIGO, CLI_NOME, CLI_ENDEREÇO, CLI_NUMERO, \n";
                strSql += "CLI_COMPLEMENTO, CLI_CEP, CLI_BAIRRO, CLI_TELEFONE, CLI_CELULAR, \n";
                strSql += "CLI_EMAIL, CLI_FOTO, CLI_STATUS, CID.CID_CODIGO, EST.EST_CODIGO \n";
                strSql += "FROM TB_CLIENTE_CLI CLI \n";
                strSql += "INNER JOIN TB_CIDADE_CID CID ON CID.CID_CODIGO = CLI.CID_CODIGO \n";
                strSql += "INNER JOIN TB_ESTADO_EST EST ON EST.EST_CODIGO = CID.EST_CODIGO \n";

                if (strCPF != string.Empty)
                {
                    strSql += "WHERE CLI_CPF = @p_CPF";
                }

                oParametros.Add(new SqlParameter("@p_CPF", strCPF));

                dtUsuario = oAcessoBD.ConsultarSQL(strSql, oParametros);

                if (dtUsuario.Rows.Count == 1)
                {
                    intCodigoCidade = Convert.ToInt32(dtUsuario.Rows[0]["CID_CODIGO"]);
                    intCodigoEstado = Convert.ToInt32(dtUsuario.Rows[0]["EST_CODIGO"]);
                    intCodigo = Convert.ToInt32(dtUsuario.Rows[0]["CLI_CODIGO"]);
                    strNome = dtUsuario.Rows[0]["CLI_NOME"].ToString();
                    strCPF = dtUsuario.Rows[0]["CLI_CPF"].ToString();
                    strEmail = dtUsuario.Rows[0]["CLI_EMAIL"].ToString();
                    strEndereco = dtUsuario.Rows[0]["CLI_ENDEREÇO"].ToString();
                    strNumero = dtUsuario.Rows[0]["CLI_NUMERO"].ToString();
                    strComplemento = dtUsuario.Rows[0]["CLI_COMPLEMENTO"].ToString();
                    strCEP = dtUsuario.Rows[0]["CLI_CEP"].ToString();
                    strBairro = dtUsuario.Rows[0]["CLI_BAIRRO"].ToString();
                    strTelefone = dtUsuario.Rows[0]["CLI_TELEFONE"].ToString();
                    blnStatus = Convert.ToBoolean(dtUsuario.Rows[0]["CLI_STATUS"]);
                    strCelular = dtUsuario.Rows[0]["CLI_CELULAR"].ToString();
                    bytImagem = (byte[])dtUsuario.Rows[0]["CLI_FOTO"];
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
                    strSql = "UPDATE TB_CLIENTE_CLI SET \n";
                    strSql += "CLI_NOME = @p_Nome, \n";
                    strSql += "CLI_ENDEREÇO = @p_Endereco, \n";
                    strSql += "CLI_NUMERO = @p_Numero, \n";
                    strSql += "CLI_COMPLEMENTO = @p_Complemento, \n";
                    strSql += "CLI_CEP = @p_CEP, \n";
                    strSql += "CLI_BAIRRO = @p_Bairro, \n";
                    strSql += "CLI_TELEFONE = @p_Telefone, \n";
                    strSql += "CLI_CELULAR = @p_Celular, \n";
                    strSql += "CLI_EMAIL = @p_Email, \n";
                    strSql += "CID_CODIGO = @p_CidCodigo, \n";
                    strSql += "CLI_FOTO = @p_Foto, \n";
                    strSql += "CLI_STATUS = @p_Status \n";
                    strSql += "WHERE CLI_CPF = @p_CPF";
                }

                oParametros.Add(new SqlParameter("@p_CPF", strCPF));
                oParametros.Add(new SqlParameter("@p_Nome", strNome));
                oParametros.Add(new SqlParameter("@p_Endereco", strEndereco));
                oParametros.Add(new SqlParameter("@p_Numero", strNumero));
                oParametros.Add(new SqlParameter("@p_Complemento", strComplemento));
                oParametros.Add(new SqlParameter("@p_CEP", strCEP));
                oParametros.Add(new SqlParameter("@p_Bairro", strBairro));
                oParametros.Add(new SqlParameter("@p_Telefone", strTelefone));
                oParametros.Add(new SqlParameter("@p_Celular", strCelular));
                oParametros.Add(new SqlParameter("@p_Email", strEmail));
                oParametros.Add(new SqlParameter("@p_Status", blnStatus));
                oParametros.Add(new SqlParameter("@p_CidCodigo", intCodigoCidade));
                oParametros.Add(new SqlParameter("@p_Foto", bytImagem));
                oAcessoBD.ExecutarSQL(strSql, oParametros);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
