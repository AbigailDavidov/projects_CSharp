namespace Scheduling
{
    partial class Day
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
            this.DayNamelable = new System.Windows.Forms.Label();
            this.AddBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DayNamelable
            // 
            this.DayNamelable.AutoSize = true;
            this.DayNamelable.BackColor = System.Drawing.Color.PeachPuff;
            this.DayNamelable.Font = new System.Drawing.Font("Fb Noga", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayNamelable.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DayNamelable.Location = new System.Drawing.Point(57, 15);
            this.DayNamelable.Name = "DayNamelable";
            this.DayNamelable.Size = new System.Drawing.Size(45, 25);
            this.DayNamelable.TabIndex = 3;
            this.DayNamelable.Text = "יום";
            // 
            // AddBTN
            // 
            this.AddBTN.BackColor = System.Drawing.Color.Linen;
            this.AddBTN.Font = new System.Drawing.Font("Fb Noga", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBTN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddBTN.Location = new System.Drawing.Point(16, 52);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(120, 31);
            this.AddBTN.TabIndex = 2;
            this.AddBTN.Text = "הוספת שיעור";
            this.AddBTN.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DayNamelable);
            this.Controls.Add(this.AddBTN);
            this.Name = "Day";
            this.Size = new System.Drawing.Size(150, 436);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DayNamelable;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button button1;
    }
}
