using Crypto;
using System;
using System.Windows.Forms;

namespace Encrypted_Notepad
{
    public partial class MainForm : Form
    {
        string SavedText = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuNewFile_Click(object sender, EventArgs e)
        {
            mainTextBox.ResetText();
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            SavedText = mainTextBox.Text;
        }

        private void CutText_Click(object sender, EventArgs e)
        {
            if (mainTextBox.SelectedText != "")
            {
                mainTextBox.Cut();
            }
        }

        private void mnuSaveAndEncrypt_Click(object sender, EventArgs e)
        {
            dlg_saveFile.ShowDialog();
        }

        private void btn_encrypt_test_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = DataEncryption.EncryptText(SavedText);
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = DataEncryption.DecryptText(SavedText);
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextBox.SelectionLength > 0)
            {
                mainTextBox.Copy();
            }
        }

        private void txt_enc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                mainTextBox.Paste();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextBox.CanUndo == true)
            {
                mainTextBox.Undo();
            }
        }

        private void dlg_saveFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (e.Cancel == true ) { return; }
            DataEncryption.SaveEncryptedTextToFile(dlg_saveFile.OpenFile(),DataEncryption.EncryptText(SavedText));
        }
    }
}
