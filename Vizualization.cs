using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombinatorialProblem
{
    internal class Vizualization
    {
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;

        public Vizualization(PictureBox pictureBox, RichTextBox richTextBox) 
        {
            this.pictureBox1 = pictureBox;
            this.richTextBox1 = richTextBox;
        }

        public void DrawMatrix(List<bool[]> matrix)
        {
            // Clear the PictureBox
            pictureBox1.Image = null;
            pictureBox1.Refresh();
            int ballSize = Math.Min((int)(pictureBox1.Width / matrix[0].Length), (int)(pictureBox1.Height / matrix.Count));
            int emptySize = ballSize / 2;

            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    int x = j * ballSize + ballSize / 2;
                    int y = i * ballSize + ballSize / 2;

                    if (matrix[i][j])
                    {
                        graphics.FillEllipse(Brushes.Green, x - ballSize / 4, y - ballSize / 4, ballSize / 2, ballSize / 2);
                        graphics.FillEllipse(Brushes.White, x - ballSize / 8, y - ballSize / 8, ballSize / 4, ballSize / 4);
                    }
                    else
                    {
                        graphics.FillEllipse(Brushes.Green, x - emptySize / 2, y - emptySize / 2, emptySize, emptySize);
                    }
                }
            }

            pictureBox1.Image = bitmap;
        }

        public void ShowMatrix(List<bool[]> matrix)
        {
            richTextBox1.Text = "";
            for (int i = 0; i < matrix.Count; i++)
            {      
                for (int j = 0; j < matrix[i].Length; j++)
                {

                    if (matrix[i][j])
                    {
                        richTextBox1.Text += "1";
                    }
                    else
                    {
                        richTextBox1.Text += "0";
                    }
                }
                richTextBox1.Text += "\n";
            }
        }
    }
}
