namespace TP_SalaoDeFestas
{
    partial class CadastrarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFornecedor));
            this.label3 = new System.Windows.Forms.Label();
            this.fo_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fo_prod = new System.Windows.Forms.TextBox();
            this.cl_cadastrar = new System.Windows.Forms.Button();
            this.fo_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fo_tel = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefone";
            // 
            // fo_nome
            // 
            this.fo_nome.Location = new System.Drawing.Point(15, 26);
            this.fo_nome.Name = "fo_nome";
            this.fo_nome.Size = new System.Drawing.Size(227, 20);
            this.fo_nome.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Produto";
            // 
            // fo_prod
            // 
            this.fo_prod.Location = new System.Drawing.Point(15, 104);
            this.fo_prod.Name = "fo_prod";
            this.fo_prod.Size = new System.Drawing.Size(227, 20);
            this.fo_prod.TabIndex = 14;
            // 
            // cl_cadastrar
            // 
            this.cl_cadastrar.Location = new System.Drawing.Point(51, 235);
            this.cl_cadastrar.Name = "cl_cadastrar";
            this.cl_cadastrar.Size = new System.Drawing.Size(149, 43);
            this.cl_cadastrar.TabIndex = 15;
            this.cl_cadastrar.Text = "Cadastrar";
            this.cl_cadastrar.UseVisualStyleBackColor = true;
            this.cl_cadastrar.Click += new System.EventHandler(this.cl_cadastrar_Click);
            // 
            // fo_pass
            // 
            this.fo_pass.Location = new System.Drawing.Point(15, 143);
            this.fo_pass.Name = "fo_pass";
            this.fo_pass.PasswordChar = '•';
            this.fo_pass.Size = new System.Drawing.Size(227, 20);
            this.fo_pass.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Senha";
            // 
            // fo_tel
            // 
            this.fo_tel.Location = new System.Drawing.Point(15, 65);
            this.fo_tel.Mask = "(99) 00000-0000";
            this.fo_tel.Name = "fo_tel";
            this.fo_tel.Size = new System.Drawing.Size(227, 20);
            this.fo_tel.TabIndex = 31;
            // 
            // CadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 290);
            this.Controls.Add(this.fo_tel);
            this.Controls.Add(this.fo_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cl_cadastrar);
            this.Controls.Add(this.fo_prod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fo_nome);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarFornecedor";
            this.Text = "Novo Fornecedor";
            this.Load += new System.EventHandler(this.CadastrarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fo_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fo_prod;
        private System.Windows.Forms.Button cl_cadastrar;
        private System.Windows.Forms.TextBox fo_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox fo_tel;
    }
}