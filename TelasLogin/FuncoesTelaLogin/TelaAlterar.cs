using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMercado.TelasLogin.FuncoesTelaLogin
{
    public partial class TelaAlterar : Form
    {
        public TelaAlterar()
        {
            InitializeComponent();
        }

        private void TelaAlterar_Load(object sender, EventArgs e)
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaGerenciarLogins tela = new TelaGerenciarLogins();
            this.Visible = false;
            tela.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSenha.Text) && !string.IsNullOrEmpty(txtUsuario.Text))
            {
                HashLogin hash = new HashLogin(SHA512.Create());
                string senhaHash = hash.CriptografarSenha(txtSenha.Text);
                string update = $"UPDATE dbo.Usuarios Set usuario = '{txtUsuario.Text}', senha = '{senhaHash}' WHERE usuario = '{cboOpcoes.Text}'";
                DBConnection.Executa(update);
            }
        }
    }
}
