namespace client
{
    partial class dob_ob
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
            this.otv_l = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateSpis = new System.Windows.Forms.DateTimePicker();
            this.dateUst = new System.Windows.Forms.DateTimePicker();
            this.otm = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.naz_ob = new System.Windows.Forms.ComboBox();
            this.stoim = new System.Windows.Forms.TextBox();
            this.inv_N = new System.Windows.Forms.TextBox();
            this.N_a = new System.Windows.Forms.TextBox();
            this.ko = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otv_l
            // 
            this.otv_l.DisplayMember = "FIO";
            this.otv_l.FormattingEnabled = true;
            this.otv_l.Location = new System.Drawing.Point(129, 141);
            this.otv_l.Name = "otv_l";
            this.otv_l.Size = new System.Drawing.Size(149, 21);
            this.otv_l.TabIndex = 77;
            this.otv_l.ValueMember = "Id_chela";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Ответственное лицо";
            // 
            // dateSpis
            // 
            this.dateSpis.CustomFormat = "ddMMMMyyyy";
            this.dateSpis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSpis.Location = new System.Drawing.Point(129, 195);
            this.dateSpis.Name = "dateSpis";
            this.dateSpis.Size = new System.Drawing.Size(149, 20);
            this.dateSpis.TabIndex = 73;
            this.dateSpis.MouseEnter += new System.EventHandler(this.dateSpis_MouseEnter);
            // 
            // dateUst
            // 
            this.dateUst.CustomFormat = "ddMMMMyyyy";
            this.dateUst.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateUst.Location = new System.Drawing.Point(129, 168);
            this.dateUst.Name = "dateUst";
            this.dateUst.Size = new System.Drawing.Size(149, 20);
            this.dateUst.TabIndex = 72;
            this.dateUst.Value = new System.DateTime(2014, 5, 4, 0, 0, 0, 0);
            this.dateUst.MouseEnter += new System.EventHandler(this.dateUst_MouseEnter);
            // 
            // otm
            // 
            this.otm.Location = new System.Drawing.Point(203, 241);
            this.otm.Name = "otm";
            this.otm.Size = new System.Drawing.Size(75, 23);
            this.otm.TabIndex = 71;
            this.otm.Text = "Отмена";
            this.otm.UseVisualStyleBackColor = true;
            this.otm.Click += new System.EventHandler(this.otm_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(15, 241);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 70;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // naz_ob
            // 
            this.naz_ob.DisplayMember = "Nazvanie";
            this.naz_ob.FormattingEnabled = true;
            this.naz_ob.Location = new System.Drawing.Point(129, 90);
            this.naz_ob.Name = "naz_ob";
            this.naz_ob.Size = new System.Drawing.Size(149, 21);
            this.naz_ob.TabIndex = 69;
            this.naz_ob.ValueMember = "ID_oborudovania";
            // 
            // stoim
            // 
            this.stoim.Location = new System.Drawing.Point(129, 115);
            this.stoim.Name = "stoim";
            this.stoim.Size = new System.Drawing.Size(149, 20);
            this.stoim.TabIndex = 68;
            // 
            // inv_N
            // 
            this.inv_N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inv_N.Location = new System.Drawing.Point(129, 64);
            this.inv_N.Name = "inv_N";
            this.inv_N.Size = new System.Drawing.Size(149, 20);
            this.inv_N.TabIndex = 67;
            // 
            // N_a
            // 
            this.N_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.N_a.Location = new System.Drawing.Point(129, 12);
            this.N_a.Name = "N_a";
            this.N_a.Size = new System.Drawing.Size(149, 20);
            this.N_a.TabIndex = 66;
            // 
            // ko
            // 
            this.ko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ko.Location = new System.Drawing.Point(129, 38);
            this.ko.Name = "ko";
            this.ko.Size = new System.Drawing.Size(149, 20);
            this.ko.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Дата списания";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Дата установки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Название";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Инвентарный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "№ аудитории";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Корпус";
            // 
            // dob_ob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 291);
            this.Controls.Add(this.otv_l);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateSpis);
            this.Controls.Add(this.dateUst);
            this.Controls.Add(this.otm);
            this.Controls.Add(this.save);
            this.Controls.Add(this.naz_ob);
            this.Controls.Add(this.stoim);
            this.Controls.Add(this.inv_N);
            this.Controls.Add(this.N_a);
            this.Controls.Add(this.ko);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dob_ob";
            this.Text = "dob_ob";
            this.Load += new System.EventHandler(this.dob_ob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox otv_l;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateSpis;
        private System.Windows.Forms.DateTimePicker dateUst;
        private System.Windows.Forms.Button otm;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox naz_ob;
        private System.Windows.Forms.TextBox stoim;
        private System.Windows.Forms.TextBox inv_N;
        private System.Windows.Forms.TextBox N_a;
        private System.Windows.Forms.TextBox ko;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}