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
    }
}
