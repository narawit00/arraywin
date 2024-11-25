namespace arraywin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] studen = new string[5];
            studen[0] = "Biw";
            studen[1] = "M";
            studen[2] = "Tow";
            studen[3] = "Showgun";
            studen[4] = "Bas";
            string test = "";

            int n = studen.Length;  ///หาขนาดของ Array

            for (int i = 0; i < n; i++)
            {
                test += studen[i] + Environment.NewLine;
            }
            MessageBox.Show(test);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruits = { "tomato", "mango", "apple", "orang" };
            string myFeuit = "";
            foreach (string str in Fruits)
            {
                myFeuit += str + ", ";
            }
            MessageBox.Show(myFeuit, "ผลไม้ของฉัน");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;   //นำข้อมูลเเต่ละบันทัดไปใส่ใน Array
            string result = "";
            foreach (string str in data)
            {
                if (str != "")
                {
                    result += str + Environment.NewLine;
                }

            }

            label1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            string result = "";
            int sum = 0;
            foreach (var str in data)
            {
                int x = 0;
                if (int.TryParse(str, out x))

                {
                    sum += x;
                    result += x.ToString() + Environment.NewLine;
                }
            }
            label1.Text = result;
            MessageBox.Show(sum.ToString(), "ผลรวมของตัวเลข");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "M";
            student[0, 1] = "sagonnakon";
            student[1, 0] = "Biw";
            student[1, 1] = "Udontani";
            student[2, 0] = "Tow";
            student[2, 1] = "Uontani";
            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ResultData += student[i, j];
                    if (j < n - 1) // เพิ่มขีดเฉพาะเมื่อไม่ใช่คอลัมน์สุดท้าย
                    {
                        ResultData += "-";
                    }
                }
                ResultData += Environment.NewLine;
            }
            MessageBox.Show(ResultData, "ShowData in 2D Array");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Fruits = { "tomato", "mango", "apple", "orang" };
            comboBox1.Items.AddRange(Fruits);
            listBox1.Items.AddRange(Fruits);
            checkedListBox1.Items.AddRange(Fruits);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedIndex.ToString() + "-";
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedIndex.ToString() + "-";
            str += listBox1.SelectedItem;
            MessageBox.Show(str);
        }
    }
}

