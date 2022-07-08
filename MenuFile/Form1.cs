namespace MenuFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void îòêğòûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = Direct.ChooseFile("Òîëüêî PDF (*.pdf)|*.pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Direct.OpenFile(textBox1.Text);
        }
    }
}