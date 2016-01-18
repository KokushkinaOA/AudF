namespace client
{
    partial class osn
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(osn));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dob_aud = new System.Windows.Forms.Button();
            this.DGW_au = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_ob = new System.Windows.Forms.Button();
            this.DGW_ob = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.add_rem = new System.Windows.Forms.Button();
            this.DGW_remont = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.redact = new System.Windows.Forms.DataGridViewImageColumn();
            this.Del = new System.Windows.Forms.DataGridViewImageColumn();
            this.redact_ob = new System.Windows.Forms.DataGridViewImageColumn();
            this.del_ob = new System.Windows.Forms.DataGridViewImageColumn();
            this.redact_rem = new System.Windows.Forms.DataGridViewImageColumn();
            this.del_rem = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.kriterii_otcheta = new System.Windows.Forms.ComboBox();
            this.tip_diagrammi = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.Postroenie_otcheta = new System.Windows.Forms.Button();
            this.dGV_otchet = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exp_rem = new System.Windows.Forms.Button();
            this.exp_ob = new System.Windows.Forms.Button();
            this.exp_aud = new System.Windows.Forms.Button();
            this.saveExcel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_au)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_ob)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_remont)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_otchet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dob_aud
            // 
            this.dob_aud.Location = new System.Drawing.Point(7, 6);
            this.dob_aud.Name = "dob_aud";
            this.dob_aud.Size = new System.Drawing.Size(75, 23);
            this.dob_aud.TabIndex = 0;
            this.dob_aud.Text = "Добавить";
            this.dob_aud.UseVisualStyleBackColor = true;
            this.dob_aud.Click += new System.EventHandler(this.dob_aud_Click);
            // 
            // DGW_au
            // 
            this.DGW_au.AllowUserToAddRows = false;
            this.DGW_au.BackgroundColor = System.Drawing.Color.LightGreen;
            this.DGW_au.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_au.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.redact,
            this.Del});
            this.DGW_au.Location = new System.Drawing.Point(3, 51);
            this.DGW_au.Name = "DGW_au";
            this.DGW_au.Size = new System.Drawing.Size(1181, 386);
            this.DGW_au.TabIndex = 3;
            this.DGW_au.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_au_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1199, 471);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.exp_aud);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DGW_au);
            this.tabPage1.Controls.Add(this.dob_aud);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1191, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Аудитории";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.exp_ob);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.add_ob);
            this.tabPage2.Controls.Add(this.DGW_ob);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1191, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оборудование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // add_ob
            // 
            this.add_ob.Location = new System.Drawing.Point(7, 6);
            this.add_ob.Name = "add_ob";
            this.add_ob.Size = new System.Drawing.Size(75, 23);
            this.add_ob.TabIndex = 1;
            this.add_ob.Text = "Добавить";
            this.add_ob.UseVisualStyleBackColor = true;
            this.add_ob.Click += new System.EventHandler(this.add_ob_Click);
            // 
            // DGW_ob
            // 
            this.DGW_ob.AllowUserToAddRows = false;
            this.DGW_ob.BackgroundColor = System.Drawing.Color.LightGreen;
            this.DGW_ob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_ob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.redact_ob,
            this.del_ob});
            this.DGW_ob.Location = new System.Drawing.Point(3, 48);
            this.DGW_ob.Name = "DGW_ob";
            this.DGW_ob.Size = new System.Drawing.Size(1181, 394);
            this.DGW_ob.TabIndex = 0;
            this.DGW_ob.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_ob_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.exp_rem);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.add_rem);
            this.tabPage3.Controls.Add(this.DGW_remont);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1191, 445);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ремонт";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // add_rem
            // 
            this.add_rem.Location = new System.Drawing.Point(7, 8);
            this.add_rem.Name = "add_rem";
            this.add_rem.Size = new System.Drawing.Size(75, 23);
            this.add_rem.TabIndex = 1;
            this.add_rem.Text = "Добавить";
            this.add_rem.UseVisualStyleBackColor = true;
            this.add_rem.Click += new System.EventHandler(this.add_rem_Click);
            // 
            // DGW_remont
            // 
            this.DGW_remont.AllowUserToAddRows = false;
            this.DGW_remont.BackgroundColor = System.Drawing.Color.LightGreen;
            this.DGW_remont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_remont.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.redact_rem,
            this.del_rem});
            this.DGW_remont.Location = new System.Drawing.Point(0, 50);
            this.DGW_remont.Name = "DGW_remont";
            this.DGW_remont.Size = new System.Drawing.Size(1184, 392);
            this.DGW_remont.TabIndex = 0;
            this.DGW_remont.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_remont_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Редактирование";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Удаление";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Редактирование";
            this.dataGridViewImageColumn3.Image = global::client.Properties.Resources.edit_notes;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Удаление";
            this.dataGridViewImageColumn4.Image = global::client.Properties.Resources.del;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            // 
            // redact
            // 
            this.redact.HeaderText = "Редактирование";
            this.redact.Image = ((System.Drawing.Image)(resources.GetObject("redact.Image")));
            this.redact.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.redact.Name = "redact";
            // 
            // Del
            // 
            this.Del.HeaderText = "Удаление";
            this.Del.Image = ((System.Drawing.Image)(resources.GetObject("Del.Image")));
            this.Del.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Del.Name = "Del";
            // 
            // redact_ob
            // 
            this.redact_ob.HeaderText = "Редактирование";
            this.redact_ob.Image = global::client.Properties.Resources.edit_notes;
            this.redact_ob.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.redact_ob.Name = "redact_ob";
            // 
            // del_ob
            // 
            this.del_ob.HeaderText = "Удаление";
            this.del_ob.Image = global::client.Properties.Resources.del;
            this.del_ob.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.del_ob.Name = "del_ob";
            // 
            // redact_rem
            // 
            this.redact_rem.HeaderText = "Редактирование";
            this.redact_rem.Image = global::client.Properties.Resources.edit_notes;
            this.redact_rem.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.redact_rem.Name = "redact_rem";
            this.redact_rem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.redact_rem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // del_rem
            // 
            this.del_rem.HeaderText = "Удаление";
            this.del_rem.Image = global::client.Properties.Resources.del;
            this.del_rem.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.del_rem.Name = "del_rem";
            this.del_rem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.del_rem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.dGV_otchet);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1191, 445);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Отчеты";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // kriterii_otcheta
            // 
            this.kriterii_otcheta.FormattingEnabled = true;
            this.kriterii_otcheta.Items.AddRange(new object[] {
            "Подразделение",
            "Оборудование",
            "Ответственное лицо",
            "Подрядная организация"});
            this.kriterii_otcheta.Location = new System.Drawing.Point(119, 18);
            this.kriterii_otcheta.Name = "kriterii_otcheta";
            this.kriterii_otcheta.Size = new System.Drawing.Size(184, 24);
            this.kriterii_otcheta.TabIndex = 5;
            this.kriterii_otcheta.Text = "Подразделение";
            // 
            // tip_diagrammi
            // 
            this.tip_diagrammi.FormattingEnabled = true;
            this.tip_diagrammi.Items.AddRange(new object[] {
            "Круговая",
            "Столбчатая"});
            this.tip_diagrammi.Location = new System.Drawing.Point(119, 43);
            this.tip_diagrammi.Name = "tip_diagrammi";
            this.tip_diagrammi.Size = new System.Drawing.Size(184, 24);
            this.tip_diagrammi.TabIndex = 4;
            this.tip_diagrammi.Text = "Круговая";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Lavender;
            this.groupBox5.Controls.Add(this.kriterii_otcheta);
            this.groupBox5.Controls.Add(this.tip_diagrammi);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.Postroenie_otcheta);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(0, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1159, 73);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Построение отчета";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(6, 47);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Тип диаграммы";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.Location = new System.Drawing.Point(6, 23);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(107, 13);
            this.label36.TabIndex = 2;
            this.label36.Text = "Основной критерий";
            // 
            // Postroenie_otcheta
            // 
            this.Postroenie_otcheta.Location = new System.Drawing.Point(989, 40);
            this.Postroenie_otcheta.Name = "Postroenie_otcheta";
            this.Postroenie_otcheta.Size = new System.Drawing.Size(91, 27);
            this.Postroenie_otcheta.TabIndex = 0;
            this.Postroenie_otcheta.Text = "Построить";
            this.Postroenie_otcheta.UseVisualStyleBackColor = true;
            this.Postroenie_otcheta.Click += new System.EventHandler(this.Postroenie_otcheta_Click);
            // 
            // dGV_otchet
            // 
            this.dGV_otchet.AllowUserToAddRows = false;
            this.dGV_otchet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_otchet.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dGV_otchet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_otchet.Location = new System.Drawing.Point(607, 82);
            this.dGV_otchet.Name = "dGV_otchet";
            this.dGV_otchet.Size = new System.Drawing.Size(577, 355);
            this.dGV_otchet.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(6, 82);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(595, 355);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // exp_rem
            // 
            this.exp_rem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exp_rem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exp_rem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.exp_rem.Location = new System.Drawing.Point(102, 8);
            this.exp_rem.Name = "exp_rem";
            this.exp_rem.Size = new System.Drawing.Size(76, 22);
            this.exp_rem.TabIndex = 14;
            this.exp_rem.Text = "Экспорт";
            this.exp_rem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exp_rem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exp_rem.UseVisualStyleBackColor = true;
            this.exp_rem.Click += new System.EventHandler(this.exp_rem_Click);
            // 
            // exp_ob
            // 
            this.exp_ob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exp_ob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exp_ob.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.exp_ob.Location = new System.Drawing.Point(88, 7);
            this.exp_ob.Name = "exp_ob";
            this.exp_ob.Size = new System.Drawing.Size(76, 22);
            this.exp_ob.TabIndex = 15;
            this.exp_ob.Text = "Экспорт";
            this.exp_ob.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exp_ob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exp_ob.UseVisualStyleBackColor = true;
            this.exp_ob.Click += new System.EventHandler(this.exp_ob_Click);
            // 
            // exp_aud
            // 
            this.exp_aud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exp_aud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exp_aud.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.exp_aud.Location = new System.Drawing.Point(99, 7);
            this.exp_aud.Name = "exp_aud";
            this.exp_aud.Size = new System.Drawing.Size(76, 22);
            this.exp_aud.TabIndex = 15;
            this.exp_aud.Text = "Экспорт";
            this.exp_aud.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exp_aud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exp_aud.UseVisualStyleBackColor = true;
            this.exp_aud.Click += new System.EventHandler(this.exp_aud_Click);
            // 
            // osn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 473);
            this.Controls.Add(this.tabControl1);
            this.Name = "osn";
            this.Text = "Аудиторный фонд университета";
            this.Load += new System.EventHandler(this.osn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_au)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_ob)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_remont)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_otchet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dob_aud;
        private System.Windows.Forms.DataGridView DGW_au;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGW_ob;
        private System.Windows.Forms.DataGridView DGW_remont;
        private System.Windows.Forms.DataGridViewImageColumn redact;
        private System.Windows.Forms.DataGridViewImageColumn Del;
        private System.Windows.Forms.Button add_ob;
        private System.Windows.Forms.Button add_rem;
        private System.Windows.Forms.DataGridViewImageColumn redact_ob;
        private System.Windows.Forms.DataGridViewImageColumn del_ob;
        private System.Windows.Forms.DataGridViewImageColumn redact_rem;
        private System.Windows.Forms.DataGridViewImageColumn del_rem;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox kriterii_otcheta;
        private System.Windows.Forms.ComboBox tip_diagrammi;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button Postroenie_otcheta;
        private System.Windows.Forms.DataGridView dGV_otchet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exp_aud;
        private System.Windows.Forms.Button exp_ob;
        private System.Windows.Forms.Button exp_rem;
        private System.Windows.Forms.SaveFileDialog saveExcel;
    }
}

