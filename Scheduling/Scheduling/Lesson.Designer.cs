namespace Scheduling
{
    partial class Lesson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveBTN = new System.Windows.Forms.Button();
            this.AmountCB = new System.Windows.Forms.ComboBox();
            this.SubjectCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.Color.PeachPuff;
            this.SaveBTN.Location = new System.Drawing.Point(25, 70);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(104, 23);
            this.SaveBTN.TabIndex = 5;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // AmountCB
            // 
            this.AmountCB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AmountCB.FormattingEnabled = true;
            this.AmountCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.AmountCB.Location = new System.Drawing.Point(43, 44);
            this.AmountCB.Name = "AmountCB";
            this.AmountCB.Size = new System.Drawing.Size(68, 21);
            this.AmountCB.TabIndex = 4;
            // 
            // SubjectCB
            // 
            this.SubjectCB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SubjectCB.FormattingEnabled = true;
            this.SubjectCB.Location = new System.Drawing.Point(25, 18);
            this.SubjectCB.Name = "SubjectCB";
            this.SubjectCB.Size = new System.Drawing.Size(104, 21);
            this.SubjectCB.TabIndex = 3;
            // 
            // Lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.AmountCB);
            this.Controls.Add(this.SubjectCB);
            this.Name = "Lesson";
            this.Size = new System.Drawing.Size(150, 106);
            this.Load += new System.EventHandler(this.Lesson_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.ComboBox AmountCB;
        private System.Windows.Forms.ComboBox SubjectCB;
    }
}
