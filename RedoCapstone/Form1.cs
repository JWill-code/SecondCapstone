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
        //the species will be handled later
        species.add("dwarf");
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this; //when created, save instance
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this contains the title which will needs to be updated
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //I don't remember what this does
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //switches tabs with CharacterCreate UI
            CharacterCreate form = new CharacterCreate();
            form.Show();
        }
    }
}
