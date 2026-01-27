using English_Learning_Management_System.Lib;
using English_Learning_Management_System.Screens;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace English_Learning_Management_System
{
    public partial class frmSpeakWordsProperViewForSocialM : Form
    {

        clsSpeakWordsInView View;
        public frmSpeakWordsProperViewForSocialM(frmExamplesInsertion frmE, frmMainScreen frm, List<ListViewItem> SelectedWords, string[] Examples, string[] ExamplesTranslations)
        {
            InitializeComponent();
            View = new clsSpeakWordsInView(this, frmE, frm, SelectedWords, Examples, ExamplesTranslations, GbtnEnglishWord, lblExample, lblTranslation, lblReady, lblTE, GbtnTranslation1, GbtnTranslation2, GbtnTranslation3, GbtnTranslation4, guna2GradientPanel1, guna2ProgressIndicator1, timer2);

        }
        private void frmSpeakWordsProperViewForSocialM_Load(object sender, EventArgs e)
        {
            View.EnableTimer();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            View.StartSession();

        }

    }
    }

