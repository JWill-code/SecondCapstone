using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedoCapstone
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //this gui will contain char sheet where fewer attributes can be edited.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this will not change at all.
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //this will change with every character name selected from combobox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //switches tabs with CharacterCreate UI. this works fine
            new CharacterCreate().Show();
        }
        private void selectAndStart(object sender, EventArgs e)
        {
            //starts game
            //this will be the button to start the game with the selected character
        }

        private void CharListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //once changed, the listbox will change contents to match the character with given name.
            //each attribute will be on a separate line.
        }
    }
}
