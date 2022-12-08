namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Produto = new System.Windows.Forms.Label();
            this.Preço = new System.Windows.Forms.Label();
            this.Quantidade = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.TextBox();
            this.valor = new System.Windows.Forms.TextBox();
            this.estoque = new System.Windows.Forms.TextBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.exibir = new System.Windows.Forms.Button();
            this.produtos = new System.Windows.Forms.DataGridView();
            this.excluir = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // Produto
            // 
            this.Produto.AutoSize = true;
            this.Produto.Location = new System.Drawing.Point(12, 62);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(50, 15);
            this.Produto.TabIndex = 0;
            this.Produto.Text = "Produto";
            this.Produto.Click += new System.EventHandler(this.label1_Click);
            // 
            // Preço
            // 
            this.Preço.AutoSize = true;
            this.Preço.Location = new System.Drawing.Point(12, 106);
            this.Preço.Name = "Preço";
            this.Preço.Size = new System.Drawing.Size(37, 15);
            this.Preço.TabIndex = 1;
            this.Preço.Text = "Preço";
            this.Preço.Click += new System.EventHandler(this.label2_Click);
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(12, 150);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(69, 15);
            this.Quantidade.TabIndex = 2;
            this.Quantidade.Text = "Quantidade";
            this.Quantidade.Click += new System.EventHandler(this.label3_Click);
            // 
            // item
            // 
            this.item.Location = new System.Drawing.Point(12, 80);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(177, 23);
            this.item.TabIndex = 3;
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(12, 124);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(177, 23);
            this.valor.TabIndex = 4;
            // 
            // estoque
            // 
            this.estoque.Location = new System.Drawing.Point(12, 168);
            this.estoque.Name = "estoque";
            this.estoque.Size = new System.Drawing.Size(177, 23);
            this.estoque.TabIndex = 5;
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(12, 197);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(177, 31);
            this.Salvar.TabIndex = 6;
            this.Salvar.Text = "salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // exibir
            // 
            this.exibir.Location = new System.Drawing.Point(256, 44);
            this.exibir.Name = "exibir";
            this.exibir.Size = new System.Drawing.Size(113, 30);
            this.exibir.TabIndex = 10;
            this.exibir.Text = "Exibir Dados";
            this.exibir.UseVisualStyleBackColor = true;
            this.exibir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // produtos
            // 
            this.produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtos.Location = new System.Drawing.Point(256, 80);
            this.produtos.Name = "produtos";
            this.produtos.RowTemplate.Height = 25;
            this.produtos.Size = new System.Drawing.Size(384, 214);
            this.produtos.TabIndex = 11;
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(657, 109);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(129, 28);
            this.excluir.TabIndex = 12;
            this.excluir.Text = "Excluir Produto";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(657, 80);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(129, 23);
            this.id.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID do produto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.produtos);
            this.Controls.Add(this.exibir);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.estoque);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.item);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.Preço);
            this.Controls.Add(this.Produto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Produto;
        private Label Preço;
        private Label Quantidade;
        private TextBox item;
        private TextBox valor;
        private TextBox estoque;
        private Button Salvar;
        private Button exibir;
        private DataGridView produtos;
        private Button excluir;
        private TextBox id;
        private Label label1;
    }
}