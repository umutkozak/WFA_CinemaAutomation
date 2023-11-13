namespace WFA_CinemaAutomation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            panel1=new Panel();
            btnReport=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=SystemColors.ActiveCaption;
            label1.Font=new Font("Segoe UI Semibold", 18F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor=SystemColors.ActiveCaptionText;
            label1.Location=new Point(433, -1);
            label1.Name="label1";
            label1.Size=new Size(291, 41);
            label1.TabIndex=0;
            label1.Text="Cinema Automation";
            // 
            // panel1
            // 
            panel1.Location=new Point(3, 57);
            panel1.Name="panel1";
            panel1.Size=new Size(1144, 401);
            panel1.TabIndex=1;
            // 
            // btnReport
            // 
            btnReport.Location=new Point(981, 464);
            btnReport.Name="btnReport";
            btnReport.Size=new Size(166, 29);
            btnReport.TabIndex=2;
            btnReport.Text="Report";
            btnReport.UseVisualStyleBackColor=true;
            btnReport.Click+=btnReport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1159, 497);
            Controls.Add(btnReport);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnReport;
    }
}