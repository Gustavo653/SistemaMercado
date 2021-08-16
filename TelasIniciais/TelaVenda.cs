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
using Microsoft.VisualBasic;

namespace SistemaMercado
{
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();
        }

        private void TelaVenda_Load(object sender, EventArgs e)
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
            DBConnection.Connection.Close();
            dr.Close();
            cboProdutos.DataSource = produtos;
        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> quantidades = new List<int>();
            string select = $"SELECT quantidade, preco from dbo.Produtos WHERE nome = '{cboProdutos.Text}'";
            SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
            DBConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                for (int i = 1; i <= Convert.ToInt32(dr["quantidade"]); i++)
                {
                    quantidades.Add(i);
                }
                txtPreco.Text = dr["preco"].ToString();
            }
            DBConnection.Connection.Close();
            dr.Close();
            cboQuantidade.DataSource = quantidades;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string update = $"UPDATE dbo.Produtos Set quantidade = quantidade - {cboQuantidade.Text} WHERE nome = '{cboProdutos.Text}'";
            DBConnection.Executa(update);
            dgvCarrinho.Rows.Add(cboProdutos.Text, cboQuantidade.Text, txtPreco.Text);
        }

        private void btnEncerrarVenda_Click(object sender, EventArgs e)
        {
            List<Produto> produtos = new List<Produto>();
            foreach (DataGridViewRow dataGridViewRow in dgvCarrinho.Rows)
            {
                Produto produto = new Produto(dataGridViewRow.Cells["ColunaPreco"].Value.ToString(), dataGridViewRow.Cells["ColunaQuantidade"].Value.ToString());
                produtos.Add(produto);
            }
            double precoTotal = 0;
            foreach (var item in produtos)
            {
                double precoProduto = 0;
                precoProduto += Convert.ToDouble(item.Preco);
                precoProduto *= Convert.ToDouble(item.Quantidade);
                precoTotal += precoProduto;
            }

            Interaction.MsgBox($"Valor total da compra: {precoTotal:c}", MsgBoxStyle.OkOnly, "Encerrando compra");
            string valorRecebido = Interaction.InputBox("Insira o valor recebido pelo cliente", "Recebimento", "", 200, 200);
            double valorTroco = Convert.ToDouble(valorRecebido) - precoTotal;
            Interaction.MsgBox($"Agradecemos sua compra! \nSeu troco: {valorTroco:c}", MsgBoxStyle.OkOnly, "Troco");

            TelaVenda tela = new TelaVenda();
            this.Visible = false;
            tela.Show();
        }
        private class Produto
        {
            public string Preco { get; set; }
            public string Quantidade { get; set; }

            public Produto(string preco, string quantidade)
            {
                Preco = preco;
                Quantidade = quantidade;
            }
        }
    }
}
