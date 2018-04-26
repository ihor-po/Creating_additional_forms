namespace TextFileReader
{
    partial class tfr_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.tfr_tb_fileText = new System.Windows.Forms.TextBox();
            this.tfr_b_openFile = new System.Windows.Forms.Button();
            this.tfr_b_editText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст из файла";
            // 
            // tfr_tb_fileText
            // 
            this.tfr_tb_fileText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tfr_tb_fileText.Enabled = false;
            this.tfr_tb_fileText.Location = new System.Drawing.Point(16, 31);
            this.tfr_tb_fileText.Multiline = true;
            this.tfr_tb_fileText.Name = "tfr_tb_fileText";
            this.tfr_tb_fileText.ReadOnly = true;
            this.tfr_tb_fileText.Size = new System.Drawing.Size(953, 214);
            this.tfr_tb_fileText.TabIndex = 1;
            // 
            // tfr_b_openFile
            // 
            this.tfr_b_openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tfr_b_openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tfr_b_openFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tfr_b_openFile.Location = new System.Drawing.Point(15, 261);
            this.tfr_b_openFile.Name = "tfr_b_openFile";
            this.tfr_b_openFile.Size = new System.Drawing.Size(232, 45);
            this.tfr_b_openFile.TabIndex = 2;
            this.tfr_b_openFile.Text = "Открыть файл";
            this.tfr_b_openFile.UseVisualStyleBackColor = true;
            // 
            // tfr_b_editText
            // 
            this.tfr_b_editText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tfr_b_editText.Enabled = false;
            this.tfr_b_editText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tfr_b_editText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tfr_b_editText.Location = new System.Drawing.Point(738, 260);
            this.tfr_b_editText.Name = "tfr_b_editText";
            this.tfr_b_editText.Size = new System.Drawing.Size(232, 45);
            this.tfr_b_editText.TabIndex = 3;
            this.tfr_b_editText.Text = "Редаткировать содержимое";
            this.tfr_b_editText.UseVisualStyleBackColor = true;
            // 
            // tfr_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 319);
            this.Controls.Add(this.tfr_b_editText);
            this.Controls.Add(this.tfr_b_openFile);
            this.Controls.Add(this.tfr_tb_fileText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "tfr_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text file Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tfr_tb_fileText;
        private System.Windows.Forms.Button tfr_b_openFile;
        private System.Windows.Forms.Button tfr_b_editText;
    }
}

