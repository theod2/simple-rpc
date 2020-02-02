using System.ComponentModel;

namespace simple_rpc
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.IdBox = new System.Windows.Forms.TextBox();
            this.GIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GIT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PIT = new System.Windows.Forms.TextBox();
            this.PIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstline = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.secondline = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuration du RichPresence";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(14, 67);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(227, 23);
            this.IdBox.TabIndex = 1;
            // 
            // GIN
            // 
            this.GIN.Location = new System.Drawing.Point(14, 122);
            this.GIN.Name = "GIN";
            this.GIN.Size = new System.Drawing.Size(227, 23);
            this.GIN.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grande Image (nom) :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Grande image (texte) :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GIT
            // 
            this.GIT.Location = new System.Drawing.Point(14, 178);
            this.GIT.Name = "GIT";
            this.GIT.Size = new System.Drawing.Size(227, 23);
            this.GIT.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Petite image (texte) :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Petite image (nom) :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PIT
            // 
            this.PIT.Location = new System.Drawing.Point(14, 290);
            this.PIT.Name = "PIT";
            this.PIT.Size = new System.Drawing.Size(227, 23);
            this.PIT.TabIndex = 13;
            // 
            // PIN
            // 
            this.PIN.Location = new System.Drawing.Point(14, 233);
            this.PIN.Name = "PIN";
            this.PIN.Size = new System.Drawing.Size(227, 23);
            this.PIN.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Première ligne :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstline
            // 
            this.firstline.Location = new System.Drawing.Point(14, 346);
            this.firstline.Name = "firstline";
            this.firstline.Size = new System.Drawing.Size(227, 23);
            this.firstline.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Deuxième ligne :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // secondline
            // 
            this.secondline.Location = new System.Drawing.Point(14, 405);
            this.secondline.Name = "secondline";
            this.secondline.Size = new System.Drawing.Size(227, 23);
            this.secondline.TabIndex = 20;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(14, 461);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(227, 25);
            this.submit.TabIndex = 24;
            this.submit.Text = "Valider";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 500);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.secondline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstline);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PIT);
            this.Controls.Add(this.PIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GIT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GIN);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.label1);
            this.Name = "ConfigForm";
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox GIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GIT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PIT;
        private System.Windows.Forms.TextBox PIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstline;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secondline;
        private System.Windows.Forms.Button submit;
    }
}