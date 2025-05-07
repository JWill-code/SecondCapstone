using System;
using System.Collections.Generic;
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


            Character character1 = new Character(0, "Bob", "Elf", "Adventurer", 0, 0, 0, 10, 10);
            Item item1 = new Item(1, "Sword", 1, "A Warriors Weapon", 2);
            character1.DonItem(item1);

            CharacterViewerForm newForm = new CharacterViewerForm(character1);
            newForm.ShowDialog();  // This blocks until closed
            this.Close();  // Clean up after dialog is closed
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
