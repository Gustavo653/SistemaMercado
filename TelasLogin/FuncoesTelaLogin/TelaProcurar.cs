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
    public partial class TelaProcurar : Form
    {
        public TelaProcurar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaGerenciarLogins tela = new TelaGerenciarLogins();
            this.Visible = false;
            tela.Show();
        }

        private void TelaProcurar_Load(object sender, EventArgs e)
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

        private void txtProcurar_Click(object sender, EventArgs e)
        {
            if (cckListar.Checked)
            {
                List<ListaLogin> usuarios = new List<ListaLogin>();
                string select = $"SELECT * from dbo.Usuarios";
                SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
                DBConnection.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListaLogin lista = new ListaLogin(dr["usuario"].ToString(), dr["senha"].ToString());
                    usuarios.Add(lista);
                }
                dgvUsuarios.DataSource = usuarios;
                DBConnection.Connection.Close();
            }
            else
            {
                List<ListaLogin> usuarios = new List<ListaLogin>();
                string select = $"SELECT * from dbo.Usuarios WHERE usuario = '{cboOpcoes.Text}'";
                SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
                DBConnection.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListaLogin lista = new ListaLogin(dr["usuario"].ToString(), dr["senha"].ToString());
                    usuarios.Add(lista);
                }
                dgvUsuarios.DataSource = usuarios;
                DBConnection.Connection.Close();
            }
        }

        private void cckListar_CheckedChanged(object sender, EventArgs e)
        {
            if (cckListar.Checked)
                cboOpcoes.Enabled = false;
            else
                cboOpcoes.Enabled = true;
        }
    }
}
