namespace RedoCapstone
{
    partial class formTitleScreen
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
            this.tplMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCharCreate = new System.Windows.Forms.Button();
            this.btnCharSelect = new System.Windows.Forms.Button();
            this.tplMain.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tplMain
            // 
            this.tplMain.AutoSize = true;
            this.tplMain.ColumnCount = 1;
            this.tplMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1455F));
            this.tplMain.Controls.Add(this.lblTitle, 0, 0);
            this.tplMain.Controls.Add(this.tlpButtons, 0, 1);
            this.tplMain.Location = new System.Drawing.Point(12, 12);
            this.tplMain.Name = "tplMain";
            this.tplMain.RowCount = 2;
            this.tplMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.52929F));
            this.tplMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.47071F));
            this.tplMain.Size = new System.Drawing.Size(1455, 973);
            this.tplMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 315);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1415, 108);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "RPG Manager";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpButtons.ColumnCount = 1;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.Controls.Add(this.btnCharCreate, 0, 0);
            this.tlpButtons.Controls.Add(this.btnCharSelect, 0, 1);
            this.tlpButtons.Location = new System.Drawing.Point(487, 463);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(20);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 2;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Size = new System.Drawing.Size(480, 208);
            this.tlpButtons.TabIndex = 1;
            // 
            // btnCharCreate
            // 
            this.btnCharCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCharCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharCreate.Location = new System.Drawing.Point(10, 10);
            this.btnCharCreate.Margin = new System.Windows.Forms.Padding(10);
            this.btnCharCreate.Name = "btnCharCreate";
            this.btnCharCreate.Size = new System.Drawing.Size(460, 84);
            this.btnCharCreate.TabIndex = 0;
            this.btnCharCreate.Text = "Create New Character";
            this.btnCharCreate.UseVisualStyleBackColor = true;
            this.btnCharCreate.Click += new System.EventHandler(this.btnCharCreate_Click);
            // 
            // btnCharSelect
            // 
            this.btnCharSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCharSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharSelect.Location = new System.Drawing.Point(10, 114);
            this.btnCharSelect.Margin = new System.Windows.Forms.Padding(10);
            this.btnCharSelect.Name = "btnCharSelect";
            this.btnCharSelect.Size = new System.Drawing.Size(460, 84);
            this.btnCharSelect.TabIndex = 1;
            this.btnCharSelect.Text = "Select Character";
            this.btnCharSelect.UseVisualStyleBackColor = true;
            this.btnCharSelect.Click += new System.EventHandler(this.btnCharSelect_Click);
            // 
            // formTitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 997);
            this.Controls.Add(this.tplMain);
            this.Name = "formTitleScreen";
            this.Text = "Title Form";
            this.Load += new System.EventHandler(this.TitleForm_Load);
            this.tplMain.ResumeLayout(false);
            this.tplMain.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tplMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnCharCreate;
        private System.Windows.Forms.Button btnCharSelect;
    }
}

