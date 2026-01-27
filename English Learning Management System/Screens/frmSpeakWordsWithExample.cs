using System;
using System.Collections.Generic;
using System.Windows.Forms;
using English_Learning_Management_System.Lib;
namespace English_Learning_Management_System.Screens
{
    public partial class frmSpeakWordsWithExample : Form
    {

        clsSpeakWordsInView View;
        public frmSpeakWordsWithExample(frmExamplesInsertion frmE,frmMainScreen frm , List<ListViewItem> SelectedWords,string [] Examples,string[] ExamplesTranslations)
        {
            InitializeComponent();
            View=new clsSpeakWordsInView(this,frmE,frm,SelectedWords,Examples,ExamplesTranslations,GbtnEnglishWord,lblExample,lblTranslation,lblReady,lblTE,GbtnTranslation1,GbtnTranslation2,GbtnTranslation3,GbtnTranslation4,guna2GradientPanel1,guna2ProgressIndicator1,timer2);
        }

        private void frmSpeakWordsWithExample_Load(object sender, EventArgs e)
        {
            View.EnableTimer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            View.StartSession();
        }
    }
}
