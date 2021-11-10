
namespace CustomMessageBoxTest
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbSWarn = new System.Windows.Forms.RadioButton();
            this.rbSQ = new System.Windows.Forms.RadioButton();
            this.rbSInf = new System.Windows.Forms.RadioButton();
            this.rbSErr = new System.Windows.Forms.RadioButton();
            this.rbSCust = new System.Windows.Forms.RadioButton();
            this.rbSNone = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbIWarn = new System.Windows.Forms.RadioButton();
            this.rbIQ = new System.Windows.Forms.RadioButton();
            this.rbIInf = new System.Windows.Forms.RadioButton();
            this.rbIErr = new System.Windows.Forms.RadioButton();
            this.rbINone = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbARI = new System.Windows.Forms.RadioButton();
            this.rbYN = new System.Windows.Forms.RadioButton();
            this.rbOKC = new System.Windows.Forms.RadioButton();
            this.rbOK = new System.Windows.Forms.RadioButton();
            this.tTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tMsg = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cbParent = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblRes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tMsg);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.cbParent);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 273);
            this.panel1.TabIndex = 0;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(300, 245);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(19, 13);
            this.lblRes.TabIndex = 11;
            this.lblRes.Text = "<>";
            this.lblRes.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Result: ";
            this.label2.UseMnemonic = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(178, 240);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "T&est";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbSWarn);
            this.groupBox4.Controls.Add(this.rbSQ);
            this.groupBox4.Controls.Add(this.rbSInf);
            this.groupBox4.Controls.Add(this.rbSErr);
            this.groupBox4.Controls.Add(this.rbSCust);
            this.groupBox4.Controls.Add(this.rbSNone);
            this.groupBox4.Location = new System.Drawing.Point(6, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(437, 49);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "&Sound:";
            // 
            // rbSWarn
            // 
            this.rbSWarn.AutoSize = true;
            this.rbSWarn.Location = new System.Drawing.Point(338, 19);
            this.rbSWarn.Name = "rbSWarn";
            this.rbSWarn.Size = new System.Drawing.Size(65, 17);
            this.rbSWarn.TabIndex = 6;
            this.rbSWarn.Text = "Warning";
            this.rbSWarn.UseVisualStyleBackColor = true;
            // 
            // rbSQ
            // 
            this.rbSQ.AutoSize = true;
            this.rbSQ.Location = new System.Drawing.Point(265, 19);
            this.rbSQ.Name = "rbSQ";
            this.rbSQ.Size = new System.Drawing.Size(67, 17);
            this.rbSQ.TabIndex = 5;
            this.rbSQ.Text = "Question";
            this.rbSQ.UseVisualStyleBackColor = true;
            // 
            // rbSInf
            // 
            this.rbSInf.AutoSize = true;
            this.rbSInf.Location = new System.Drawing.Point(182, 19);
            this.rbSInf.Name = "rbSInf";
            this.rbSInf.Size = new System.Drawing.Size(77, 17);
            this.rbSInf.TabIndex = 4;
            this.rbSInf.Text = "Information";
            this.rbSInf.UseVisualStyleBackColor = true;
            // 
            // rbSErr
            // 
            this.rbSErr.AutoSize = true;
            this.rbSErr.Location = new System.Drawing.Point(129, 19);
            this.rbSErr.Name = "rbSErr";
            this.rbSErr.Size = new System.Drawing.Size(47, 17);
            this.rbSErr.TabIndex = 3;
            this.rbSErr.Text = "Error";
            this.rbSErr.UseVisualStyleBackColor = true;
            // 
            // rbSCust
            // 
            this.rbSCust.AutoSize = true;
            this.rbSCust.Location = new System.Drawing.Point(63, 19);
            this.rbSCust.Name = "rbSCust";
            this.rbSCust.Size = new System.Drawing.Size(60, 17);
            this.rbSCust.TabIndex = 1;
            this.rbSCust.Text = "Custom";
            this.rbSCust.UseVisualStyleBackColor = true;
            // 
            // rbSNone
            // 
            this.rbSNone.AutoSize = true;
            this.rbSNone.Checked = true;
            this.rbSNone.Location = new System.Drawing.Point(6, 19);
            this.rbSNone.Name = "rbSNone";
            this.rbSNone.Size = new System.Drawing.Size(51, 17);
            this.rbSNone.TabIndex = 0;
            this.rbSNone.TabStop = true;
            this.rbSNone.Text = "None";
            this.rbSNone.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbIWarn);
            this.groupBox3.Controls.Add(this.rbIQ);
            this.groupBox3.Controls.Add(this.rbIInf);
            this.groupBox3.Controls.Add(this.rbIErr);
            this.groupBox3.Controls.Add(this.rbINone);
            this.groupBox3.Location = new System.Drawing.Point(6, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 49);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "&Icon:";
            // 
            // rbIWarn
            // 
            this.rbIWarn.AutoSize = true;
            this.rbIWarn.Location = new System.Drawing.Point(272, 19);
            this.rbIWarn.Name = "rbIWarn";
            this.rbIWarn.Size = new System.Drawing.Size(65, 17);
            this.rbIWarn.TabIndex = 12;
            this.rbIWarn.Text = "Warning";
            this.rbIWarn.UseVisualStyleBackColor = true;
            // 
            // rbIQ
            // 
            this.rbIQ.AutoSize = true;
            this.rbIQ.Location = new System.Drawing.Point(199, 19);
            this.rbIQ.Name = "rbIQ";
            this.rbIQ.Size = new System.Drawing.Size(67, 17);
            this.rbIQ.TabIndex = 11;
            this.rbIQ.Text = "Question";
            this.rbIQ.UseVisualStyleBackColor = true;
            // 
            // rbIInf
            // 
            this.rbIInf.AutoSize = true;
            this.rbIInf.Location = new System.Drawing.Point(116, 19);
            this.rbIInf.Name = "rbIInf";
            this.rbIInf.Size = new System.Drawing.Size(77, 17);
            this.rbIInf.TabIndex = 10;
            this.rbIInf.Text = "Information";
            this.rbIInf.UseVisualStyleBackColor = true;
            // 
            // rbIErr
            // 
            this.rbIErr.AutoSize = true;
            this.rbIErr.Location = new System.Drawing.Point(63, 19);
            this.rbIErr.Name = "rbIErr";
            this.rbIErr.Size = new System.Drawing.Size(47, 17);
            this.rbIErr.TabIndex = 9;
            this.rbIErr.Text = "Error";
            this.rbIErr.UseVisualStyleBackColor = true;
            // 
            // rbINone
            // 
            this.rbINone.AutoSize = true;
            this.rbINone.Checked = true;
            this.rbINone.Location = new System.Drawing.Point(6, 19);
            this.rbINone.Name = "rbINone";
            this.rbINone.Size = new System.Drawing.Size(51, 17);
            this.rbINone.TabIndex = 8;
            this.rbINone.TabStop = true;
            this.rbINone.Text = "None";
            this.rbINone.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb3);
            this.groupBox2.Controls.Add(this.rb2);
            this.groupBox2.Controls.Add(this.rb1);
            this.groupBox2.Location = new System.Drawing.Point(332, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 49);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "&Default Button:";
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(80, 19);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(31, 17);
            this.rb3.TabIndex = 2;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(43, 19);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(31, 17);
            this.rb2.TabIndex = 1;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(6, 19);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(31, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbARI);
            this.groupBox1.Controls.Add(this.rbYN);
            this.groupBox1.Controls.Add(this.rbOKC);
            this.groupBox1.Controls.Add(this.rbOK);
            this.groupBox1.Location = new System.Drawing.Point(6, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Buttons:";
            // 
            // rbARI
            // 
            this.rbARI.AutoSize = true;
            this.rbARI.Location = new System.Drawing.Point(204, 19);
            this.rbARI.Name = "rbARI";
            this.rbARI.Size = new System.Drawing.Size(115, 17);
            this.rbARI.TabIndex = 9;
            this.rbARI.Text = "Abort/Retry/Ignore";
            this.rbARI.UseVisualStyleBackColor = true;
            // 
            // rbYN
            // 
            this.rbYN.AutoSize = true;
            this.rbYN.Location = new System.Drawing.Point(136, 19);
            this.rbYN.Name = "rbYN";
            this.rbYN.Size = new System.Drawing.Size(62, 17);
            this.rbYN.TabIndex = 8;
            this.rbYN.Text = "Yes/No";
            this.rbYN.UseVisualStyleBackColor = true;
            // 
            // rbOKC
            // 
            this.rbOKC.AutoSize = true;
            this.rbOKC.Location = new System.Drawing.Point(52, 19);
            this.rbOKC.Name = "rbOKC";
            this.rbOKC.Size = new System.Drawing.Size(78, 17);
            this.rbOKC.TabIndex = 7;
            this.rbOKC.Text = "OK/Cancel";
            this.rbOKC.UseVisualStyleBackColor = true;
            // 
            // rbOK
            // 
            this.rbOK.AutoSize = true;
            this.rbOK.Checked = true;
            this.rbOK.Location = new System.Drawing.Point(6, 19);
            this.rbOK.Name = "rbOK";
            this.rbOK.Size = new System.Drawing.Size(40, 17);
            this.rbOK.TabIndex = 6;
            this.rbOK.TabStop = true;
            this.rbOK.Text = "OK";
            this.rbOK.UseVisualStyleBackColor = true;
            // 
            // tTitle
            // 
            this.tTitle.Location = new System.Drawing.Point(62, 46);
            this.tTitle.Name = "tTitle";
            this.tTitle.Size = new System.Drawing.Size(383, 20);
            this.tTitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Title:";
            // 
            // tMsg
            // 
            this.tMsg.Location = new System.Drawing.Point(62, 20);
            this.tMsg.Name = "tMsg";
            this.tMsg.Size = new System.Drawing.Size(383, 20);
            this.tMsg.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(3, 23);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "&Message:";
            // 
            // cbParent
            // 
            this.cbParent.AutoSize = true;
            this.cbParent.Location = new System.Drawing.Point(3, 3);
            this.cbParent.Name = "cbParent";
            this.cbParent.Size = new System.Drawing.Size(134, 17);
            this.cbParent.TabIndex = 0;
            this.cbParent.Text = "&Pass in Form as Parent";
            this.cbParent.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 291);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 321);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.Text = "MsgBox Test";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbParent;
        private System.Windows.Forms.TextBox tTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tMsg;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbARI;
        private System.Windows.Forms.RadioButton rbYN;
        private System.Windows.Forms.RadioButton rbOKC;
        private System.Windows.Forms.RadioButton rbOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbIInf;
        private System.Windows.Forms.RadioButton rbIErr;
        private System.Windows.Forms.RadioButton rbINone;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rbIQ;
        private System.Windows.Forms.RadioButton rbIWarn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbSErr;
        private System.Windows.Forms.RadioButton rbSCust;
        private System.Windows.Forms.RadioButton rbSNone;
        private System.Windows.Forms.RadioButton rbSWarn;
        private System.Windows.Forms.RadioButton rbSQ;
        private System.Windows.Forms.RadioButton rbSInf;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label label2;
    }
}

