using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramExtractor
{
    public partial class Form1 : Form
    {
        string extractLoc = null;
        Extractor extractor = null;

        public Form1()
        {
            InitializeComponent();
            try
            {
                extractor = new Extractor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Program Startup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();  // FIXME: seems not working
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog fileDialog = new SaveFileDialog())
            {
                fileDialog.Filter = "exe files (*.exe)|*.exe";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;
                fileDialog.FileName = extractor.GetProgName();

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    extractLoc = fileDialog.FileName;
                    txtExtractLoc.Text = extractLoc;
                }
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (extractLoc == null)
            {
                MessageBox.Show("Please select extract location first.", "Extract Program", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                extractor.Extract(extractLoc);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Extract Program", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
