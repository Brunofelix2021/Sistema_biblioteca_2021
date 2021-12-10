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
    class Emprestar
    {
        public string strIdentificacao { get; set; }
        public string strNomeLivro { get; set; }
        public string strAutor { get; set; }
        public decimal dcmValor { get; set; }
        public string strExemplares { get; set; }
        public bool blnStatusLivro { get; set; }
        public string strCPF { get; set; }
        public string strNomeCliente { get; set; }
        public bool blnStatusCliente { get; set; }
        public DateTime dtmEmprestimo { get; set; }
        public DateTime dtmDevolucao { get; set; }
        public Emprestar()
        {

        }
        AcessoBD oAcessoBD = new AcessoBD();
        DataTable dtUsuario = new DataTable();
        List<SqlParameter> oParametros = new List<SqlParameter>();
        string strSql = string.Empty;
    }
}
