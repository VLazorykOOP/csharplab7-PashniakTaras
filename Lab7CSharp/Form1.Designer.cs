
namespace Lab7CSharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonShuffle = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(260, 100);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.Text = "";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 118);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(260, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Location = new System.Drawing.Point(12, 144);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(126, 23);
            this.buttonShuffle.TabIndex = 2;
            this.buttonShuffle.Text = "Перемішати";
            this.buttonShuffle.UseVisualStyleBackColor = true;
            this.buttonShuffle.Click += new System.EventHandler(this.buttonShuffle_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(146, 144);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(126, 23);
            this.buttonReplace.TabIndex = 3;
            this.buttonReplace.Text = "Замінити";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonShuffle);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.richTextBoxOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonShuffle;
        private System.Windows.Forms.Button buttonReplace;
    }
}

