namespace FibonacciClock
{
    partial class Principal
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
            this.btn2 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn2.Location = new System.Drawing.Point(0, 0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(63, 63);
            this.btn2.TabIndex = 0;
            this.btn2.TabStop = false;
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn11.Location = new System.Drawing.Point(60, 0);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(30, 32);
            this.btn11.TabIndex = 1;
            this.btn11.TabStop = false;
            this.btn11.UseVisualStyleBackColor = false;
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn12.Location = new System.Drawing.Point(60, 31);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(30, 32);
            this.btn12.TabIndex = 2;
            this.btn12.TabStop = false;
            this.btn12.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Location = new System.Drawing.Point(-1, 62);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(93, 85);
            this.btn3.TabIndex = 3;
            this.btn3.TabStop = false;
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Teal;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Location = new System.Drawing.Point(89, 0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(147, 147);
            this.btn5.TabIndex = 4;
            this.btn5.TabStop = false;
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 147);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.TopMost = true;
            this.MouseEnter += new System.EventHandler(this.btn5_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.btn5_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
    }
}

