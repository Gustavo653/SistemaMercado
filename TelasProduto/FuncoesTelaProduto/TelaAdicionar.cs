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
using System.Globalization;

namespace SistemaMercado.TelasProduto.FuncoesTelaProduto
{
    public partial class TelaAdicionar : Form
    {
        CultureInfo enUs = new CultureInfo("en-US");
        public TelaAdicionar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaGerenciarProdutos tela = new TelaGerenciarProdutos();
            this.Visible = false;
            tela.Show();
        }

        private void cckProdutoNovo_CheckedChanged(object sender, EventArgs e)
        {
            if (cckProdutoNovo.Checked) //Produto é novo
            {
                cboOpcoes.Enabled = false;
                txtNome.Enabled = true;
                txtPreco.Enabled = true;
                txtNome.Clear();
                txtPreco.Clear();
                txtQtd.Clear();
            }
            else
            {
                cboOpcoes.Enabled = true;
                txtNome.Enabled = false;
                txtPreco.Enabled = false;
            }
        }

        private void TelaAdicionar_Load(object sender, EventArgs e)
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
            txtNome.Enabled = false;
            txtPreco.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cckProdutoNovo.Checked)
            {
                if (!string.IsNullOrEmpty(txtNome.Text) && !string.IsNullOrEmpty(txtPreco.Text) && !string.IsNullOrEmpty(txtQtd.Text))
                {
                    string insert = $"INSERT into dbo.Produtos (nome, quantidade, preco) values ('{txtNome.Text}', {txtQtd.Text} , {string.Format(enUs, "{0:N0}", txtPreco.Text)})";
                    DBConnection.Executa(insert);
                }
                else
                {
                    MessageBox.Show("Verifique se todos os campos foram preenchidos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string update = $"UPDATE dbo.Produtos Set quantidade = {txtQtd.Text} WHERE nome = '{cboOpcoes.Text}'";
                DBConnection.Executa(update);
            }
            TelaAdicionar tela = new TelaAdicionar();
            this.Visible = false;
            tela.Show();
        }

        private void cboOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = $"SELECT nome, quantidade, preco from dbo.Produtos WHERE nome = '{cboOpcoes.Text}'";
            SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
            DBConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtNome.Text = dr["nome"].ToString();
                txtPreco.Text = dr["preco"].ToString();
                txtQtd.Text = dr["quantidade"].ToString();
            }
            DBConnection.Connection.Close();
            dr.Close();
        }
    }
}
