using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramEncapsulator
{
    public partial class Form1 : Form
    {
        string templateLoc = null;
        string origLoc = null;
        string outputLoc = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectTemplate_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "exe files (*.exe)|*.exe";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    templateLoc = fileDialog.FileName;
                    txtTemplateLoc.Text = templateLoc;
                }
            }
        }

        private void btnSelectOrig_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "exe files (*.exe)|*.exe";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    origLoc = fileDialog.FileName;
                    txtOrigLoc.Text = origLoc;
                }
            }
        }

        private void btnSelectOutput_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog fileDialog = new SaveFileDialog())
            {
                fileDialog.Filter = "exe files (*.exe)|*.exe";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputLoc = fileDialog.FileName;
                    txtOutputLoc.Text = outputLoc;
                }
            }
        }

        private bool CheckLoc(ref string loc, string locName)
        {
            if (loc == null)
            {
                MessageBox.Show($"Please select {locName} loc.", "Encapsulate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnEncapsulate_Click(object sender, EventArgs e)
        {
            if (!CheckLoc(ref templateLoc, "template") ||
                !CheckLoc(ref origLoc, "original program") ||
                !CheckLoc(ref outputLoc, "output program"))
            {
                return;
            }

            Encapsulator.Encapsulate(templateLoc, origLoc, outputLoc);
        }
    }
}
