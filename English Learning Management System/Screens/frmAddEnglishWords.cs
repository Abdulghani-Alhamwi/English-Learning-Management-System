using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using Lib;

namespace English_Learning_Management_System.Screens
{
    public partial class frmAddEnglishWords : Form
    {
        public frmAddEnglishWords()
        {
            InitializeComponent();
            clsLib.ChangeFormProperties(this, Convert.ToInt16(this.Width),Convert.ToInt16 (this.Height));
            
        }

        private void btnAddWords_Click(object sender, EventArgs e)
        {
            if ((txtBoxEnglishWord.Text != "" && txtBoxEnglishWord.Text!="Enter English Word/s") && (txtArabicWord.Text!="" && txtArabicWord.Text!="Enter Arabic Translation/s"))
            {
                if(clsWord.SaveEnglishWordsToFile(txtBoxEnglishWord.Text, "EnglishWords.txt", true)&& clsWord.SaveArabicTranslationsToFile(txtArabicWord.Text, "ArabicTranslationWords.txt", true))
                   MessageBox.Show("Word added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxEnglishWord.Clear();
                txtArabicWord.Clear();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void frmAddEnglishWords_Load(object sender, EventArgs e)
        {
            btnExit.CausesValidation = false;
         
        }
        bool AllowTabMovingForControl = false;
        private void txtBoxWord_Validating(object sender, CancelEventArgs e)
        {
            clsUtilControls.ValidateTextBox(sender, txtErrorProvider, e,true,AllowTabMovingForControl);
        }

        private void txtWord_Enter(object sender, EventArgs e)
        {
            AllowTabMovingForControl = false;

            if (((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "A" && (((Guna.UI2.WinForms.Guna2TextBox)sender).Text=="" || ((Guna.UI2.WinForms.Guna2TextBox)sender).Text== "Enter Arabic Translation/s"))
            {
                txtArabicWord.Clear();
                txtArabicWord.ForeColor = Color.FromArgb(255, 30, 30, 30);
                txtBoxEnglishWord.CausesValidation = false;
            }
            else if(((Guna.UI2.WinForms.Guna2TextBox)sender).Text=="" || ((Guna.UI2.WinForms.Guna2TextBox)sender).Text=="Enter English Word/s")
            {
                txtBoxEnglishWord.Clear();
                txtBoxEnglishWord.ForeColor = Color.FromArgb(255, 30, 30, 30);
                txtArabicWord.CausesValidation = false;
            }
        }

        private void txtWordLeave(object sender,EventArgs e)
        {
            if (((Guna.UI2.WinForms.Guna2TextBox)sender).Text == "")
            {
                if (((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "A")
                {
                    txtArabicWord.Text = "Enter Arabic Translation/s";
                    txtArabicWord.ForeColor = Color.FromArgb(255, 60, 60, 60);
                    txtBoxEnglishWord.CausesValidation = true;
                }
                else
                {
                    txtBoxEnglishWord.Text = "Enter English Word/s";
                    txtBoxEnglishWord.ForeColor = Color.FromArgb(255, 60, 60, 60);
                    txtArabicWord.CausesValidation = true;
                }
            }
            else
                AllowTabMovingForControl = true;
        }

        private void btngAddMoreTranslations_Click(object sender, EventArgs e)
        {
            if(txtBoxEnglishWord.Text!="" && txtArabicWord.Text!="")
            {
                Form frmMoreArabicTranslations = new frmAddMoreTranslations(this,txtBoxEnglishWord.Text, txtArabicWord.Text);
                frmMoreArabicTranslations.ShowDialog();
                
            }

            if(txtBoxEnglishWord.Text=="" && txtArabicWord.Text == "")
           {
                MessageBox.Show("Please enter English Word and Its Translation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
           }

            if (txtBoxEnglishWord.Text == "")
            {
                MessageBox.Show("Please enter English Word", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }

            if (txtArabicWord.Text=="")
                {
                MessageBox.Show("Please enter one arabic translation then if you want you can add more.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                }

        }
    }
    
}
