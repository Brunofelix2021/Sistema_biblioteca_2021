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
    class CFuncionario
    {
        public int intCodigo { get; set; }
        public string strCPF { get; set; }
        public string strNome { get; set; }
        public string strEndereco { get; set; }
        public string strNumero { get; set; }
        public string strComplemento { get; set; }
        public string strCEP{ get; set; }
        public string strBairro { get; set; }
        public string strTelefone { get; set; }
        public string strCelular { get; set; }
        public string strEmail { get; set; }
        public string strLogin { get; set; }
        public string strSenha { get; set; }
        public bool blnAtivo { get; set; }
        public byte[] bytImagem { get; set; }
        public int intCodigoCidade { get; set; }
        public int intCodigoCargo { get; set; }
        public int intCodigoEstado { get; set; }
        public CFuncionario()
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
            strSenha = string.Empty;
            strLogin = string.Empty;
            blnAtivo = true;
            intCodigoCidade = 0;
            intCodigoCargo = 0;
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
                    strSql = "INSERT INTO TB_FUNCIONARIO_FUN \n";
                    strSql += "(FUN_CPF, FUN_NOME, FUN_ENDEREÇO, FUN_NUMERO, FUN_COMPLEMENTO, FUN_CEP, FUN_BAIRRO, FUN_TELEFONE, FUN_CELULAR, \n";
                    strSql += "FUN_EMAIL, FUN_FOTO, FUN_ATIVO, FUN_LOGIN, FUN_SENHA, CID_CODIGO, CAR_CODIGO) \n";
                    strSql += "VALUES\n";
                    strSql += "(@p_CPF, @p_Nome, @p_Endereco, @p_Numero, @p_Complemento, @p_CEP, @p_Bairro, @p_Telefone, @p_Celular, \n";
                    strSql += "@p_Email, @p_Foto, @p_Ativo, @p_Login, @p_Senha, @p_CidCodigo, @p_CarCodigo)";
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
                oParametros.Add(new SqlParameter("@p_Ativo", blnAtivo));
                oParametros.Add(new SqlParameter("@p_Login", strLogin));
                oParametros.Add(new SqlParameter("@p_Senha", strSenha));
                oParametros.Add(new SqlParameter("@p_CarCodigo", intCodigoCargo));
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
                strSql = "SELECT FUN_CPF, FUN_CODIGO, FUN_NOME, FUN_ENDEREÇO, FUN_NUMERO, FUN_COMPLEMENTO, FUN_CEP, FUN_BAIRRO, FUN_TELEFONE, FUN_CELULAR, \n";
                strSql += "FUN_EMAIL, FUN_FOTO, FUN_ATIVO, FUN_LOGIN, FUN_SENHA, CID.CID_CODIGO, CAR.CAR_CODIGO, EST.EST_CODIGO \n";
                strSql += "FROM TB_FUNCIONARIO_FUN FUN \n";
                strSql += "INNER JOIN TB_CIDADE_CID CID ON CID.CID_CODIGO = FUN.CID_CODIGO \n";
                strSql += "INNER JOIN TB_ESTADO_EST EST ON EST.EST_CODIGO = CID.EST_CODIGO \n";
                strSql += "INNER JOIN TB_CARGO_CAR CAR ON CAR.CAR_CODIGO = FUN.CAR_CODIGO \n";
                if (strCPF != string.Empty)
                {
                    strSql += "WHERE FUN_CPF = @p_CPF";
                }
                else if (strLogin != string.Empty)
                {
                    strSql += "WHERE FUN_LOGIN = @p_Login";
                }

                oParametros.Add(new SqlParameter("@p_CPF", strCPF));
                oParametros.Add(new SqlParameter("@p_Login", strLogin));

                dtUsuario = oAcessoBD.ConsultarSQL(strSql, oParametros);

                if (dtUsuario.Rows.Count == 1)
                {
                    intCodigoCidade = Convert.ToInt32(dtUsuario.Rows[0]["CID_CODIGO"]);
                    intCodigoCargo = Convert.ToInt32(dtUsuario.Rows[0]["CAR_CODIGO"]);
                    intCodigoEstado = Convert.ToInt32(dtUsuario.Rows[0]["EST_CODIGO"]);
                    intCodigo = Convert.ToInt32(dtUsuario.Rows[0]["FUN_CODIGO"]);
                    strNome = dtUsuario.Rows[0]["FUN_NOME"].ToString();
                    strCPF = dtUsuario.Rows[0]["FUN_CPF"].ToString();
                    strEmail = dtUsuario.Rows[0]["FUN_EMAIL"].ToString();
                    strEndereco = dtUsuario.Rows[0]["FUN_ENDEREÇO"].ToString();
                    strNumero = dtUsuario.Rows[0]["FUN_NUMERO"].ToString();
                    strComplemento = dtUsuario.Rows[0]["FUN_COMPLEMENTO"].ToString();
                    strCEP = dtUsuario.Rows[0]["FUN_CEP"].ToString();
                    strBairro = dtUsuario.Rows[0]["FUN_BAIRRO"].ToString();
                    strTelefone = dtUsuario.Rows[0]["FUN_TELEFONE"].ToString();
                    strCelular = dtUsuario.Rows[0]["FUN_CELULAR"].ToString();
                    strLogin = dtUsuario.Rows[0]["FUN_LOGIN"].ToString();
                    strSenha = dtUsuario.Rows[0]["FUN_SENHA"].ToString();
                    blnAtivo = Convert.ToBoolean(dtUsuario.Rows[0]["FUN_ATIVO"]);
                    bytImagem = (byte[])dtUsuario.Rows[0]["FUN_FOTO"];
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
                    strSql = "UPDATE TB_FUNCIONARIO_FUN SET \n";
                    strSql += "FUN_NOME = @p_Nome, \n";
                    strSql += "FUN_ENDEREÇO = @p_Endereco, \n";
                    strSql += "FUN_NUMERO = @p_Numero, \n";
                    strSql += "FUN_COMPLEMENTO = @p_Complemento, \n";
                    strSql += "FUN_CEP = @p_CEP, \n";
                    strSql += "FUN_BAIRRO = @p_BairrO, \n";
                    strSql += "FUN_TELEFONE = @p_Telefone, \n";
                    strSql += "FUN_CELULAR = @p_Celular, \n";
                    strSql += "FUN_EMAIL = @p_Email, \n";
                    strSql += "CID_CODIGO = @p_CidCodigo, \n";
                    strSql += "CAR_CODIGO = @p_CarCodigo, \n";
                    strSql += "FUN_FOTO = @p_Foto, \n";
                    strSql += "FUN_SENHA = @p_Senha, \n";
                    strSql += "FUN_ATIVO = @p_Ativo \n";
                    strSql += "WHERE FUN_CPF = @p_CPF";
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
                oParametros.Add(new SqlParameter("@p_Login", strLogin));
                oParametros.Add(new SqlParameter("@p_Senha", strSenha));
                oParametros.Add(new SqlParameter("@p_Ativo", blnAtivo));
                oParametros.Add(new SqlParameter("@p_CidCodigo", intCodigoCidade));
                oParametros.Add(new SqlParameter("@p_CarCodigo", intCodigoCargo));
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
