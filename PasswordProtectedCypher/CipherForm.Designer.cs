
namespace PasswordProtectedCypher
{
    partial class CipherForm
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
            this.rtbInputText = new System.Windows.Forms.RichTextBox();
            this.rtbOutputText = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.trbEncryptionOffset = new System.Windows.Forms.TrackBar();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblPreviousFiles = new System.Windows.Forms.Label();
            this.lblInputText = new System.Windows.Forms.Label();
            this.lblOutputText = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblSliderValue = new System.Windows.Forms.Label();
            this.lstPreviousFiles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbEncryptionOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbInputText
            // 
            this.rtbInputText.Location = new System.Drawing.Point(340, 73);
            this.rtbInputText.Name = "rtbInputText";
            this.rtbInputText.Size = new System.Drawing.Size(380, 96);
            this.rtbInputText.TabIndex = 0;
            this.rtbInputText.Text = "";
            // 
            // rtbOutputText
            // 
            this.rtbOutputText.Enabled = false;
            this.rtbOutputText.Location = new System.Drawing.Point(340, 279);
            this.rtbOutputText.Name = "rtbOutputText";
            this.rtbOutputText.Size = new System.Drawing.Size(380, 96);
            this.rtbOutputText.TabIndex = 1;
            this.rtbOutputText.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(415, 226);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(116, 46);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // trbEncryptionOffset
            // 
            this.trbEncryptionOffset.Location = new System.Drawing.Point(340, 175);
            this.trbEncryptionOffset.Maximum = 25;
            this.trbEncryptionOffset.Name = "trbEncryptionOffset";
            this.trbEncryptionOffset.Size = new System.Drawing.Size(380, 45);
            this.trbEncryptionOffset.TabIndex = 3;
            this.trbEncryptionOffset.Scroll += new System.EventHandler(this.trbEncryptionOffset_Scroll);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(405, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(553, 399);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblPreviousFiles
            // 
            this.lblPreviousFiles.AutoSize = true;
            this.lblPreviousFiles.Location = new System.Drawing.Point(37, 54);
            this.lblPreviousFiles.Name = "lblPreviousFiles";
            this.lblPreviousFiles.Size = new System.Drawing.Size(72, 13);
            this.lblPreviousFiles.TabIndex = 7;
            this.lblPreviousFiles.Text = "Previous Files";
            // 
            // lblInputText
            // 
            this.lblInputText.AutoSize = true;
            this.lblInputText.Location = new System.Drawing.Point(337, 57);
            this.lblInputText.Name = "lblInputText";
            this.lblInputText.Size = new System.Drawing.Size(55, 13);
            this.lblInputText.TabIndex = 8;
            this.lblInputText.Text = "Input Text";
            // 
            // lblOutputText
            // 
            this.lblOutputText.AutoSize = true;
            this.lblOutputText.Location = new System.Drawing.Point(337, 263);
            this.lblOutputText.Name = "lblOutputText";
            this.lblOutputText.Size = new System.Drawing.Size(63, 13);
            this.lblOutputText.TabIndex = 9;
            this.lblOutputText.Text = "Output Text";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(537, 226);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(116, 46);
            this.btnDecrypt.TabIndex = 10;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblSliderValue
            // 
            this.lblSliderValue.AutoSize = true;
            this.lblSliderValue.Location = new System.Drawing.Point(517, 201);
            this.lblSliderValue.Name = "lblSliderValue";
            this.lblSliderValue.Size = new System.Drawing.Size(33, 13);
            this.lblSliderValue.TabIndex = 11;
            this.lblSliderValue.Text = "None";
            // 
            // lstPreviousFiles
            // 
            this.lstPreviousFiles.FormattingEnabled = true;
            this.lstPreviousFiles.Location = new System.Drawing.Point(40, 73);
            this.lstPreviousFiles.Name = "lstPreviousFiles";
            this.lstPreviousFiles.Size = new System.Drawing.Size(263, 303);
            this.lstPreviousFiles.TabIndex = 12;
            this.lstPreviousFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPreviousFiles_MouseDoubleClick);
            // 
            // CipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPreviousFiles);
            this.Controls.Add(this.lblSliderValue);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblOutputText);
            this.Controls.Add(this.lblInputText);
            this.Controls.Add(this.lblPreviousFiles);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.trbEncryptionOffset);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.rtbOutputText);
            this.Controls.Add(this.rtbInputText);
            this.MaximizeBox = false;
            this.Name = "CipherForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbEncryptionOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInputText;
        private System.Windows.Forms.RichTextBox rtbOutputText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TrackBar trbEncryptionOffset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblPreviousFiles;
        private System.Windows.Forms.Label lblInputText;
        private System.Windows.Forms.Label lblOutputText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblSliderValue;
        private System.Windows.Forms.ListBox lstPreviousFiles;
    }
}