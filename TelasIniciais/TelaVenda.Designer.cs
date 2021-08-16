
namespace SistemaMercado
{
    partial class TelaVenda
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
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboQuantidade = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEncerrarVenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.AllowUserToAddRows = false;
            this.dgvCarrinho.AllowUserToDeleteRows = false;
            this.dgvCarrinho.AllowUserToOrderColumns = true;
            this.dgvCarrinho.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaNome,
            this.ColunaQuantidade,
            this.ColunaPreco});
            this.dgvCarrinho.Location = new System.Drawing.Point(11, 110);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.ReadOnly = true;
            this.dgvCarrinho.Size = new System.Drawing.Size(284, 170);
            this.dgvCarrinho.TabIndex = 0;
            // 
            // ColunaNome
            // 
            this.ColunaNome.HeaderText = "Nome";
            this.ColunaNome.Name = "ColunaNome";
            this.ColunaNome.ReadOnly = true;
            // 
            // ColunaQuantidade
            // 
            this.ColunaQuantidade.HeaderText = "Quantidade";
            this.ColunaQuantidade.Name = "ColunaQuantidade";
            this.ColunaQuantidade.ReadOnly = true;
            this.ColunaQuantidade.Width = 80;
            // 
            // ColunaPreco
            // 
            this.ColunaPreco.HeaderText = "Preco";
            this.ColunaPreco.Name = "ColunaPreco";
            this.ColunaPreco.ReadOnly = true;
            this.ColunaPreco.Width = 60;
            // 
            // cboQuantidade
            // 
            this.cboQuantidade.BackColor = System.Drawing.Color.PapayaWhip;
            this.cboQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuantidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboQuantidade.FormattingEnabled = true;
            this.cboQuantidade.Location = new System.Drawing.Point(93, 41);
            this.cboQuantidade.Name = "cboQuantidade";
            this.cboQuantidade.Size = new System.Drawing.Size(121, 21);
            this.cboQuantidade.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(220, 14);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 29);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEncerrarVenda
            // 
            this.btnEncerrarVenda.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnEncerrarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrarVenda.Location = new System.Drawing.Point(220, 49);
            this.btnEncerrarVenda.Name = "btnEncerrarVenda";
            this.btnEncerrarVenda.Size = new System.Drawing.Size(75, 40);
            this.btnEncerrarVenda.TabIndex = 3;
            this.btnEncerrarVenda.Text = "Encerrar Venda";
            this.btnEncerrarVenda.UseVisualStyleBackColor = false;
            this.btnEncerrarVenda.Click += new System.EventHandler(this.btnEncerrarVenda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantidade ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produto ->";
            // 
            // cboProdutos
            // 
            this.cboProdutos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboProdutos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProdutos.BackColor = System.Drawing.Color.PapayaWhip;
            this.cboProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Location = new System.Drawing.Point(93, 14);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(121, 21);
            this.cboProdutos.TabIndex = 6;
            this.cboProdutos.SelectedIndexChanged += new System.EventHandler(this.cboProdutos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Preço ->";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(93, 68);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(121, 20);
            this.txtPreco.TabIndex = 8;
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(307, 292);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboProdutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncerrarVenda);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cboQuantidade);
            this.Controls.Add(this.dgvCarrinho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TelaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.TelaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaPreco;
        private System.Windows.Forms.ComboBox cboQuantidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEncerrarVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProdutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreco;
    }
}