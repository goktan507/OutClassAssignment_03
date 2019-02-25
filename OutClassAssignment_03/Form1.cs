using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutClassAssignment_03
{
    public partial class btn_selectfile : Form
    {
        public static System.IO.StreamWriter sw;
        public btn_selectfile()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw = System.IO.File.CreateText(" TextFile.txt ");
            if ( this.openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                String allText = sr.ReadToEnd();
                //this.txt_file.Text = allText;

                string[] words = allText.Split();
                string[] letters = allText.Split();
                string longestWord = "";
                string firstAlpha = "";
                string lastAlpha = "";
                string mostvowels = "";
                int mostvowelsnum =  0;
                int curvowelsnum = 0;

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].ToLower();

                    // is this the first word?
                    if (i == 0)
                    {
                        longestWord = words[i];
                        firstAlpha = words[i];
                        lastAlpha = words[i];
                        mostvowels = words[i];
                    }

                    if (longestWord.Length < words[i].Length)
                    {
                        longestWord = words[i];
                    }

                    if ( words[i].CompareTo(firstAlpha) < 0)
                    {
                        firstAlpha = words[i];
                    }

                    if ( words[i].CompareTo(lastAlpha) > 0)
                    {
                        lastAlpha = words[i];
                    }

                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (words[i][j] == 'a' ||
                            words[i][j] == 'e' ||
                            words[i][j] == 'i' ||
                            words[i][j] == 'o' ||
                            words[i][j] == 'u')
                        {
                            curvowelsnum++;
                           
                        }

                    }

                    if (curvowelsnum > mostvowelsnum)
                    {
                        mostvowelsnum = curvowelsnum;
                        mostvowels = words[i];

                    }
                    curvowelsnum = 0; 


                    this.txt_file.Text += words[i] + "\n";
                    sw.Write(words[i] + " ");

                }
                //txt_file.Text = "Longest word is : " + longestWord + "\n" + "First word as alphabetically is : " + firstAlpha + "\n" + "Last word as alphabetically is :" + lastAlpha;
                box_longest.Text = longestWord;
                box_firstalpha.Text = firstAlpha;
                box_lastalpha.Text = lastAlpha;
                box_mostvowel.Text = mostvowels;
                sw.Close();
            }
        }
    }
}
