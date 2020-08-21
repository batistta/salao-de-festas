namespace TP_SalaoDeFestas
{
    partial class CadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.cl_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cl_endereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cl_senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cl_cadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cl_data = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cl_tel = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // cl_nome
            // 
            this.cl_nome.Location = new System.Drawing.Point(15, 26);
            this.cl_nome.Name = "cl_nome";
            this.cl_nome.Size = new System.Drawing.Size(227, 20);
            this.cl_nome.TabIndex = 1;
            this.cl_nome.TextChanged += new System.EventHandler(this.cl_nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // cl_endereco
            // 
            this.cl_endereco.Location = new System.Drawing.Point(15, 65);
            this.cl_endereco.Name = "cl_endereco";
            this.cl_endereco.Size = new System.Drawing.Size(227, 20);
            this.cl_endereco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // cl_senha
            // 
            this.cl_senha.Location = new System.Drawing.Point(15, 183);
            this.cl_senha.Name = "cl_senha";
            this.cl_senha.PasswordChar = '•';
            this.cl_senha.Size = new System.Drawing.Size(227, 20);
            this.cl_senha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Nascimento";
            // 
            // cl_cadastrar
            // 
            this.cl_cadastrar.Location = new System.Drawing.Point(50, 235);
            this.cl_cadastrar.Name = "cl_cadastrar";
            this.cl_cadastrar.Size = new System.Drawing.Size(149, 43);
            this.cl_cadastrar.TabIndex = 8;
            this.cl_cadastrar.Text = "Cadastrar";
            this.cl_cadastrar.UseVisualStyleBackColor = true;
            this.cl_cadastrar.Click += new System.EventHandler(this.cl_cadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cl_data
            // 
            this.cl_data.Location = new System.Drawing.Point(15, 144);
            this.cl_data.Name = "cl_data";
            this.cl_data.Size = new System.Drawing.Size(227, 20);
            this.cl_data.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Senha";
            // 
            // cl_tel
            // 
            this.cl_tel.Location = new System.Drawing.Point(15, 104);
            this.cl_tel.Mask = "(99) 00000-0000";
            this.cl_tel.Name = "cl_tel";
            this.cl_tel.Size = new System.Drawing.Size(227, 20);
            this.cl_tel.TabIndex = 12;
            this.cl_tel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cl_tel_MaskInputRejected);
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 290);
            this.Controls.Add(this.cl_tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cl_data);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cl_cadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cl_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cl_endereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cl_nome);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarCliente";
            this.Text = "Novo Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cl_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cl_endereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cl_senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cl_cadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker cl_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox cl_tel;
    }
}