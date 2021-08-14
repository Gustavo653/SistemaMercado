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
    public partial class TelaRemover : Form
    {
        public TelaRemover()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaGerenciarProdutos tela = new TelaGerenciarProdutos();
            this.Visible = false;
            tela.Show();
        }

        private void TelaRemover_Load(object sender, EventArgs e)
        {
            List<string> produtos = new List<string>();
            string select = $"SELECT nome from dbo.Produtos";
            SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
            DBConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(dr["nome"].ToString());
            }
            cboOpcoes.DataSource = produtos;
            DBConnection.Connection.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE from dbo.Produtos WHERE nome = '{cboOpcoes.Text}'";
            DBConnection.Executa(delete);
            MessageBox.Show("Produto removido!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
