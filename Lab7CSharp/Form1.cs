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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab7CSharp
{
    public partial class MainForm : Form
    {
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void drawRandomShapesButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            graphics.Clear(Color.White);

            Shape[] shapes = GenerateRandomShapes();

            foreach (Shape shape in shapes)
            {
                shape.Draw(graphics);
            }
        }

        private Shape[] GenerateRandomShapes()
        {
            Shape[] shapes = new Shape[4];
            shapes[0] = new Triangle(random);
            shapes[1] = new Rectangle(random);
            shapes[2] = new Ellipse(random);
            shapes[3] = new Star(random);

            return shapes;  
        }
    }

    abstract class Shape
    {
        protected int x, y;
        protected int size;
        protected Color color;
        protected Random random;

        public Shape(Random random)
        {
            this.random = random;
            x = random.Next(10, 200); // Випадкові координати в межах PictureBox
            y = random.Next(10, 200);
            size = random.Next(20, 50); // Випадковий розмір
            color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)); // Випадковий колір
        }

        public abstract void Draw(Graphics g);
    }

    class Rectangle : Shape
    {
        public Rectangle(Random random) : base(random) { }

        public override void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(color);
            g.FillRectangle(brush, x, y, size * 2, size);
        }
    }

    class Ellipse : Shape
    {
        public Ellipse(Random random) : base(random) { }

        public override void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, x, y, size, size);
        }
    }

    class Star : Shape
    {
        public Star(Random random) : base(random) { }

        public override void Draw(Graphics g)
        {
            // Визначення вершин зірки
            PointF[] points = new PointF[10];
            double angle = Math.PI / 5; // 36 градусів в радіанах

            for (int i = 0; i < 10; i++)
            {
                double r = (i % 2 == 0) ? size : size / 2; // Довжина радіуса
                points[i] = new PointF((float)(x + r * Math.Cos(i * 2 * angle - Math.PI / 2)),
                                       (float)(y + r * Math.Sin(i * 2 * angle - Math.PI / 2)));
            }

            // Малювання зафарбованої зірки
            SolidBrush brush = new SolidBrush(color);
            g.FillPolygon(brush, points);
        }
    }

    class Triangle : Shape
    {
        public Triangle(Random random) : base(random) { }

        public override void Draw(Graphics g)
        {
            // Визначення вершин трикутника
            PointF[] points =
            {
            new PointF(x + size / 2, y), // Верхня вершина
            new PointF(x, y + size),     // Ліва нижня вершина
            new PointF(x + size, y + size) // Права нижня вершина
        };

            // Малювання зафарбованого трикутника
            SolidBrush brush = new SolidBrush(color);
            g.FillPolygon(brush, points);
        }
    }

}
