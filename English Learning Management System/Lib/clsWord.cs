using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lib
{
    internal class clsWord
    {
        internal static bool SaveEnglishWordsToFile(string EnglishWord,string FileName, bool Append)
        {
            //if (EnglishWord == "")
            //{
            //    MessageBox.Show("You did'nt enter data", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}

            //else
            //{

            //    if (Append)
            //    {
            //        //using (StreamWriter MyFile = new StreamWriter("Daily Tasks File.txt", true))
            //        //{
            //        //    MyFile.WriteLine(txtTask.Text + "#//#" + txtDeadLine.Text);
            //        //    //MyFile.Dispose();//No need to it because using will automatically calls it and even if an exception happens the using will close the file.
            //        //}

            //        //File.AppendAllText("Daily Tasks File.txt", txtTask.Text + "#//#" + txtDeadLine.Text);
            //        //the previous line closes the file automatically and creates the file if it is not exists and append to the file if it is exists , so it is a shortcut for :
            //        //using (StreamWriter MyFile = new StreamWriter("Daily Tasks File.txt", true))
            //        //{
            //        //    MyFile.WriteLine(txtTask.Text + "#//#" + txtDeadLine.Text);
            //        //    //MyFile.Dispose();//No need to it because using will automatically calls it and even if an exception happens the using will close the file.
            //        //}

            //        //File.AppendAllText("Daily Tasks.txt", txtTask.Text + "#//#" + txtDeadLine.Text + Environment.NewLine()    );//Automatically closes the file and creates it if it is not exists
            //        if (!EnglishWord.Contains(","))
            //            File.AppendAllText(FileName, EnglishWord + "\r\n");//Automatically closes the file and creates it if it is not exists
            //        else
            //        {
            //            using (StreamWriter MyFile = new StreamWriter(FileName, true))
            //            {
            //                while (EnglishWord.Contains(","))
            //                {
            //                    int IndexOfComma = EnglishWord.IndexOf(",");
            //                    string subword = EnglishWord.Substring(0, IndexOfComma);
            //                    EnglishWord=EnglishWord.Remove(0, IndexOfComma + 1);
            //                    MyFile.WriteLine(subword);
            //                }
            //                MyFile.WriteLine(   EnglishWord);
            //                //MyFile.Dispose();//No need to it because using will automatically calls it and even if an exception happens the using will close the file.
            //            }
            //        }
            //    }
            //    //else
            //    //{
            //    //    File.Delete(FileName);
            //    //}
            //    return true;
            //}
            return SaveArabicTranslationsToFile(EnglishWord, FileName, Append,false);
        }

        private static bool _SaveMoreTranslations(string T1,string T2,string T3,string T4,string FileName,bool WithSeparator=true)
        {

            if (T1 != "" && T1 != "Enter Arabic Translation/s")
            {
                using (StreamWriter MyFile = new StreamWriter(FileName, true))
                {
                    if (WithSeparator)
                        MyFile.Write("\r\n" + "#//#" + "\r\n" + T1);
                    else
                        MyFile.Write(T1 + "\r\n");//For English Word

                    if (T2 != "" && T2 != null && T2 != "Enter Arabic Translation 2")
                        MyFile.Write("," + T2);

                    if (T3 != "" && T3 != null && T3 != "Enter Arabic Translation 3")
                        MyFile.Write("," + T3);

                    if (T4 != "" && T4 != null && T4 != "Enter Arabic Translation 4")
                        MyFile.Write("," + T4);

                    return true;
                }
            }
            return false;

        }

        internal static bool SaveArabicTranslationsToFile(string Translation1, string FileName, bool Append, bool WithSeparator = true, string Translation2 = null, string Translation3 = null, string Translation4 = null)
        {
            if (Translation1 == "")
            {
                MessageBox.Show("You did'nt enter data", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

                return _SaveMoreTranslations(Translation1, Translation2, Translation3, Translation4, FileName,WithSeparator);
                        
        }
            
        internal struct ArabicTranslation
        {
            public string Translation1;
            public string Translation2;
            public string Translation3;
            public string Translation4;
        }

        internal static List<ArabicTranslation> LoadArabicTranslationsFromFile(string FileName)
        {
            List<string> lWords = new List<string>();
            List<ArabicTranslation> lArabicTranslations = new List<ArabicTranslation>();

            
            if (File.Exists(FileName))
                using (StreamReader MyFile = new StreamReader(FileName))
                {
                    string Line;
                    ArabicTranslation AT;
                    while ((Line = MyFile.ReadLine()) != null)
                    {

                         if (Line!="#//#" && Line!="")
                            {
                            AT=new ArabicTranslation();
                            lWords = Line.Split(new Char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Where(s => !String.IsNullOrEmpty(s)).ToList();
                            for(short i=0;i<lWords.Count;i++)
                            {
                                if (i == 0)
                                    AT.Translation1 = lWords[i];
                                else if (i == 1)
                                    AT.Translation2 = lWords[i];
                                else if (i == 2)
                                    AT.Translation3 = lWords[i];
                                else if (i == 3)
                                    AT.Translation4 = lWords[i];
                            }
                            lArabicTranslations.Add(AT);
                            lWords.Clear();
                        }

                    }

                }

            //Second Way:
            //string[] arrTasks = File.ReadAllLines(FileName);//Automatically closes file after open it
            //lTasks.AddRange(arrTasks);

            return lArabicTranslations;
        }

        internal static List<string> LoadEnglishWordsFromFile(string FileName)
        {
            List<string> lWords = new List<string>();
                        
            if (File.Exists(FileName))
                using (StreamReader MyFile = new StreamReader(FileName))
                {
                    string Line;
              
                    while ((Line = MyFile.ReadLine()) != null)
                    {
                        if(Line!="")
                        lWords.Add(Line.Trim());                        
                    }

                }

            //Second Way:
            //string[] arrTasks = File.ReadAllLines(FileName);//Automatically closes file after open it
            //lTasks.AddRange(arrTasks);

            return lWords;
        }
    }
}
