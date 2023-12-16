namespace Day6
{
    partial class Grid_View
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
            this.Name_Label = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.Phone_Label = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.BirthDate_Label = new System.Windows.Forms.Label();
            this.Birth_Date_Time = new System.Windows.Forms.DateTimePicker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate_Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(19, 81);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(71, 24);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "Name:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(115, 81);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(211, 29);
            this.txt_Name.TabIndex = 1;
            // 
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.Phone_Label.Location = new System.Drawing.Point(19, 138);
            this.Phone_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(77, 24);
            this.Phone_Label.TabIndex = 2;
            this.Phone_Label.Text = "Phone:";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(115, 138);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(211, 29);
            this.txt_Phone.TabIndex = 3;
            // 
            // BirthDate_Label
            // 
            this.BirthDate_Label.AutoSize = true;
            this.BirthDate_Label.Location = new System.Drawing.Point(19, 217);
            this.BirthDate_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BirthDate_Label.Name = "BirthDate_Label";
            this.BirthDate_Label.Size = new System.Drawing.Size(106, 24);
            this.BirthDate_Label.TabIndex = 4;
            this.BirthDate_Label.Text = "Birth Date:";
            // 
            // Birth_Date_Time
            // 
            this.Birth_Date_Time.Location = new System.Drawing.Point(162, 217);
            this.Birth_Date_Time.Name = "Birth_Date_Time";
            this.Birth_Date_Time.Size = new System.Drawing.Size(349, 29);
            this.Birth_Date_Time.TabIndex = 5;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Table,
            this.Phone_Table,
            this.BirthDate_Table});
            this.dataGridView1.Location = new System.Drawing.Point(570, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Name_Table
            // 
            this.Name_Table.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Name_Table.HeaderText = "Name";
            this.Name_Table.Name = "Name_Table";
            // 
            // Phone_Table
            // 
            this.Phone_Table.HeaderText = "Phone";
            this.Phone_Table.Name = "Phone_Table";
            // 
            // BirthDate_Table
            // 
            this.BirthDate_Table.HeaderText = "Birth Date";
            this.BirthDate_Table.Name = "BirthDate_Table";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(231, 278);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(128, 46);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(428, 278);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(128, 46);
            this.btn_Remove.TabIndex = 8;
            this.btn_Remove.Text = "Clear";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(611, 278);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 46);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Grid_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 390);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Birth_Date_Time);
            this.Controls.Add(this.BirthDate_Label);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.Phone_Label);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.Name_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Grid_View";
            this.Text = "Grid_View";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label Phone_Label;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label BirthDate_Label;
        private System.Windows.Forms.DateTimePicker Birth_Date_Time;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate_Table;
        private System.Windows.Forms.Button btn_Save;
    }
}