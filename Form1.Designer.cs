namespace Nöbetci_UI
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
            this.cmb_Ay = new System.Windows.Forms.ComboBox();
            this.btn_GetExcel = new System.Windows.Forms.Button();
            this.cmb_Nobetci = new System.Windows.Forms.ComboBox();
            this.txt_Unvan = new System.Windows.Forms.TextBox();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.dtp_Tarih = new System.Windows.Forms.DateTimePicker();
            this.dgv_Excel = new System.Windows.Forms.DataGridView();
            this.nobetci_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvan_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih_dgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SetExcel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chc_Degisim = new System.Windows.Forms.CheckBox();
            this.txt_Telefon = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Excel)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Ay
            // 
            this.cmb_Ay.FormattingEnabled = true;
            this.cmb_Ay.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık",
            "Nöbet"});
            this.cmb_Ay.Location = new System.Drawing.Point(12, 63);
            this.cmb_Ay.Name = "cmb_Ay";
            this.cmb_Ay.Size = new System.Drawing.Size(121, 21);
            this.cmb_Ay.TabIndex = 0;
            // 
            // btn_GetExcel
            // 
            this.btn_GetExcel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GetExcel.Location = new System.Drawing.Point(229, 31);
            this.btn_GetExcel.Name = "btn_GetExcel";
            this.btn_GetExcel.Size = new System.Drawing.Size(190, 53);
            this.btn_GetExcel.TabIndex = 1;
            this.btn_GetExcel.Text = "Excel\'i Yükle";
            this.btn_GetExcel.UseVisualStyleBackColor = true;
            this.btn_GetExcel.Click += new System.EventHandler(this.Btn_GetExcel_Click);
            // 
            // cmb_Nobetci
            // 
            this.cmb_Nobetci.FormattingEnabled = true;
            this.cmb_Nobetci.Location = new System.Drawing.Point(12, 145);
            this.cmb_Nobetci.Name = "cmb_Nobetci";
            this.cmb_Nobetci.Size = new System.Drawing.Size(121, 21);
            this.cmb_Nobetci.TabIndex = 2;
            this.cmb_Nobetci.SelectedValueChanged += new System.EventHandler(this.Cmb_Nobetci_SelectedValueChanged);
            // 
            // txt_Unvan
            // 
            this.txt_Unvan.Location = new System.Drawing.Point(139, 146);
            this.txt_Unvan.Name = "txt_Unvan";
            this.txt_Unvan.Size = new System.Drawing.Size(100, 20);
            this.txt_Unvan.TabIndex = 3;
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(351, 145);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(100, 20);
            this.txt_Mail.TabIndex = 5;
            // 
            // dtp_Tarih
            // 
            this.dtp_Tarih.Location = new System.Drawing.Point(457, 146);
            this.dtp_Tarih.Name = "dtp_Tarih";
            this.dtp_Tarih.Size = new System.Drawing.Size(200, 20);
            this.dtp_Tarih.TabIndex = 6;
            this.dtp_Tarih.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dtp_Tarih_KeyDown);
            // 
            // dgv_Excel
            // 
            this.dgv_Excel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Excel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nobetci_dgv,
            this.unvan_dgv,
            this.telefon_dgv,
            this.mail_dgv,
            this.tarih_dgv});
            this.dgv_Excel.Location = new System.Drawing.Point(12, 215);
            this.dgv_Excel.Name = "dgv_Excel";
            this.dgv_Excel.Size = new System.Drawing.Size(791, 334);
            this.dgv_Excel.TabIndex = 7;
            // 
            // nobetci_dgv
            // 
            this.nobetci_dgv.HeaderText = "Nöbetçi";
            this.nobetci_dgv.Name = "nobetci_dgv";
            this.nobetci_dgv.Width = 150;
            // 
            // unvan_dgv
            // 
            this.unvan_dgv.HeaderText = "Unvan";
            this.unvan_dgv.Name = "unvan_dgv";
            this.unvan_dgv.Width = 150;
            // 
            // telefon_dgv
            // 
            this.telefon_dgv.HeaderText = "Telefon";
            this.telefon_dgv.Name = "telefon_dgv";
            this.telefon_dgv.Width = 150;
            // 
            // mail_dgv
            // 
            this.mail_dgv.HeaderText = "Mail";
            this.mail_dgv.Name = "mail_dgv";
            this.mail_dgv.Width = 150;
            // 
            // tarih_dgv
            // 
            this.tarih_dgv.HeaderText = "Tarih";
            this.tarih_dgv.Name = "tarih_dgv";
            this.tarih_dgv.Width = 150;
            // 
            // btn_SetExcel
            // 
            this.btn_SetExcel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SetExcel.Location = new System.Drawing.Point(12, 555);
            this.btn_SetExcel.Name = "btn_SetExcel";
            this.btn_SetExcel.Size = new System.Drawing.Size(791, 53);
            this.btn_SetExcel.TabIndex = 8;
            this.btn_SetExcel.Text = "Excel\'e Kaydet";
            this.btn_SetExcel.UseVisualStyleBackColor = true;
            this.btn_SetExcel.Click += new System.EventHandler(this.Btn_SetExcel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.Location = new System.Drawing.Point(668, 113);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(135, 53);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aylar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nöbetçi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(135, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Unvan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(241, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(347, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(453, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tarih";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(139, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 16;
            // 
            // chc_Degisim
            // 
            this.chc_Degisim.AutoSize = true;
            this.chc_Degisim.Location = new System.Drawing.Point(12, 192);
            this.chc_Degisim.Name = "chc_Degisim";
            this.chc_Degisim.Size = new System.Drawing.Size(107, 17);
            this.chc_Degisim.TabIndex = 17;
            this.chc_Degisim.Text = "Değişime İzin Ver";
            this.chc_Degisim.UseVisualStyleBackColor = true;
            this.chc_Degisim.CheckedChanged += new System.EventHandler(this.Chc_Degisim_CheckedChanged);
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Location = new System.Drawing.Point(245, 145);
            this.txt_Telefon.Mask = "(999) 000-0000";
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefon.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 620);
            this.Controls.Add(this.txt_Telefon);
            this.Controls.Add(this.chc_Degisim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_SetExcel);
            this.Controls.Add(this.dgv_Excel);
            this.Controls.Add(this.dtp_Tarih);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.txt_Unvan);
            this.Controls.Add(this.cmb_Nobetci);
            this.Controls.Add(this.btn_GetExcel);
            this.Controls.Add(this.cmb_Ay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Excel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Ay;
        private System.Windows.Forms.Button btn_GetExcel;
        private System.Windows.Forms.ComboBox cmb_Nobetci;
        private System.Windows.Forms.TextBox txt_Unvan;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.DateTimePicker dtp_Tarih;
        private System.Windows.Forms.DataGridView dgv_Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nobetci_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih_dgv;
        private System.Windows.Forms.Button btn_SetExcel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chc_Degisim;
        private System.Windows.Forms.MaskedTextBox txt_Telefon;
    }
}

