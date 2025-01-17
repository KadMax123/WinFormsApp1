namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FindMaxInInterval(double B, double C, double[] numbers)
        {
            if (B <= 0 || B >= C || numbers.Length != 10)
            {
                textBox1.Text = "0 0";
                return;
            }

            double max = double.MinValue;
            int maxIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > B && numbers[i] < C)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                        maxIndex = i + 1; // Номер, а не индекс
                    }
                }
            }

            if (maxIndex == -1)
            {
                textBox1.Text = "0 0";
            }
            else
            {
                textBox1.Text = "Максимальный элемент:" + max + " Номер: " + maxIndex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double B = Convert.ToDouble(textBox2.Text);
            double C = Convert.ToDouble(textBox3.Text);
            double[] numbers = { 1, 7, 12, 3, 9, 16, 8, 5, 10, 6 };

            FindMaxInInterval(B, C, numbers);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
