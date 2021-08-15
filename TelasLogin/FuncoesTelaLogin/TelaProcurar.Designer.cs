
namespace SistemaMercado.TelasLogin.FuncoesTelaLogin
{
    partial class TelaProcurar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProcurar));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtProcurar = new System.Windows.Forms.Button();
            this.cboOpcoes = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cckListar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 73);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(240, 191);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // txtProcurar
            // 
            this.txtProcurar.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtProcurar.Location = new System.Drawing.Point(177, 12);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(75, 23);
            this.txtProcurar.TabIndex = 1;
            this.txtProcurar.Text = "Procurar";
            this.txtProcurar.UseVisualStyleBackColor = false;
            this.txtProcurar.Click += new System.EventHandler(this.txtProcurar_Click);
            // 
            // cboOpcoes
            // 
            this.cboOpcoes.BackColor = System.Drawing.Color.PapayaWhip;
            this.cboOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboOpcoes.FormattingEnabled = true;
            this.cboOpcoes.Location = new System.Drawing.Point(12, 14);
            this.cboOpcoes.Name = "cboOpcoes";
            this.cboOpcoes.Size = new System.Drawing.Size(159, 21);
            this.cboOpcoes.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(177, 41);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cckListar
            // 
            this.cckListar.AutoSize = true;
            this.cckListar.Location = new System.Drawing.Point(12, 47);
            this.cckListar.Name = "cckListar";
            this.cckListar.Size = new System.Drawing.Size(80, 17);
            this.cckListar.TabIndex = 4;
            this.cckListar.Text = "Listar todos";
            this.cckListar.UseVisualStyleBackColor = true;
            this.cckListar.CheckedChanged += new System.EventHandler(this.cckListar_CheckedChanged);
            // 
            // TelaProcurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(264, 276);
            this.Controls.Add(this.cckListar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cboOpcoes);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaProcurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurar Login";
            this.Load += new System.EventHandler(this.TelaProcurar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button txtProcurar;
        private System.Windows.Forms.ComboBox cboOpcoes;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.CheckBox cckListar;
    }
}