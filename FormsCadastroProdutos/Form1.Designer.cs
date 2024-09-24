namespace FormsCadastroProdutos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextProduto = new System.Windows.Forms.TextBox();
            this.TextQtde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextVl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dvg = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonqtde = new System.Windows.Forms.Button();
            this.TextAlterar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Finalizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TextProdutoAlterar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TextVlAlterar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            // 
            // TextProduto
            // 
            this.TextProduto.Location = new System.Drawing.Point(136, 23);
            this.TextProduto.Name = "TextProduto";
            this.TextProduto.Size = new System.Drawing.Size(210, 20);
            this.TextProduto.TabIndex = 1;
            this.TextProduto.TextChanged += new System.EventHandler(this.Box_produto_TextChanged);
            // 
            // TextQtde
            // 
            this.TextQtde.Location = new System.Drawing.Point(136, 64);
            this.TextQtde.Name = "TextQtde";
            this.TextQtde.Size = new System.Drawing.Size(210, 20);
            this.TextQtde.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qtde:";
            // 
            // TextVl
            // 
            this.TextVl.Location = new System.Drawing.Point(136, 103);
            this.TextVl.Name = "TextVl";
            this.TextVl.Size = new System.Drawing.Size(210, 20);
            this.TextVl.TabIndex = 5;
            this.TextVl.TextChanged += new System.EventHandler(this.BoxVl_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(25, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Unit:";
            // 
            // dvg
            // 
            this.dvg.AllowUserToAddRows = false;
            this.dvg.AllowUserToDeleteRows = false;
            this.dvg.AllowUserToOrderColumns = true;
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Qtde,
            this.Valor_unit,
            this.Valor_Total});
            this.dvg.Location = new System.Drawing.Point(30, 148);
            this.dvg.Name = "dvg";
            this.dvg.ReadOnly = true;
            this.dvg.Size = new System.Drawing.Size(444, 161);
            this.dvg.TabIndex = 10;
            this.dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Qtde
            // 
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.Name = "Qtde";
            this.Qtde.ReadOnly = true;
            // 
            // Valor_unit
            // 
            this.Valor_unit.HeaderText = "Valor_unit";
            this.Valor_unit.Name = "Valor_unit";
            this.Valor_unit.ReadOnly = true;
            // 
            // buttonqtde
            // 
            this.buttonqtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonqtde.Location = new System.Drawing.Point(258, 357);
            this.buttonqtde.Name = "buttonqtde";
            this.buttonqtde.Size = new System.Drawing.Size(88, 34);
            this.buttonqtde.TabIndex = 11;
            this.buttonqtde.Text = "Alterar";
            this.buttonqtde.UseVisualStyleBackColor = true;
            this.buttonqtde.Click += new System.EventHandler(this.buttonqtde_Click);
            // 
            // TextAlterar
            // 
            this.TextAlterar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.TextAlterar.Location = new System.Drawing.Point(151, 357);
            this.TextAlterar.Multiline = true;
            this.TextAlterar.Name = "TextAlterar";
            this.TextAlterar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextAlterar.Size = new System.Drawing.Size(76, 34);
            this.TextAlterar.TabIndex = 12;
            this.TextAlterar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(10, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Alterar Qtde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.label5.Location = new System.Drawing.Point(570, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 35);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(669, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 35);
            this.label6.TabIndex = 15;
            this.label6.Text = "0";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Finalizar
            // 
            this.Finalizar.Location = new System.Drawing.Point(564, 265);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(75, 44);
            this.Finalizar.TabIndex = 17;
            this.Finalizar.Text = "Finalizar";
            this.Finalizar.UseVisualStyleBackColor = true;
            this.Finalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 18;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(548, -46);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 602);
            this.textBox2.TabIndex = 20;
            // 
            // btnincluir
            // 
            this.btnincluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnincluir.Location = new System.Drawing.Point(352, 23);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(81, 50);
            this.btnincluir.TabIndex = 21;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btnremover
            // 
            this.btnremover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnremover.Location = new System.Drawing.Point(458, 23);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(84, 50);
            this.btnremover.TabIndex = 22;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(10, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Alterar Produto:";
            // 
            // TextProdutoAlterar
            // 
            this.TextProdutoAlterar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextProdutoAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.TextProdutoAlterar.Location = new System.Drawing.Point(151, 315);
            this.TextProdutoAlterar.Multiline = true;
            this.TextProdutoAlterar.Name = "TextProdutoAlterar";
            this.TextProdutoAlterar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextProdutoAlterar.Size = new System.Drawing.Size(76, 34);
            this.TextProdutoAlterar.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(258, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(10, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Alterar Valor:";
            // 
            // TextVlAlterar
            // 
            this.TextVlAlterar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextVlAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.TextVlAlterar.Location = new System.Drawing.Point(151, 397);
            this.TextVlAlterar.Multiline = true;
            this.TextVlAlterar.Name = "TextVlAlterar";
            this.TextVlAlterar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextVlAlterar.Size = new System.Drawing.Size(76, 34);
            this.TextVlAlterar.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button3.Location = new System.Drawing.Point(258, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 34);
            this.button3.TabIndex = 26;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Valor_Total
            // 
            this.Valor_Total.HeaderText = "Valor_Total";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextVlAlterar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextProdutoAlterar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Finalizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextAlterar);
            this.Controls.Add(this.buttonqtde);
            this.Controls.Add(this.dvg);
            this.Controls.Add(this.TextVl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextQtde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextProduto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextProduto;
        private System.Windows.Forms.TextBox TextQtde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_unit;
        private System.Windows.Forms.Button buttonqtde;
        private System.Windows.Forms.TextBox TextAlterar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Finalizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.TextBox TextVl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextProdutoAlterar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextVlAlterar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
    }
}

