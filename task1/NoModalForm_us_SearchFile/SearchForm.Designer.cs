namespace NoModalForm_us_SearchFile
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sf_st_path = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.sf_tb_masks = new System.Windows.Forms.TextBox();
            this.sf_b_startSearch = new System.Windows.Forms.Button();
            this.sf_b_openFolder = new System.Windows.Forms.Button();
            this.sf_lb_files = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sf_st_path});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(370, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            // 
            // sf_st_path
            // 
            this.sf_st_path.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sf_st_path.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.sf_st_path.Name = "sf_st_path";
            this.sf_st_path.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Маска поиска";
            // 
            // sf_tb_masks
            // 
            this.sf_tb_masks.Enabled = false;
            this.sf_tb_masks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sf_tb_masks.Location = new System.Drawing.Point(202, 15);
            this.sf_tb_masks.Name = "sf_tb_masks";
            this.sf_tb_masks.Size = new System.Drawing.Size(100, 29);
            this.sf_tb_masks.TabIndex = 3;
            // 
            // sf_b_startSearch
            // 
            this.sf_b_startSearch.Enabled = false;
            this.sf_b_startSearch.Image = global::NoModalForm_us_SearchFile.Properties.Resources.FauxS_XP__Cobalt__V1_5_Icon_28;
            this.sf_b_startSearch.Location = new System.Drawing.Point(311, 11);
            this.sf_b_startSearch.Name = "sf_b_startSearch";
            this.sf_b_startSearch.Size = new System.Drawing.Size(49, 36);
            this.sf_b_startSearch.TabIndex = 4;
            this.sf_b_startSearch.UseVisualStyleBackColor = true;
            // 
            // sf_b_openFolder
            // 
            this.sf_b_openFolder.Image = global::NoModalForm_us_SearchFile.Properties.Resources.FauxS_XP__Cobalt__V1_5_Icon_25;
            this.sf_b_openFolder.Location = new System.Drawing.Point(12, 12);
            this.sf_b_openFolder.Name = "sf_b_openFolder";
            this.sf_b_openFolder.Size = new System.Drawing.Size(46, 35);
            this.sf_b_openFolder.TabIndex = 1;
            this.sf_b_openFolder.UseVisualStyleBackColor = true;
            // 
            // sf_lb_files
            // 
            this.sf_lb_files.Enabled = false;
            this.sf_lb_files.FormattingEnabled = true;
            this.sf_lb_files.Location = new System.Drawing.Point(12, 56);
            this.sf_lb_files.Name = "sf_lb_files";
            this.sf_lb_files.Size = new System.Drawing.Size(346, 290);
            this.sf_lb_files.TabIndex = 5;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 382);
            this.Controls.Add(this.sf_lb_files);
            this.Controls.Add(this.sf_b_startSearch);
            this.Controls.Add(this.sf_tb_masks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sf_b_openFolder);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "Окно поиска";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sf_st_path;
        private System.Windows.Forms.Button sf_b_openFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sf_tb_masks;
        private System.Windows.Forms.Button sf_b_startSearch;
        private System.Windows.Forms.ListBox sf_lb_files;
    }
}