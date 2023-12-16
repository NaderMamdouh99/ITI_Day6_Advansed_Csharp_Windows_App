namespace Day6
{
    partial class Dialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.Color_Box = new System.Windows.Forms.GroupBox();
            this.Blue_Color = new System.Windows.Forms.RadioButton();
            this.Green_Color = new System.Windows.Forms.RadioButton();
            this.Red_Color = new System.Windows.Forms.RadioButton();
            this.Format_Box = new System.Windows.Forms.GroupBox();
            this.UnderLine_Format = new System.Windows.Forms.CheckBox();
            this.Italic_Format = new System.Windows.Forms.CheckBox();
            this.Bold_Format = new System.Windows.Forms.CheckBox();
            this.Size_Label = new System.Windows.Forms.Label();
            this.Size_text = new System.Windows.Forms.TextBox();
            this.Ok_Format = new System.Windows.Forms.Button();
            this.Dialog_Font = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1.SuspendLayout();
            this.Color_Box.SuspendLayout();
            this.Format_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 31);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // Color_Box
            // 
            this.Color_Box.Controls.Add(this.Blue_Color);
            this.Color_Box.Controls.Add(this.Green_Color);
            this.Color_Box.Controls.Add(this.Red_Color);
            this.Color_Box.Location = new System.Drawing.Point(445, 68);
            this.Color_Box.Name = "Color_Box";
            this.Color_Box.Size = new System.Drawing.Size(200, 103);
            this.Color_Box.TabIndex = 3;
            this.Color_Box.TabStop = false;
            this.Color_Box.Text = "Color";
            // 
            // Blue_Color
            // 
            this.Blue_Color.AutoSize = true;
            this.Blue_Color.ForeColor = System.Drawing.Color.Blue;
            this.Blue_Color.Location = new System.Drawing.Point(69, 71);
            this.Blue_Color.Name = "Blue_Color";
            this.Blue_Color.Size = new System.Drawing.Size(60, 22);
            this.Blue_Color.TabIndex = 2;
            this.Blue_Color.TabStop = true;
            this.Blue_Color.Text = "Blue";
            this.Blue_Color.UseVisualStyleBackColor = true;
            // 
            // Green_Color
            // 
            this.Green_Color.AutoSize = true;
            this.Green_Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Green_Color.Location = new System.Drawing.Point(69, 43);
            this.Green_Color.Name = "Green_Color";
            this.Green_Color.Size = new System.Drawing.Size(69, 22);
            this.Green_Color.TabIndex = 1;
            this.Green_Color.TabStop = true;
            this.Green_Color.Text = "Green";
            this.Green_Color.UseVisualStyleBackColor = true;
            // 
            // Red_Color
            // 
            this.Red_Color.AutoSize = true;
            this.Red_Color.ForeColor = System.Drawing.Color.Red;
            this.Red_Color.Location = new System.Drawing.Point(69, 15);
            this.Red_Color.Name = "Red_Color";
            this.Red_Color.Size = new System.Drawing.Size(54, 22);
            this.Red_Color.TabIndex = 0;
            this.Red_Color.TabStop = true;
            this.Red_Color.Text = "Red";
            this.Red_Color.UseVisualStyleBackColor = true;
            // 
            // Format_Box
            // 
            this.Format_Box.Controls.Add(this.UnderLine_Format);
            this.Format_Box.Controls.Add(this.Italic_Format);
            this.Format_Box.Controls.Add(this.Bold_Format);
            this.Format_Box.Location = new System.Drawing.Point(26, 183);
            this.Format_Box.Name = "Format_Box";
            this.Format_Box.Size = new System.Drawing.Size(399, 100);
            this.Format_Box.TabIndex = 4;
            this.Format_Box.TabStop = false;
            this.Format_Box.Text = "Format";
            // 
            // UnderLine_Format
            // 
            this.UnderLine_Format.AutoSize = true;
            this.UnderLine_Format.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderLine_Format.Location = new System.Drawing.Point(278, 44);
            this.UnderLine_Format.Name = "UnderLine_Format";
            this.UnderLine_Format.Size = new System.Drawing.Size(98, 22);
            this.UnderLine_Format.TabIndex = 5;
            this.UnderLine_Format.Text = "UnderLine";
            this.UnderLine_Format.UseVisualStyleBackColor = true;
            // 
            // Italic_Format
            // 
            this.Italic_Format.AutoSize = true;
            this.Italic_Format.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Italic_Format.Location = new System.Drawing.Point(154, 44);
            this.Italic_Format.Name = "Italic_Format";
            this.Italic_Format.Size = new System.Drawing.Size(62, 22);
            this.Italic_Format.TabIndex = 4;
            this.Italic_Format.Text = "Italic";
            this.Italic_Format.UseVisualStyleBackColor = true;
            // 
            // Bold_Format
            // 
            this.Bold_Format.AutoSize = true;
            this.Bold_Format.Location = new System.Drawing.Point(30, 44);
            this.Bold_Format.Name = "Bold_Format";
            this.Bold_Format.Size = new System.Drawing.Size(62, 22);
            this.Bold_Format.TabIndex = 3;
            this.Bold_Format.Text = "Bold";
            this.Bold_Format.UseVisualStyleBackColor = true;
            // 
            // Size_Label
            // 
            this.Size_Label.AutoSize = true;
            this.Size_Label.Location = new System.Drawing.Point(95, 128);
            this.Size_Label.Name = "Size_Label";
            this.Size_Label.Size = new System.Drawing.Size(38, 18);
            this.Size_Label.TabIndex = 5;
            this.Size_Label.Text = "Size";
            // 
            // Size_text
            // 
            this.Size_text.Location = new System.Drawing.Point(180, 125);
            this.Size_text.Name = "Size_text";
            this.Size_text.Size = new System.Drawing.Size(120, 25);
            this.Size_text.TabIndex = 6;
            // 
            // Ok_Format
            // 
            this.Ok_Format.Location = new System.Drawing.Point(245, 325);
            this.Ok_Format.Name = "Ok_Format";
            this.Ok_Format.Size = new System.Drawing.Size(228, 23);
            this.Ok_Format.TabIndex = 7;
            this.Ok_Format.Text = "OK";
            this.Ok_Format.UseVisualStyleBackColor = true;
            this.Ok_Format.Click += new System.EventHandler(this.Ok_Format_Click);
            // 
            // Dialog_Font
            // 
            this.Dialog_Font.FormattingEnabled = true;
            this.Dialog_Font.Items.AddRange(new object[] {
            "Arial",
            "Calibri",
            "Batang",
            "Chiller"});
            this.Dialog_Font.Location = new System.Drawing.Point(180, 68);
            this.Dialog_Font.Name = "Dialog_Font";
            this.Dialog_Font.Size = new System.Drawing.Size(121, 26);
            this.Dialog_Font.TabIndex = 8;
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 400);
            this.Controls.Add(this.Dialog_Font);
            this.Controls.Add(this.Ok_Format);
            this.Controls.Add(this.Size_text);
            this.Controls.Add(this.Size_Label);
            this.Controls.Add(this.Format_Box);
            this.Controls.Add(this.Color_Box);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Dialog";
            this.Text = "Dialog";
            this.Load += new System.EventHandler(this.Dialog_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.Color_Box.ResumeLayout(false);
            this.Color_Box.PerformLayout();
            this.Format_Box.ResumeLayout(false);
            this.Format_Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.GroupBox Color_Box;
        private System.Windows.Forms.RadioButton Blue_Color;
        private System.Windows.Forms.RadioButton Green_Color;
        private System.Windows.Forms.RadioButton Red_Color;
        private System.Windows.Forms.GroupBox Format_Box;
        private System.Windows.Forms.Label Size_Label;
        private System.Windows.Forms.TextBox Size_text;
        private System.Windows.Forms.Button Ok_Format;
        private System.Windows.Forms.CheckBox UnderLine_Format;
        private System.Windows.Forms.CheckBox Italic_Format;
        private System.Windows.Forms.CheckBox Bold_Format;
        private System.Windows.Forms.ComboBox Dialog_Font;
    }
}