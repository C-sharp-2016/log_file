namespace log_file
{
    partial class Form1
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
            this.press_log_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // press_log_button1
            // 
            this.press_log_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.press_log_button1.Location = new System.Drawing.Point(37, 84);
            this.press_log_button1.Name = "press_log_button1";
            this.press_log_button1.Size = new System.Drawing.Size(202, 99);
            this.press_log_button1.TabIndex = 0;
            this.press_log_button1.Text = "Press To Log Text To File";
            this.press_log_button1.UseVisualStyleBackColor = true;
            this.press_log_button1.Click += new System.EventHandler(this.press_log_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.press_log_button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button press_log_button1;
    }
}

