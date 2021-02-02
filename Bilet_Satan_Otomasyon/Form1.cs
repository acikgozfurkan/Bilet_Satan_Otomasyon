using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilet_Satan_Otomasyon
{
    public partial class Form1 : Form
    {

        DataTable tablo = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text);
            dataGridView1.DataSource = tablo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Ad", typeof(string));
            tablo.Columns.Add("Soyad", typeof(string));
            tablo.Columns.Add("yas", typeof(int));
            tablo.Columns.Add("Cinsiyet", typeof(string));
            dataGridView1.DataSource = tablo;
        }
    }
}
