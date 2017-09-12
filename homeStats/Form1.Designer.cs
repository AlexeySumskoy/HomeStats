namespace homeStats
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameOfUser = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.Label();
            this.secondDate = new System.Windows.Forms.Label();
            this.firstDate = new System.Windows.Forms.Label();
            this.byName = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateOne = new System.Windows.Forms.DateTimePicker();
            this.dateTwo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.byName)).BeginInit();
            this.SuspendLayout();
            // 
            // nameOfUser
            // 
            this.nameOfUser.FormattingEnabled = true;
            this.nameOfUser.Location = new System.Drawing.Point(13, 22);
            this.nameOfUser.Name = "nameOfUser";
            this.nameOfUser.Size = new System.Drawing.Size(440, 21);
            this.nameOfUser.TabIndex = 0;
            this.nameOfUser.Click += new System.EventHandler(this.nameOfUser_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(180, 6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(75, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Вид продукта";
            // 
            // secondDate
            // 
            this.secondDate.AutoSize = true;
            this.secondDate.Location = new System.Drawing.Point(704, 6);
            this.secondDate.Name = "secondDate";
            this.secondDate.Size = new System.Drawing.Size(42, 13);
            this.secondDate.TabIndex = 4;
            this.secondDate.Text = "Дата 2";
            // 
            // firstDate
            // 
            this.firstDate.AutoSize = true;
            this.firstDate.Location = new System.Drawing.Point(520, 6);
            this.firstDate.Name = "firstDate";
            this.firstDate.Size = new System.Drawing.Size(42, 13);
            this.firstDate.TabIndex = 5;
            this.firstDate.Text = "Дата 1";
            // 
            // byName
            // 
            this.byName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.byName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.byName.DefaultCellStyle = dataGridViewCellStyle1;
            this.byName.Location = new System.Drawing.Point(3, 49);
            this.byName.Name = "byName";
            this.byName.Size = new System.Drawing.Size(820, 270);
            this.byName.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateOne
            // 
            this.dateOne.CustomFormat = "dd.mm.yyyy";
            this.dateOne.Location = new System.Drawing.Point(466, 22);
            this.dateOne.Name = "dateOne";
            this.dateOne.Size = new System.Drawing.Size(141, 20);
            this.dateOne.TabIndex = 10;
            // 
            // dateTwo
            // 
            this.dateTwo.CustomFormat = "dd.mm.yyyy";
            this.dateTwo.Location = new System.Drawing.Point(653, 23);
            this.dateTwo.Name = "dateTwo";
            this.dateTwo.Size = new System.Drawing.Size(141, 20);
            this.dateTwo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(813, 129);
            this.label1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTwo);
            this.Controls.Add(this.dateOne);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.byName);
            this.Controls.Add(this.firstDate);
            this.Controls.Add(this.secondDate);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameOfUser);
            this.Name = "Form1";
            this.Text = "Статистика по виду продукта";
            ((System.ComponentModel.ISupportInitialize)(this.byName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nameOfUser;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label secondDate;
        private System.Windows.Forms.Label firstDate;
        private System.Windows.Forms.DataGridView byName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateOne;
        private System.Windows.Forms.DateTimePicker dateTwo;
        private System.Windows.Forms.Label label1;
    }
}