namespace HOTELMS
{
    partial class Clientinfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientinfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clientidtbl = new System.Windows.Forms.TextBox();
            this.clientemail = new System.Windows.Forms.TextBox();
            this.clientphone = new System.Windows.Forms.TextBox();
            this.clientage = new System.Windows.Forms.TextBox();
            this.addtb = new System.Windows.Forms.Button();
            this.deletetb = new System.Windows.Forms.Button();
            this.edittb = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clienttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDBDataSetCLIENT = new HOTELMS.HMSDBDataSetCLIENT();
            this.back = new System.Windows.Forms.Button();
            this.client_tblTableAdapter = new HOTELMS.HMSDBDataSetCLIENTTableAdapters.Client_tblTableAdapter();
            this.datelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.clienttblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDBDataSetCLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienttblBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDBDataSetCLIENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDBDataSetCLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttblBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(90, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLIENT INFORMATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLIENT ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(13, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "CLIENT AGE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(269, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "CLIENT PHONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(8, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "CLIENT EMAIL";
            // 
            // clientidtbl
            // 
            this.clientidtbl.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.clientidtbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientidtbl.Location = new System.Drawing.Point(126, 83);
            this.clientidtbl.Name = "clientidtbl";
            this.clientidtbl.Size = new System.Drawing.Size(100, 22);
            this.clientidtbl.TabIndex = 6;
            // 
            // clientemail
            // 
            this.clientemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientemail.Location = new System.Drawing.Point(137, 127);
            this.clientemail.Name = "clientemail";
            this.clientemail.Size = new System.Drawing.Size(100, 22);
            this.clientemail.TabIndex = 7;
            // 
            // clientphone
            // 
            this.clientphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientphone.Location = new System.Drawing.Point(409, 86);
            this.clientphone.Name = "clientphone";
            this.clientphone.Size = new System.Drawing.Size(100, 22);
            this.clientphone.TabIndex = 8;
            // 
            // clientage
            // 
            this.clientage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientage.Location = new System.Drawing.Point(132, 185);
            this.clientage.Name = "clientage";
            this.clientage.Size = new System.Drawing.Size(100, 22);
            this.clientage.TabIndex = 9;
            // 
            // addtb
            // 
            this.addtb.BackColor = System.Drawing.Color.LightBlue;
            this.addtb.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtb.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addtb.Location = new System.Drawing.Point(29, 276);
            this.addtb.Name = "addtb";
            this.addtb.Size = new System.Drawing.Size(94, 34);
            this.addtb.TabIndex = 10;
            this.addtb.Text = "ADD";
            this.addtb.UseVisualStyleBackColor = false;
            this.addtb.Click += new System.EventHandler(this.button1_Click);
            // 
            // deletetb
            // 
            this.deletetb.BackColor = System.Drawing.Color.LightBlue;
            this.deletetb.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletetb.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deletetb.Location = new System.Drawing.Point(29, 364);
            this.deletetb.Name = "deletetb";
            this.deletetb.Size = new System.Drawing.Size(94, 34);
            this.deletetb.TabIndex = 11;
            this.deletetb.Text = "DELETE";
            this.deletetb.UseVisualStyleBackColor = false;
            this.deletetb.Click += new System.EventHandler(this.deletetb_Click);
            // 
            // edittb
            // 
            this.edittb.BackColor = System.Drawing.Color.LightBlue;
            this.edittb.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edittb.ForeColor = System.Drawing.SystemColors.Highlight;
            this.edittb.Location = new System.Drawing.Point(152, 276);
            this.edittb.Name = "edittb";
            this.edittb.Size = new System.Drawing.Size(94, 34);
            this.edittb.TabIndex = 12;
            this.edittb.Text = "EDIT";
            this.edittb.UseVisualStyleBackColor = false;
            this.edittb.Click += new System.EventHandler(this.edittb_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(447, 188);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(170, 22);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(640, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 27);
            this.button4.TabIndex = 14;
            this.button4.Text = "SEARCH";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.NullValue = "iuio";
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(618, 212);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clienttblBindingSource
            // 
            this.clienttblBindingSource.DataMember = "Client_tbl";
            this.clienttblBindingSource.DataSource = this.hMSDBDataSetCLIENT;
            // 
            // hMSDBDataSetCLIENT
            // 
            this.hMSDBDataSetCLIENT.DataSetName = "HMSDBDataSetCLIENT";
            this.hMSDBDataSetCLIENT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.LightBlue;
            this.back.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.Highlight;
            this.back.Location = new System.Drawing.Point(152, 364);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(94, 34);
            this.back.TabIndex = 16;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button5_Click);
            // 
            // client_tblTableAdapter
            // 
            this.client_tblTableAdapter.ClearBeforeFill = true;
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.datelbl.Location = new System.Drawing.Point(442, 29);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(67, 27);
            this.datelbl.TabIndex = 17;
            this.datelbl.Text = "DATE";
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // clienttblBindingSource1
            // 
            this.clienttblBindingSource1.DataMember = "Client_tbl";
            this.clienttblBindingSource1.DataSource = this.hMSDBDataSetCLIENT;
            // 
            // hMSDBDataSetCLIENTBindingSource
            // 
            this.hMSDBDataSetCLIENTBindingSource.DataSource = this.hMSDBDataSetCLIENT;
            this.hMSDBDataSetCLIENTBindingSource.Position = 0;
            // 
            // clienttblBindingSource2
            // 
            this.clienttblBindingSource2.DataMember = "Client_tbl";
            this.clienttblBindingSource2.DataSource = this.hMSDBDataSetCLIENTBindingSource;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(740, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(701, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(225, 172);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            // 
            // Clientinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(926, 480);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.edittb);
            this.Controls.Add(this.deletetb);
            this.Controls.Add(this.addtb);
            this.Controls.Add(this.clientage);
            this.Controls.Add(this.clientphone);
            this.Controls.Add(this.clientemail);
            this.Controls.Add(this.clientidtbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientinfo";
            this.Load += new System.EventHandler(this.Clientinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDBDataSetCLIENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDBDataSetCLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttblBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientidtbl;
        private System.Windows.Forms.TextBox clientemail;
        private System.Windows.Forms.TextBox clientphone;
        private System.Windows.Forms.TextBox clientage;
        private System.Windows.Forms.Button addtb;
        private System.Windows.Forms.Button deletetb;
        private System.Windows.Forms.Button edittb;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button back;
        private HMSDBDataSetCLIENT hMSDBDataSetCLIENT;
        private System.Windows.Forms.BindingSource clienttblBindingSource;
        private HMSDBDataSetCLIENTTableAdapters.Client_tblTableAdapter client_tblTableAdapter;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.BindingSource clienttblBindingSource1;
        private System.Windows.Forms.BindingSource clienttblBindingSource2;
        private System.Windows.Forms.BindingSource hMSDBDataSetCLIENTBindingSource;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}