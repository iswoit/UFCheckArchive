﻿namespace UFCheckArchive
{
    partial class UFCheckArchiveView
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbProgramStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIsCheckPassed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.lbNow = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rbOtherDay = new System.Windows.Forms.RadioButton();
            this.rbToday = new System.Windows.Forms.RadioButton();
            this.lvCheckList = new UFCheckArchive.DoubleBufferListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(711, 314);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 37);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "检查";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbProgramStatus
            // 
            this.lbProgramStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProgramStatus.AutoSize = true;
            this.lbProgramStatus.Location = new System.Drawing.Point(632, 314);
            this.lbProgramStatus.Name = "lbProgramStatus";
            this.lbProgramStatus.Size = new System.Drawing.Size(41, 12);
            this.lbProgramStatus.TabIndex = 14;
            this.lbProgramStatus.Text = "未运行";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "运行状态:";
            // 
            // lbIsCheckPassed
            // 
            this.lbIsCheckPassed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIsCheckPassed.AutoSize = true;
            this.lbIsCheckPassed.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbIsCheckPassed.Location = new System.Drawing.Point(631, 336);
            this.lbIsCheckPassed.Name = "lbIsCheckPassed";
            this.lbIsCheckPassed.Size = new System.Drawing.Size(35, 16);
            this.lbIsCheckPassed.TabIndex = 12;
            this.lbIsCheckPassed.Text = "N/A";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "检查是否通过:";
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // lbNow
            // 
            this.lbNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNow.AutoSize = true;
            this.lbNow.Location = new System.Drawing.Point(60, 19);
            this.lbNow.Name = "lbNow";
            this.lbNow.Size = new System.Drawing.Size(23, 12);
            this.lbNow.TabIndex = 16;
            this.lbNow.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.lbNow);
            this.groupBox1.Controls.Add(this.rbOtherDay);
            this.groupBox1.Controls.Add(this.rbToday);
            this.groupBox1.Location = new System.Drawing.Point(12, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 66);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检查日期";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(61, 38);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(122, 21);
            this.dtpDate.TabIndex = 2;
            // 
            // rbOtherDay
            // 
            this.rbOtherDay.AutoSize = true;
            this.rbOtherDay.Location = new System.Drawing.Point(7, 44);
            this.rbOtherDay.Name = "rbOtherDay";
            this.rbOtherDay.Size = new System.Drawing.Size(47, 16);
            this.rbOtherDay.TabIndex = 1;
            this.rbOtherDay.Text = "过点";
            this.rbOtherDay.UseVisualStyleBackColor = true;
            this.rbOtherDay.CheckedChanged += new System.EventHandler(this.rbDate_CheckedChanged);
            // 
            // rbToday
            // 
            this.rbToday.AutoSize = true;
            this.rbToday.Location = new System.Drawing.Point(7, 19);
            this.rbToday.Name = "rbToday";
            this.rbToday.Size = new System.Drawing.Size(47, 16);
            this.rbToday.TabIndex = 0;
            this.rbToday.Text = "当日";
            this.rbToday.UseVisualStyleBackColor = true;
            this.rbToday.CheckedChanged += new System.EventHandler(this.rbDate_CheckedChanged);
            // 
            // lvCheckList
            // 
            this.lvCheckList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader8});
            this.lvCheckList.FullRowSelect = true;
            this.lvCheckList.GridLines = true;
            this.lvCheckList.Location = new System.Drawing.Point(12, 12);
            this.lvCheckList.MultiSelect = false;
            this.lvCheckList.Name = "lvCheckList";
            this.lvCheckList.Size = new System.Drawing.Size(774, 277);
            this.lvCheckList.TabIndex = 1;
            this.lvCheckList.UseCompatibleStateImageBehavior = false;
            this.lvCheckList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "检查项";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "当前表";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "记录数";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 61;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "历史表";
            this.columnHeader6.Width = 67;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "记录数";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "通过检查";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "说明";
            this.columnHeader8.Width = 261;
            // 
            // UFCheckArchiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 367);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbProgramStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbIsCheckPassed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lvCheckList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UFCheckArchiveView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UF经营数据归历史情况确认";
            this.Load += new System.EventHandler(this.UFCheckView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private UFCheckArchive.DoubleBufferListView lvCheckList;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbProgramStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIsCheckPassed;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.Label lbNow;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbToday;
        private System.Windows.Forms.RadioButton rbOtherDay;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

