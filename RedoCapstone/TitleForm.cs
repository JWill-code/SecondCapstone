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
    public partial class formTitleScreen : Form
    {
        List<string> name = new List<string>();
        List<string> species = new List<string>();
        //the species will be handled later
        //species.add("dwarf");
        public static formTitleScreen instance;
        public formTitleScreen()
        {
            InitializeComponent();
            instance = this; //when created, save instance
        }

        private void btnCharSelect_Click(object sender, EventArgs e)
        {
            //I don't remember what this does
        }

        private void btnCharCreate_Click(object sender, EventArgs e)
        {
            //switches tabs with CharacterCreate UI
            this.Hide();
            CharacterCreate newForm = new CharacterCreate();
            newForm.ShowDialog();  // This blocks until closed
            this.Close();  // Clean up after dialog is closed
        }

        private void TitleForm_Load(object sender, EventArgs e)
        {

        }

    }
}
