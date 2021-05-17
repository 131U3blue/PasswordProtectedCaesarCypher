using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PasswordProtectedCypher
{
    public partial class CipherForm : Form
    {
        public CipherForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (rtbInputText.Text.Length > 0) {
                rtbOutputText.Text = CipherFunctions.EncryptText(rtbInputText.Text, trbEncryptionOffset.Value);
                rtbInputText.Clear();
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            try {
                File.WriteAllText(saveFileDialog1.FileName, rtbOutputText.Text);
                lstPreviousFiles.Items.Add(saveFileDialog1.FileName);
            }
            catch (ArgumentException) {
                MessageBox.Show("No file selected");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try {
                string fileString = File.ReadAllText(openFileDialog1.FileName);
                rtbOutputText.Text = fileString;
            }
            catch (FileNotFoundException ex) {
                MessageBox.Show(ex.Message);
            }
            
            rtbInputText.Clear();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            rtbInputText.Text = CipherFunctions.DecryptText(rtbOutputText.Text, trbEncryptionOffset.Value);
        }

        private void trbEncryptionOffset_Scroll(object sender, EventArgs e)
        {
            lblSliderValue.Text = trbEncryptionOffset.Value.ToString();
        }

        private void lstPreviousFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string fileString = File.ReadAllText(lstPreviousFiles.SelectedItem.ToString());
            rtbInputText.Clear();
            rtbOutputText.Text = fileString;
        }
    }
}
