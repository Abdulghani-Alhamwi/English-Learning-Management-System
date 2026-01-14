namespace English_Learning_Management_System
{
    partial class frmLFFirstLoad
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Cairo", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(15, -8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(575, 64);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "English Learning Managment System";
            // 
            // CircleProgressBar1
            // 
            this.CircleProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.CircleProgressBar1.Location = new System.Drawing.Point(910, 117);
            this.CircleProgressBar1.Maximum = 500;
            this.CircleProgressBar1.Minimum = 0;
            this.CircleProgressBar1.Name = "CircleProgressBar1";
            this.CircleProgressBar1.ProgressColor = System.Drawing.Color.DarkOrchid;
            this.CircleProgressBar1.ProgressColor2 = System.Drawing.Color.Lime;
            this.CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleProgressBar1.Size = new System.Drawing.Size(199, 199);
            this.CircleProgressBar1.TabIndex = 1;
            this.CircleProgressBar1.Text = "4";
            // 
            // timer1
            // 
            this.timer1.Interval = 31;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GradientPanel1
            // 
            this.GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.GradientPanel1.Controls.Add(this.lblTitle);
            this.GradientPanel1.FillColor = System.Drawing.Color.Purple;
            this.GradientPanel1.FillColor2 = System.Drawing.Color.Indigo;
            this.GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.GradientPanel1.Location = new System.Drawing.Point(-3, -1);
            this.GradientPanel1.Name = "GradientPanel1";
            this.GradientPanel1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.GradientPanel1.Size = new System.Drawing.Size(587, 56);
            this.GradientPanel1.TabIndex = 2;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2BorderlessForm1.BorderRadius = 100;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmLFFirstLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::English_Learning_Management_System.Properties.Resources.Whisk_5f815065315d09592be4f3ec4ab8d974eg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 537);
            this.Controls.Add(this.GradientPanel1);
            this.Controls.Add(this.CircleProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLFFirstLoad";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLFFirstLoad_Load);
            this.Shown += new System.EventHandler(this.frmLFFirstLoad_Shown);
            this.GradientPanel1.ResumeLayout(false);
            this.GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2GradientPanel GradientPanel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}

