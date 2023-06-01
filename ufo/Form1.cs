using ScottPlot;

namespace ufo
{
    public partial class Form1 : Form
    {
        const int step = 5;

        const int width = 1200;
        const int height = 600;

        const int indent = 100;
        const int x1 = indent, y1 = 2 * height - indent;
        const int x2 = 2 * width - indent, y2 = indent;
        const int pointRadius = 20;

        const int testsCount = 15;

        Pen targets = new Pen(Color.Green, 4);
        Brush point = new SolidBrush(Color.Purple);

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(width, height);
            //sleepTime.Value = step;
        }
        int Factorial(int x)
        {
            return x == 0 ? 1 : x * Factorial(x - 1);
        }

        public double Sin(double x, int n)
        {
            double normalisedX = x % (Math.PI / 2);
            normalisedX = ((int)(2 * x / Math.PI)) % 2 == 0 ? normalisedX : (normalisedX / Math.Abs(normalisedX)) * Math.PI / 2 - normalisedX;

            double sum = 0;
            int sign = 1;
            double xpow = normalisedX;
            for (int i = 0; i < n; i++)
            {
                sum += sign * xpow / Factorial(2 * i + 1);
                sign *= -1;
                xpow *= normalisedX * normalisedX;
            }
            return ((int)(x / Math.PI) % 2 == 0 ? 1 : -1) * sum;
        }

        public double Cos(double x, int n)
        {
            return Sin(x + Math.PI / 2, n);
        }
        public double Atan(double x, int n)
        {
            double result = 0;
            bool reversive = false;
            if (x*x > 1)
            {
                x = 1 / x;
                reversive = true;
            }

            int sign = 1;
            double xpow = x;
            double denominator = 1;
            for (int i = 0; i < n; i++)
            {
                result += sign * xpow / denominator;
                sign *= -1;
                xpow *= x * x;
                denominator += 2;
            }
            result = reversive? Math.PI / 2 - result : result;
            return result;
        }

        private void Draw(object sender, PaintEventArgs e, double x, double y)
        {
            Graphics g = e.Graphics;

            g.ScaleTransform(0.5f, 0.5f);
            g.Clear(BackColor);

            g.DrawEllipse(targets, x1 - pointRadius, y1 - pointRadius, 2 * pointRadius, 2 * pointRadius);
            g.DrawEllipse(targets, x2 - pointRadius, y2 - pointRadius, 2 * pointRadius, 2 * pointRadius);

            g.FillEllipse(point, (int)(x - pointRadius + 2), (int)(y - pointRadius + 2), 2 * pointRadius - 4, 2 * pointRadius - 4);
        }

        private double PointMove(int n, int sleepTime)
        {
            double angle = Math.Atan((double)(y2 - y1) / (x2 - x1));
            double x = x1;
            double y = y1;

            double distance = Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2));
            double value = distance;

            while (distance <= value)
            {
                Draw(this, new PaintEventArgs(CreateGraphics(), Bounds), x, y);

                System.Threading.Thread.Sleep(sleepTime);

                x += step * Cos(angle, n);
                y += step * Sin(angle, n);

                distance = Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2));
                if (value > distance)
                {
                    value = distance;
                }
            }

            return value;
        }


        private void startBtn_Click(object sender, EventArgs e)
        {
            double[] dataX = new double[testsCount];
            double[] dataY = new double[testsCount];

            for (int n = 1; n <= testsCount; n++)
            {
                polynom.Text = "Polynom Power = " + Convert.ToString(n);
                polynom.Refresh();
                dataX[n - 1] = n;
                dataY[n - 1] = PointMove(n,(int) sleepTime.Value);
            }

            Plot1.Visible = true;
            xLabel.Visible = true;
            yLabel.Visible = true;
            Plot1.Plot.AddScatter(dataX, dataY);
            Plot1.Refresh();
        }

       
    }
}
