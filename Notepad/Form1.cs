using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "open  document";
            open.Filter = " text document(*.txt)|*.txt|All Files(.)| . ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save  document";
            save.Filter = " text document(*.txt)|*.txt|All Files(.)| . ";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.Font = richTextBox1.SelectionFont;
            if (f.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = f.Font;

            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.Color = richTextBox1.SelectionColor;
            if (c.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = c.Color;

            }

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save  document";
            save.Filter = " text document(*.txt)|*.txt|All Files(.)| . ";
            if (save.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "open  document";
            open.Filter = " text document(*.txt)|*.txt|All Files(.)| . ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }
    }
}
