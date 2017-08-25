namespace homeStats
{
    partial class Graphic
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.nameOfUser = new System.Windows.Forms.ComboBox();
            this.nameOfProduct = new System.Windows.Forms.ComboBox();
            this.user = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.Label();
            this.drawed = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1090, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(680, 35);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Рисовать";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameOfUser
            // 
            this.nameOfUser.FormattingEnabled = true;
            this.nameOfUser.Location = new System.Drawing.Point(12, 35);
            this.nameOfUser.Name = "nameOfUser";
            this.nameOfUser.Size = new System.Drawing.Size(121, 21);
            this.nameOfUser.TabIndex = 2;
            // 
            // nameOfProduct
            // 
            this.nameOfProduct.FormattingEnabled = true;
            this.nameOfProduct.Location = new System.Drawing.Point(140, 35);
            this.nameOfProduct.Name = "nameOfProduct";
            this.nameOfProduct.Size = new System.Drawing.Size(121, 21);
            this.nameOfProduct.TabIndex = 3;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(39, 19);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(64, 13);
            this.user.TabIndex = 4;
            this.user.Text = "Вид товара";
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Location = new System.Drawing.Point(177, 19);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(49, 13);
            this.product.TabIndex = 5;
            this.product.Text = "Продукт";
            // 
            // drawed
            // 
            this.drawed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawed.Location = new System.Drawing.Point(761, 19);
            this.drawed.Name = "drawed";
            this.drawed.Size = new System.Drawing.Size(341, 37);
            this.drawed.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата 1";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(474, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата 2";
            // 
            // Graphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.drawed);
            this.Controls.Add(this.product);
            this.Controls.Add(this.user);
            this.Controls.Add(this.nameOfProduct);
            this.Controls.Add(this.nameOfUser);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Graphic";
            this.Text = "Графики";
            this.Load += new System.EventHandler(this.Graphic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.ComboBox nameOfUser;
        private System.Windows.Forms.ComboBox nameOfProduct;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label product;
        private System.Windows.Forms.Label drawed;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
    }
}