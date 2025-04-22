using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedoCapstone
{
    public partial class Form1 : Form
    {
        List<string> name = new List<string>();
        List<string> species = new List<string>();
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this; //when created, save instance
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //switches tabs
            CharacterCreate form = new CharacterCreate();
            form.Show();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
