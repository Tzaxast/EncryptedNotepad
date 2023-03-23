
namespace Encrypted_Notepad
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dlg_saveFile = new System.Windows.Forms.SaveFileDialog();
            this.dlg_openFile = new System.Windows.Forms.OpenFileDialog();
            this.mnu_File_Strip = new System.Windows.Forms.MenuStrip();
            this.mnu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDecryptAndOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAndEncrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CutText = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSelectAllText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ctx_mnu_Strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainTextBox = new Encrypted_Notepad.EncryptedTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_newFileToolstrip = new System.Windows.Forms.ToolStripButton();
            this.btn_openFileToolStrip = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mnu_File_Strip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlg_saveFile
            // 
            this.dlg_saveFile.DefaultExt = "enc";
            this.dlg_saveFile.Filter = "EncryptedTextFiles|*.enc";
            this.dlg_saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlg_saveFile_FileOk);
            // 
            // mnu_File_Strip
            // 
            this.mnu_File_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_File,
            this.mnu_Edit,
            this.mnu_Help});
            this.mnu_File_Strip.Location = new System.Drawing.Point(0, 0);
            this.mnu_File_Strip.Name = "mnu_File_Strip";
            this.mnu_File_Strip.Size = new System.Drawing.Size(690, 24);
            this.mnu_File_Strip.TabIndex = 1;
            this.mnu_File_Strip.Text = "menuStrip1";
            // 
            // mnu_File
            // 
            this.mnu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewFile,
            this.mnuDecryptAndOpen,
            this.mnuSaveAndEncrypt,
            this.mnuExitApplication});
            this.mnu_File.Name = "mnu_File";
            this.mnu_File.Size = new System.Drawing.Size(37, 20);
            this.mnu_File.Text = "&File";
            // 
            // mnuNewFile
            // 
            this.mnuNewFile.Name = "mnuNewFile";
            this.mnuNewFile.Size = new System.Drawing.Size(180, 22);
            this.mnuNewFile.Text = "&New Encrypted File";
            this.mnuNewFile.Click += new System.EventHandler(this.mnuNewFile_Click);
            // 
            // mnuDecryptAndOpen
            // 
            this.mnuDecryptAndOpen.Name = "mnuDecryptAndOpen";
            this.mnuDecryptAndOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuDecryptAndOpen.Text = "Decrypt and &Open...";
            // 
            // mnuSaveAndEncrypt
            // 
            this.mnuSaveAndEncrypt.Name = "mnuSaveAndEncrypt";
            this.mnuSaveAndEncrypt.Size = new System.Drawing.Size(180, 22);
            this.mnuSaveAndEncrypt.Text = "&Save and Encrypt...";
            this.mnuSaveAndEncrypt.ToolTipText = "Save and Encrypt Text to file";
            this.mnuSaveAndEncrypt.Click += new System.EventHandler(this.mnuSaveAndEncrypt_Click);
            // 
            // mnuExitApplication
            // 
            this.mnuExitApplication.Name = "mnuExitApplication";
            this.mnuExitApplication.Size = new System.Drawing.Size(180, 22);
            this.mnuExitApplication.Text = "E&xit";
            // 
            // mnu_Edit
            // 
            this.mnu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripSeparator4,
            this.CutText,
            this.cToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.mnuSelectAllText,
            this.toolStripSeparator2,
            this.toolStripMenuItem1});
            this.mnu_Edit.Name = "mnu_Edit";
            this.mnu_Edit.Size = new System.Drawing.Size(39, 20);
            this.mnu_Edit.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Z";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(189, 6);
            // 
            // CutText
            // 
            this.CutText.Name = "CutText";
            this.CutText.ShortcutKeyDisplayString = "Ctrl + X";
            this.CutText.Size = new System.Drawing.Size(192, 22);
            this.CutText.Text = "Cu&t";
            this.CutText.Click += new System.EventHandler(this.CutText_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + C";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.cToolStripMenuItem.Text = "&Copy";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + V";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // mnuSelectAllText
            // 
            this.mnuSelectAllText.Name = "mnuSelectAllText";
            this.mnuSelectAllText.ShortcutKeyDisplayString = "Ctrl + A";
            this.mnuSelectAllText.Size = new System.Drawing.Size(192, 22);
            this.mnuSelectAllText.Text = "Select &All";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem1.Text = "Set Key For Encryption";
            // 
            // mnu_Help
            // 
            this.mnu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.mnuAbout});
            this.mnu_Help.Name = "mnu_Help";
            this.mnu_Help.Size = new System.Drawing.Size(44, 20);
            this.mnu_Help.Text = "&Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuAbout.Text = "&About";
            // 
            // ctx_mnu_Strip
            // 
            this.ctx_mnu_Strip.Name = "contextMenuStrip1";
            this.ctx_mnu_Strip.Size = new System.Drawing.Size(61, 4);
            // 
            // mainTextBox
            // 
            this.mainTextBox.AcceptsReturn = true;
            this.mainTextBox.AcceptsTab = true;
            this.mainTextBox.ContextMenuStrip = this.ctx_mnu_Strip;
            this.mainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mainTextBox.Location = new System.Drawing.Point(0, 24);
            this.mainTextBox.MaxLength = 64767;
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainTextBox.Size = new System.Drawing.Size(690, 588);
            this.mainTextBox.TabIndex = 2;
            this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBox_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_newFileToolstrip,
            this.btn_openFileToolStrip,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator3,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(690, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "mnu_main_toolStrip";
            // 
            // btn_newFileToolstrip
            // 
            this.btn_newFileToolstrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_newFileToolstrip.Image = ((System.Drawing.Image)(resources.GetObject("btn_newFileToolstrip.Image")));
            this.btn_newFileToolstrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_newFileToolstrip.Name = "btn_newFileToolstrip";
            this.btn_newFileToolstrip.Size = new System.Drawing.Size(23, 22);
            this.btn_newFileToolstrip.Text = "&New";
            this.btn_newFileToolstrip.ToolTipText = "Create new Encrypted Text File";
            // 
            // btn_openFileToolStrip
            // 
            this.btn_openFileToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_openFileToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btn_openFileToolStrip.Image")));
            this.btn_openFileToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_openFileToolStrip.Name = "btn_openFileToolStrip";
            this.btn_openFileToolStrip.Size = new System.Drawing.Size(23, 22);
            this.btn_openFileToolStrip.Text = "&Open";
            this.btn_openFileToolStrip.ToolTipText = "Open an encrypted text file";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 624);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.mnu_File_Strip);
            this.MainMenuStrip = this.mnu_File_Strip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Encrypted Notepad";
            this.mnu_File_Strip.ResumeLayout(false);
            this.mnu_File_Strip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog dlg_saveFile;
        private System.Windows.Forms.OpenFileDialog dlg_openFile;
        private System.Windows.Forms.MenuStrip mnu_File_Strip;
        private Encrypted_Notepad.EncryptedTextBox mainTextBox;
        private System.Windows.Forms.ContextMenuStrip ctx_mnu_Strip;
        private System.Windows.Forms.ToolStripMenuItem mnu_File;
        private System.Windows.Forms.ToolStripMenuItem mnuNewFile;
        private System.Windows.Forms.ToolStripMenuItem mnuDecryptAndOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAndEncrypt;
        private System.Windows.Forms.ToolStripMenuItem mnuExitApplication;
        private System.Windows.Forms.ToolStripMenuItem mnu_Edit;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectAllText;
        private System.Windows.Forms.ToolStripMenuItem mnu_Help;
        private System.Windows.Forms.ToolStripMenuItem CutText;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_newFileToolstrip;
        private System.Windows.Forms.ToolStripButton btn_openFileToolStrip;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
    }
}

