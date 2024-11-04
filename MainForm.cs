using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Dyplomy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonTemplateSelection_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "DOCX Files|*.docx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelTemplate.Text = openFileDialog.FileName;
            }
        }

        private void buttonDataSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelDataSource.Text = openFileDialog.FileName;
            }
        }

        private void buttonCreateDyplomy_Click(object sender, EventArgs e)
        {
            List<string> uniqueNames = new List<string>();

            int dyplomyCount = 0;
            FileInfo info = new FileInfo(labelTemplate.Text);

            string directory = info.Directory + "\\" + info.Name.Replace(".docx", "");

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            FastZip fastZip = new FastZip();

            string[] nazwy = File.ReadAllLines(labelDataSource.Text);

            foreach (var line in nazwy)
            {
                if (line.Contains("nazwa"))
                    continue;

                string linia = line;
                if (line.Contains("\","))
                    linia = linia.Replace("\",", ";").Replace("\"", "");
                else
                    linia = linia.Replace(",", ";");

                string[] split = linia.Split(new char[] { ';' });
                if (split[0].Trim().Length == 0) continue;
                if (split.Length > 1 && split[1].Trim().Contains("-")) continue;

                string nazwa = split[0].Trim();
                if (checkBoxRemoveNonLetters.Checked)
                {
                    nazwa = Regex.Replace(nazwa, @"[0-9\-/]", string.Empty).Trim();
                }

                if (checkBoxUniqueNames.Checked && uniqueNames.Contains(nazwa)) continue;
                uniqueNames.Add(nazwa);

                string targetDir = directory + "\\" + nazwa + " " + info.Name + "___";
                fastZip.ExtractZip(labelTemplate.Text, targetDir, null);

                if (checkBoxAddPanPani.Checked)
                {
                    string[] nazwaSplit = nazwa.Split(new char[] { ' ' });
                    if (nazwaSplit[0].EndsWith("a"))
                        nazwa = "Pani " + nazwa;
                    else
                        nazwa = "Pan " + nazwa;
                }

                ReplaceTextInFolder(targetDir, "[nazwa]", nazwa);
                if (split.Length > 1)
                {
                    ReplaceTextInFolder(targetDir, "[miejsce]", split[1]);
                }

                fastZip.CreateZip(targetDir.Replace("___", ""), targetDir, true, null);

                dyplomyCount++;

                try
                {
                    Thread.Sleep(100);
                    Directory.Delete(targetDir, true);
                }
                catch (Exception)
                {
                }
            }

            MessageBox.Show(dyplomyCount + " dyplomy created");
        }

        private void ReplaceTextInFolder(string targetDir, string textToFind, string replaceWith)
        {
            string[] entries = Directory.GetFileSystemEntries(targetDir, "*.xml", SearchOption.AllDirectories);

            foreach (var file in entries)
            {
                string text = File.ReadAllText(file);

                if (text.Contains(textToFind))
                {
                    text = text.Replace(textToFind, replaceWith);
                    File.WriteAllText(file, text, Encoding.UTF8);
                }
            }
        }
    }
}
