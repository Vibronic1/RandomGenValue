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
            dataGridView1.Rows[0].Tag = "Values";
            for (int i = 0;i<Program.count;i++) 
            {
                dataGridView1.Columns[i].Name = (i+1).ToString();
                dataGridView1.Rows[0].Cells[i].Value = numbers[i];

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
