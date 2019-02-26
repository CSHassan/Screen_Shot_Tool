namespace DesktopApp1
{
    partial class Form1
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
            this.debugInstructionsLabel = new System.Windows.Forms.Label();
            this.screenCapture_Btn = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.Drag_Screen_Shot = new System.Windows.Forms.Button();
            this.output_file_lbl = new System.Windows.Forms.Label();
            this.current_screen_shot_btn = new System.Windows.Forms.Button();
            this.output_file_location_txtbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // debugInstructionsLabel
            // 
            this.debugInstructionsLabel.AutoSize = true;
            this.debugInstructionsLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.debugInstructionsLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.debugInstructionsLabel.Location = new System.Drawing.Point(130, 86);
            this.debugInstructionsLabel.Name = "debugInstructionsLabel";
            this.debugInstructionsLabel.Size = new System.Drawing.Size(477, 17);
            this.debugInstructionsLabel.TabIndex = 1;
            this.debugInstructionsLabel.Text = "Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app!";
            // 
            // screenCapture_Btn
            // 
            this.screenCapture_Btn.Location = new System.Drawing.Point(128, 555);
            this.screenCapture_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.screenCapture_Btn.Name = "screenCapture_Btn";
            this.screenCapture_Btn.Size = new System.Drawing.Size(169, 34);
            this.screenCapture_Btn.TabIndex = 2;
            this.screenCapture_Btn.Text = "Capture Whole Screen";
            this.screenCapture_Btn.UseVisualStyleBackColor = true;
            this.screenCapture_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(269, 24);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(161, 31);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Hello World!";
            // 
            // Drag_Screen_Shot
            // 
            this.Drag_Screen_Shot.Location = new System.Drawing.Point(303, 555);
            this.Drag_Screen_Shot.Name = "Drag_Screen_Shot";
            this.Drag_Screen_Shot.Size = new System.Drawing.Size(149, 34);
            this.Drag_Screen_Shot.TabIndex = 4;
            this.Drag_Screen_Shot.Text = "Drag Screen Shot";
            this.Drag_Screen_Shot.UseVisualStyleBackColor = true;
            this.Drag_Screen_Shot.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // output_file_lbl
            // 
            this.output_file_lbl.AutoSize = true;
            this.output_file_lbl.Location = new System.Drawing.Point(130, 134);
            this.output_file_lbl.Name = "output_file_lbl";
            this.output_file_lbl.Size = new System.Drawing.Size(81, 17);
            this.output_file_lbl.TabIndex = 5;
            this.output_file_lbl.Text = "OutputFile: ";
            this.output_file_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // current_screen_shot_btn
            // 
            this.current_screen_shot_btn.Location = new System.Drawing.Point(458, 555);
            this.current_screen_shot_btn.Name = "current_screen_shot_btn";
            this.current_screen_shot_btn.Size = new System.Drawing.Size(149, 34);
            this.current_screen_shot_btn.TabIndex = 6;
            this.current_screen_shot_btn.Text = "Current Screen Shot";
            this.current_screen_shot_btn.UseVisualStyleBackColor = true;
            this.current_screen_shot_btn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // output_file_location_txtbox
            // 
            this.output_file_location_txtbox.Location = new System.Drawing.Point(209, 134);
            this.output_file_location_txtbox.Name = "output_file_location_txtbox";
            this.output_file_location_txtbox.Size = new System.Drawing.Size(268, 22);
            this.output_file_location_txtbox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(110, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(842, 629);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.output_file_location_txtbox);
            this.Controls.Add(this.current_screen_shot_btn);
            this.Controls.Add(this.output_file_lbl);
            this.Controls.Add(this.Drag_Screen_Shot);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.screenCapture_Btn);
            this.Controls.Add(this.debugInstructionsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label debugInstructionsLabel;
        private System.Windows.Forms.Button screenCapture_Btn;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.Button Drag_Screen_Shot;
        private System.Windows.Forms.Label output_file_lbl;
        private System.Windows.Forms.Button current_screen_shot_btn;
        private System.Windows.Forms.TextBox output_file_location_txtbox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

