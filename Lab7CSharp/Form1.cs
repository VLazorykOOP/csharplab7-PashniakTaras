using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            // Отримуємо текст з TextBox і перемішуємо його
            string text = textBoxInput.Text;
            var shuffledText = new string(text.ToCharArray().OrderBy(c => Guid.NewGuid()).ToArray());

            // Виводимо перемішаний текст у RichTextBox
            richTextBoxOutput.Text = shuffledText;
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            // Отримуємо текст з TextBox і замінюємо символи
            string text = textBoxInput.Text;
            string replacedText = ReplaceChars(text);

            // Виводимо замінений текст у RichTextBox
            richTextBoxOutput.Text = replacedText;
        }

        private string ReplaceChars(string text)
        {
            // Замінюємо всі букви вхідного тексту на алфавіт без 'А', 'Б', 'В'
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string replacedText = new string(alphabet.Where(c => !text.Contains(c) && !text.Contains(char.ToLower(c))).ToArray());
            return replacedText;
        }
    }
}
