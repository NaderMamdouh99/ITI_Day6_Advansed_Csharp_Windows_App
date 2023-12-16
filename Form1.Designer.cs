namespace Day6
{
    partial class Form_Format
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
            this.txt_Format = new System.Windows.Forms.TextBox();
            this.Format = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Format
            // 
            this.txt_Format.Location = new System.Drawing.Point(101, 36);
            this.txt_Format.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Format.Name = "txt_Format";
            this.txt_Format.Size = new System.Drawing.Size(148, 26);
            this.txt_Format.TabIndex = 0;
            // 
            // Format
            // 
            this.Format.Location = new System.Drawing.Point(299, 32);
            this.Format.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(112, 35);
            this.Format.TabIndex = 1;
            this.Format.Text = "Format";
            this.Format.UseVisualStyleBackColor = true;
            this.Format.Click += new System.EventHandler(this.Format_Click);
            // 
            // Form_Format
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 222);
            this.Controls.Add(this.Format);
            this.Controls.Add(this.txt_Format);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Format";
            this.Text = "Format";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Format;
        private System.Windows.Forms.Button Format;
    }
}

