namespace WinFormsApp1
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
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.twitch_link = new System.Windows.Forms.TextBox();
            this.btn_No = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_message.Location = new System.Drawing.Point(107, 427);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 86);
            this.lbl_message.TabIndex = 5;
            this.lbl_message.Click += new System.EventHandler(this.lbl_Click);
            // 
            // btn_Yes
            // 
            this.btn_Yes.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Yes.Location = new System.Drawing.Point(224, 253);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(217, 59);
            this.btn_Yes.TabIndex = 6;
            this.btn_Yes.Text = "Yes";
            this.btn_Yes.UseVisualStyleBackColor = true;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // twitch_link
            // 
            this.twitch_link.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twitch_link.Location = new System.Drawing.Point(224, 612);
            this.twitch_link.Name = "twitch_link";
            this.twitch_link.Size = new System.Drawing.Size(657, 46);
            this.twitch_link.TabIndex = 8;
            this.twitch_link.Text = "https://github.com/DoubleDragon05/C-Sharp";
            this.twitch_link.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.twitch_link.Visible = false;
            this.twitch_link.TextChanged += new System.EventHandler(this.twitch_link_TextChanged);
            // 
            // btn_No
            // 
            this.btn_No.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_No.Location = new System.Drawing.Point(664, 253);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(217, 59);
            this.btn_No.TabIndex = 9;
            this.btn_No.Text = "No";
            this.btn_No.UseVisualStyleBackColor = true;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "Have you checked out my Github yet?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 702);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.twitch_link);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.lbl_message);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_message;
        private Button btn_Yes;
        private TextBox twitch_link;
        private Button btn_No;
        private Label label1;
    }
}