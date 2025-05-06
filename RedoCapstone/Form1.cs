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
        //species.add("dwarf");
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this; //when created, save instance
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this contains the title which will need to be updated
            //I don't know if you guys want a picture
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //I don't remember what this does
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //switches tabs with CharacterCreate UI
            this.Hide();
            CharacterCreate newForm = new CharacterCreate();
            newForm.ShowDialog();  // This blocks until closed
            this.Close();  // Clean up after dialog is closed
        }
    }
}
