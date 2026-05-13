namespace Realsoft_Configurador
{
    partial class FormBalanca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBalanca));
            this.megasoftButton1 = new Megasoft.MegasoftButton();
            this.LbPeso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clstPorts = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChAplicacao = new System.Windows.Forms.CheckBox();
            this.ChFilizola = new System.Windows.Forms.CheckBox();
            this.ChToledo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // megasoftButton1
            // 
            this.megasoftButton1.BackColor = System.Drawing.Color.Transparent;
            this.megasoftButton1.ButtonColor = System.Drawing.Color.DarkOrange;
            this.megasoftButton1.ButtonText = "Testar";
            this.megasoftButton1.Location = new System.Drawing.Point(6, 92);
            this.megasoftButton1.Name = "megasoftButton1";
            this.megasoftButton1.Size = new System.Drawing.Size(156, 37);
            this.megasoftButton1.TabIndex = 0;
            this.megasoftButton1.Click += new System.EventHandler(this.megasoftButton1_Click);
            // 
            // LbPeso
            // 
            this.LbPeso.AutoSize = true;
            this.LbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPeso.Location = new System.Drawing.Point(78, 35);
            this.LbPeso.Name = "LbPeso";
            this.LbPeso.Size = new System.Drawing.Size(84, 37);
            this.LbPeso.TabIndex = 2;
            this.LbPeso.Text = "0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peso";
            // 
            // clstPorts
            // 
            this.clstPorts.AccessibleDescription = "Checked ListBox to display the 4 main COM ports.";
            this.clstPorts.AccessibleName = "ComPorts CheckedListBox";
            this.clstPorts.BackColor = System.Drawing.Color.Black;
            this.clstPorts.ForeColor = System.Drawing.Color.White;
            this.clstPorts.Location = new System.Drawing.Point(12, 25);
            this.clstPorts.Name = "clstPorts";
            this.clstPorts.Size = new System.Drawing.Size(208, 94);
            this.clstPorts.TabIndex = 4;
            this.clstPorts.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ChAplicacao);
            this.groupBox1.Controls.Add(this.ChFilizola);
            this.groupBox1.Controls.Add(this.ChToledo);
            this.groupBox1.Controls.Add(this.megasoftButton1);
            this.groupBox1.Controls.Add(this.LbPeso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 151);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comunicação";
            // 
            // ChAplicacao
            // 
            this.ChAplicacao.AutoSize = true;
            this.ChAplicacao.Location = new System.Drawing.Point(6, 69);
            this.ChAplicacao.Name = "ChAplicacao";
            this.ChAplicacao.Size = new System.Drawing.Size(73, 17);
            this.ChAplicacao.TabIndex = 4;
            this.ChAplicacao.Text = "Aplicação";
            this.ChAplicacao.UseVisualStyleBackColor = true;
            // 
            // ChFilizola
            // 
            this.ChFilizola.AutoSize = true;
            this.ChFilizola.Location = new System.Drawing.Point(6, 49);
            this.ChFilizola.Name = "ChFilizola";
            this.ChFilizola.Size = new System.Drawing.Size(57, 17);
            this.ChFilizola.TabIndex = 1;
            this.ChFilizola.Text = "Filizola";
            this.ChFilizola.UseVisualStyleBackColor = true;
            // 
            // ChToledo
            // 
            this.ChToledo.AutoSize = true;
            this.ChToledo.Location = new System.Drawing.Point(6, 28);
            this.ChToledo.Name = "ChToledo";
            this.ChToledo.Size = new System.Drawing.Size(59, 17);
            this.ChToledo.TabIndex = 0;
            this.ChToledo.Text = "Toledo";
            this.ChToledo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Portas ativas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormBalanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Realsoft_Configurador.Properties.Resources.principal1;
            this.ClientSize = new System.Drawing.Size(238, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clstPorts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBalanca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balanca";
            this.Load += new System.EventHandler(this.FormBalanca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Megasoft.MegasoftButton megasoftButton1;
        private System.Windows.Forms.Label LbPeso;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.CheckedListBox clstPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChFilizola;
        private System.Windows.Forms.CheckBox ChToledo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChAplicacao;
    }
}