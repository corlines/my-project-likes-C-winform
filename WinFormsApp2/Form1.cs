using System.Net.Cache;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] colstr = { "닉네임", "티어", "점수", "나이" };
        int[] width = { 100, 100, 120, 80 };

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                listView1.Columns.Add(colstr[i], width[i]);
            }
            listView1.FullRowSelect = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                this.listView1.Items.Add(this.textBox1.Text);
                this.textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Length <= 0)
            {
                MessageBox.Show("경고");
                return;
            }
            ListViewItem liv = new ListViewItem(textBox2.Text);
            liv.SubItems.Add(textBox3.Text);
            liv.SubItems.Add(textBox4.Text);
            liv.SubItems.Add(textBox5.Text);

            listView1.Items.Add(liv);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
