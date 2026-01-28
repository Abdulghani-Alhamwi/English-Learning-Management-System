namespace English_Learning_Management_System.Screens
{
    partial class frmAddEnglishWords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEnglishWords));
            this.btnAddWords = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtBoxEnglishWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtArabicWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.btngAddMoreTranslations = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddWords
            // 
            this.btnAddWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWords.BackColor = System.Drawing.Color.Transparent;
            this.btnAddWords.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddWords.BorderRadius = 30;
            this.btnAddWords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWords.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddWords.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddWords.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddWords.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddWords.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddWords.FillColor = System.Drawing.Color.LimeGreen;
            this.btnAddWords.FillColor2 = System.Drawing.Color.DarkGreen;
            this.btnAddWords.FocusedColor = System.Drawing.Color.LawnGreen;
            this.btnAddWords.Font = new System.Drawing.Font("Cairo", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddWords.ForeColor = System.Drawing.Color.White;
            this.btnAddWords.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddWords.HoverState.FillColor = System.Drawing.Color.DarkGreen;
            this.btnAddWords.HoverState.FillColor2 = System.Drawing.Color.OliveDrab;
            this.btnAddWords.IndicateFocus = true;
            this.btnAddWords.Location = new System.Drawing.Point(274, 451);
            this.btnAddWords.Name = "btnAddWords";
            this.btnAddWords.PressedColor = System.Drawing.Color.LightGreen;
            this.btnAddWords.Size = new System.Drawing.Size(305, 80);
            this.btnAddWords.TabIndex = 2;
            this.btnAddWords.Text = "Add  Word";
            this.btnAddWords.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnAddWords.Click += new System.EventHandler(this.btnAddWords_Click);
            // 
            // txtBoxEnglishWord
            // 
            this.txtBoxEnglishWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxEnglishWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBoxEnglishWord.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxEnglishWord.BorderRadius = 40;
            this.txtBoxEnglishWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEnglishWord.DefaultText = "Enter English Word";
            this.txtBoxEnglishWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEnglishWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEnglishWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEnglishWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEnglishWord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtBoxEnglishWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEnglishWord.Font = new System.Drawing.Font("Cairo", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEnglishWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtBoxEnglishWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEnglishWord.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxEnglishWord.IconLeft")));
            this.txtBoxEnglishWord.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.txtBoxEnglishWord.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtBoxEnglishWord.Location = new System.Drawing.Point(122, 141);
            this.txtBoxEnglishWord.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtBoxEnglishWord.MaxLength = 5000;
            this.txtBoxEnglishWord.Name = "txtBoxEnglishWord";
            this.txtBoxEnglishWord.PlaceholderText = "";
            this.txtBoxEnglishWord.SelectedText = "";
            this.txtBoxEnglishWord.Size = new System.Drawing.Size(586, 90);
            this.txtBoxEnglishWord.TabIndex = 0;
            this.txtBoxEnglishWord.Tag = "E";
            this.txtBoxEnglishWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEnglishWord.Enter += new System.EventHandler(this.txtWord_Enter);
            this.txtBoxEnglishWord.Leave += new System.EventHandler(this.txtWordLeave);
            this.txtBoxEnglishWord.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxWord_Validating);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.BorderRadius = 100;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 10;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Maroon;
            this.btnExit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FocusedColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Font = new System.Drawing.Font("Cairo", 39.25F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.btnExit.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.IndicateFocus = true;
            this.btnExit.Location = new System.Drawing.Point(775, -15);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedColor = System.Drawing.Color.Coral;
            this.btnExit.Size = new System.Drawing.Size(81, 99);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "x";
            this.btnExit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtErrorProvider
            // 
            this.txtErrorProvider.ContainerControl = this;
            // 
            // txtArabicWord
            // 
            this.txtArabicWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArabicWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtArabicWord.BackColor = System.Drawing.Color.Transparent;
            this.txtArabicWord.BorderRadius = 40;
            this.txtArabicWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArabicWord.DefaultText = "Enter Arabic Translation";
            this.txtArabicWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtArabicWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtArabicWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArabicWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArabicWord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtArabicWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArabicWord.Font = new System.Drawing.Font("Cairo", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtArabicWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtArabicWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArabicWord.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtArabicWord.IconLeft")));
            this.txtArabicWord.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.txtArabicWord.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtArabicWord.Location = new System.Drawing.Point(122, 289);
            this.txtArabicWord.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtArabicWord.MaxLength = 5000;
            this.txtArabicWord.Name = "txtArabicWord";
            this.txtArabicWord.PlaceholderText = "";
            this.txtArabicWord.SelectedText = "";
            this.txtArabicWord.Size = new System.Drawing.Size(586, 90);
            this.txtArabicWord.TabIndex = 1;
            this.txtArabicWord.Tag = "A";
            this.txtArabicWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArabicWord.Enter += new System.EventHandler(this.txtWord_Enter);
            this.txtArabicWord.Leave += new System.EventHandler(this.txtWordLeave);
            this.txtArabicWord.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxWord_Validating);
            // 
            // btngAddMoreTranslations
            // 
            this.btngAddMoreTranslations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btngAddMoreTranslations.BackColor = System.Drawing.Color.Transparent;
            this.btngAddMoreTranslations.BorderColor = System.Drawing.Color.Transparent;
            this.btngAddMoreTranslations.BorderRadius = 30;
            this.btngAddMoreTranslations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngAddMoreTranslations.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngAddMoreTranslations.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngAddMoreTranslations.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngAddMoreTranslations.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngAddMoreTranslations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngAddMoreTranslations.FillColor = System.Drawing.Color.Purple;
            this.btngAddMoreTranslations.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.btngAddMoreTranslations.FocusedColor = System.Drawing.Color.DarkOrchid;
            this.btngAddMoreTranslations.Font = new System.Drawing.Font("Cairo", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btngAddMoreTranslations.ForeColor = System.Drawing.Color.White;
            this.btngAddMoreTranslations.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btngAddMoreTranslations.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btngAddMoreTranslations.HoverState.FillColor2 = System.Drawing.Color.DarkViolet;
            this.btngAddMoreTranslations.IndicateFocus = true;
            this.btngAddMoreTranslations.Location = new System.Drawing.Point(27, 435);
            this.btngAddMoreTranslations.Name = "btngAddMoreTranslations";
            this.btngAddMoreTranslations.PressedColor = System.Drawing.Color.Indigo;
            this.btngAddMoreTranslations.Size = new System.Drawing.Size(194, 112);
            this.btngAddMoreTranslations.TabIndex = 3;
            this.btngAddMoreTranslations.Text = "Add  More Translations";
            this.btngAddMoreTranslations.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btngAddMoreTranslations.Click += new System.EventHandler(this.btngAddMoreTranslations_Click);
            // 
            // frmAddEnglishWords
            // 
            this.AcceptButton = this.btnAddWords;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(851, 573);
            this.Controls.Add(this.btngAddMoreTranslations);
            this.Controls.Add(this.txtArabicWord);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtBoxEnglishWord);
            this.Controls.Add(this.btnAddWords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEnglishWords";
            this.ShowInTaskbar = false;
            this.Text = "English Learning Management System";
            this.Load += new System.EventHandler(this.frmAddEnglishWords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnAddWords;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEnglishWord;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientButton btnExit;
        private System.Windows.Forms.ErrorProvider txtErrorProvider;
        private Guna.UI2.WinForms.Guna2TextBox txtArabicWord;
        private Guna.UI2.WinForms.Guna2GradientButton btngAddMoreTranslations;
    }
}