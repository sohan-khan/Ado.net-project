
namespace project__of_ado_dot_net
{
    partial class Frmpatients
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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.Btnupdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btnreset = new System.Windows.Forms.Button();
            this.Btnsave = new System.Windows.Forms.Button();
            this.Btnupload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblpatients = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Silver;
            this.BtnSearch.ForeColor = System.Drawing.Color.Black;
            this.BtnSearch.Location = new System.Drawing.Point(671, 105);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 52;
            this.BtnSearch.Text = "Search by Id";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(576, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 51;
            // 
            // BtnView
            // 
            this.BtnView.BackColor = System.Drawing.Color.Blue;
            this.BtnView.ForeColor = System.Drawing.Color.White;
            this.BtnView.Location = new System.Drawing.Point(495, 106);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 23);
            this.BtnView.TabIndex = 50;
            this.BtnView.Text = "View";
            this.BtnView.UseVisualStyleBackColor = false;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(391, 106);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 49;
            this.BtnDelete.Text = "Delete ";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Btnupdate
            // 
            this.Btnupdate.BackColor = System.Drawing.Color.DarkGreen;
            this.Btnupdate.Location = new System.Drawing.Point(288, 106);
            this.Btnupdate.Name = "Btnupdate";
            this.Btnupdate.Size = new System.Drawing.Size(75, 23);
            this.Btnupdate.TabIndex = 48;
            this.Btnupdate.Text = "Update ";
            this.Btnupdate.UseVisualStyleBackColor = false;
            this.Btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 300);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Category:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // Btnreset
            // 
            this.Btnreset.BackColor = System.Drawing.Color.OrangeRed;
            this.Btnreset.Location = new System.Drawing.Point(166, 415);
            this.Btnreset.Name = "Btnreset";
            this.Btnreset.Size = new System.Drawing.Size(75, 23);
            this.Btnreset.TabIndex = 44;
            this.Btnreset.Text = "Reset";
            this.Btnreset.UseVisualStyleBackColor = false;
            this.Btnreset.Click += new System.EventHandler(this.Btnreset_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.BackColor = System.Drawing.Color.Lime;
            this.Btnsave.Location = new System.Drawing.Point(65, 415);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(75, 23);
            this.Btnsave.TabIndex = 43;
            this.Btnsave.Text = "Save";
            this.Btnsave.UseVisualStyleBackColor = false;
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // Btnupload
            // 
            this.Btnupload.BackColor = System.Drawing.Color.Yellow;
            this.Btnupload.Location = new System.Drawing.Point(138, 363);
            this.Btnupload.Name = "Btnupload";
            this.Btnupload.Size = new System.Drawing.Size(75, 23);
            this.Btnupload.TabIndex = 42;
            this.Btnupload.Text = "Upload";
            this.Btnupload.UseVisualStyleBackColor = false;
            this.Btnupload.Click += new System.EventHandler(this.Btnupload_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(105, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "AppointDate:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(117, 135);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(148, 20);
            this.txtname.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(117, 85);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(148, 20);
            this.txtId.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID:";
            // 
            // lblpatients
            // 
            this.lblpatients.AutoSize = true;
            this.lblpatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatients.ForeColor = System.Drawing.Color.Aqua;
            this.lblpatients.Location = new System.Drawing.Point(146, 16);
            this.lblpatients.Name = "lblpatients";
            this.lblpatients.Size = new System.Drawing.Size(107, 20);
            this.lblpatients.TabIndex = 34;
            this.lblpatients.Text = "PatientsInfo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            // 
            // Frmpatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.Btnupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Btnreset);
            this.Controls.Add(this.Btnsave);
            this.Controls.Add(this.Btnupload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblpatients);
            this.Controls.Add(this.label1);
            this.Name = "Frmpatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmpatients";
            this.Load += new System.EventHandler(this.Frmpatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button Btnupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btnreset;
        private System.Windows.Forms.Button Btnsave;
        private System.Windows.Forms.Button Btnupload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblpatients;
        private System.Windows.Forms.Label label1;
    }
}