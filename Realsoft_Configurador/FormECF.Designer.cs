namespace Realsoft_Configurador
{
    partial class FormECF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormECF));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.megasoftButton1 = new Megasoft.MegasoftButton();
            this.megasoftButton2 = new Megasoft.MegasoftButton();
            this.TxSerie = new System.Windows.Forms.TextBox();
            this.TxModelo = new System.Windows.Forms.TextBox();
            this.TxLoja = new System.Windows.Forms.TextBox();
            this.TxCriptografia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChAtivo = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 242);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(470, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel1.Text = "Total Reduções Z";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel2.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel3.Text = "Intervenção Técnica";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel4.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informações da impressora";
            // 
            // megasoftButton1
            // 
            this.megasoftButton1.BackColor = System.Drawing.Color.Transparent;
            this.megasoftButton1.BaseColor = System.Drawing.Color.SteelBlue;
            this.megasoftButton1.ButtonText = "Cadastrar";
            this.megasoftButton1.Location = new System.Drawing.Point(210, 195);
            this.megasoftButton1.Name = "megasoftButton1";
            this.megasoftButton1.Size = new System.Drawing.Size(100, 32);
            this.megasoftButton1.TabIndex = 3;
            this.megasoftButton1.Click += new System.EventHandler(this.megasoftButton1_Click);
            // 
            // megasoftButton2
            // 
            this.megasoftButton2.BackColor = System.Drawing.Color.Transparent;
            this.megasoftButton2.BaseColor = System.Drawing.Color.SteelBlue;
            this.megasoftButton2.ButtonText = "Fechar";
            this.megasoftButton2.Location = new System.Drawing.Point(340, 195);
            this.megasoftButton2.Name = "megasoftButton2";
            this.megasoftButton2.Size = new System.Drawing.Size(100, 32);
            this.megasoftButton2.TabIndex = 4;
            // 
            // TxSerie
            // 
            this.TxSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxSerie.Location = new System.Drawing.Point(148, 59);
            this.TxSerie.Name = "TxSerie";
            this.TxSerie.Size = new System.Drawing.Size(292, 20);
            this.TxSerie.TabIndex = 5;
            // 
            // TxModelo
            // 
            this.TxModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxModelo.Location = new System.Drawing.Point(148, 85);
            this.TxModelo.Name = "TxModelo";
            this.TxModelo.Size = new System.Drawing.Size(292, 20);
            this.TxModelo.TabIndex = 6;
            // 
            // TxLoja
            // 
            this.TxLoja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxLoja.Location = new System.Drawing.Point(148, 111);
            this.TxLoja.Name = "TxLoja";
            this.TxLoja.Size = new System.Drawing.Size(93, 20);
            this.TxLoja.TabIndex = 7;
            // 
            // TxCriptografia
            // 
            this.TxCriptografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxCriptografia.Location = new System.Drawing.Point(148, 137);
            this.TxCriptografia.Name = "TxCriptografia";
            this.TxCriptografia.Size = new System.Drawing.Size(292, 20);
            this.TxCriptografia.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Número de Série";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Criptografia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loja";
            // 
            // ChAtivo
            // 
            this.ChAtivo.AutoSize = true;
            this.ChAtivo.BackColor = System.Drawing.Color.Transparent;
            this.ChAtivo.ForeColor = System.Drawing.Color.White;
            this.ChAtivo.Location = new System.Drawing.Point(390, 163);
            this.ChAtivo.Name = "ChAtivo";
            this.ChAtivo.Size = new System.Drawing.Size(50, 17);
            this.ChAtivo.TabIndex = 13;
            this.ChAtivo.Text = "Ativo";
            this.ChAtivo.UseVisualStyleBackColor = false;
            // 
            // FormECF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Realsoft_Configurador.Properties.Resources.principal1;
            this.ClientSize = new System.Drawing.Size(470, 264);
            this.Controls.Add(this.ChAtivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxCriptografia);
            this.Controls.Add(this.TxLoja);
            this.Controls.Add(this.TxModelo);
            this.Controls.Add(this.TxSerie);
            this.Controls.Add(this.megasoftButton2);
            this.Controls.Add(this.megasoftButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormECF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECF";
            this.Load += new System.EventHandler(this.FormECF_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private Megasoft.MegasoftButton megasoftButton1;
        private Megasoft.MegasoftButton megasoftButton2;
        private System.Windows.Forms.TextBox TxSerie;
        private System.Windows.Forms.TextBox TxModelo;
        private System.Windows.Forms.TextBox TxLoja;
        private System.Windows.Forms.TextBox TxCriptografia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChAtivo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}