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
            this.SuspendLayout();
            // 
            // CharacterCreate
            // 
            this.ClientSize = new System.Drawing.Size(1338, 538);
            this.Name = "CharacterCreate";
            this.ResumeLayout(false);

        }
    }
}
