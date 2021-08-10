﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMercado
{
    public partial class TelaAdministrador : Form
    {
        public TelaAdministrador()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(cboOpcoes.Text == "Gerenciar logins")
            {
                TelaGerenciarLogins tela = new TelaGerenciarLogins();
                this.Visible = false;
                tela.Show();
            }
            else
            {
                TelaGerenciarProdutos tela = new TelaGerenciarProdutos();
                this.Visible = false;
                tela.Show();
            }
        }
    }
}
