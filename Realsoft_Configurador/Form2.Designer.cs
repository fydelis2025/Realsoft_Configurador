namespace Realsoft_Configurador
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TxValidacao = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxMail = new System.Windows.Forms.TextBox();
            this.BtFechar = new Megasoft.MegasoftButton();
            this.BtEmail = new Megasoft.MegasoftButton();
            this.BtCadastrar = new Megasoft.MegasoftButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TxTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxCNPJ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxFantasia = new System.Windows.Forms.TextBox();
            this.TxRazaoSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbSenha = new System.Windows.Forms.Label();
            this.LbStatus = new System.Windows.Forms.Label();
            this.TxEmail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxValidacao);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TxMail);
            this.panel1.Controls.Add(this.BtFechar);
            this.panel1.Controls.Add(this.BtEmail);
            this.panel1.Controls.Add(this.BtCadastrar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxTelefone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxCNPJ);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxFantasia);
            this.panel1.Controls.Add(this.TxRazaoSocial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LbSenha);
            this.panel1.Controls.Add(this.LbStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 315);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(219, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Validação";
            // 
            // TxValidacao
            // 
            this.TxValidacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxValidacao.Location = new System.Drawing.Point(222, 225);
            this.TxValidacao.Name = "TxValidacao";
            this.TxValidacao.Size = new System.Drawing.Size(200, 20);
            this.TxValidacao.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Realsoft_Configurador.Properties.Resources.LOGOMARCA1;
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // TxMail
            // 
            this.TxMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxMail.Location = new System.Drawing.Point(16, 225);
            this.TxMail.Name = "TxMail";
            this.TxMail.Size = new System.Drawing.Size(200, 20);
            this.TxMail.TabIndex = 19;
            // 
            // BtFechar
            // 
            this.BtFechar.BackColor = System.Drawing.Color.Transparent;
            this.BtFechar.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtFechar.ButtonText = "Fechar";
            this.BtFechar.Location = new System.Drawing.Point(228, 266);
            this.BtFechar.Name = "BtFechar";
            this.BtFechar.Size = new System.Drawing.Size(100, 32);
            this.BtFechar.TabIndex = 17;
            this.BtFechar.Click += new System.EventHandler(this.BtFechar_Click_1);
            // 
            // BtEmail
            // 
            this.BtEmail.BackColor = System.Drawing.Color.Transparent;
            this.BtEmail.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtEmail.ButtonText = "Enviar Email";
            this.BtEmail.Location = new System.Drawing.Point(122, 266);
            this.BtEmail.Name = "BtEmail";
            this.BtEmail.Size = new System.Drawing.Size(100, 32);
            this.BtEmail.TabIndex = 16;
            this.BtEmail.Click += new System.EventHandler(this.BtEmail_Click);
            // 
            // BtCadastrar
            // 
            this.BtCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.BtCadastrar.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtCadastrar.ButtonText = "Cadastrar";
            this.BtCadastrar.Location = new System.Drawing.Point(16, 266);
            this.BtCadastrar.Name = "BtCadastrar";
            this.BtCadastrar.Size = new System.Drawing.Size(100, 32);
            this.BtCadastrar.TabIndex = 15;
            this.BtCadastrar.Click += new System.EventHandler(this.BtCadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "E-mail";
            // 
            // TxTelefone
            // 
            this.TxTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxTelefone.Location = new System.Drawing.Point(222, 183);
            this.TxTelefone.Name = "TxTelefone";
            this.TxTelefone.Size = new System.Drawing.Size(200, 20);
            this.TxTelefone.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefone";
            // 
            // TxCNPJ
            // 
            this.TxCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxCNPJ.Location = new System.Drawing.Point(16, 183);
            this.TxCNPJ.Name = "TxCNPJ";
            this.TxCNPJ.Size = new System.Drawing.Size(200, 20);
            this.TxCNPJ.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF/CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fantasia";
            // 
            // TxFantasia
            // 
            this.TxFantasia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxFantasia.Location = new System.Drawing.Point(222, 139);
            this.TxFantasia.Name = "TxFantasia";
            this.TxFantasia.Size = new System.Drawing.Size(200, 20);
            this.TxFantasia.TabIndex = 5;
            // 
            // TxRazaoSocial
            // 
            this.TxRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxRazaoSocial.Location = new System.Drawing.Point(16, 139);
            this.TxRazaoSocial.Name = "TxRazaoSocial";
            this.TxRazaoSocial.Size = new System.Drawing.Size(200, 20);
            this.TxRazaoSocial.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome / Razão Social";
            // 
            // LbSenha
            // 
            this.LbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSenha.ForeColor = System.Drawing.Color.Red;
            this.LbSenha.Location = new System.Drawing.Point(144, 92);
            this.LbSenha.Name = "LbSenha";
            this.LbSenha.Size = new System.Drawing.Size(278, 24);
            this.LbSenha.TabIndex = 1;
            this.LbSenha.Text = "000";
            this.LbSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbStatus
            // 
            this.LbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStatus.ForeColor = System.Drawing.Color.White;
            this.LbStatus.Location = new System.Drawing.Point(131, 12);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(247, 80);
            this.LbStatus.TabIndex = 0;
            this.LbStatus.Text = "Sistema ainda não registrado";
            this.LbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxEmail
            // 
            this.TxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxEmail.Location = new System.Drawing.Point(16, 301);
            this.TxEmail.Name = "TxEmail";
            this.TxEmail.Size = new System.Drawing.Size(200, 20);
            this.TxEmail.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Realsoft_Configurador.Properties.Resources.principal1;
            this.ClientSize = new System.Drawing.Size(445, 315);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorizar o uso do sistema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbSenha;
        public System.Windows.Forms.Label LbStatus;
        private System.Windows.Forms.TextBox TxRazaoSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxFantasia;
        private System.Windows.Forms.TextBox TxCNPJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxTelefone;
        private System.Windows.Forms.Label label5;
        //private Megasoft.MegasoftButton BtEnviar;
        //private Megasoft.MegasoftButton BtFechar;
        //private Megasoft.MegasoftButton BtAutorizar;
        private System.Windows.Forms.TextBox TxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxMail;
        private Megasoft.MegasoftButton BtFechar;
        private Megasoft.MegasoftButton BtEmail;
        private Megasoft.MegasoftButton BtCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxValidacao;
        //private Megasoft.MegasoftButton BtBoleto;
        
    }
}