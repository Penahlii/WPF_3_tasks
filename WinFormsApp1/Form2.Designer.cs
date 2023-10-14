namespace WinFormsApp1
{
    partial class Form2
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
            label_of_timer = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label_of_timer
            // 
            label_of_timer.AutoSize = true;
            label_of_timer.Font = new Font("Segoe UI Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label_of_timer.Location = new Point(292, 9);
            label_of_timer.Name = "label_of_timer";
            label_of_timer.Size = new Size(200, 45);
            label_of_timer.TabIndex = 0;
            label_of_timer.Text = "Baku Timer";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(308, 297);
            button1.Name = "button1";
            button1.Size = new Size(127, 47);
            button1.TabIndex = 1;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label_of_timer);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_of_timer;
        private Button button1;
    }
}