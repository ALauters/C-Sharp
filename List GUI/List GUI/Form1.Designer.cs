namespace List_GUI
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
            this.lstbx = new System.Windows.Forms.ListBox();
            this.lbl_num_friends = new System.Windows.Forms.Label();
            this.btn_add_one = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_a_to_z = new System.Windows.Forms.Button();
            this.btn_z_to_a = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbx
            // 
            this.lstbx.FormattingEnabled = true;
            this.lstbx.ItemHeight = 15;
            this.lstbx.Location = new System.Drawing.Point(33, 30);
            this.lstbx.Name = "lstbx";
            this.lstbx.Size = new System.Drawing.Size(246, 349);
            this.lstbx.TabIndex = 0;
            this.lstbx.SelectedIndexChanged += new System.EventHandler(this.lstbx_SelectedIndexChanged);
            // 
            // lbl_num_friends
            // 
            this.lbl_num_friends.AutoSize = true;
            this.lbl_num_friends.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_num_friends.Location = new System.Drawing.Point(595, 78);
            this.lbl_num_friends.Name = "lbl_num_friends";
            this.lbl_num_friends.Size = new System.Drawing.Size(88, 25);
            this.lbl_num_friends.TabIndex = 1;
            this.lbl_num_friends.Text = "0 Friends";
            this.lbl_num_friends.Click += new System.EventHandler(this.lbl_num_friends_Click);
            // 
            // btn_add_one
            // 
            this.btn_add_one.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add_one.Location = new System.Drawing.Point(381, 69);
            this.btn_add_one.Name = "btn_add_one";
            this.btn_add_one.Size = new System.Drawing.Size(92, 34);
            this.btn_add_one.TabIndex = 2;
            this.btn_add_one.Text = "Add 1";
            this.btn_add_one.UseVisualStyleBackColor = true;
            this.btn_add_one.Click += new System.EventHandler(this.btn_add_one_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(381, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 33);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_a_to_z
            // 
            this.btn_a_to_z.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_a_to_z.Location = new System.Drawing.Point(381, 345);
            this.btn_a_to_z.Name = "btn_a_to_z";
            this.btn_a_to_z.Size = new System.Drawing.Size(91, 34);
            this.btn_a_to_z.TabIndex = 5;
            this.btn_a_to_z.Text = "A -> Z";
            this.btn_a_to_z.UseVisualStyleBackColor = true;
            this.btn_a_to_z.Click += new System.EventHandler(this.btn_a_to_z_Click);
            // 
            // btn_z_to_a
            // 
            this.btn_z_to_a.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_z_to_a.Location = new System.Drawing.Point(488, 345);
            this.btn_z_to_a.Name = "btn_z_to_a";
            this.btn_z_to_a.Size = new System.Drawing.Size(91, 34);
            this.btn_z_to_a.TabIndex = 6;
            this.btn_z_to_a.Text = "Z -> A";
            this.btn_z_to_a.UseVisualStyleBackColor = true;
            this.btn_z_to_a.Click += new System.EventHandler(this.btn_z_to_a_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(592, 345);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(91, 34);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_z_to_a);
            this.Controls.Add(this.btn_a_to_z);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_add_one);
            this.Controls.Add(this.lbl_num_friends);
            this.Controls.Add(this.lstbx);
            this.Name = "Form1";
            this.Text = "List of Friends";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstbx;
        private Label lbl_num_friends;
        private Button btn_add_one;
        private TextBox textBox1;
        private Button btn_a_to_z;
        private Button btn_z_to_a;
        private Button btn_clear;
    }
}