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

namespace SistemaMercado.TelasLogin.FuncoesTelaLogin
{
    public partial class TelaRemover : Form
    {
        public TelaRemover()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaGerenciarLogins tela = new TelaGerenciarLogins();
            this.Visible = false;
            tela.Show();
        }

        private void TelaRemover_Load(object sender, EventArgs e)
        {
            List<string> usuarios = new List<string>();
            string select = $"SELECT usuario from dbo.Usuarios";
            SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
            DBConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuarios.Add(dr["usuario"].ToString());
            }
            cboOpcoes.DataSource = usuarios;
            DBConnection.Connection.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            string delete = $"DELETE from dbo.Usuarios WHERE usuario = '{cboOpcoes.Text}'";
            DBConnection.Executa(delete);
            MessageBox.Show("Usuário removido!", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
