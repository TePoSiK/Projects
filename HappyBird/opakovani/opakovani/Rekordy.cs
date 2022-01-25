using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.ListView;

namespace opakovani
{
    public partial class Rekordy : Form
    {

        private const string textFilePath = "Dokumenty/happybird/rekordy.txt";

        int score = 0;
        bool added = false;

        
        public Rekordy(Form1 main)
        {
            InitializeComponent();
            score = main.score;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!added)
            {
                if (nicknameBox.Text != "")
                {
                    ListViewItem item = new ListViewItem(nicknameBox.Text);
                    item.SubItems.Add(score.ToString());
                    listView1.Items.Add(item);
                    nicknameBox.Clear();
                    added = true;
                }
                else
                {
                    MessageBox.Show("Musíš zadat svůj nickname", "Není zadán nick", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Už jsi se jednou zapsal!", "Pozor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


