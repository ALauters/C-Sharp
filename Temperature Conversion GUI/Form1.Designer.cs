namespace Temperature_Conversion_GUI
{
    partial class temp_convert
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
            this.txtbx_fahrenheight = new System.Windows.Forms.TextBox();
            this.txtbx_celcius = new System.Windows.Forms.TextBox();
            this.lbl_fahrenheight = new System.Windows.Forms.Label();
            this.lbl_celcius = new System.Windows.Forms.Label();
            this.lbl_kelvin = new System.Windows.Forms.Label();
            this.txtbx_kelvin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbx_fahrenheight
            // 
            this.txtbx_fahrenheight.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbx_fahrenheight.Location = new System.Drawing.Point(290, 105);
            this.txtbx_fahrenheight.Name = "txtbx_fahrenheight";
            this.txtbx_fahrenheight.Size = new System.Drawing.Size(263, 43);
            this.txtbx_fahrenheight.TabIndex = 0;
            this.txtbx_fahrenheight.Text = "32";
            this.txtbx_fahrenheight.TextChanged += new System.EventHandler(this.txtbx_fahrenheight_TextChanged);
            // 
            // txtbx_celcius
            // 
            this.txtbx_celcius.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbx_celcius.Location = new System.Drawing.Point(290, 184);
            this.txtbx_celcius.Name = "txtbx_celcius";
            this.txtbx_celcius.Size = new System.Drawing.Size(263, 43);
            this.txtbx_celcius.TabIndex = 1;
            this.txtbx_celcius.Text = "0";
            this.txtbx_celcius.TextChanged += new System.EventHandler(this.txtbx_celcius_TextChanged);
            // 
            // lbl_fahrenheight
            // 
            this.lbl_fahrenheight.AutoSize = true;
            this.lbl_fahrenheight.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_fahrenheight.Location = new System.Drawing.Point(58, 105);
            this.lbl_fahrenheight.Name = "lbl_fahrenheight";
            this.lbl_fahrenheight.Size = new System.Drawing.Size(172, 37);
            this.lbl_fahrenheight.TabIndex = 3;
            this.lbl_fahrenheight.Text = "Fahrenheight";
            // 
            // lbl_celcius
            // 
            this.lbl_celcius.AutoSize = true;
            this.lbl_celcius.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_celcius.Location = new System.Drawing.Point(58, 184);
            this.lbl_celcius.Name = "lbl_celcius";
            this.lbl_celcius.Size = new System.Drawing.Size(100, 37);
            this.lbl_celcius.TabIndex = 4;
            this.lbl_celcius.Text = "Celcius";
            // 
            // lbl_kelvin
            // 
            this.lbl_kelvin.AutoSize = true;
            this.lbl_kelvin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kelvin.Location = new System.Drawing.Point(58, 274);
            this.lbl_kelvin.Name = "lbl_kelvin";
            this.lbl_kelvin.Size = new System.Drawing.Size(89, 37);
            this.lbl_kelvin.TabIndex = 5;
            this.lbl_kelvin.Text = "Kelvin";
            // 
            // txtbx_kelvin
            // 
            this.txtbx_kelvin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbx_kelvin.Location = new System.Drawing.Point(290, 274);
            this.txtbx_kelvin.Name = "txtbx_kelvin";
            this.txtbx_kelvin.Size = new System.Drawing.Size(263, 43);
            this.txtbx_kelvin.TabIndex = 6;
            this.txtbx_kelvin.Text = "273";
            this.txtbx_kelvin.TextChanged += new System.EventHandler(this.txtbx_kelvin_TextChanged);
            // 
            // temp_convert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbx_kelvin);
            this.Controls.Add(this.lbl_kelvin);
            this.Controls.Add(this.lbl_celcius);
            this.Controls.Add(this.lbl_fahrenheight);
            this.Controls.Add(this.txtbx_celcius);
            this.Controls.Add(this.txtbx_fahrenheight);
            this.Name = "temp_convert";
            this.Text = "Temperature Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbx_fahrenheight;
        private TextBox txtbx_celcius;
        private Label lbl_fahrenheight;
        private Label lbl_celcius;
        private Label lbl_kelvin;
        private TextBox txtbx_kelvin;
    }
}