using System.Windows.Forms;

namespace RedoCapstone
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CharListBox = new System.Windows.Forms.ComboBox();
            this.charSheetboxitems = new System.Windows.Forms.ListBox();
            this.select = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 58);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "List of already made characters: select character name to see sheet, then push se" +
    "lect button to select current character. ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CharListBox
            // 
            this.CharListBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CharListBox.FormattingEnabled = true;
            this.CharListBox.Location = new System.Drawing.Point(93, 135);
            this.CharListBox.Name = "CharListBox";
            this.CharListBox.Size = new System.Drawing.Size(201, 24);
            this.CharListBox.TabIndex = 1;
            this.CharListBox.SelectedIndexChanged += new System.EventHandler(this.CharListBox_SelectedIndexChanged);
            // 
            // charSheetboxitems
            // 
            this.charSheetboxitems.FormattingEnabled = true;
            this.charSheetboxitems.ItemHeight = 16;
            this.charSheetboxitems.Location = new System.Drawing.Point(93, 224);
            this.charSheetboxitems.Name = "charSheetboxitems";
            this.charSheetboxitems.Size = new System.Drawing.Size(303, 212);
            this.charSheetboxitems.TabIndex = 2;
            this.charSheetboxitems.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(362, 136);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(98, 43);
            this.select.TabIndex = 3;
            this.select.Text = "Select and Start Game";
            this.select.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back to Character Creation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.select);
            this.Controls.Add(this.charSheetboxitems);
            this.Controls.Add(this.CharListBox);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CharListBox;
        private System.Windows.Forms.ListBox charSheetboxitems; 
        //contains all attributes of character in selected combobox character
        private System.Windows.Forms.Button select; //starts game

        

        private System.Windows.Forms.Button button1;
        //List<Character
    }
}