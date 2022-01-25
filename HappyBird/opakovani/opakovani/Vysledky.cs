using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace opakovani
{
    public partial class Vysledky : Form
    {
        private const string textFilePath = @"C:\Users\palekto\Documents\score.txt";

        bool gameStarted = false;
        bool zapsano = false;

        int score;

        

        public Vysledky(Form1 main)
        {
            InitializeComponent();
            score = main.score;
            gameStarted = main.gameOver;
        }

        private void Vysledky_Load(object sender, EventArgs e)
        {
            if (File.Exists(textFilePath))
            {
                string[] readText = File.ReadAllLines(textFilePath);
                foreach (string s in readText)
                {
                    ListViewItem readItem = new ListViewItem(s);
                    listView1.Items.Add(readItem);
                }
            }
            if (gameStarted && !zapsano)
            {
                ListViewItem item = new ListViewItem(score.ToString());
                listView1.Items.Add(item);
                zapsano = true;
            }
        }

        private void Vysledky_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!File.Exists(textFilePath))
            {
                if (gameStarted)
                {
                    string[] createText = { score.ToString() };
                    File.WriteAllLines(textFilePath, createText);
                }
                if (!gameStarted)
                {
                    string[] createText = { score.ToString() };
                    File.WriteAllLines(textFilePath, createText);
                }
            }
            else
            {
                if (gameStarted)
                {
                    string appendText = score.ToString() + Environment.NewLine;
                    File.AppendAllText(textFilePath, appendText);
                    zapsano = true;
                }
            }
        }
    }
}
