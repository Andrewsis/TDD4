namespace TDD4
{
    public partial class Form1 : Form
    {
        private ShapeContainer shapeContainer;

        public Form1()
        {
            InitializeComponent();
            shapeContainer = new ShapeContainer();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = double.TryParse(textBox1.Text, out double radius);

            if (radius < 0 || !isValid)
            {
                MessageBox.Show("Enter a positive radius");
                return;
            }

            Circle circle = new Circle(radius);
            shapeContainer.AddShape(circle);

            label1.Text = "Circle:\nRadius: " + radius;
            UpdateShapeList();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void UpdateShapeList()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < shapeContainer.Count; i++)
            {
                listBox1.Items.Add("Fig: " + (i + 1) + ' ' + shapeContainer[i].Name);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bool isValid = double.TryParse(textBox2.Text, out double width);
            bool isValid2 = double.TryParse(textBox3.Text, out double height);

            if (!isValid || width < 0 || !isValid2 || height < 0)
            {
                MessageBox.Show("Enter positive width and height for the rectangle");
                return;
            }

            Rectangle rectangle = new Rectangle(width, height);
            shapeContainer.AddShape(rectangle);

            label1.Text = "Rectangle:\nWidth: " + width + "\nHeight: " + height;
            UpdateShapeList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isValid = double.TryParse(textBox4.Text, out double baseLength);
            bool isValid2 = double.TryParse(textBox5.Text, out double height);
            bool isValid3 = double.TryParse(textBox6.Text, out double side);

            if (!isValid || baseLength < 0 || !isValid2 || height < 0 || !isValid3 || side < 0)
            {
                MessageBox.Show("Enter positive value");
                return;
            }

            Parallelogram parallelogram = new Parallelogram(baseLength, height, side);
            shapeContainer.AddShape(parallelogram);

            label1.Text = "Parallelogram:\nBaseLength: " + baseLength +
                "\nHeight: " + height +
                "\nSide: " + side;
            UpdateShapeList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isValid = int.TryParse(textBox7.Text, out int shapeIndex);

            if (!isValid || shapeIndex < 1 || shapeIndex > shapeContainer.Count)
            {
                MessageBox.Show("Enter a valid shape number to delete.");
                return;
            }

            shapeIndex -= 1;


            shapeContainer.RemoveShape(shapeContainer[shapeIndex]);
            UpdateShapeList();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int shapeIndex = (int)numericUpDown1.Value;

            if (shapeIndex < 1 || shapeIndex > shapeContainer.Count)
            {
                MessageBox.Show("Enter a valid shape index.");
                return;
            }

            shapeIndex -= 1;

            Shape shape = shapeContainer[shapeIndex];

            if (shape is Circle circle)
            {
                double area = circle.GetArea();
                double circumference = circle.GetPerimeter();
                label2.Text = $"Area: {area:F2} | Circumference: {circumference:F2}";
            }
            else if (shape is Rectangle rectangle)
            {
                double area = rectangle.GetArea();
                double perimeter = rectangle.GetPerimeter();
                label2.Text = $"Area: {area:F2} | Perimeter: {perimeter:F2}";
            }
            else if (shape is Parallelogram parallelogram)
            {
                double area = parallelogram.GetArea();
                double perimeter = parallelogram.GetPerimeter();
                label2.Text = $"Area: {area:F2} | Perimeter: {perimeter:F2}";
            }
            else
            {
                label2.Text = "Shape not recognized.";
            }    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
