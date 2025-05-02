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
        private ComboBox comboBox1;
        private Button CreateStartButton;
        public static CharacterCreate instance;
        public CharacterCreate()
        {
            
            instance = this;
        }

        

        private void CharacterCreate_Load(object sender, EventArgs e)
        {

        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            //this will move back to the home screen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ensure that all material is saved fro drop down tab list
            //list uses LivingEntity.
        }

        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CreateStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(450, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // CharacterCreate
            // 
            this.ClientSize = new System.Drawing.Size(1338, 538);
            this.Controls.Add(this.CreateStartButton);
            this.Controls.Add(this.comboBox1);
            this.Name = "CharacterCreate";
            this.ResumeLayout(false);

        }

        private void CreateStartButton_Click(object sender, EventArgs e)
        {
            //starts game. again i don't know how
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select number or type in name to go with selected attribute.
        }
    }
}
