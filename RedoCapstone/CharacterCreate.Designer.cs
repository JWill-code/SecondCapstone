﻿namespace RedoCapstone
{
    partial class CharacterCreate
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
            this.backToHomeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "There are many options for characters.";
            // 
            // backToHomeButton
            // 
            this.backToHomeButton.Location = new System.Drawing.Point(528, 45);
            this.backToHomeButton.Name = "backToHomeButton";
            this.backToHomeButton.Size = new System.Drawing.Size(110, 23);
            this.backToHomeButton.TabIndex = 1;
            this.backToHomeButton.Text = "Back To Home";
            this.backToHomeButton.UseVisualStyleBackColor = true;
            this.backToHomeButton.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save All Stats";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(62, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(73, 97);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // CharacterCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backToHomeButton);
            this.Controls.Add(this.textBox1);
            this.Name = "CharacterCreate";
            this.Text = "CharacterCreate";
            this.Load += new System.EventHandler(this.CharacterCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button backToHomeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}