namespace NoModalForm_us_SearchFile
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
            this.mf_b_search = new System.Windows.Forms.Button();
            this.mf_b_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mf_b_search
            // 
            this.mf_b_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mf_b_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mf_b_search.Image = global::NoModalForm_us_SearchFile.Properties.Resources.FauxS_XP__Cobalt__V1_5_Icon_04;
            this.mf_b_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mf_b_search.Location = new System.Drawing.Point(12, 12);
            this.mf_b_search.Name = "mf_b_search";
            this.mf_b_search.Size = new System.Drawing.Size(235, 38);
            this.mf_b_search.TabIndex = 0;
            this.mf_b_search.Text = "&Окно поиска";
            this.mf_b_search.UseVisualStyleBackColor = true;
            // 
            // mf_b_close
            // 
            this.mf_b_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mf_b_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mf_b_close.Location = new System.Drawing.Point(257, 12);
            this.mf_b_close.Name = "mf_b_close";
            this.mf_b_close.Size = new System.Drawing.Size(239, 38);
            this.mf_b_close.TabIndex = 1;
            this.mf_b_close.Text = "&Закрыть";
            this.mf_b_close.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 62);
            this.ControlBox = false;
            this.Controls.Add(this.mf_b_close);
            this.Controls.Add(this.mf_b_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mf_b_search;
        private System.Windows.Forms.Button mf_b_close;
    }
}

