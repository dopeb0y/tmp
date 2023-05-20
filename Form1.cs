using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace CombinatorialProblem

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int m = (int)numericUpDown2.Value;
            int n = (int)numericUpDown1.Value;
            List<bool[]> matrix;
            Solving solving = new Solving();
            DbSaving saving = new DbSaving();
            Vizualization vizualization = new Vizualization(pictureBox1, richTextBox1);
            if (m > n)
            {

                try
                {

                    Solving solving1 = new Solving();

                    if (m < 11)
                    {

                        matrix = solving1.PlacementWithOptions(m, n);
                        label4.Text = "Число размещений - " + matrix.Count;
                        vizualization.DrawMatrix(matrix);
                        vizualization.ShowMatrix(matrix);
                        saving.SaveResult(m, n, matrix.Count);
                    }
                    else
                    {
                        pictureBox1.Image = null;

                        long result = solving1.PlacementWithoutOptions(m, n);
                        label4.Text = "Число размещений - " + result;
                    }
                }
                catch (Exception ex)
                {
                    saving.SaveException(ex);
                    MessageBox.Show("Непредвиденая ошибка", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "Количество лунок должно быть больше количества шаров!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}