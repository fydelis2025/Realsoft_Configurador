namespace Realsoft_Configurador
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PropertyConfig = new System.Windows.Forms.PropertyGrid();
            this.LbMensagem = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtBalanca = new System.Windows.Forms.ToolStripButton();
            this.BtECF = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtRegistro = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PropertyConfig
            // 
            this.PropertyConfig.BackColor = System.Drawing.Color.Black;
            this.PropertyConfig.CategoryForeColor = System.Drawing.Color.SteelBlue;
            this.PropertyConfig.CommandsActiveLinkColor = System.Drawing.Color.Black;
            this.PropertyConfig.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.PropertyConfig.CommandsForeColor = System.Drawing.Color.White;
            this.PropertyConfig.HelpBackColor = System.Drawing.Color.White;
            this.PropertyConfig.Location = new System.Drawing.Point(0, 42);
            this.PropertyConfig.Name = "PropertyConfig";
            this.PropertyConfig.Size = new System.Drawing.Size(797, 406);
            this.PropertyConfig.TabIndex = 0;
            this.PropertyConfig.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyConfig_PropertyValueChanged);
            // 
            // LbMensagem
            // 
            this.LbMensagem.BackColor = System.Drawing.Color.White;
            this.LbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMensagem.ForeColor = System.Drawing.Color.Red;
            this.LbMensagem.Location = new System.Drawing.Point(469, 3);
            this.LbMensagem.Name = "LbMensagem";
            this.LbMensagem.Size = new System.Drawing.Size(325, 21);
            this.LbMensagem.TabIndex = 2;
            this.LbMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.BackgroundImage = global::Realsoft_Configurador.Properties.Resources.principal1;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtBalanca,
            this.BtECF,
            this.toolStripSeparator1,
            this.BtRegistro,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.BtUsuario,
            this.toolStripSeparator3,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 39);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtBalanca
            // 
            this.BtBalanca.ForeColor = System.Drawing.Color.White;
            this.BtBalanca.Image = global::Realsoft_Configurador.Properties.Resources._3;
            this.BtBalanca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtBalanca.Name = "BtBalanca";
            this.BtBalanca.Size = new System.Drawing.Size(97, 36);
            this.BtBalanca.Text = "BALANCA";
            this.BtBalanca.Click += new System.EventHandler(this.BtBalanca_Click);
            // 
            // BtECF
            // 
            this.BtECF.ForeColor = System.Drawing.Color.White;
            this.BtECF.Image = global::Realsoft_Configurador.Properties.Resources.printer1;
            this.BtECF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtECF.Name = "BtECF";
            this.BtECF.Size = new System.Drawing.Size(63, 36);
            this.BtECF.Text = "ECF";
            this.BtECF.Click += new System.EventHandler(this.BtECF_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // BtRegistro
            // 
            this.BtRegistro.ForeColor = System.Drawing.Color.White;
            this.BtRegistro.Image = global::Realsoft_Configurador.Properties.Resources.onebit_10;
            this.BtRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtRegistro.Name = "BtRegistro";
            this.BtRegistro.Size = new System.Drawing.Size(105, 36);
            this.BtRegistro.Text = "REGISTRAR ";
            this.BtRegistro.Click += new System.EventHandler(this.BtRegistro_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = global::Realsoft_Configurador.Properties.Resources._25;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(107, 36);
            this.toolStripButton1.Text = "Criptografar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // BtUsuario
            // 
            this.BtUsuario.ForeColor = System.Drawing.Color.White;
            this.BtUsuario.Image = global::Realsoft_Configurador.Properties.Resources._37;
            this.BtUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtUsuario.Name = "BtUsuario";
            this.BtUsuario.Size = new System.Drawing.Size(136, 36);
            this.BtUsuario.Text = "Cadastrar Usuário";
            this.BtUsuario.Click += new System.EventHandler(this.BtUsuario_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = global::Realsoft_Configurador.Properties.Resources._130;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(127, 36);
            this.toolStripButton2.Text = "Banco de dados";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip1.BackgroundImage = global::Realsoft_Configurador.Properties.Resources.principal1;
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 473);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LbMensagem);
            this.Controls.Add(this.PropertyConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realsoft Configurador 2013";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid PropertyConfig;
        private System.Windows.Forms.Label LbMensagem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtBalanca;
        private System.Windows.Forms.ToolStripButton BtECF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtRegistro;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtUsuario;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

