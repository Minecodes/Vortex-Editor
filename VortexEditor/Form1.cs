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

namespace VortexEditor
{
    public partial class Form1 : Form
    {
        protected bool boChanged = false;

        public String filename = "File";
        public String fileindex = "";
        public bool saved = false;

        public Form1()
        {
            InitializeComponent();
            this.text.TextChanged += Text_TextChanged;
            this.FormClosing += Form1_FormClosing;
            this.Load += Form1_Load;
            clearChanged();
        }

        protected void clearChanged()
        {
            boChanged = false;
            this.Text = Properties.Resources.Title + filename;
        }

        protected void setChanged()
        {
            boChanged = true;
            this.Text = Properties.Resources.Title_changed + filename + Properties.Resources.Title_changed_suffix;
        }

        private void newText_Click(object sender, EventArgs e)
        {
            if (!boChanged)
            {
                text.Clear();
            }
            else
            {
                DialogResult saving = MessageBox.Show("Do you want to save the changes?", "Vortex Editor", MessageBoxButtons.YesNoCancel);
                if (saving == DialogResult.Yes)
                {
                    saveText_Click(null, null);
                    if (saved)
                    {
                        text.Clear();
                    }
                }
                else if (saving == DialogResult.No)
                {
                    text.Clear();
                }
                else if (saving == DialogResult.Cancel)
                {
                    text.Clear();
                }
            }
        }

        private void openText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Vortex Editor - Open File";
            openfile.Filter = "Text files (*.txt)|*.txt|Markdown document (*.md)|*.md|JSON Config (*.json)|*.json|YAML Config (*.yml)|*.yml|All files (*.*)|*";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                text.Clear();
                text.Text = File.ReadAllText(openfile.FileName);
                fileindex = File.ReadAllText(openfile.FileName);
                filename = openfile.FileName;
                clearChanged();
            }
        }
        private void saveText_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Text files (*.txt)|*.txt|Markdown document (*.md)|*.md|JSON Config (*.json)|*.json|YAML Config (*.yml)|*.yml|All files (*.*)|*";
            savefile.FileName = "*.txt";
            savefile.Title = "Vortex Editor - Save File";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(savefile.FileName, text.Text);
                clearChanged();
                saved = true;
            }
            else
            {
                saved = false;
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoText_Click(object sender, EventArgs e)
        {
            text.Undo();
        }

        private void redoText_Click(object sender, EventArgs e)
        {
            text.Redo();
        }

        private void cutText_Click(object sender, EventArgs e)
        {
            text.Cut();
        }

        private void copyText_Click(object sender, EventArgs e)
        {
            text.Copy();
        }

        private void pasteText_Click(object sender, EventArgs e)
        {
            text.Paste();
        }

        private void selectAllText_Click(object sender, EventArgs e)
        {
            text.SelectAll();
        }

        private void info_Click(object sender, EventArgs e)
        {
            Info infoWindow = new Info();
            infoWindow.Show();
        }

        private void youtubeLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "explorer.exe";
            startInfo.Arguments = "https://youtube.com/c/Minecodes";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void githubLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "explorer.exe";
            startInfo.Arguments = "https://github.com/Minecodes";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void gitlabLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "explorer.exe";
            startInfo.Arguments = "https://gitlab.com/Minecodes13";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void newTextTools_Click(object sender, EventArgs e)
        {
            newText.PerformClick();
        }

        private void openTextTools_Click(object sender, EventArgs e)
        {
            openText.PerformClick();
        }

        private void saveTextTools_Click(object sender, EventArgs e)
        {
            saveText.PerformClick();
        }

        private void cutTextTools_Click(object sender, EventArgs e)
        {
            cutText.PerformClick();
        }

        private void copyTextTools_Click(object sender, EventArgs e)
        {
            copyText.PerformClick();
        }

        private void pasteTextTools_Click(object sender, EventArgs e)
        {
            pasteText.PerformClick();
        }

        private void Text_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(text.Text) || text.Text == fileindex)
            {
                clearChanged();
            }
            else
            {
                setChanged();
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            clearChanged();
        }

        private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (boChanged)
            {
                DialogResult saving = MessageBox.Show("Do you want to save the changes?", "Vortex Editor", MessageBoxButtons.YesNoCancel);
                if (saving == DialogResult.Yes)
                {
                    saveText_Click(null, null);
                    e.Cancel = true;
                } else if (saving == DialogResult.No)
                {
                    e.Cancel = false;
                } else if (saving == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
       }
    }
}
