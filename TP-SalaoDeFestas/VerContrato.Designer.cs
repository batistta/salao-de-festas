namespace TP_SalaoDeFestas
{
    partial class VerContrato
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
            this.b1 = new System.Windows.Forms.TextBox();
            this.b2 = new System.Windows.Forms.TextBox();
            this.b3 = new System.Windows.Forms.TextBox();
            this.b4 = new System.Windows.Forms.TextBox();
            this.b5 = new System.Windows.Forms.Label();
            this.precot = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.precof = new System.Windows.Forms.Label();
            this.pgto = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(75, 12);
            this.b1.Name = "b1";
            this.b1.ReadOnly = true;
            this.b1.Size = new System.Drawing.Size(100, 20);
            this.b1.TabIndex = 0;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(75, 39);
            this.b2.Name = "b2";
            this.b2.ReadOnly = true;
            this.b2.Size = new System.Drawing.Size(100, 20);
            this.b2.TabIndex = 1;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(75, 66);
            this.b3.Name = "b3";
            this.b3.ReadOnly = true;
            this.b3.Size = new System.Drawing.Size(100, 20);
            this.b3.TabIndex = 2;
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(75, 93);
            this.b4.Name = "b4";
            this.b4.ReadOnly = true;
            this.b4.Size = new System.Drawing.Size(100, 20);
            this.b4.TabIndex = 3;
            // 
            // b5
            // 
            this.b5.AutoSize = true;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(75, 120);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(51, 13);
            this.b5.TabIndex = 4;
            this.b5.Text = "A pagar";
            // 
            // precot
            // 
            this.precot.AutoSize = true;
            this.precot.Location = new System.Drawing.Point(7, 15);
            this.precot.Name = "precot";
            this.precot.Size = new System.Drawing.Size(62, 13);
            this.precot.TabIndex = 5;
            this.precot.Text = "Preço Total";
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(7, 42);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(53, 13);
            this.desc.TabIndex = 6;
            this.desc.Text = "Desconto";
            // 
            // precof
            // 
            this.precof.AutoSize = true;
            this.precof.Location = new System.Drawing.Point(7, 69);
            this.precof.Name = "precof";
            this.precof.Size = new System.Drawing.Size(60, 13);
            this.precof.TabIndex = 7;
            this.precof.Text = "Preço Final";
            // 
            // pgto
            // 
            this.pgto.AutoSize = true;
            this.pgto.Location = new System.Drawing.Point(7, 96);
            this.pgto.Name = "pgto";
            this.pgto.Size = new System.Drawing.Size(61, 13);
            this.pgto.TabIndex = 8;
            this.pgto.Text = "Pagamento";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(7, 120);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(37, 13);
            this.status.TabIndex = 9;
            this.status.Text = "Status";
            // 
            // VerContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 142);
            this.Controls.Add(this.status);
            this.Controls.Add(this.pgto);
            this.Controls.Add(this.precof);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.precot);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "VerContrato";
            this.Text = "Ver Contrato";
            this.Load += new System.EventHandler(this.VerContrato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.TextBox b2;
        private System.Windows.Forms.TextBox b3;
        private System.Windows.Forms.TextBox b4;
        private System.Windows.Forms.Label b5;
        private System.Windows.Forms.Label precot;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label precof;
        private System.Windows.Forms.Label pgto;
        private System.Windows.Forms.Label status;
    }
}