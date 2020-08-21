namespace TP_SalaoDeFestas
{
    partial class MostrarFestas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarFestas));
            this.label1 = new System.Windows.Forms.Label();
            this.codfesta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.convfesta = new System.Windows.Forms.TextBox();
            this.datafesta = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inifesta = new System.Windows.Forms.TextBox();
            this.fimfesta = new System.Windows.Forms.TextBox();
            this.bpagar = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.atfesta = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.totfesta = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.nomecl = new System.Windows.Forms.ToolStripTextBox();
            this.verc = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // codfesta
            // 
            this.codfesta.Location = new System.Drawing.Point(81, 39);
            this.codfesta.Name = "codfesta";
            this.codfesta.ReadOnly = true;
            this.codfesta.Size = new System.Drawing.Size(151, 20);
            this.codfesta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Convidados";
            // 
            // convfesta
            // 
            this.convfesta.Location = new System.Drawing.Point(81, 65);
            this.convfesta.Name = "convfesta";
            this.convfesta.ReadOnly = true;
            this.convfesta.Size = new System.Drawing.Size(151, 20);
            this.convfesta.TabIndex = 4;
            // 
            // datafesta
            // 
            this.datafesta.Enabled = false;
            this.datafesta.Location = new System.Drawing.Point(296, 34);
            this.datafesta.Name = "datafesta";
            this.datafesta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Início";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fim";
            // 
            // inifesta
            // 
            this.inifesta.Location = new System.Drawing.Point(81, 91);
            this.inifesta.Name = "inifesta";
            this.inifesta.ReadOnly = true;
            this.inifesta.Size = new System.Drawing.Size(151, 20);
            this.inifesta.TabIndex = 9;
            // 
            // fimfesta
            // 
            this.fimfesta.Location = new System.Drawing.Point(81, 117);
            this.fimfesta.Name = "fimfesta";
            this.fimfesta.ReadOnly = true;
            this.fimfesta.Size = new System.Drawing.Size(151, 20);
            this.fimfesta.TabIndex = 10;
            // 
            // bpagar
            // 
            this.bpagar.Location = new System.Drawing.Point(81, 173);
            this.bpagar.Name = "bpagar";
            this.bpagar.Size = new System.Drawing.Size(151, 23);
            this.bpagar.TabIndex = 11;
            this.bpagar.Text = "Pagar";
            this.bpagar.UseVisualStyleBackColor = true;
            this.bpagar.Click += new System.EventHandler(this.bpagar_Click);
            // 
            // bcancel
            // 
            this.bcancel.Location = new System.Drawing.Point(81, 143);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(151, 23);
            this.bcancel.TabIndex = 12;
            this.bcancel.Text = "Cancelar";
            this.bcancel.UseVisualStyleBackColor = true;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.atfesta,
            this.toolStripLabel1,
            this.totfesta,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.nomecl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(537, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Anterior";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // atfesta
            // 
            this.atfesta.Name = "atfesta";
            this.atfesta.Size = new System.Drawing.Size(25, 25);
            this.atfesta.Text = "0";
            this.atfesta.TextChanged += new System.EventHandler(this.atfesta_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel1.Text = "de";
            // 
            // totfesta
            // 
            this.totfesta.Name = "totfesta";
            this.totfesta.Size = new System.Drawing.Size(21, 22);
            this.totfesta.Text = "{0}";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Próxima";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(101, 22);
            this.toolStripLabel3.Text = "Exibindo festas de";
            // 
            // nomecl
            // 
            this.nomecl.Enabled = false;
            this.nomecl.Name = "nomecl";
            this.nomecl.Size = new System.Drawing.Size(150, 25);
            this.nomecl.Text = "Administrador";
            // 
            // verc
            // 
            this.verc.Location = new System.Drawing.Point(15, 143);
            this.verc.Name = "verc";
            this.verc.Size = new System.Drawing.Size(60, 53);
            this.verc.TabIndex = 14;
            this.verc.Text = "Ver Contrato";
            this.verc.UseVisualStyleBackColor = true;
            this.verc.Click += new System.EventHandler(this.verc_Click);
            // 
            // MostrarFestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 214);
            this.Controls.Add(this.verc);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bpagar);
            this.Controls.Add(this.fimfesta);
            this.Controls.Add(this.inifesta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datafesta);
            this.Controls.Add(this.convfesta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codfesta);
            this.Controls.Add(this.label1);
            this.Name = "MostrarFestas";
            this.Text = "Mostrar Festas";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codfesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox convfesta;
        private System.Windows.Forms.MonthCalendar datafesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inifesta;
        private System.Windows.Forms.TextBox fimfesta;
        private System.Windows.Forms.Button bpagar;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox atfesta;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel totfesta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox nomecl;
        private System.Windows.Forms.Button verc;
    }
}