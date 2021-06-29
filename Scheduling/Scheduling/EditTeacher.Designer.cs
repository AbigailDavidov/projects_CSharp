namespace Scheduling
{
    partial class EditTeacher
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
            this.NotPosibleHourGB = new System.Windows.Forms.GroupBox();
            this.imposibleHoursDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HourCB = new System.Windows.Forms.ComboBox();
            this.DayCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RemoveRowBTN = new System.Windows.Forms.Button();
            this.InfoGB = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.NotPosibleHourGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imposibleHoursDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.InfoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // NotPosibleHourGB
            // 
            this.NotPosibleHourGB.BackColor = System.Drawing.Color.PeachPuff;
            this.NotPosibleHourGB.Controls.Add(this.imposibleHoursDGV);
            this.NotPosibleHourGB.Controls.Add(this.groupBox1);
            this.NotPosibleHourGB.Controls.Add(this.label9);
            this.NotPosibleHourGB.Controls.Add(this.RemoveRowBTN);
            this.NotPosibleHourGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NotPosibleHourGB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NotPosibleHourGB.Location = new System.Drawing.Point(999, 109);
            this.NotPosibleHourGB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NotPosibleHourGB.Name = "NotPosibleHourGB";
            this.NotPosibleHourGB.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NotPosibleHourGB.Size = new System.Drawing.Size(1486, 1237);
            this.NotPosibleHourGB.TabIndex = 28;
            this.NotPosibleHourGB.TabStop = false;
            this.NotPosibleHourGB.Text = "עריכת שעות";
            // 
            // imposibleHoursDGV
            // 
            this.imposibleHoursDGV.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.imposibleHoursDGV.ColumnHeadersHeight = 30;
            this.imposibleHoursDGV.Location = new System.Drawing.Point(372, 232);
            this.imposibleHoursDGV.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.imposibleHoursDGV.Name = "imposibleHoursDGV";
            this.imposibleHoursDGV.RowHeadersWidth = 50;
            this.imposibleHoursDGV.Size = new System.Drawing.Size(938, 535);
            this.imposibleHoursDGV.TabIndex = 22;
            this.imposibleHoursDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.imposibleHoursDGV_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.HourCB);
            this.groupBox1.Controls.Add(this.DayCB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddBTN);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(372, 835);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(976, 377);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "להוספת שעה בלתי אפשרית";
            // 
            // HourCB
            // 
            this.HourCB.FormattingEnabled = true;
            this.HourCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.HourCB.Location = new System.Drawing.Point(346, 260);
            this.HourCB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.HourCB.Name = "HourCB";
            this.HourCB.Size = new System.Drawing.Size(121, 84);
            this.HourCB.TabIndex = 35;
            // 
            // DayCB
            // 
            this.DayCB.FormattingEnabled = true;
            this.DayCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.DayCB.Location = new System.Drawing.Point(346, 133);
            this.DayCB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DayCB.Name = "DayCB";
            this.DayCB.Size = new System.Drawing.Size(121, 84);
            this.DayCB.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(490, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 69);
            this.label4.TabIndex = 33;
            this.label4.Text = "שעה ביום";
            // 
            // AddBTN
            // 
            this.AddBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AddBTN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddBTN.Location = new System.Drawing.Point(92, 187);
            this.AddBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(215, 91);
            this.AddBTN.TabIndex = 31;
            this.AddBTN.Text = "הוסף שורה";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(325, 1025);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 62);
            this.button2.TabIndex = 26;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(490, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 69);
            this.label5.TabIndex = 32;
            this.label5.Text = "יום בשבוע";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(402, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(758, 61);
            this.label9.TabIndex = 26;
            this.label9.Text = "שעות בלתי אפשרויות עבור המורה";
            // 
            // RemoveRowBTN
            // 
            this.RemoveRowBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.RemoveRowBTN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RemoveRowBTN.Location = new System.Drawing.Point(75, 350);
            this.RemoveRowBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RemoveRowBTN.Name = "RemoveRowBTN";
            this.RemoveRowBTN.Size = new System.Drawing.Size(213, 98);
            this.RemoveRowBTN.TabIndex = 28;
            this.RemoveRowBTN.Text = "מחק שורה";
            this.RemoveRowBTN.UseVisualStyleBackColor = true;
            this.RemoveRowBTN.Click += new System.EventHandler(this.RemoveRowBTN_Click_1);
            // 
            // InfoGB
            // 
            this.InfoGB.BackColor = System.Drawing.Color.PeachPuff;
            this.InfoGB.Controls.Add(this.button1);
            this.InfoGB.Controls.Add(this.FirstNameTB);
            this.InfoGB.Controls.Add(this.label1);
            this.InfoGB.Controls.Add(this.label2);
            this.InfoGB.Controls.Add(this.LastNameTB);
            this.InfoGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.InfoGB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.InfoGB.Location = new System.Drawing.Point(93, 109);
            this.InfoGB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.InfoGB.Name = "InfoGB";
            this.InfoGB.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.InfoGB.Size = new System.Drawing.Size(848, 639);
            this.InfoGB.TabIndex = 27;
            this.InfoGB.TabStop = false;
            this.InfoGB.Text = "עריכת מורה";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(325, 1025);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 62);
            this.button1.TabIndex = 26;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FirstNameTB.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FirstNameTB.Location = new System.Drawing.Point(77, 232);
            this.FirstNameTB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(333, 67);
            this.FirstNameTB.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(524, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 61);
            this.label1.TabIndex = 11;
            this.label1.Text = "שם פרטי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(469, 387);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 61);
            this.label2.TabIndex = 13;
            this.label2.Text = "שם משפחה";
            // 
            // LastNameTB
            // 
            this.LastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LastNameTB.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LastNameTB.Location = new System.Drawing.Point(77, 387);
            this.LastNameTB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(322, 67);
            this.LastNameTB.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(296, 900);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 148);
            this.button3.TabIndex = 36;
            this.button3.Text = "עדכן";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(2597, 1459);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NotPosibleHourGB);
            this.Controls.Add(this.InfoGB);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "EditTeacher";
            this.Text = "EditTeacher";
            this.Load += new System.EventHandler(this.EditTeacher_Load);
            this.NotPosibleHourGB.ResumeLayout(false);
            this.NotPosibleHourGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imposibleHoursDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.InfoGB.ResumeLayout(false);
            this.InfoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NotPosibleHourGB;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button RemoveRowBTN;
        private System.Windows.Forms.DataGridView imposibleHoursDGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox InfoGB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox HourCB;
        private System.Windows.Forms.ComboBox DayCB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}