using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SistemaMercado
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (cboOpcoes.Text != "")
            {
                if (cboOpcoes.Text == "Vender")
                {
                    TelaVenda tela = new TelaVenda();
                    this.Visible = false;
                    tela.Show();
                }
                else
                {
                    bool login = false;
                    string usuario = Interaction.InputBox("Insira o login", "Login", "", 200, 200);
                    string senha = Interaction.InputBox("Insira a senha", "Senha", "", 200, 200);
                    if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(senha))
                    {
                        //senha = senha.GetHashCode().ToString();

                        HashLogin hash = new HashLogin(SHA512.Create());
                        bool senhaHash;


                        string select = $"SELECT usuario, senha from dbo.Usuarios";
                        SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
                        DBConnection.Connection.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {

                            senhaHash = hash.VerificarSenha(senha, dr["senha"].ToString());

                            if (usuario == dr["usuario"].ToString() && senhaHash)//senha == dr["senha"].tostring()
                            {
                                login = true;
                            }
                        }
                        DBConnection.Connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Preencha corretamente o login e a senha!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (login)
                    {
                        MessageBox.Show("Login efetuado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TelaAdministrador tela = new TelaAdministrador();
                        this.Visible = false;
                        tela.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login não efetuado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Verifique se escolheu uma opção!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
