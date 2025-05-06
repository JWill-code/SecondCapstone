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
    public partial class CharacterCreate : Form
    {
        private ComboBox Characteristics;
        private Button CreateStartButton;
        private Button BackToHome;
        private Button button1;
        private Button PrevChar;
        public static CharacterCreate instance;
        public CharacterCreate()
        {

            instance = this;
            InitializeComponent();
            this.Load += CharacterCreate_Load;  // Attach the handler
        }



        private void CharacterCreate_Load(object sender, EventArgs e)
        {
            //i don't know how to do this

        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1();
            newForm.ShowDialog();  // This blocks until closed
            this.Close();  // Clean up after dialog is closed
            //this will move back to the home screen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ensure that all material is saved fro drop down tab list
            //list uses LivingEntity.
        }

        private void InitializeComponent()
        {
            this.Characteristics = new System.Windows.Forms.ComboBox();
            this.CreateStartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PrevChar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Characteristics
            // 
            this.Characteristics.FormattingEnabled = true;
            this.Characteristics.Items.AddRange(new object[] {
            "Name",
            "Weight",
            "Species",
            "Stamina",
            "Dexterity",
            "Constitution",
            "Willpower",
            "Equipment"});
            this.Characteristics.Location = new System.Drawing.Point(450, 263);
            this.Characteristics.Name = "Characteristics";
            this.Characteristics.Size = new System.Drawing.Size(151, 24);
            this.Characteristics.TabIndex = 0;
            this.Characteristics.Text = "Character";
            this.Characteristics.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // CreateStartButton
            // 
            this.CreateStartButton.Location = new System.Drawing.Point(980, 353);
            this.CreateStartButton.Name = "CreateStartButton";
            this.CreateStartButton.Size = new System.Drawing.Size(182, 67);
            this.CreateStartButton.TabIndex = 1;
            this.CreateStartButton.Text = "Start Playing";
            this.CreateStartButton.UseVisualStyleBackColor = true;
            this.CreateStartButton.Click += new System.EventHandler(this.CreateStartButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back To Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // PrevChar
            // 
            this.PrevChar.Location = new System.Drawing.Point(824, 86);
            this.PrevChar.Name = "PrevChar";
            this.PrevChar.Size = new System.Drawing.Size(176, 23);
            this.PrevChar.TabIndex = 2;
            this.PrevChar.Text = "Previous Characters";
            this.PrevChar.UseVisualStyleBackColor = true;
            this.PrevChar.Click += new System.EventHandler(this.PrevChar_Click);
            // 
            // CharacterCreate
            // 
            this.ClientSize = new System.Drawing.Size(1168, 538);
            this.Controls.Add(this.PrevChar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreateStartButton);
            this.Controls.Add(this.Characteristics);
            this.Name = "CharacterCreate";
            this.ResumeLayout(false);

        }

        private void CreateStartButton_Click(object sender, EventArgs e)
        {
            //starts game. again i don't know how this is supposed to work.
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select characteristic, type in number or species
            ComboBox combo = sender as ComboBox;
            string selectedItem = combo.SelectedItem.ToString();
            //textbox will then be able to change and have user enter double/int/string.
        }
        private void PrevChar_Click(object sender, EventArgs e)
        {
            //this will switch to the previous character screen
            this.Hide();
            Form2 newForm = new Form2();
            newForm.ShowDialog();  // This blocks until closed
            this.Close();  // Clean up after dialog is closed
        }
    }
}
