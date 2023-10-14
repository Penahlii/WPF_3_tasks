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
            Baku_Button = new Button();
            London_Button = new Button();
            SuspendLayout();
            // 
            // Baku_Button
            // 
            Baku_Button.BackColor = SystemColors.InfoText;
            Baku_Button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Baku_Button.ForeColor = SystemColors.ButtonHighlight;
            Baku_Button.Location = new Point(49, 45);
            Baku_Button.Name = "Baku_Button";
            Baku_Button.Size = new Size(123, 44);
            Baku_Button.TabIndex = 0;
            Baku_Button.Text = "Baku";
            Baku_Button.UseVisualStyleBackColor = false;
            Baku_Button.Click += Baku_Button_Click;
            // 
            // London_Button
            // 
            London_Button.BackColor = SystemColors.InfoText;
            London_Button.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            London_Button.ForeColor = SystemColors.ButtonHighlight;
            London_Button.Location = new Point(619, 45);
            London_Button.Name = "London_Button";
            London_Button.Size = new Size(123, 44);
            London_Button.TabIndex = 1;
            London_Button.Text = "London";
            London_Button.UseVisualStyleBackColor = false;
            London_Button.Click += London_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.earth_11015_1280;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(London_Button);
            Controls.Add(Baku_Button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Baku_Button;
        private Button London_Button;
    }
}