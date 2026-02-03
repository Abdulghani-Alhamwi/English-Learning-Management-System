using Guna.UI2.WinForms;
using Lib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;

namespace English_Learning_Management_System.Screens
{
    public partial class frmExamplesInsertion : Form
    {
        short _NumberOfSelectedItems;
        List<ListViewItem> lstItems;
        frmMainScreen MainForm;
        public frmExamplesInsertion(frmMainScreen frmM,List<ListViewItem> lstSelectedItems)
        {
            if(lstSelectedItems.Count<1 || lstSelectedItems.Count>4)
            {
                MessageBox.Show("Please select between 1 and 4 Words.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
                return;
            }
            InitializeComponent();

            _NumberOfSelectedItems = Convert.ToInt16(lstSelectedItems.Count);
            lstItems= lstSelectedItems;
            MainForm= frmM;
        }

      
        private bool _IstxtBoxEmpty(Guna2TextBox txtBox)
        {
            return txtBox.Text == "";
        }
        private string [] _GetExamplesInputs()
        {
            List<string> Lexamples = new List<string>();

            if (!_IstxtBoxEmpty(txtGExampleEWord1) && _NumberOfSelectedItems >= 1 && txtGExampleEWord1.Text!="Enter Example For English Word 1")
                Lexamples.Add(txtGExampleEWord1.Text);

            if (!_IstxtBoxEmpty(txtGExampleEWord2) && _NumberOfSelectedItems >= 2 && txtGExampleEWord2.Text != "Enter Example For English Word 2")
                Lexamples.Add(txtGExampleEWord2.Text);

            if (!_IstxtBoxEmpty(txtGEWord3) && _NumberOfSelectedItems >= 3 && txtGEWord3.Text != "Enter Example For English Word 3")
                Lexamples.Add(txtGEWord3.Text);

            if (!_IstxtBoxEmpty(txtGEWord4) && _NumberOfSelectedItems == 4 && txtGEWord4.Text != "Enter Example For English Word 4")
                Lexamples.Add(txtGEWord4.Text);

            return Lexamples.ToArray();

        }

        private string[] _GetExamplesTranslationsInputs()
        {
            List<string> LexamplesTranslations = new List<string>();

            if (!_IstxtBoxEmpty(GtxtExample1Transaltion) && _NumberOfSelectedItems >= 1 && GtxtExample1Transaltion.Text != "Enter Translation For Example 1")
                LexamplesTranslations.Add(GtxtExample1Transaltion.Text);

            if (!_IstxtBoxEmpty(GtxtExample2Translation) && _NumberOfSelectedItems >= 2 && GtxtExample2Translation.Text != "Enter Translation For Example 2")
                LexamplesTranslations.Add(GtxtExample2Translation.Text);

            if (!_IstxtBoxEmpty(GtxtExample3Translation) && _NumberOfSelectedItems >= 3 && GtxtExample3Translation.Text != "Enter Translation For Example 3")
                LexamplesTranslations.Add(GtxtExample3Translation.Text);

            if (!_IstxtBoxEmpty(GtxtExample4Translation) && _NumberOfSelectedItems == 4 && GtxtExample4Translation.Text != "Enter Translation For Example 4")
                LexamplesTranslations.Add(GtxtExample4Translation.Text);

            return LexamplesTranslations.ToArray();

        }
        private void txtBox_Enter(object sender, EventArgs e)
        {
            if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "A1") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text != "Enter Example For English Word 1")
                return;

            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "A2") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text != "Enter Example For English Word 2")
                return;

            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "A3") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text != "Enter Example For English Word 3")
                return;

            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "A4") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text != "Enter Example For English Word 4")
                return;

            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "E1") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text != "Enter Translation For Example 1")
                return;

            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "E2") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text != "Enter Translation For Example 2")
                return;

            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "E3") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text != "Enter Translation For Example 3")
                return;

            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "E4") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text != "Enter Translation For Example 4")
                return;
               
            
            ((Guna.UI2.WinForms.Guna2TextBox)sender).Clear();
            ((Guna.UI2.WinForms.Guna2TextBox)sender).ForeColor = Color.FromArgb(255, 30, 30, 30);
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "A1") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text == "")
            {
                ((Guna.UI2.WinForms.Guna2TextBox)sender).Text = "Enter Example For English Word 1";
                ((Guna.UI2.WinForms.Guna2TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }

            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "A2") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text == "")
            {
                ((Guna.UI2.WinForms.Guna2TextBox)sender).Text = "Enter Example For English Word 2";
                ((Guna.UI2.WinForms.Guna2TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "A3") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text == "")
            {
                ((Guna.UI2.WinForms.Guna2TextBox)sender).Text = "Enter Example For English Word 3";
                ((Guna.UI2.WinForms.Guna2TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "A4") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text == "")
            {
                ((Guna.UI2.WinForms.Guna2TextBox)sender).Text = "Enter Example For English Word 4";
                ((Guna.UI2.WinForms.Guna2TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
    
            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "E1") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text == "")
            {
                ((Guna.UI2.WinForms.Guna2TextBox)sender).Text = "Enter Translation For Example 1";
                ((Guna.UI2.WinForms.Guna2TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "E2") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text == "")
            {
                ((Guna.UI2.WinForms.Guna2TextBox)sender).Text = "Enter Translation For Example 2";
                ((Guna.UI2.WinForms.Guna2TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "E3") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text == "")
            {
                ((Guna.UI2.WinForms.Guna2TextBox)sender).Text = "Enter Translation For Example 3";
                ((Guna.UI2.WinForms.Guna2TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
            else if ((((Guna.UI2.WinForms.Guna2TextBox)sender).Tag.ToString() == "E4") && ((Guna.UI2.WinForms.Guna2TextBox)sender).Text == "")
            {
                ((Guna.UI2.WinForms.Guna2TextBox)sender).Text = "Enter Translation For Example 4";
                ((Guna.UI2.WinForms.Guna2TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
        }
        private void btnAddExmples_Click(object sender, EventArgs e)
        {

            string[] arrExamplesInputs = _GetExamplesInputs();
            string[] arrExamplesTranslations = _GetExamplesTranslationsInputs();
            if (arrExamplesInputs.Length < 1 || arrExamplesTranslations.Length < 1 || arrExamplesInputs.Length != _NumberOfSelectedItems || arrExamplesTranslations.Length!=_NumberOfSelectedItems)
                MessageBox.Show("Please enter Example/s by the number of your choosed words from 1 to 4 .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            if(!GchkSocialMediaView.Checked)
            {
                Form frmspeakwords = new frmSpeakWordsWithExample(this, MainForm, lstItems, arrExamplesInputs, arrExamplesTranslations);
                this.Hide();
                MainForm.Hide();
                frmspeakwords.Show();
            }
            else
            {
                Form frmProperView = new frmSpeakWordsProperViewForSocialM(this, MainForm, lstItems, arrExamplesInputs, arrExamplesTranslations);
                this.Hide();
                MainForm.Hide();
                frmProperView.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmExamplesInsertion_Load(object sender, EventArgs e)
        {
            for (short i = 0; i < _NumberOfSelectedItems; i++)
            {
                if (i == 0)
                {
                    await clsWord.Run(lstItems[i].Text, lstItems[i]);
                    txtGExampleEWord1.Text = clsWord.WordExample.ExampleInEnglish;
                    GtxtExample1Transaltion.Text = clsWord.WordExample.ExampleInArabic;
                }

                if (i == 1)
                {
                    await clsWord.Run(lstItems[i].Text, lstItems[i]);
                    txtGExampleEWord2.Text = clsWord.WordExample.ExampleInEnglish;
                    GtxtExample2Translation.Text = clsWord.WordExample.ExampleInArabic;
                }

                if (i == 2)
                {
                    await clsWord.Run(lstItems[i].Text, lstItems[i]);
                    txtGEWord3.Text = clsWord.WordExample.ExampleInEnglish;
                    GtxtExample3Translation.Text = clsWord.WordExample.ExampleInArabic;
                }
                if (i == 3)
                {
                    await clsWord.Run(lstItems[i].Text, lstItems[i]);
                    txtGEWord4.Text = clsWord.WordExample.ExampleInEnglish;
                    GtxtExample4Translation.Text = clsWord.WordExample.ExampleInArabic;
                }
            }
        }
    }
}
