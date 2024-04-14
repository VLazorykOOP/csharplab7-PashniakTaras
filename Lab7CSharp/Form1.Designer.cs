
namespace Lab7CSharp
{
    partial class MainForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.drawRandomShapesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(231, 8);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(655, 381);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // drawRandomShapesButton
            // 
            this.drawRandomShapesButton.Location = new System.Drawing.Point(9, 16);
            this.drawRandomShapesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawRandomShapesButton.Name = "drawRandomShapesButton";
            this.drawRandomShapesButton.Size = new System.Drawing.Size(206, 52);
            this.drawRandomShapesButton.TabIndex = 8;
            this.drawRandomShapesButton.Text = "Draw Random Shapes";
            this.drawRandomShapesButton.UseVisualStyleBackColor = true;
            this.drawRandomShapesButton.Click += new System.EventHandler(this.drawRandomShapesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 442);
            this.Controls.Add(this.drawRandomShapesButton);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button openFileDialogButton;
        private System.Windows.Forms.Button saveFileDialogButton;
        private System.Windows.Forms.Button convertToGrayScaleButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button drawRandomShapesButton;
    }
}

