namespace TextFileReader
{
    partial class EditForm
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
            this.ef_tb_edit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ef_b_save = new System.Windows.Forms.Button();
            this.ef_b_cansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ef_tb_edit
            // 
            this.ef_tb_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ef_tb_edit.Location = new System.Drawing.Point(12, 32);
            this.ef_tb_edit.Name = "ef_tb_edit";
            this.ef_tb_edit.Size = new System.Drawing.Size(962, 23);
            this.ef_tb_edit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текст для редактирования";
            // 
            // ef_b_save
            // 
            this.ef_b_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ef_b_save.Location = new System.Drawing.Point(771, 61);
            this.ef_b_save.Name = "ef_b_save";
            this.ef_b_save.Size = new System.Drawing.Size(90, 29);
            this.ef_b_save.TabIndex = 2;
            this.ef_b_save.Text = "Сохранить";
            this.ef_b_save.UseVisualStyleBackColor = true;
            // 
            // ef_b_cansel
            // 
            this.ef_b_cansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ef_b_cansel.Location = new System.Drawing.Point(885, 61);
            this.ef_b_cansel.Name = "ef_b_cansel";
            this.ef_b_cansel.Size = new System.Drawing.Size(90, 29);
            this.ef_b_cansel.TabIndex = 3;
            this.ef_b_cansel.Text = "Отмена";
            this.ef_b_cansel.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 95);
            this.Controls.Add(this.ef_b_cansel);
            this.Controls.Add(this.ef_b_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ef_tb_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.ShowIcon = false;
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ef_tb_edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ef_b_save;
        private System.Windows.Forms.Button ef_b_cansel;
    }
}