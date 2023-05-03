namespace Stock_Managemet_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.button1 = new Guna.UI.WinForms.GunaButton();
            this.textBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.textBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AnimationHoverSpeed = 0.07F;
            this.button1.AnimationSpeed = 0.03F;
            this.button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.button1.BorderColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.FocusedColor = System.Drawing.Color.Empty;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageSize = new System.Drawing.Size(20, 20);
            this.button1.Location = new System.Drawing.Point(239, 274);
            this.button1.Name = "button1";
            this.button1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.button1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button1.OnHoverForeColor = System.Drawing.Color.White;
            this.button1.OnHoverImage = null;
            this.button1.OnPressedColor = System.Drawing.Color.Black;
            this.button1.Size = new System.Drawing.Size(160, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log In";
            // 
            // textBox1
            // 
            this.textBox1.BaseColor = System.Drawing.Color.White;
            this.textBox1.BorderColor = System.Drawing.Color.Silver;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.textBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(239, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.SelectedText = "";
            this.textBox1.Size = new System.Drawing.Size(160, 32);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "username";
            // 
            // textBox2
            // 
            this.textBox2.BaseColor = System.Drawing.Color.White;
            this.textBox2.BorderColor = System.Drawing.Color.Silver;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.textBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Location = new System.Drawing.Point(239, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '\0';
            this.textBox2.SelectedText = "";
            this.textBox2.Size = new System.Drawing.Size(160, 32);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton button1;
        private Guna.UI.WinForms.GunaTextBox textBox1;
        private Guna.UI.WinForms.GunaTextBox textBox2;
    }
}