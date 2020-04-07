namespace ProjectFileUpdater
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDirectories = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtDelphiVersion = new System.Windows.Forms.TextBox();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.txtVersionMajor = new System.Windows.Forms.TextBox();
            this.txtVersionMinor = new System.Windows.Forms.TextBox();
            this.txtVersionRelase = new System.Windows.Forms.TextBox();
            this.txtVersionBuild = new System.Windows.Forms.TextBox();
            this.lblDirectories = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblDelphiVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDirectories
            // 
            this.txtDirectories.Location = new System.Drawing.Point(157, 12);
            this.txtDirectories.Name = "txtDirectories";
            this.txtDirectories.Size = new System.Drawing.Size(352, 20);
            this.txtDirectories.TabIndex = 0;
            this.txtDirectories.Text = "D:\\DevelopXE\\Cobra";
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(157, 38);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(352, 20);
            this.txtEdition.TabIndex = 1;
            this.txtEdition.Text = "2019-1";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(157, 90);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(352, 20);
            this.txtCompany.TabIndex = 3;
            this.txtCompany.Text = "mps public solutions gmbh";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(122, 187);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(251, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtDelphiVersion
            // 
            this.txtDelphiVersion.Location = new System.Drawing.Point(157, 116);
            this.txtDelphiVersion.Name = "txtDelphiVersion";
            this.txtDelphiVersion.Size = new System.Drawing.Size(352, 20);
            this.txtDelphiVersion.TabIndex = 5;
            this.txtDelphiVersion.Text = "18.6";
            // 
            // txtCopyright
            // 
            this.txtCopyright.Location = new System.Drawing.Point(157, 142);
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(352, 20);
            this.txtCopyright.TabIndex = 6;
            this.txtCopyright.Text = "© 2019 mps public solutions gmbh";
            // 
            // txtVersionMajor
            // 
            this.txtVersionMajor.Location = new System.Drawing.Point(157, 64);
            this.txtVersionMajor.Name = "txtVersionMajor";
            this.txtVersionMajor.Size = new System.Drawing.Size(40, 20);
            this.txtVersionMajor.TabIndex = 7;
            this.txtVersionMajor.Text = "6";
            // 
            // txtVersionMinor
            // 
            this.txtVersionMinor.Location = new System.Drawing.Point(203, 64);
            this.txtVersionMinor.Name = "txtVersionMinor";
            this.txtVersionMinor.Size = new System.Drawing.Size(40, 20);
            this.txtVersionMinor.TabIndex = 8;
            this.txtVersionMinor.Text = "0";
            // 
            // txtVersionRelase
            // 
            this.txtVersionRelase.Location = new System.Drawing.Point(249, 64);
            this.txtVersionRelase.Name = "txtVersionRelase";
            this.txtVersionRelase.Size = new System.Drawing.Size(40, 20);
            this.txtVersionRelase.TabIndex = 9;
            this.txtVersionRelase.Text = "1";
            // 
            // txtVersionBuild
            // 
            this.txtVersionBuild.Location = new System.Drawing.Point(295, 64);
            this.txtVersionBuild.Name = "txtVersionBuild";
            this.txtVersionBuild.Size = new System.Drawing.Size(40, 20);
            this.txtVersionBuild.TabIndex = 10;
            this.txtVersionBuild.Text = "0";
            // 
            // lblDirectories
            // 
            this.lblDirectories.AutoSize = true;
            this.lblDirectories.Location = new System.Drawing.Point(12, 15);
            this.lblDirectories.Name = "lblDirectories";
            this.lblDirectories.Size = new System.Drawing.Size(52, 13);
            this.lblDirectories.TabIndex = 11;
            this.lblDirectories.Text = "Directory:";
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Location = new System.Drawing.Point(12, 41);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(42, 13);
            this.lblEdition.TabIndex = 12;
            this.lblEdition.Text = "Edition:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 67);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "Version:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(12, 93);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(82, 13);
            this.lblCompany.TabIndex = 14;
            this.lblCompany.Text = "CompanyName:";
            // 
            // lblDelphiVersion
            // 
            this.lblDelphiVersion.AutoSize = true;
            this.lblDelphiVersion.Location = new System.Drawing.Point(12, 119);
            this.lblDelphiVersion.Name = "lblDelphiVersion";
            this.lblDelphiVersion.Size = new System.Drawing.Size(78, 13);
            this.lblDelphiVersion.TabIndex = 15;
            this.lblDelphiVersion.Text = "Delphi Version:";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(12, 145);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(54, 13);
            this.lblCopyright.TabIndex = 16;
            this.lblCopyright.Text = "Copyright:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 230);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblDelphiVersion);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.lblDirectories);
            this.Controls.Add(this.txtVersionBuild);
            this.Controls.Add(this.txtVersionRelase);
            this.Controls.Add(this.txtVersionMinor);
            this.Controls.Add(this.txtVersionMajor);
            this.Controls.Add(this.txtCopyright);
            this.Controls.Add(this.txtDelphiVersion);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.txtDirectories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDirectories;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtDelphiVersion;
        private System.Windows.Forms.TextBox txtCopyright;
        private System.Windows.Forms.TextBox txtVersionMajor;
        private System.Windows.Forms.TextBox txtVersionMinor;
        private System.Windows.Forms.TextBox txtVersionRelase;
        private System.Windows.Forms.TextBox txtVersionBuild;
        private System.Windows.Forms.Label lblDirectories;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblDelphiVersion;
        private System.Windows.Forms.Label lblCopyright;
    }
}

