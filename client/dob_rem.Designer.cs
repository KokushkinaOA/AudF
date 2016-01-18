namespace client
{
    partial class dob_rem
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
            this.Podradnai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOkonchania = new System.Windows.Forms.DateTimePicker();
            this.dateNachala = new System.Windows.Forms.DateTimePicker();
            this.otm = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.vid_remonta = new System.Windows.Forms.ComboBox();
            this.stoim = new System.Windows.Forms.TextBox();
            this.N_smeti = new System.Windows.Forms.TextBox();
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
            // Podradnai
            // 
            this.Podradnai.DisplayMember = "Название";
            this.Podradnai.FormattingEnabled = true;
            this.Podradnai.Location = new System.Drawing.Point(129, 120);
            this.Podradnai.Name = "Podradnai";
            this.Podradnai.Size = new System.Drawing.Size(155, 21);
            this.Podradnai.TabIndex = 89;
            this.Podradnai.ValueMember = "Id_org";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 88;
            this.label3.Text = "Подрядная организация";
            // 
            // dateOkonchania
            // 
            this.dateOkonchania.Location = new System.Drawing.Point(129, 199);
            this.dateOkonchania.Name = "dateOkonchania";
            this.dateOkonchania.Size = new System.Drawing.Size(155, 20);
            this.dateOkonchania.TabIndex = 87;
            // 
            // dateNachala
            // 
            this.dateNachala.Location = new System.Drawing.Point(129, 172);
            this.dateNachala.Name = "dateNachala";
            this.dateNachala.Size = new System.Drawing.Size(155, 20);
            this.dateNachala.TabIndex = 86;
            // 
            // otm
            // 
            this.otm.Location = new System.Drawing.Point(209, 243);
            this.otm.Name = "otm";
            this.otm.Size = new System.Drawing.Size(75, 23);
            this.otm.TabIndex = 85;
            this.otm.Text = "Отмена";
            this.otm.UseVisualStyleBackColor = true;
            this.otm.Click += new System.EventHandler(this.otm_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(15, 243);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 84;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // vid_remonta
            // 
            this.vid_remonta.DisplayMember = "Nazvanie_remonta";
            this.vid_remonta.FormattingEnabled = true;
            this.vid_remonta.Location = new System.Drawing.Point(129, 93);
            this.vid_remonta.Name = "vid_remonta";
            this.vid_remonta.Size = new System.Drawing.Size(155, 21);
            this.vid_remonta.TabIndex = 83;
            this.vid_remonta.ValueMember = "ID_remonta";
            // 
            // stoim
            // 
            this.stoim.Location = new System.Drawing.Point(129, 146);
            this.stoim.Name = "stoim";
            this.stoim.Size = new System.Drawing.Size(155, 20);
            this.stoim.TabIndex = 82;
            // 
            // N_smeti
            // 
            this.N_smeti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.N_smeti.Location = new System.Drawing.Point(129, 67);
            this.N_smeti.Name = "N_smeti";
            this.N_smeti.Size = new System.Drawing.Size(155, 20);
            this.N_smeti.TabIndex = 81;
            // 
            // N_a
            // 
            this.N_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.N_a.Location = new System.Drawing.Point(129, 16);
            this.N_a.Name = "N_a";
            this.N_a.Size = new System.Drawing.Size(155, 20);
            this.N_a.TabIndex = 80;
            // 
            // ko
            // 
            this.ko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ko.Location = new System.Drawing.Point(129, 42);
            this.ko.Name = "ko";
            this.ko.Size = new System.Drawing.Size(155, 20);
            this.ko.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Дата окончания";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Дата начала";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Вид ремонта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "№ сметы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "№ аудитории";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Корпус";
            // 
            // dob_rem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 296);
            this.Controls.Add(this.Podradnai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateOkonchania);
            this.Controls.Add(this.dateNachala);
            this.Controls.Add(this.otm);
            this.Controls.Add(this.save);
            this.Controls.Add(this.vid_remonta);
            this.Controls.Add(this.stoim);
            this.Controls.Add(this.N_smeti);
            this.Controls.Add(this.N_a);
            this.Controls.Add(this.ko);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dob_rem";
            this.Text = "dob_rem";
            this.Load += new System.EventHandler(this.dob_rem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Podradnai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateOkonchania;
        private System.Windows.Forms.DateTimePicker dateNachala;
        private System.Windows.Forms.Button otm;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox vid_remonta;
        private System.Windows.Forms.TextBox stoim;
        private System.Windows.Forms.TextBox N_smeti;
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