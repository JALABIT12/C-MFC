
namespace myNotepad
{
    partial class Form2
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSpeed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.rbCom1 = new System.Windows.Forms.RadioButton();
            this.rbCom2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDatabit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStopbit = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(199, 333);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(122, 38);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(345, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 38);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(45, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Speed";
            // 
            // cbSpeed
            // 
            this.cbSpeed.FormattingEnabled = true;
            this.cbSpeed.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbSpeed.Location = new System.Drawing.Point(116, 123);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Size = new System.Drawing.Size(342, 26);
            this.cbSpeed.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(55, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parity";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "   none",
            "   odd",
            "   even"});
            this.cbParity.Location = new System.Drawing.Point(116, 170);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(342, 26);
            this.cbParity.TabIndex = 2;
            // 
            // rbCom1
            // 
            this.rbCom1.AutoSize = true;
            this.rbCom1.Checked = true;
            this.rbCom1.Location = new System.Drawing.Point(156, 27);
            this.rbCom1.Name = "rbCom1";
            this.rbCom1.Size = new System.Drawing.Size(83, 22);
            this.rbCom1.TabIndex = 3;
            this.rbCom1.TabStop = true;
            this.rbCom1.Text = "COM1";
            this.rbCom1.UseVisualStyleBackColor = true;
            // 
            // rbCom2
            // 
            this.rbCom2.AutoSize = true;
            this.rbCom2.Location = new System.Drawing.Point(302, 27);
            this.rbCom2.Name = "rbCom2";
            this.rbCom2.Size = new System.Drawing.Size(83, 22);
            this.rbCom2.TabIndex = 3;
            this.rbCom2.Text = "COM2";
            this.rbCom2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCom1);
            this.groupBox1.Controls.Add(this.rbCom2);
            this.groupBox1.Location = new System.Drawing.Point(43, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(41, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "DataBit";
            // 
            // cbDatabit
            // 
            this.cbDatabit.FormattingEnabled = true;
            this.cbDatabit.Items.AddRange(new object[] {
            "8",
            "7"});
            this.cbDatabit.Location = new System.Drawing.Point(116, 221);
            this.cbDatabit.Name = "cbDatabit";
            this.cbDatabit.Size = new System.Drawing.Size(342, 26);
            this.cbDatabit.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(39, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "StopBit";
            // 
            // cbStopbit
            // 
            this.cbStopbit.FormattingEnabled = true;
            this.cbStopbit.Location = new System.Drawing.Point(116, 266);
            this.cbStopbit.Name = "cbStopbit";
            this.cbStopbit.Size = new System.Drawing.Size(342, 26);
            this.cbStopbit.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbStopbit);
            this.Controls.Add(this.cbDatabit);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "ComPort Config";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbParity;
        public System.Windows.Forms.ComboBox cbDatabit;
        public System.Windows.Forms.ComboBox cbStopbit;
        public System.Windows.Forms.RadioButton rbCom1;
        public System.Windows.Forms.RadioButton rbCom2;
    }
}