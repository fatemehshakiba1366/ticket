namespace Ticket
{
    partial class frm_Main
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
            this.btnShowTickets = new System.Windows.Forms.Button();
            this.btnRegUser = new System.Windows.Forms.Button();
            this.btnRegTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowTickets
            // 
            this.btnShowTickets.Location = new System.Drawing.Point(344, 110);
            this.btnShowTickets.Name = "btnShowTickets";
            this.btnShowTickets.Size = new System.Drawing.Size(94, 203);
            this.btnShowTickets.TabIndex = 0;
            this.btnShowTickets.Text = "مسافران";
            this.btnShowTickets.UseVisualStyleBackColor = true;
            this.btnShowTickets.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegUser
            // 
            this.btnRegUser.Location = new System.Drawing.Point(198, 105);
            this.btnRegUser.Name = "btnRegUser";
            this.btnRegUser.Size = new System.Drawing.Size(94, 203);
            this.btnRegUser.TabIndex = 1;
            this.btnRegUser.Text = "ثبت کاربر";
            this.btnRegUser.UseVisualStyleBackColor = true;
            this.btnRegUser.Click += new System.EventHandler(this.btnRegUser_Click);
            // 
            // btnRegTicket
            // 
            this.btnRegTicket.Location = new System.Drawing.Point(57, 110);
            this.btnRegTicket.Name = "btnRegTicket";
            this.btnRegTicket.Size = new System.Drawing.Size(94, 203);
            this.btnRegTicket.TabIndex = 2;
            this.btnRegTicket.Text = "ثبت بلیط";
            this.btnRegTicket.UseVisualStyleBackColor = true;
            this.btnRegTicket.Click += new System.EventHandler(this.btnRegTicket_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 413);
            this.Controls.Add(this.btnRegTicket);
            this.Controls.Add(this.btnRegUser);
            this.Controls.Add(this.btnShowTickets);
            this.Name = "frm_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "نرم افزار صدور بلیط";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowTickets;
        private System.Windows.Forms.Button btnRegUser;
        private System.Windows.Forms.Button btnRegTicket;
    }
}