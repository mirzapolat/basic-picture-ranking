using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace picture_ranker
{
    public partial class Form1 : Form
    {
        bool started = false;
        Dictionary<string, int> map = new Dictionary<string, int>();
        Random random = new Random();
        string path = "";

        string a = "";
        string b = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            int act = map[a];
            map[a] = act + 1;

            nextImages();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            int act = map[b];
            map[b] = act + 1;

            nextImages();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult res = dialog.ShowDialog();
            if (res != DialogResult.OK) return;
            path = dialog.SelectedPath + "/scores.txt";

            var enumLines = File.ReadLines(dialog.SelectedPath + "/scores.txt", Encoding.UTF8);

            foreach (var line in enumLines)
            {
                map.Add(line.Substring(line.Split(' ')[0].Length + 1), Int32.Parse(line.Split(' ')[0]));
            }

            nextImages();
        }

        private void nextImages()
        {
            a = map.ElementAt(random.Next(0, map.Count)).Key;
            do
            {
                b = map.ElementAt(random.Next(0, map.Count)).Key;
            } while (a == b);

            pb1.ImageLocation = a;
            pb2.ImageLocation = b;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter strm = File.CreateText(path);
            strm.Flush();
            foreach (var item in map.OrderByDescending(key => key.Value))
            {
                strm.WriteLine(item.Value.ToString() + " " + item.Key);
            }
            strm.Close();
        }

        private void initializeFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult res = dialog.ShowDialog();

            if (res != DialogResult.OK) return;

            string[] files = Directory.GetFiles(dialog.SelectedPath);

            StreamWriter sw = new StreamWriter(dialog.SelectedPath + "/scores.txt");
            foreach (string file in files)
            {
                sw.WriteLine("0 " + file);
            }
            sw.Close();
        }
    }
}
