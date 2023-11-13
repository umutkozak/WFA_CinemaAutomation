namespace WFA_CinemaAutomation
{
    partial class ReservationForm
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
            label1=new Label();
            label2=new Label();
            label3=new Label();
            txtSurnameName=new TextBox();
            txtSocialSecurityNo=new TextBox();
            rdbFemale=new RadioButton();
            rdbMale=new RadioButton();
            btnCancel=new Button();
            btnSave=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor=SystemColors.AppWorkspace;
            label1.Font=new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(12, 9);
            label1.Name="label1";
            label1.Size=new Size(519, 76);
            label1.TabIndex=0;
            label1.Text="Reservation Board";
            label1.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(12, 130);
            label2.Name="label2";
            label2.Size=new Size(110, 20);
            label2.TabIndex=1;
            label2.Text="Surname,Name";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(12, 192);
            label3.Name="label3";
            label3.Size=new Size(129, 20);
            label3.TabIndex=1;
            label3.Text="Social Security No";
            // 
            // txtSurnameName
            // 
            txtSurnameName.Location=new Point(142, 127);
            txtSurnameName.Name="txtSurnameName";
            txtSurnameName.Size=new Size(262, 27);
            txtSurnameName.TabIndex=2;
            // 
            // txtSocialSecurityNo
            // 
            txtSocialSecurityNo.Location=new Point(142, 189);
            txtSocialSecurityNo.Name="txtSocialSecurityNo";
            txtSocialSecurityNo.Size=new Size(262, 27);
            txtSocialSecurityNo.TabIndex=2;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize=true;
            rdbFemale.Location=new Point(423, 127);
            rdbFemale.Name="rdbFemale";
            rdbFemale.Size=new Size(78, 24);
            rdbFemale.TabIndex=3;
            rdbFemale.TabStop=true;
            rdbFemale.Text="Female";
            rdbFemale.UseVisualStyleBackColor=true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize=true;
            rdbMale.Location=new Point(423, 188);
            rdbMale.Name="rdbMale";
            rdbMale.Size=new Size(63, 24);
            rdbMale.TabIndex=3;
            rdbMale.TabStop=true;
            rdbMale.Text="Male";
            rdbMale.UseVisualStyleBackColor=true;
            // 
            // btnCancel
            // 
            btnCancel.Location=new Point(320, 248);
            btnCancel.Name="btnCancel";
            btnCancel.Size=new Size(94, 29);
            btnCancel.TabIndex=4;
            btnCancel.Text="Cancel";
            btnCancel.UseVisualStyleBackColor=true;
            btnCancel.Click+=btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location=new Point(437, 248);
            btnSave.Name="btnSave";
            btnSave.Size=new Size(94, 29);
            btnSave.TabIndex=4;
            btnSave.Text="Save";
            btnSave.UseVisualStyleBackColor=true;
            btnSave.Click+=btnSave_Click;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(543, 289);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(rdbMale);
            Controls.Add(rdbFemale);
            Controls.Add(txtSocialSecurityNo);
            Controls.Add(txtSurnameName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="ReservationForm";
            Text="ReservationForm";
            Load+=ReservationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSurnameName;
        private TextBox txtSocialSecurityNo;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private Button btnCancel;
        private Button btnSave;
    }
}