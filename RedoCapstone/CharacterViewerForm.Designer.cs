using System.Windows.Forms;

namespace RedoCapstone
{
    partial class CharacterViewerForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Eqiupment", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Iron Sword",
            "Weapon",
            "A Sharp Blade used by Warriors",
            "x1",
            "4 lbs"}, -1);
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.lblHP = new System.Windows.Forms.Label();
            this.numHP = new System.Windows.Forms.NumericUpDown();
            this.lblStamina = new System.Windows.Forms.Label();
            this.numStamina = new System.Windows.Forms.NumericUpDown();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblWill = new System.Windows.Forms.Label();
            this.txtDex = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtWill = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblInventory = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.invName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.invWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStamina)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 5);
            this.lblName.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(153, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblSpecies
            // 
            this.lblSpecies.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(3, 35);
            this.lblSpecies.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(70, 20);
            this.lblSpecies.TabIndex = 2;
            this.lblSpecies.Text = "Species:";
            this.lblSpecies.Click += new System.EventHandler(this.lblSpecies_Click);
            // 
            // txtSpecies
            // 
            this.txtSpecies.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecies.Location = new System.Drawing.Point(153, 33);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(100, 26);
            this.txtSpecies.TabIndex = 3;
            // 
            // lblHP
            // 
            this.lblHP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(3, 65);
            this.lblHP.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(81, 20);
            this.lblHP.TabIndex = 4;
            this.lblHP.Text = "Hit Points:";
            this.lblHP.Click += new System.EventHandler(this.lblHP_Click);
            // 
            // numHP
            // 
            this.numHP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHP.Location = new System.Drawing.Point(153, 63);
            this.numHP.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numHP.Name = "numHP";
            this.numHP.Size = new System.Drawing.Size(120, 26);
            this.numHP.TabIndex = 5;
            this.numHP.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblStamina
            // 
            this.lblStamina.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStamina.AutoSize = true;
            this.lblStamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStamina.Location = new System.Drawing.Point(3, 95);
            this.lblStamina.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblStamina.Name = "lblStamina";
            this.lblStamina.Size = new System.Drawing.Size(72, 20);
            this.lblStamina.TabIndex = 6;
            this.lblStamina.Text = "Stamina:";
            this.lblStamina.Click += new System.EventHandler(this.lblStamina_Click);
            // 
            // numStamina
            // 
            this.numStamina.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numStamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStamina.Location = new System.Drawing.Point(153, 93);
            this.numStamina.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numStamina.Name = "numStamina";
            this.numStamina.Size = new System.Drawing.Size(120, 26);
            this.numStamina.TabIndex = 7;
            this.numStamina.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblDex
            // 
            this.lblDex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDex.AutoSize = true;
            this.lblDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDex.Location = new System.Drawing.Point(3, 125);
            this.lblDex.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(75, 20);
            this.lblDex.TabIndex = 8;
            this.lblDex.Text = "Dexterity:";
            this.lblDex.Click += new System.EventHandler(this.lblDex_Click);
            // 
            // lblCon
            // 
            this.lblCon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(3, 155);
            this.lblCon.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(98, 20);
            this.lblCon.TabIndex = 10;
            this.lblCon.Text = "Constitution:";
            this.lblCon.Click += new System.EventHandler(this.lblCon_Click);
            // 
            // lblWill
            // 
            this.lblWill.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWill.AutoSize = true;
            this.lblWill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWill.Location = new System.Drawing.Point(3, 185);
            this.lblWill.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblWill.Name = "lblWill";
            this.lblWill.Size = new System.Drawing.Size(80, 20);
            this.lblWill.TabIndex = 12;
            this.lblWill.Text = "Willpower:";
            this.lblWill.Click += new System.EventHandler(this.lblWill_Click);
            // 
            // txtDex
            // 
            this.txtDex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDex.Location = new System.Drawing.Point(153, 123);
            this.txtDex.Name = "txtDex";
            this.txtDex.Size = new System.Drawing.Size(100, 26);
            this.txtDex.TabIndex = 9;
            // 
            // txtCon
            // 
            this.txtCon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCon.Location = new System.Drawing.Point(153, 153);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(100, 26);
            this.txtCon.TabIndex = 11;
            // 
            // txtWill
            // 
            this.txtWill.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtWill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWill.Location = new System.Drawing.Point(153, 183);
            this.txtWill.Name = "txtWill";
            this.txtWill.Size = new System.Drawing.Size(100, 26);
            this.txtWill.TabIndex = 13;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(3, 920);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load Character";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(153, 920);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save Character";
            // 
            // btnAddItem
            // 
            this.btnAddItem.AutoSize = true;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(3, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(84, 30);
            this.btnAddItem.TabIndex = 18;
            this.btnAddItem.Text = "Add Item";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(0, 0);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveItem.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.txtWeight, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.lblWeight, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.lblInventory, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.btnSave, 1, 10);
            this.tableLayoutPanel.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblSpecies, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtSpecies, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblHP, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.numHP, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblStamina, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.numStamina, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblDex, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.txtDex, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.lblCon, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.txtCon, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.lblWill, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.txtWill, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.listView1, 0, 9);
            this.tableLayoutPanel.Controls.Add(this.btnLoad, 0, 10);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 1, 8);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.MinimumSize = new System.Drawing.Size(100, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 11;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(792, 947);
            this.tableLayoutPanel.TabIndex = 1;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint);
            // 
            // lblInventory
            // 
            this.lblInventory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(3, 250);
            this.lblInventory.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(74, 20);
            this.lblInventory.TabIndex = 21;
            this.lblInventory.Text = "Inventory";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.invName,
            this.invType,
            this.invDescription,
            this.invQuantity,
            this.invWeight});
            this.tableLayoutPanel.SetColumnSpan(this.listView1, 2);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            listViewGroup1.Header = "Eqiupment";
            listViewGroup1.Name = "Equipment";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(3, 283);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(786, 631);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // invName
            // 
            this.invName.Text = "Name";
            this.invName.Width = 100;
            // 
            // invType
            // 
            this.invType.Text = "Type";
            this.invType.Width = 100;
            // 
            // invDescription
            // 
            this.invDescription.Text = "Description";
            this.invDescription.Width = 380;
            // 
            // invQuantity
            // 
            this.invQuantity.Text = "Quantity";
            this.invQuantity.Width = 100;
            // 
            // invWeight
            // 
            this.invWeight.Text = "Weight";
            this.invWeight.Width = 100;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddItem);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(153, 243);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(636, 34);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(3, 215);
            this.lblWeight.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(63, 20);
            this.lblWeight.TabIndex = 23;
            this.lblWeight.Text = "Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(153, 213);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 26);
            this.txtWeight.TabIndex = 24;
            // 
            // CharacterViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 947);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "CharacterViewerForm";
            this.Text = "Character Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStamina)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblWill;
        private System.Windows.Forms.Label lblStamina;
        private System.Windows.Forms.TextBox txtDex;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.TextBox txtWill;
        private System.Windows.Forms.TextBox txtStamina;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.NumericUpDown numHP;
        private System.Windows.Forms.NumericUpDown numStamina;
        private ListView listView1;
        private ColumnHeader invName;
        private ColumnHeader invType;
        private ColumnHeader invDescription;
        private ColumnHeader invQuantity;
        private ColumnHeader invWeight;
        private Label lblInventory;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtWeight;
        private Label lblWeight;
    }
}