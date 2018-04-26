namespace task2
{
    partial class CEdit
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
            this.cef_l_title = new System.Windows.Forms.Label();
            this.cef_tb_title = new System.Windows.Forms.TextBox();
            this.cef_l_characteristics = new System.Windows.Forms.Label();
            this.cef_rtb_characteristics = new System.Windows.Forms.RichTextBox();
            this.cef_rtb_description = new System.Windows.Forms.RichTextBox();
            this.cef_l_description = new System.Windows.Forms.Label();
            this.cef_tb_price = new System.Windows.Forms.TextBox();
            this.cef_l_price = new System.Windows.Forms.Label();
            this.cef_b_add = new System.Windows.Forms.Button();
            this.cef_b_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cef_l_title
            // 
            this.cef_l_title.AutoSize = true;
            this.cef_l_title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cef_l_title.Location = new System.Drawing.Point(18, 22);
            this.cef_l_title.Name = "cef_l_title";
            this.cef_l_title.Size = new System.Drawing.Size(115, 19);
            this.cef_l_title.TabIndex = 0;
            this.cef_l_title.Text = "Наименование";
            // 
            // cef_tb_title
            // 
            this.cef_tb_title.Location = new System.Drawing.Point(142, 19);
            this.cef_tb_title.Name = "cef_tb_title";
            this.cef_tb_title.Size = new System.Drawing.Size(265, 27);
            this.cef_tb_title.TabIndex = 1;
            // 
            // cef_l_characteristics
            // 
            this.cef_l_characteristics.AutoSize = true;
            this.cef_l_characteristics.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cef_l_characteristics.Location = new System.Drawing.Point(12, 56);
            this.cef_l_characteristics.Name = "cef_l_characteristics";
            this.cef_l_characteristics.Size = new System.Drawing.Size(122, 19);
            this.cef_l_characteristics.TabIndex = 2;
            this.cef_l_characteristics.Text = "Характеристики";
            // 
            // cef_rtb_characteristics
            // 
            this.cef_rtb_characteristics.Location = new System.Drawing.Point(142, 56);
            this.cef_rtb_characteristics.Name = "cef_rtb_characteristics";
            this.cef_rtb_characteristics.Size = new System.Drawing.Size(265, 62);
            this.cef_rtb_characteristics.TabIndex = 2;
            this.cef_rtb_characteristics.Text = "";
            // 
            // cef_rtb_description
            // 
            this.cef_rtb_description.Location = new System.Drawing.Point(142, 129);
            this.cef_rtb_description.Name = "cef_rtb_description";
            this.cef_rtb_description.Size = new System.Drawing.Size(265, 67);
            this.cef_rtb_description.TabIndex = 3;
            this.cef_rtb_description.Text = "";
            // 
            // cef_l_description
            // 
            this.cef_l_description.AutoSize = true;
            this.cef_l_description.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cef_l_description.Location = new System.Drawing.Point(53, 129);
            this.cef_l_description.Name = "cef_l_description";
            this.cef_l_description.Size = new System.Drawing.Size(79, 19);
            this.cef_l_description.TabIndex = 4;
            this.cef_l_description.Text = "Описание";
            // 
            // cef_tb_price
            // 
            this.cef_tb_price.Location = new System.Drawing.Point(142, 207);
            this.cef_tb_price.Name = "cef_tb_price";
            this.cef_tb_price.Size = new System.Drawing.Size(265, 27);
            this.cef_tb_price.TabIndex = 6;
            // 
            // cef_l_price
            // 
            this.cef_l_price.AutoSize = true;
            this.cef_l_price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cef_l_price.Location = new System.Drawing.Point(86, 210);
            this.cef_l_price.Name = "cef_l_price";
            this.cef_l_price.Size = new System.Drawing.Size(45, 19);
            this.cef_l_price.TabIndex = 5;
            this.cef_l_price.Text = "Цена";
            // 
            // cef_b_add
            // 
            this.cef_b_add.Location = new System.Drawing.Point(142, 249);
            this.cef_b_add.Name = "cef_b_add";
            this.cef_b_add.Size = new System.Drawing.Size(119, 32);
            this.cef_b_add.TabIndex = 7;
            this.cef_b_add.Text = "button1";
            this.cef_b_add.UseVisualStyleBackColor = true;
            // 
            // cef_b_cancel
            // 
            this.cef_b_cancel.Location = new System.Drawing.Point(332, 249);
            this.cef_b_cancel.Name = "cef_b_cancel";
            this.cef_b_cancel.Size = new System.Drawing.Size(75, 32);
            this.cef_b_cancel.TabIndex = 8;
            this.cef_b_cancel.Text = "Отмена";
            this.cef_b_cancel.UseVisualStyleBackColor = true;
            // 
            // CEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 298);
            this.ControlBox = false;
            this.Controls.Add(this.cef_b_cancel);
            this.Controls.Add(this.cef_b_add);
            this.Controls.Add(this.cef_tb_price);
            this.Controls.Add(this.cef_l_price);
            this.Controls.Add(this.cef_rtb_description);
            this.Controls.Add(this.cef_l_description);
            this.Controls.Add(this.cef_rtb_characteristics);
            this.Controls.Add(this.cef_l_characteristics);
            this.Controls.Add(this.cef_tb_title);
            this.Controls.Add(this.cef_l_title);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cef_l_title;
        private System.Windows.Forms.TextBox cef_tb_title;
        private System.Windows.Forms.Label cef_l_characteristics;
        private System.Windows.Forms.RichTextBox cef_rtb_characteristics;
        private System.Windows.Forms.RichTextBox cef_rtb_description;
        private System.Windows.Forms.Label cef_l_description;
        private System.Windows.Forms.TextBox cef_tb_price;
        private System.Windows.Forms.Label cef_l_price;
        private System.Windows.Forms.Button cef_b_add;
        private System.Windows.Forms.Button cef_b_cancel;
    }
}