using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMercado.TelasProduto.FuncoesTelaProduto
{
    public partial class TelaAlterar : Form
    {
        public TelaAlterar()
        {
            InitializeComponent();
        }

        private void TelaAlterar_Load(object sender, EventArgs e)
        {
            List<string> nomes = new List<string>();
            string select = $"SELECT nome from dbo.Produtos";
            SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
            DBConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nomes.Add(dr["nome"].ToString());
            }
            DBConnection.Connection.Close();
            dr.Close();
            cboOpcoes.DataSource = nomes;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaGerenciarProdutos tela = new TelaGerenciarProdutos();
            this.Visible = false;
            tela.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
