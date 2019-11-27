namespace IntroToArrayTaishaun
{
    partial class FrmArray
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lstAverageNum = new System.Windows.Forms.ListBox();
            this.btnCalAverage = new System.Windows.Forms.Button();
            this.lblDisAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(348, 47);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lstAverageNum
            // 
            this.lstAverageNum.FormattingEnabled = true;
            this.lstAverageNum.Location = new System.Drawing.Point(254, 87);
            this.lstAverageNum.Name = "lstAverageNum";
            this.lstAverageNum.Size = new System.Drawing.Size(289, 277);
            this.lstAverageNum.TabIndex = 1;
            // 
            // btnCalAverage
            // 
            this.btnCalAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalAverage.Location = new System.Drawing.Point(172, 386);
            this.btnCalAverage.Name = "btnCalAverage";
            this.btnCalAverage.Size = new System.Drawing.Size(228, 37);
            this.btnCalAverage.TabIndex = 2;
            this.btnCalAverage.Text = "Calculate Average";
            this.btnCalAverage.UseVisualStyleBackColor = true;
            // 
            // lblDisAverage
            // 
            this.lblDisAverage.AutoSize = true;
            this.lblDisAverage.Location = new System.Drawing.Point(507, 409);
            this.lblDisAverage.Name = "lblDisAverage";
            this.lblDisAverage.Size = new System.Drawing.Size(38, 13);
            this.lblDisAverage.TabIndex = 3;
            this.lblDisAverage.Text = "label 1";
            // 
            // FrmArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisAverage);
            this.Controls.Add(this.btnCalAverage);
            this.Controls.Add(this.lstAverageNum);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmArray";
            this.Text = "Introduction to Array by Taishaun.J";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstAverageNum;
        private System.Windows.Forms.Button btnCalAverage;
        private System.Windows.Forms.Label lblDisAverage;
    }
}

