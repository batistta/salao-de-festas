namespace TP_SalaoDeFestas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ini_name = new System.Windows.Forms.TextBox();
            this.ini_senha = new System.Windows.Forms.TextBox();
            this.ini_entrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-79, -60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 391);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conecte-se a uma conta";
            // 
            // ini_name
            // 
            this.ini_name.Location = new System.Drawing.Point(491, 34);
            this.ini_name.Name = "ini_name";
            this.ini_name.Size = new System.Drawing.Size(120, 20);
            this.ini_name.TabIndex = 2;
            this.ini_name.Tag = "";
            this.ini_name.Text = "Nome";
            this.ini_name.TextChanged += new System.EventHandler(this.ini_name_TextChanged);
            // 
            // ini_senha
            // 
            this.ini_senha.Location = new System.Drawing.Point(491, 61);
            this.ini_senha.Name = "ini_senha";
            this.ini_senha.PasswordChar = '•';
            this.ini_senha.Size = new System.Drawing.Size(120, 20);
            this.ini_senha.TabIndex = 3;
            this.ini_senha.Text = "Senha";
            this.ini_senha.TextChanged += new System.EventHandler(this.ini_senha_TextChanged);
            // 
            // ini_entrar
            // 
            this.ini_entrar.Location = new System.Drawing.Point(491, 88);
            this.ini_entrar.Name = "ini_entrar";
            this.ini_entrar.Size = new System.Drawing.Size(120, 23);
            this.ini_entrar.TabIndex = 4;
            this.ini_entrar.Text = "Entrar";
            this.ini_entrar.UseVisualStyleBackColor = true;
            this.ini_entrar.Click += new System.EventHandler(this.ini_entrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ainda não é cadastrado?";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(505, 178);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(93, 13);
            this.linkLabel3.TabIndex = 8;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Cadastre-se agora";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 331);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ini_entrar);
            this.Controls.Add(this.ini_senha);
            this.Controls.Add(this.ini_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Salão de Festas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ini_name;
        private System.Windows.Forms.TextBox ini_senha;
        private System.Windows.Forms.Button ini_entrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}

