namespace AsyncProgrammming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Button 1 Clicked");
            await ClickAsync(label1, textBox1);
            listBox1.Items.Add("Button 1 Done");
        }

        private async Task ClickAsync(Label label, TextBox textBox)
        {
            label.Text = "Processing..";
            string input = textBox.Text;
            listBox1.Items.Add("Start " + input);

            string result = await TestAsync(input);

            listBox1.Items.Add("End " + textBox.Text);
            label.Text = result;
        }

        private async Task<string> TestAsync(string input)
        {
            await Task.Delay(2000);
            listBox1.Items.Add(input);
            return input;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Button 2 Clicked");
             ClickAsync(label2, textBox2);

            listBox1.Items.Add("Button 2 Done");
        }
    }
}
