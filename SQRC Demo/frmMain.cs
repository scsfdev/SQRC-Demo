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

namespace SQRC_Demo
{
    public partial class frmMain : Form
    {
        string title = "SQRC Demo";

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPub.Text = txtPri.Text = txtExport.Text = "";

            btnPub.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnPub.Focus();
        }

        private void btnPub_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Browse Public data text file...";
            ofd.Filter = "Text file (*.txt)|*.txt";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName))
                return;


            if(string.IsNullOrEmpty(File.ReadAllText(ofd.FileName)))
                MessageBox.Show("Public data file is empty!", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                txtPub.Text = ofd.FileName;
        }

        private void btnPri_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Browse Private data text file...";
            ofd.Filter = "Text file (*.txt)|*.txt";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName))
                return;

            if (string.IsNullOrEmpty(File.ReadAllText(ofd.FileName)))
                MessageBox.Show("Private data file is empty!", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                txtPri.Text = ofd.FileName;
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Export SQRC image file to...";
            sfd.Filter = "Image file (*.png)|*.png";
            sfd.ShowDialog();

            if (string.IsNullOrEmpty(sfd.FileName))
                return;

            txtExport.Text = sfd.FileName;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtPub.Text) && File.Exists(txtPri.Text) && !string.IsNullOrEmpty(txtExport.Text))
            {
                // Generate SQRC.
                sqrcOcx.CellUnit = -1;


                sqrcOcx.SQRCenable = SQRCmakerLib.enumOnOff.On;
                sqrcOcx.SQRCkey = "0123456789ABCDEF";
                sqrcOcx.InputData = File.ReadAllText(txtPub.Text);
                sqrcOcx.SQRCdata = File.ReadAllText(txtPri.Text);

                picSqrc.Image = sqrcOcx.Picture;

                try
                {
                    if (File.Exists(txtExport.Text))
                        File.Delete(txtExport.Text);

                    short nCell = sqrcOcx.CreateQrMetaFile(this.Handle.ToInt32(), txtExport.Text, 3);
                    if (nCell == 0)
                        CheckError();
                    else
                    {
                        MessageBox.Show("Successfully generated SQRC image file to selected location.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear.PerformClick();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No SQRC image file is generated, removing of existing file failed.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Please make sure Public and Private data files are not empty and choose the location to export SQRC image file!", title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void CheckError()
        {
            switch (sqrcOcx.MakeStatus)
            {
                case -1:
                    MessageBox.Show("Too many characters defined!", title,MessageBoxButtons.OK,MessageBoxIcon.Error); break;
                case -2:
                    MessageBox.Show("Too much switching between character modes", title, MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case -3:
                    MessageBox.Show("Invalid code splitter specification", title, MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case -4:
                    MessageBox.Show("Invalid code model number", title, MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case -5:
                    MessageBox.Show("File creation error", title, MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case -6:
                    MessageBox.Show("QRversion specification error", title, MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case -7:
                    MessageBox.Show("Invalid file format specification", title, MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case -8:
                    MessageBox.Show("Miscellaneous parameter setting errors", title, MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }
    }
}
