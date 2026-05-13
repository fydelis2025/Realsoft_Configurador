namespace Realsoft_Configurador
{
    partial class Form5
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BKProgress = new System.ComponentModel.BackgroundWorker();
            this.LbAguarde = new System.Windows.Forms.Label();
            this.LbProgresso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.SteelBlue;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.ForeColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(0, 230);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(359, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            // 
            // BKProgress
            // 
            this.BKProgress.WorkerReportsProgress = true;
            this.BKProgress.WorkerSupportsCancellation = true;
            this.BKProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BKProgress_DoWork);
            this.BKProgress.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BKProgress_ProgressChanged);
            this.BKProgress.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BKProgress_RunWorkerCompleted);
            // 
            // LbAguarde
            // 
            this.LbAguarde.AutoSize = true;
            this.LbAguarde.BackColor = System.Drawing.Color.Transparent;
            this.LbAguarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAguarde.ForeColor = System.Drawing.Color.SteelBlue;
            this.LbAguarde.Location = new System.Drawing.Point(9, 211);
            this.LbAguarde.Name = "LbAguarde";
            this.LbAguarde.Size = new System.Drawing.Size(71, 16);
            this.LbAguarde.TabIndex = 5;
            this.LbAguarde.Text = "Aguarde:";
            // 
            // LbProgresso
            // 
            this.LbProgresso.AutoSize = true;
            this.LbProgresso.BackColor = System.Drawing.Color.Transparent;
            this.LbProgresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.LbProgresso.ForeColor = System.Drawing.Color.Red;
            this.LbProgresso.Location = new System.Drawing.Point(177, 210);
            this.LbProgresso.Name = "LbProgresso";
            this.LbProgresso.Size = new System.Drawing.Size(30, 17);
            this.LbProgresso.TabIndex = 4;
            this.LbProgresso.Text = "0%";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Realsoft_Configurador.Properties.Resources.splash1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 253);
            this.ControlBox = false;
            this.Controls.Add(this.LbAguarde);
            this.Controls.Add(this.LbProgresso);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker BKProgress;
        private System.Windows.Forms.Label LbAguarde;
        private System.Windows.Forms.Label LbProgresso;
    }
}