using English_Learning_Management_System.Screens;
using Guna.UI2.WinForms;
using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_Learning_Management_System
{
    public partial class frmSpeakWordsProperViewForSocialM : Form
    {
        class clsWord
        {
            public List<ListViewItem> SelectedWords;
            public string[] Examples;
            public string[] ExamplesTranslations;
            public Form PrevioceForm;
            public Form ExamplesInsertion;
        }


        clsWord Word = new clsWord();
        public frmSpeakWordsProperViewForSocialM(frmExamplesInsertion frmE, frmMainScreen frm, List<ListViewItem> SelectedWords, string[] Examples, string[] ExamplesTranslations)
        {
            InitializeComponent();
            Word.SelectedWords = SelectedWords;

            Word.Examples = Examples;
            Word.ExamplesTranslations = ExamplesTranslations;

            Word.PrevioceForm = frm;
            Word.ExamplesInsertion = frmE;
        }
        private void Prepare(short RoundCounter)
        {
            if (Word.SelectedWords != null && Word.SelectedWords.Count > 0 && RoundCounter < Word.SelectedWords.Count)
            {
                GbtnEnglishWord.Text = Word.SelectedWords[RoundCounter].Text;
                lblExample.Text = Word.Examples[RoundCounter];
                lblTranslation.Text = Word.ExamplesTranslations[RoundCounter];
                for (short i = 1; i < Word.SelectedWords[RoundCounter].SubItems.Count; i++)
                {
                    if (i == 1)
                    {
                        GbtnTranslation1.Text = Word.SelectedWords[RoundCounter].SubItems[i].Text;
                        T1 = true;

                    }
                    if (i == 2)
                    {
                        GbtnTranslation2.Text = Word.SelectedWords[RoundCounter].SubItems[i].Text;
                        T2 = true;
                    }

                    if (i == 3)
                    {
                        GbtnTranslation3.Text = Word.SelectedWords[RoundCounter].SubItems[i].Text;
                        T3 = true;
                    }

                    if (i == 4)
                    {
                        GbtnTranslation4.Text = Word.SelectedWords[RoundCounter].SubItems[i].Text;
                        T4 = true;
                    }
                }
                if (SpeakEnglishWord)
                    PrepareEnglishButton();

            }
        }
        bool T1, T2, T3, T4;

        private void ChangeGunaButtonColor(Guna2GradientButton Btn, Color color1, Color Color2)
        {
            if (color1 != null)
                Btn.FillColor = color1;
            if (Color2 != null)
                Btn.FillColor2 = Color2;
        }
        private void _HideIntroControls()
        {
            lblReady.Visible = false;
            guna2ProgressIndicator1.Visible = false;
            guna2ProgressIndicator1.Stop();
            guna2GradientPanel1.Refresh();

        }

        private void ShowIntroControls()
        {
            HideIntro = true;
            lblReady.Visible = true;
            guna2ProgressIndicator1.Start();
            guna2ProgressIndicator1.Visible = true;
            guna2GradientPanel1.Refresh();
        }

        private void _HideTranslationsButtons()
        {
            GbtnTranslation1.Visible = false;
            GbtnTranslation2.Visible = false;
            GbtnTranslation3.Visible = false;
            GbtnTranslation4.Visible = false;
            guna2GradientPanel1.Refresh();

        }

        private void _ShowExample()
        {
            lblExample.Visible = true;
            lblTE.Visible = true;
            lblTranslation.Visible = true;
            guna2GradientPanel1.Refresh();
            clsLib.SpellAWordMOD("Example");
            Thread.Sleep(800);
            clsLib.SpellAWordMOD(lblExample.Text);
        }

        void _HideExample()
        {
            Thread.Sleep(4000);
            lblExample.Visible = false;
            lblTranslation.Visible = false;
            lblTE.Visible = false;
            guna2GradientPanel1.Refresh();
        }
        short RoundCounter;

        bool HideIntro = true;

        bool SpeakEnglishWord = true;
        private void PrepareEnglishButton()
        {
            GbtnEnglishWord.Visible = true;
            guna2GradientPanel1.Refresh();
            if (SpeakEnglishWord)
            {
                clsLib.SpellAWordMOD(GbtnEnglishWord.Text);
                SpeakEnglishWord = false;
            }
        }

        bool TrasnaltionsBtn1HasShowed = false;
        bool TrasnaltionsBtn2HasShowed = false;
        bool TrasnaltionsBtn3HasShowed = false;
        bool TrasnaltionsBtn4HasShowed = false;
        void _ShownTranslationsButtons(short WaitShowing)
        {
            timer2.Interval = 2000;
            if (T1 && WaitShowing == 1)
            {
                if (!TrasnaltionsBtn1HasShowed)
                {
                    GbtnTranslation1.Visible = true;
                    guna2GradientPanel1.Refresh();
                    clsLib.SpellAWordMOD(GbtnEnglishWord.Text);
                    TrasnaltionsBtn1HasShowed = true;
                }
            }
            if (T2 && WaitShowing == 2)
            {
                if (!TrasnaltionsBtn2HasShowed)
                {
                    GbtnTranslation2.Visible = true;
                    guna2GradientPanel1.Refresh();
                    clsLib.SpellAWordMOD(GbtnEnglishWord.Text);
                    TrasnaltionsBtn2HasShowed = true;
                }
            }

            if (T3 && WaitShowing == 3)
            {
                if (!TrasnaltionsBtn3HasShowed)
                {
                    GbtnTranslation3.Visible = true;
                    guna2GradientPanel1.Refresh();
                    clsLib.SpellAWordMOD(GbtnEnglishWord.Text);
                    TrasnaltionsBtn3HasShowed = true;
                }
            }
            if (T4 && WaitShowing == 4)
            {
                if (!TrasnaltionsBtn4HasShowed)
                {
                    //ChangeGunaButtonColor(GbtnTranslation4, GbtnTranslation1.FillColor, Color.DarkSeaGreen);64, 0, 0
                    GbtnTranslation4.Visible = true;
                    guna2GradientPanel1.Refresh();
                    clsLib.SpellAWordMOD(GbtnEnglishWord.Text);
                    TrasnaltionsBtn4HasShowed = true;
                }
            }

        }

        void _ResetSettingsToRepeat(bool FullReset)
        {
            if (FullReset)
            {
                RoundCounter = 0;
                SpeakEnglishWord = true;
                T1 = false;
                T2 = false;
                T3 = false;
                T4 = false;
                TrasnaltionsBtn1HasShowed = false;
                TrasnaltionsBtn2HasShowed = false;
                TrasnaltionsBtn3HasShowed = false;
                TrasnaltionsBtn4HasShowed = false;
                _HideExample();
                GbtnEnglishWord.Visible = false;
                guna2GradientPanel1.Refresh();
                WaitShTranslationsBtns = -1;
                AllowExampleshawn = true;
                ShowIntroControls();
                timer2.Interval = 4000;
                timer2.Start();
            }
            else
            {
                timer2.Interval = 4000;
                SpeakEnglishWord = true;
                T1 = false;
                T2 = false;
                T3 = false;
                T4 = false;
                TrasnaltionsBtn1HasShowed = false;
                TrasnaltionsBtn2HasShowed = false;
                TrasnaltionsBtn3HasShowed = false;
                TrasnaltionsBtn4HasShowed = false;
                WaitShTranslationsBtns = -1;
                AllowExampleshawn = true;
                Thread.Sleep(4000);
                _HideExample();
            }
        }

        void _MoveToNextRound()
        {
            if (RoundCounter == Word.SelectedWords.Count)
            {
                timer2.Stop();
                Thread.Sleep(8000);
                if (MessageBox.Show("Lesson Has Ended , Do You Want To Repeat Lesson", "End Of Lesson", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _ResetSettingsToRepeat(true);
                    return;
                }
                else
                {
                    Word.PrevioceForm.Opacity = 0.0;
                    Word.PrevioceForm.Show();
                    this.Close();
                    Word.ExamplesInsertion.Close();
                    Word.PrevioceForm.Opacity = 100.0;
                    return;
                }
            }
            _ResetSettingsToRepeat(false);
        }


        short WaitShTranslationsBtns = -1;

  
        private void frmSpeakWordsProperViewForSocialM_Load(object sender, EventArgs e)
        {
            timer2.Enabled=true;
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            StartSession();

        }

        bool AllowExampleshawn = true;
        bool IsAllTranslationsHasShawn()
        {
            if (T1 && T2 && T3 && T4)
                return WaitShTranslationsBtns == 4;

            else if (T1 && T2 && T3)
                return WaitShTranslationsBtns == 3;

            else if (T1 && T2)
                return WaitShTranslationsBtns == 2;

            else if (T1)
                return WaitShTranslationsBtns == 1;

            return false;
        }

        void StartSession()
        {
            if (HideIntro)
            {
                _HideIntroControls();
                guna2GradientPanel1.Refresh();
                HideIntro = false;
            }

            if (RoundCounter != Word.SelectedWords.Count)
            {
                Prepare(RoundCounter);
            }

            if (!IsAllTranslationsHasShawn())
            {
                WaitShTranslationsBtns++;
                _ShownTranslationsButtons(WaitShTranslationsBtns);
            }
            else
            {
                if (AllowExampleshawn)
                {
                    timer2.Interval = 4000;
                    Thread.Sleep(2000);
                    _HideTranslationsButtons();
                    _ShowExample();
                    AllowExampleshawn = false;
                }
                else
                {
                    RoundCounter++;
                    _MoveToNextRound();
                    timer2.Interval = 2000;
                }
            }



        }

    }
}
