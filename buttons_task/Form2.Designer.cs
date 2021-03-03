namespace Завдання_4
{
    partial class Form2
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
            this.openNextForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openNextForm
            // 
            this.openNextForm.BackColor = System.Drawing.Color.Yellow;
            this.openNextForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
            this.openNextForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.openNextForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.openNextForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openNextForm.Font = new System.Drawing.Font("BIPs", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openNextForm.Location = new System.Drawing.Point(436, 206);
            this.openNextForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openNextForm.Name = "openNextForm";
            this.openNextForm.Size = new System.Drawing.Size(214, 131);
            this.openNextForm.TabIndex = 1;
            this.openNextForm.Text = "Open?";
            this.openNextForm.UseVisualStyleBackColor = false;
            this.openNextForm.Click += new System.EventHandler(this.openNextForm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.openNextForm);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openNextForm;
    }
}