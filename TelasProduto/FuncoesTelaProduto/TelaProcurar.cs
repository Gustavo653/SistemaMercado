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
    public partial class TelaProcurar : Form
    {
        public TelaProcurar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaGerenciarProdutos tela = new TelaGerenciarProdutos();
            this.Visible = false;
            tela.Show();
        }

        private void cckListar_CheckedChanged(object sender, EventArgs e)
        {
            if (cckListar.Checked)
                cboOpcoes.Enabled = false;
            else
                cboOpcoes.Enabled = true;
        }

        private void txtProcurar_Click(object sender, EventArgs e)
        {
            if (cckListar.Checked)
            {
                List<ListaProduto> produtos = new List<ListaProduto>();
                string select = $"SELECT * from dbo.Produtos";
                SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
                DBConnection.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListaProduto lista = new ListaProduto(dr["nome"].ToString(), Convert.ToInt32(dr["quantidade"]), Convert.ToDouble(dr["preco"]));
                    produtos.Add(lista);
                }
                dgvUsuarios.DataSource = produtos;
                DBConnection.Connection.Close();
            }
            else
            {
                List<ListaProduto> produtos = new List<ListaProduto>();
                string select = $"SELECT * from dbo.Produtos WHERE nome = '{cboOpcoes.Text}'";
                SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
                DBConnection.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListaProduto lista = new ListaProduto(dr["nome"].ToString(), Convert.ToInt32(dr["quantidade"]), Convert.ToDouble(dr["preco"]));
                    produtos.Add(lista);
                }
                dgvUsuarios.DataSource = produtos;
                DBConnection.Connection.Close();
            }
        }

        private void TelaProcurar_Load(object sender, EventArgs e)
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
    }
}
