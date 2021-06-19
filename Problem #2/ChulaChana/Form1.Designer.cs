namespace ChulaChana
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.phoneNum = new System.Windows.Forms.TextBox();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseLoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logDetails = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.allLocationPop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chula Chana system";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menu";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(263, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check in user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.Location = new System.Drawing.Point(263, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "Check out user";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button3.Location = new System.Drawing.Point(263, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 71);
            this.button3.TabIndex = 1;
            this.button3.Text = "Population count";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // phoneNum
            // 
            this.phoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.phoneNum.Location = new System.Drawing.Point(440, 226);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(247, 38);
            this.phoneNum.TabIndex = 2;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(598, 325);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(89, 38);
            this.buttonContinue.TabIndex = 3;
            this.buttonContinue.Text = "continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter your phone number :";
            // 
            // chooseLoc
            // 
            this.chooseLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.chooseLoc.FormattingEnabled = true;
            this.chooseLoc.Location = new System.Drawing.Point(440, 276);
            this.chooseLoc.Name = "chooseLoc";
            this.chooseLoc.Size = new System.Drawing.Size(247, 37);
            this.chooseLoc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Location :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(654, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Successfully logged out";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logDetails
            // 
            this.logDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logDetails.Location = new System.Drawing.Point(0, 0);
            this.logDetails.Name = "logDetails";
            this.logDetails.Size = new System.Drawing.Size(814, 622);
            this.logDetails.TabIndex = 0;
            this.logDetails.Text = "phoneNum at location";
            this.logDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(359, 417);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(89, 38);
            this.ok.TabIndex = 3;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // allLocationPop
            // 
            this.allLocationPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.allLocationPop.Location = new System.Drawing.Point(208, 209);
            this.allLocationPop.Multiline = true;
            this.allLocationPop.Name = "allLocationPop";
            this.allLocationPop.ReadOnly = true;
            this.allLocationPop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.allLocationPop.Size = new System.Drawing.Size(357, 189);
            this.allLocationPop.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 622);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseLoc);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.allLocationPop);
            this.Controls.Add(this.logDetails);
            this.Name = "Form1";
            this.Text = "ChulaChana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox phoneNum;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox chooseLoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label logDetails;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox allLocationPop;
    }
}

