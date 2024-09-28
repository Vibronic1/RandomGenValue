namespace RandomGenValue
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            int[] numbers = new int[Program.count];
            numbers = Program.GenerateValues( new Random(), Program.count);
            dataGridView1.ColumnCount = Program.count;
            dataGridView1.RowCount = 1;
            int i = 0;
            foreach (int n in numbers)
            {
                dataGridView1.Rows[1].Cells[i].Value = n;
                i++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.count = (int)numericUpDown1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Program.count = (int)numericUpDown1.Value;
        }
    }
}
