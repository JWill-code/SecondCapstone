using System;
using System.Windows.Forms;

namespace RedoCapstone
{
    public partial class CharacterViewerForm : Form
    {
        public CharacterViewerForm(Character character)
        {
            InitializeComponent();
            // Fill form fields with character data
            txtName.Text = character.name;
            txtSpecies.Text = character.species;
            numHP.Value = character.HealthPoints;
            numStamina.Value = character.StaminaPoints;
            txtDex.Text = character.GetDexterityScore().ToString();
            txtCon.Text = character.GetConstitutionScore().ToString();
            txtWill.Text = character.GetConstitutionScore().ToString();

            lstInventory.Items.Clear();
            foreach (var entity in character.Equipment)
            {
                ListViewItem item = new ListViewItem(entity.name);

                item.Tag = entity;
                item.SubItems.Add(entity.type);
                item.SubItems.Add(entity.description);
                item.SubItems.Add(entity.quantity.ToString());
                item.SubItems.Add(entity.weight.ToString());

                lstInventory.Items.Add(item);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lblWill_Click(object sender, EventArgs e)
        {

        }

        private void lblSpecies_Click(object sender, EventArgs e)
        {

        }

        private void lblHP_Click(object sender, EventArgs e)
        {

        }

        private void lblStamina_Click(object sender, EventArgs e)
        {

        }

        private void lblDex_Click(object sender, EventArgs e)
        {

        }

        private void lblCon_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblInventory_Click(object sender, EventArgs e)
        {

        }
    }
}
