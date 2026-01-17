using English_Learning_Management_System.Screens;
using Lib;
using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Speech.Synthesis;
using System.Threading.Tasks;


namespace English_Learning_Management_System
{
    public partial class frmMainScreen : Form
    {
        Form frmLifeCycle;


        private MMDeviceEnumerator enumerator;
        private MMDevice device;
        public frmMainScreen(Form frm)
        {
            frmLifeCycle = frm;
            InitializeComponent();
        }

        private void frmMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLifeCycle.Close();
        }

        private void btnEnglishWordsList_Click(object sender, EventArgs e)
        {
            Form frmAddWords = new frmAddEnglishWords();
            frmAddWords.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List <string> AddArabicTranslations (string T1,string T2,string T3,string T4)
        {
            List <string>AT=new List<string>();

            if (T1 != "" && T1!=null)
                AT.Add(T1) ;
            if(T2!="" && T2 != null)
                AT.Add(T2);
            if (T3!="" && T3 != null)
                AT.Add(T3);
            if (T4!="" && T4 != null)
                AT.Add(T4);

            return AT;
        }
        private void AddWordsToListView(bool Refresh=false)
        {
            ListViewItem Item;

            List<string> lWords = clsWord.LoadEnglishWordsFromFile("EnglishWords.txt");
            List<clsWord.ArabicTranslation> lWordsTranslations = clsWord.LoadArabicTranslationsFromFile("ArabicTranslationWords.txt");
            int Counter = 0;

            if (Refresh)
                lstvWords.Items.Clear();

            if(lWords.Count > 0)
            while (lWords.Count!=Counter)
            {
                Item = new ListViewItem();
                Item.Text = lWords[Counter];
                Item.ForeColor = Color.FromArgb(255, 235, 235, 235);
                
                 List<string> lArabicTranslations= AddArabicTranslations(lWordsTranslations[Counter].Translation1, lWordsTranslations[Counter].Translation2, lWordsTranslations[Counter].Translation3, lWordsTranslations[Counter].Translation4);

                    for(short i =0;i< lArabicTranslations.Count(); i++)
                    {
                        Item.SubItems.Add(lArabicTranslations[i]);
                      Item.SubItems[i].ForeColor = Color.FromArgb(255, 235, 235, 235);
                      
                    }
                lstvWords.Items.Add(Item);

                Counter++;
            }
        }
        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            AddWordsToListView();
            enumerator = new MMDeviceEnumerator();

            device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            trackBar1.Value = (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWordsToListView(true);
        }

        public void RemovePreviouseCheckedItemForView(short ChoosedItemNumber)
        {
            if (detailsToolStripMenuItem.Checked && ChoosedItemNumber!=1)
                detailsToolStripMenuItem.Checked = false;

            if (listToolStripMenuItem.Checked && ChoosedItemNumber!=2)
                listToolStripMenuItem.Checked = false;

            if(largeIconToolStripMenuItem.Checked && ChoosedItemNumber!=3)
                largeIconToolStripMenuItem.Checked = false;

            if(smallIconToolStripMenuItem.Checked && ChoosedItemNumber!=4)
                smallIconToolStripMenuItem.Checked = false;

            if(tileToolStripMenuItem.Checked && ChoosedItemNumber!=5)
                tileToolStripMenuItem.Checked = false;

        }
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePreviouseCheckedItemForView(1);
            lstvWords.View = View.Details;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePreviouseCheckedItemForView(2);
            lstvWords.View = View.List;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePreviouseCheckedItemForView(3);
            lstvWords.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePreviouseCheckedItemForView(4);
            lstvWords.View = View.SmallIcon;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePreviouseCheckedItemForView(5);
            lstvWords.View = View.Tile;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            device.AudioEndpointVolume.MasterVolumeLevelScalar = (trackBar1.Value / 100.0f);
        }
        bool LEGACY = true;
        private void lstvWords_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            for (short i = 0; i < e.Item.SubItems.Count; i++)
            {
                if (LEGACY)
                 clsLib.SpellAWordLEGACY(e.Item.SubItems[i].Text);
                else
                 clsLib.SpellAWordMOD(e.Item.SubItems[i].Text);
            }
            //The Main Item-> the first item -> the first column is stored as SubItems[0]
            //Additional Columns start from SubItems[1] and so on.
        }
        
     
        private void UnCheckAllUnUsedOptions(short NumberOfUseedOption)
        {
            if(NumberOfUseedOption!=1)
                microsoftDavidDesktopToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 2)
                microsoftZiraDesktopToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 3)
                herenaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 4)
                hayleyToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 5)
                gBCHazelToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 6)
                herenaToolStripMenuItem1.Checked = false;

            if (NumberOfUseedOption != 7)
                iNHeeraToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 8)
                daDKvHelleToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 9)
                esHelenaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 10)
                esMXYHildaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 11)
                fiHeidiToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 12)
                frFRYHortenseToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 13)
                jaHarukaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 14)
                kokrKRreAMiToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 15)
                nbnoHuldaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 16)
                nbNOHuldaToolStripMenuItem1.Checked = false;

            if (NumberOfUseedOption != 17)
                rUElenaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 18)
                plPLPaulinaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 19)
                ptHeliaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 20)
                zhHKHKHunYeeToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 21)
                zhTvVHanHanToolStripMenuItem.Checked = false;

        }

        private List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();
        private void microsoftDavidDesktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(1);
                clsLib.ChangeSpellVoice("Microsoft David Desktop");
                LEGACY = true;
            
        }

        private void microsoftZiraDesktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(2);
            clsLib.ChangeSpellVoice("Microsoft Zira Desktop");
                LEGACY = true;
            
        }
        private void LisHelenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(3);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[0]);
        }
        private void hayleyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(4);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[1]);
        }
        

        private void gBCHazelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(5);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[2]);
        }
        
        private void herenaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(6);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[3]);
        }
        private void iNHeeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(7);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[4]);
        }
        private void daDKvHelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(8);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[5]);
        }
        
        private void esHelenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(9);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[6]);
        }
        
        private void esMXYHildaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(10);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[7]);
        }
        
        private void fiHeidiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(11);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[8]);
        }
        
        private void frFRYHortenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(12);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[9]);
        }
        
        private void jaHarukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(13);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[10]);
        }
        
        private void kokrKRreAMiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(14);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[11]);
        }
        
        private void nbnoHuldaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(15);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[12]);
        }
        
        private void nbNOHannaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(16);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[13]);
        }
        
        private void rUElenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(17);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[14]);
        }
        private void plPLPaulinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(18);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[15]);
        }
        private void ptHeliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(19);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[16]);
        }
        private void zhHKHKHunYeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(20);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[17]);
        }

        private void zhTvVHanHanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(21);
            LEGACY = false;
            clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[18]);
        }

        private List<ListViewItem> prepareSelectedItemsToMove(ListView.SelectedListViewItemCollection SelectedItems)
        {
            List<ListViewItem> Items = new List<ListViewItem>();
            for (short i = 0; i < SelectedItems.Count; i++)
            {
                Items.Add(SelectedItems[i]);
            }
            return Items;
        }

        private void GSpeakSelectedWords_Click(object sender, EventArgs e)
        {
            if(lstvWords.SelectedItems.Count >=1 && lstvWords.SelectedItems.Count <=4)
            {
                frmExamplesInsertion frmE=new frmExamplesInsertion(this,prepareSelectedItemsToMove(lstvWords.SelectedItems));
                frmE.ShowDialog();
                                
            }
            else
            {
                MessageBox.Show("Please Select Item/s From The List First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }
    }
}
