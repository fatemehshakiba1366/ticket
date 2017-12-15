namespace Ticket
{
    partial class frm_RegUser
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
            this.btnRegUserNow = new System.Windows.Forms.Button();
            this.txtUPassword = new System.Windows.Forms.TextBox();
            this.txtUNameFamily = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.labelX3 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegUserNow
            // 
            this.btnRegUserNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRegUserNow.Location = new System.Drawing.Point(155, 267);
            this.btnRegUserNow.Name = "btnRegUserNow";
            this.btnRegUserNow.Size = new System.Drawing.Size(123, 67);
            this.btnRegUserNow.TabIndex = 13;
            this.btnRegUserNow.Text = "ثبت کاربر";
            this.btnRegUserNow.UseVisualStyleBackColor = true;
            this.btnRegUserNow.Click += new System.EventHandler(this.btnRegUserNow_Click);
            // 
            // txtUPassword
            // 
            this.txtUPassword.Location = new System.Drawing.Point(143, 191);
            this.txtUPassword.Name = "txtUPassword";
            this.txtUPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUPassword.Size = new System.Drawing.Size(150, 20);
            this.txtUPassword.TabIndex = 12;
            // 
            // txtUNameFamily
            // 
            this.txtUNameFamily.Location = new System.Drawing.Point(143, 131);
            this.txtUNameFamily.Name = "txtUNameFamily";
            this.txtUNameFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUNameFamily.Size = new System.Drawing.Size(150, 20);
            this.txtUNameFamily.TabIndex = 11;
            this.txtUNameFamily.TextChanged += new System.EventHandler(this.txtFamily_TextChanged);
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(143, 65);
            this.txtUID.Name = "txtUID";
            this.txtUID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUID.Size = new System.Drawing.Size(150, 20);
            this.txtUID.TabIndex = 10;
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.Location = new System.Drawing.Point(335, 182);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(141, 43);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "رمز عبور:";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX2.Location = new System.Drawing.Point(299, 122);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(178, 43);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "نام و نام خانوادگی:";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.Location = new System.Drawing.Point(369, 56);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(107, 43);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "نام کاربری:";
            // 
            // frm_RegUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 429);
            this.Controls.Add(this.btnRegUserNow);
            this.Controls.Add(this.txtUPassword);
            this.Controls.Add(this.txtUNameFamily);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "frm_RegUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ثبت کاربر جدید";
            this.Load += new System.EventHandler(this.frm_RegUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegUserNow;
        private System.Windows.Forms.TextBox txtUPassword;
        private System.Windows.Forms.TextBox txtUNameFamily;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label labelX3;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelX1;
    }
}