namespace Realsoft_Configurador
{
    partial class Form6
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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("SQL");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("MYSQL");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("ORACLE");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("POSTGRE");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.TBanco = new System.Windows.Forms.TreeView();
            this.BtConect = new Megasoft.MegasoftButton();
            this.BtBackup = new Megasoft.MegasoftButton();
            this.BtInstall = new Megasoft.MegasoftButton();
            this.BtClose = new Megasoft.MegasoftButton();
            this.DgData = new System.Windows.Forms.DataGridView();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgData)).BeginInit();
            this.SuspendLayout();
            // 
            // TBanco
            // 
            this.TBanco.BackColor = System.Drawing.Color.DimGray;
            this.TBanco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBanco.ForeColor = System.Drawing.Color.White;
            this.TBanco.LineColor = System.Drawing.Color.White;
            this.TBanco.Location = new System.Drawing.Point(2, 5);
            this.TBanco.Name = "TBanco";
            treeNode17.Name = "SQL";
            treeNode17.Text = "SQL";
            treeNode18.Name = "MYSQL";
            treeNode18.Text = "MYSQL";
            treeNode19.Name = "ORACLE";
            treeNode19.Text = "ORACLE";
            treeNode20.Name = "POSTGRE";
            treeNode20.Text = "POSTGRE";
            this.TBanco.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            this.TBanco.Size = new System.Drawing.Size(131, 149);
            this.TBanco.TabIndex = 0;
            // 
            // BtConect
            // 
            this.BtConect.BackColor = System.Drawing.Color.Transparent;
            this.BtConect.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtConect.ButtonText = "Conect";
            this.BtConect.Location = new System.Drawing.Point(12, 264);
            this.BtConect.Name = "BtConect";
            this.BtConect.Size = new System.Drawing.Size(100, 32);
            this.BtConect.TabIndex = 1;
            // 
            // BtBackup
            // 
            this.BtBackup.BackColor = System.Drawing.Color.Transparent;
            this.BtBackup.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtBackup.ButtonText = "Backup";
            this.BtBackup.Location = new System.Drawing.Point(118, 264);
            this.BtBackup.Name = "BtBackup";
            this.BtBackup.Size = new System.Drawing.Size(100, 32);
            this.BtBackup.TabIndex = 2;
            // 
            // BtInstall
            // 
            this.BtInstall.BackColor = System.Drawing.Color.Transparent;
            this.BtInstall.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtInstall.ButtonText = "Instalar";
            this.BtInstall.Location = new System.Drawing.Point(224, 264);
            this.BtInstall.Name = "BtInstall";
            this.BtInstall.Size = new System.Drawing.Size(100, 32);
            this.BtInstall.TabIndex = 3;
            // 
            // BtClose
            // 
            this.BtClose.BackColor = System.Drawing.Color.Transparent;
            this.BtClose.BaseColor = System.Drawing.Color.SteelBlue;
            this.BtClose.ButtonText = "Close";
            this.BtClose.Location = new System.Drawing.Point(330, 264);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(100, 32);
            this.BtClose.TabIndex = 4;
            // 
            // DgData
            // 
            this.DgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESCRICAO});
            this.DgData.Location = new System.Drawing.Point(2, 169);
            this.DgData.Name = "DgData";
            this.DgData.RowHeadersVisible = false;
            this.DgData.Size = new System.Drawing.Size(575, 77);
            this.DgData.TabIndex = 5;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.FillWeight = 560F;
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.Width = 560;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Realsoft_Configurador.Properties.Resources.principal1;
            this.ClientSize = new System.Drawing.Size(589, 297);
            this.Controls.Add(this.DgData);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.BtInstall);
            this.Controls.Add(this.BtBackup);
            this.Controls.Add(this.BtConect);
            this.Controls.Add(this.TBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de dados";
            ((System.ComponentModel.ISupportInitialize)(this.DgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TBanco;
        private Megasoft.MegasoftButton BtConect;
        private Megasoft.MegasoftButton BtBackup;
        private Megasoft.MegasoftButton BtInstall;
        private Megasoft.MegasoftButton BtClose;
        private System.Windows.Forms.DataGridView DgData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
    }
}