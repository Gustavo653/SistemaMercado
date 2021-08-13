﻿using SistemaMercado.TelasProduto.FuncoesTelaProduto;
using System;
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
    public partial class TelaGerenciarProdutos : Form
    {
        public TelaGerenciarProdutos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaAdministrador tela = new TelaAdministrador();
            this.Visible = false;
            tela.Show();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (cboOpcoes.Text == "Adicionar")
            {
                TelaAdicionar tela = new TelaAdicionar();
                this.Visible = false;
                tela.Show();
            }
            else if (cboOpcoes.Text == "Excluir")
            {
                TelaRemover tela = new TelaRemover();
                this.Visible = false;
                tela.Show();
            }
            else if (cboOpcoes.Text == "Alterar")
            {
                TelaAlterar tela = new TelaAlterar();
                this.Visible = false;
                tela.Show();
            }
            else if (cboOpcoes.Text == "Procurar")
            {
                TelaProcurar tela = new TelaProcurar();
                this.Visible = false;
                tela.Show();
            }
        }
    }
}
