﻿using System;
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
    public partial class TelaAdicionar : Form
    {
        public TelaAdicionar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaGerenciarLogins tela = new TelaGerenciarLogins();
            this.Visible = false;
            tela.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            HashLogin hash = new HashLogin(SHA512.Create());
            string senhaHash = hash.CriptografarSenha(txtSenha.Text);
            string insert = $"INSERT into dbo.Usuarios (usuario, senha) values ('{txtUsuario.Text}', '{senhaHash}')";
            DBConnection.Executa(insert);
            txtUsuario.Clear();
            txtSenha.Clear();
            MessageBox.Show("Usuário adicionado!", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
