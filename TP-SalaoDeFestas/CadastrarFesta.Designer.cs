namespace TP_SalaoDeFestas
{
    partial class CadastrarFesta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numconvidados = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.datafesta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.temafesta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.formapagamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.inif = new System.Windows.Forms.MaskedTextBox();
            this.fimf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numconvidados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade de Convidados";
            // 
            // numconvidados
            // 
            this.numconvidados.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numconvidados.Location = new System.Drawing.Point(15, 66);
            this.numconvidados.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numconvidados.Name = "numconvidados";
            this.numconvidados.Size = new System.Drawing.Size(219, 20);
            this.numconvidados.TabIndex = 3;
            this.numconvidados.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data da Festa";
            // 
            // datafesta
            // 
            this.datafesta.Location = new System.Drawing.Point(15, 106);
            this.datafesta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datafesta.Name = "datafesta";
            this.datafesta.Size = new System.Drawing.Size(219, 20);
            this.datafesta.TabIndex = 5;
            this.datafesta.Value = new System.DateTime(2018, 6, 7, 0, 0, 0, 0);
            this.datafesta.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Horário";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // temafesta
            // 
            this.temafesta.Location = new System.Drawing.Point(15, 186);
            this.temafesta.Name = "temafesta";
            this.temafesta.Size = new System.Drawing.Size(219, 20);
            this.temafesta.TabIndex = 9;
            this.temafesta.TextChanged += new System.EventHandler(this.temafesta_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tema";
            // 
            // formapagamento
            // 
            this.formapagamento.AutoCompleteCustomSource.AddRange(new string[] {
            "À vista",
            "Duas vezes",
            "Três vezes",
            "Quatro ou mais vezes"});
            this.formapagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formapagamento.FormattingEnabled = true;
            this.formapagamento.Items.AddRange(new object[] {
            "À vista",
            "Duas vezes",
            "Três vezes",
            "Quatro ou mais vezes"});
            this.formapagamento.Location = new System.Drawing.Point(15, 225);
            this.formapagamento.Name = "formapagamento";
            this.formapagamento.Size = new System.Drawing.Size(219, 21);
            this.formapagamento.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Forma de Pagamento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(219, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Nome";
            // 
            // inif
            // 
            this.inif.Location = new System.Drawing.Point(15, 146);
            this.inif.Mask = "00:00";
            this.inif.Name = "inif";
            this.inif.Size = new System.Drawing.Size(87, 20);
            this.inif.TabIndex = 14;
            this.inif.Text = "0000";
            this.inif.ValidatingType = typeof(System.DateTime);
            this.inif.TextChanged += new System.EventHandler(this.inif_TextChanged);
            // 
            // fimf
            // 
            this.fimf.Location = new System.Drawing.Point(133, 146);
            this.fimf.Mask = "00:00";
            this.fimf.Name = "fimf";
            this.fimf.ReadOnly = true;
            this.fimf.Size = new System.Drawing.Size(101, 20);
            this.fimf.TabIndex = 15;
            this.fimf.Text = "0400";
            this.fimf.ValidatingType = typeof(System.DateTime);
            this.fimf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "às";
            // 
            // CadastrarFesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 323);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fimf);
            this.Controls.Add(this.inif);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.formapagamento);
            this.Controls.Add(this.temafesta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datafesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numconvidados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarFesta";
            this.Text = "Cadastrar Festa";
            ((System.ComponentModel.ISupportInitialize)(this.numconvidados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numconvidados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datafesta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox temafesta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox formapagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox inif;
        private System.Windows.Forms.MaskedTextBox fimf;
        private System.Windows.Forms.Label label7;
    }
}