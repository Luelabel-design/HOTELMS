namespace HOTELMS
{
    partial class Guest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkin = new System.Windows.Forms.DateTimePicker();
            this.roomtype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkout = new System.Windows.Forms.DateTimePicker();
            this.datelbl = new System.Windows.Forms.Label();
            this.hMSDBDataSetCLIENT = new HOTELMS.HMSDBDataSetCLIENT();
            this.hMSDBDataSetCLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDBDataSet = new HOTELMS.HMSDBDataSet();
            this.roomtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_tblTableAdapter = new HOTELMS.HMSDBDataSetTableAdapters.Room_tblTableAdapter();
            this.clientphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDBDataSetCLIENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDBDataSetCLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 71;
            this.label1.Text = "WELCOME TO HMS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(31, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 19);
            this.label6.TabIndex = 75;
            this.label6.Text = "CHECK IN DATE";
            // 
            // checkin
            // 
            this.checkin.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkin.CalendarForeColor = System.Drawing.Color.DeepSkyBlue;
            this.checkin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkin.Location = new System.Drawing.Point(175, 144);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(199, 27);
            this.checkin.TabIndex = 74;
            this.checkin.ValueChanged += new System.EventHandler(this.checkin_ValueChanged);
            // 
            // roomtype
            // 
            this.roomtype.FormattingEnabled = true;
            this.roomtype.Items.AddRange(new object[] {
            "SINGLE",
            "DOUBLE",
            "MASTER"});
            this.roomtype.Location = new System.Drawing.Point(152, 100);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(113, 24);
            this.roomtype.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(31, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 77;
            this.label5.Text = "ROOM TYPE";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.back.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Highlight;
            this.back.Location = new System.Drawing.Point(431, 180);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(94, 34);
            this.back.TabIndex = 79;
            this.back.Text = "CHECK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.NullValue = "iuio";
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 243);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(152, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 81;
            this.button1.Text = "BOOK NOW!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(165, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 34);
            this.button2.TabIndex = 84;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(701, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(225, 172);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 85;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(31, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 87;
            this.label2.Text = "CHECK OUT DATE";
            // 
            // checkout
            // 
            this.checkout.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout.CalendarForeColor = System.Drawing.Color.DeepSkyBlue;
            this.checkout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout.Location = new System.Drawing.Point(190, 187);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(184, 27);
            this.checkout.TabIndex = 86;
            this.checkout.ValueChanged += new System.EventHandler(this.checkout_ValueChanged);
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.datelbl.Location = new System.Drawing.Point(447, 27);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(67, 27);
            this.datelbl.TabIndex = 88;
            this.datelbl.Text = "DATE";
            // 
            // hMSDBDataSetCLIENT
            // 
            this.hMSDBDataSetCLIENT.DataSetName = "HMSDBDataSetCLIENT";
            this.hMSDBDataSetCLIENT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hMSDBDataSetCLIENTBindingSource
            // 
            this.hMSDBDataSetCLIENTBindingSource.DataSource = this.hMSDBDataSetCLIENT;
            this.hMSDBDataSetCLIENTBindingSource.Position = 0;
            // 
            // hMSDBDataSet
            // 
            this.hMSDBDataSet.DataSetName = "HMSDBDataSet";
            this.hMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomtblBindingSource
            // 
            this.roomtblBindingSource.DataMember = "Room_tbl";
            this.roomtblBindingSource.DataSource = this.hMSDBDataSet;
            // 
            // room_tblTableAdapter
            // 
            this.room_tblTableAdapter.ClearBeforeFill = true;
            // 
            // clientphone
            // 
            this.clientphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientphone.Location = new System.Drawing.Point(465, 100);
            this.clientphone.Name = "clientphone";
            this.clientphone.Size = new System.Drawing.Size(100, 22);
            this.clientphone.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(325, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 89;
            this.label4.Text = "CLIENT PHONE";
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(926, 480);
            this.Controls.Add(this.clientphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.roomtype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Guest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest";
            this.Load += new System.EventHandler(this.Guest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDBDataSetCLIENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDBDataSetCLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker checkin;
        private System.Windows.Forms.ComboBox roomtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker checkout;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.BindingSource hMSDBDataSetCLIENTBindingSource;
        private HMSDBDataSetCLIENT hMSDBDataSetCLIENT;
        private HMSDBDataSet hMSDBDataSet;
        private System.Windows.Forms.BindingSource roomtblBindingSource;
        private HMSDBDataSetTableAdapters.Room_tblTableAdapter room_tblTableAdapter;
        private System.Windows.Forms.TextBox clientphone;
        private System.Windows.Forms.Label label4;
    }
}