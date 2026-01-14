using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI.Design;
using System.Drawing;
using System.Windows.Forms;
using Lib;

namespace English_Learning_Management_System.Screens
{
    public partial class frmAddMoreTranslations : Form
    {
        private string _EnglishWord, _ArabicTranslation1;
        frmAddEnglishWords FormToHandleClose;
        public frmAddMoreTranslations(frmAddEnglishWords frm, string EnglshWord, string ArabicTranslation1)
        {
            InitializeComponent();
            clsLib.ChangeFormProperties(this, Convert.ToInt16(this.Width), Convert.ToInt16(this.Height));
            _EnglishWord = EnglshWord;
            _ArabicTranslation1 = ArabicTranslation1;
            FormToHandleClose = frm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddMoreTranslations_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormToHandleClose.Close();
        }

        private void _SaveArabicTranslations()
        {
            if ((txtGArabicTranslation2.Text == "" || txtGArabicTranslation2.Text == "Enter Arabic Translation 2") && (txtGArabicTranslation3.Text == "" || txtGArabicTranslation3.Text == "Enter Arabic Translation 3") && (txtGArabicTranslation4.Text == "" || txtGArabicTranslation4.Text == "Enter Arabic Translation 4"))
            {
                DialogResult Result = MessageBox.Show($"Are you sure you don't want to add more translations and save the english word ({_EnglishWord}) + its One translation ({_ArabicTranslation1})", "Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Result == DialogResult.OK)
                {
                    clsWord.SaveArabicTranslationsToFile(_ArabicTranslation1, "ArabicTranslationWords.txt", true);
                    this.Close();
                    return;
                }
            }
            else { 
                clsWord.SaveArabicTranslationsToFile(_ArabicTranslation1, "ArabicTranslationWords.txt", true, true, txtGArabicTranslation2.Text, txtGArabicTranslation3.Text, txtGArabicTranslation4.Text);

                MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void btnAddTranslations_Click(object sender, EventArgs e)
        {
            if (_EnglishWord != "")
                clsWord.SaveEnglishWordsToFile(_EnglishWord, "EnglishWords.txt", true);

            if (_ArabicTranslation1 != "")
                _SaveArabicTranslations();

        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
           
            ((Guna.UI2.WinForms.Guna2TextBox)sender).Clear();
            ((Guna.UI2.WinForms.Guna2TextBox)sender).ForeColor = Color.FromArgb(255, 30, 30, 30);
        }

        private void txtBox_Leave(object sender,EventArgs e)
        {
            if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "A1") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text=="")
            {
                ((Guna.UI2.WinForms.Guna2TextBox)sender).Text="Enter Arabic Translation 2";
                ((Guna.UI2.WinForms.Guna2TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }

            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "A2") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text == "")
            {
                ((Guna.UI2.WinForms.Guna2TextBox)sender).Text = "Enter Arabic Translation 3";
                ((Guna.UI2.WinForms.Guna2TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "A3") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text == "")
            {
                ((Guna.UI2.WinForms.Guna2TextBox)sender).Text = "Enter Arabic Translation 4";
                ((Guna.UI2.WinForms.Guna2TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
         
        }
    }
}
