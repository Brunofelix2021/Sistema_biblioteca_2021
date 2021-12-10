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
    class CLivro
    {
        public int intCodigo { get; set; }
        public string strNome { get; set; }
        public string strIdentificacao { get; set; }
        public string strAutor { get; set; }
        public string strAno { get; set; }
        public string strEditora { get; set; }
        public string strExemplares { get; set; }
        public decimal dcmValor { get; set; }
        public int intCodigoGen { get; set; }
        public byte[] bytImagem { get; set; }
        public CLivro()
        {
            strNome = string.Empty;
            strIdentificacao = string.Empty;
            strAutor = string.Empty;
            strAno = string.Empty;
            strEditora = string.Empty;
            strExemplares = string.Empty;
            dcmValor = 0;
            intCodigoGen = 0;
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
                    strSql = "INSERT INTO TB_LIVRO_LIV \n";
                    strSql += "(LIV_NOME, LIV_ANO, LIV_EXEMPLARES, LIV_IDENTIFICACAO, LIV_AUTOR, LIV_EDITORA, LIV_FOTO, LIV_VALOR, GEN_CODIGO) \n";
                    strSql += "VALUES\n";
                    strSql += "(@p_Nome, @p_Ano, @p_Exemplares, @p_Identificacao, @p_Autor, @p_Editora, @p_Foto, @p_Valor, @p_GenCodigo)";
                }

                oParametros.Add(new SqlParameter("@p_Nome", strNome));
                oParametros.Add(new SqlParameter("@p_Ano", strAno));
                oParametros.Add(new SqlParameter("@p_Exemplares", strExemplares));
                oParametros.Add(new SqlParameter("@p_Identificacao", strIdentificacao));
                oParametros.Add(new SqlParameter("@p_Autor", strAutor));
                oParametros.Add(new SqlParameter("@p_Editora", strEditora));
                oParametros.Add(new SqlParameter("@p_Valor", dcmValor));
                oParametros.Add(new SqlParameter("@p_GenCodigo", intCodigoGen));
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
                strSql = "SELECT LIV_CODIGO, LIV_NOME, LIV_ANO, LIV_EXEMPLARES, LIV_IDENTIFICACAO, LIV_AUTOR, LIV_EDITORA, LIV_FOTO, LIV_VALOR, GEN.GEN_CODIGO, GEN_GENERO \n";
                strSql += "FROM TB_LIVRO_LIV LIV \n";
                strSql += "INNER JOIN TB_GENERO_GEN GEN ON GEN.GEN_CODIGO = LIV.GEN_CODIGO \n";
                if (strIdentificacao != string.Empty)
                {
                    strSql += "WHERE LIV_IDENTIFICACAO = @p_Identificacao";
                    oParametros.Add(new SqlParameter("@p_Identificacao", strIdentificacao));
                }
                else if (strNome != string.Empty)
                {
                    strSql += "WHERE LIV_NOME LIKE @p_Nome";
                    oParametros.Add(new SqlParameter("@p_Nome", "%" + strNome + "%"));
                }
                else if (strAutor != string.Empty)
                {
                    strSql += "WHERE LIV_AUTOR LIKE @p_Autor";
                    oParametros.Add(new SqlParameter("@p_Autor", "%" + strAutor + "%"));
                }

                dtUsuario = oAcessoBD.ConsultarSQL(strSql, oParametros);

                if (dtUsuario.Rows.Count == 1)
                {
                    intCodigoGen = Convert.ToInt32(dtUsuario.Rows[0]["GEN_CODIGO"]);
                    intCodigo = Convert.ToInt32(dtUsuario.Rows[0]["LIV_CODIGO"]);
                    strNome = dtUsuario.Rows[0]["LIV_NOME"].ToString();
                    strAno = dtUsuario.Rows[0]["LIV_ANO"].ToString();
                    strAutor = dtUsuario.Rows[0]["LIV_AUTOR"].ToString();
                    strExemplares = dtUsuario.Rows[0]["LIV_EXEMPLARES"].ToString();
                    strIdentificacao = dtUsuario.Rows[0]["LIV_IDENTIFICACAO"].ToString();
                    strEditora = dtUsuario.Rows[0]["LIV_EDITORA"].ToString();
                    dcmValor = Convert.ToDecimal(dtUsuario.Rows[0]["LIV_VALOR"]);
                    bytImagem = (byte[])dtUsuario.Rows[0]["LIV_FOTO"];
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
                    strSql = "UPDATE TB_LIVRO_LIV SET \n";
                    strSql += "LIV_NOME = @p_Nome, \n";
                    strSql += "LIV_ANO = @p_Ano, \n";
                    strSql += "LIV_AUTOR = @p_Autor, \n";
                    strSql += "LIV_EXEMPLARES = @p_Exemplares, \n";
                    strSql += "LIV_VALOR = @p_Valor, \n";
                    strSql += "LIV_FOTO = @p_Foto, \n";
                    strSql += "LIV_EDITORA = @p_Editora, \n";
                    strSql += "GEN_CODIGO = @p_GenCodigo \n";
                    strSql += "WHERE LIV_IDENTIFICACAO = @p_Identificacao";
                }

                oParametros.Add(new SqlParameter("@p_Nome", strNome));
                oParametros.Add(new SqlParameter("@p_Ano", strAno));
                oParametros.Add(new SqlParameter("@p_Autor", strAutor));
                oParametros.Add(new SqlParameter("@p_Identificacao", strIdentificacao));
                oParametros.Add(new SqlParameter("@p_Exemplares", strExemplares));
                oParametros.Add(new SqlParameter("@p_Valor", dcmValor));
                oParametros.Add(new SqlParameter("@p_Editora", strEditora));
                oParametros.Add(new SqlParameter("@p_GenCodigo", intCodigoGen));
                oParametros.Add(new SqlParameter("@p_Foto", bytImagem));
                oAcessoBD.ExecutarSQL(strSql, oParametros);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AlterarExemplar()
        {
            try
            {
                oParametros.Clear();
                {
                    strSql = "UPDATE TB_LIVRO_LIV SET \n";
                    strSql += "LIV_EXEMPLARES = @p_Exemplares \n";
                    strSql += "WHERE LIV_IDENTIFICACAO = @p_Identificacao";
                }
                oParametros.Add(new SqlParameter("@p_Exemplares", strExemplares));
                oParametros.Add(new SqlParameter("@p_Identificacao", strIdentificacao));
                oAcessoBD.ExecutarSQL(strSql, oParametros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }  
}
