namespace WindowQuoteProGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            quoteName_txtBox = new TextBox();
            customerName_txtBox = new TextBox();
            quoteName_lbl = new Label();
            customerName_lbl = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            new_btn = new Button();
            edit_btn = new Button();
            delete_btn = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(735, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // quoteName_txtBox
            // 
            quoteName_txtBox.Location = new Point(112, 38);
            quoteName_txtBox.Name = "quoteName_txtBox";
            quoteName_txtBox.Size = new Size(182, 23);
            quoteName_txtBox.TabIndex = 1;
            // 
            // customerName_txtBox
            // 
            customerName_txtBox.Location = new Point(112, 70);
            customerName_txtBox.Name = "customerName_txtBox";
            customerName_txtBox.Size = new Size(182, 23);
            customerName_txtBox.TabIndex = 2;
            // 
            // quoteName_lbl
            // 
            quoteName_lbl.AutoSize = true;
            quoteName_lbl.Location = new Point(12, 43);
            quoteName_lbl.Name = "quoteName_lbl";
            quoteName_lbl.Size = new Size(75, 15);
            quoteName_lbl.TabIndex = 5;
            quoteName_lbl.Text = "Quote Name";
            // 
            // customerName_lbl
            // 
            customerName_lbl.AutoSize = true;
            customerName_lbl.Location = new Point(12, 74);
            customerName_lbl.Name = "customerName_lbl";
            customerName_lbl.Size = new Size(94, 15);
            customerName_lbl.TabIndex = 6;
            customerName_lbl.Text = "Customer Name";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(112, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(112, 134);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 9;
            label1.Text = "Door Material";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 10;
            label2.Text = "Door Size";
            // 
            // new_btn
            // 
            new_btn.Location = new Point(112, 191);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(168, 36);
            new_btn.TabIndex = 11;
            new_btn.Text = "New";
            new_btn.UseVisualStyleBackColor = true;
            // 
            // edit_btn
            // 
            edit_btn.Location = new Point(286, 191);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(168, 36);
            edit_btn.TabIndex = 12;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(460, 191);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(168, 36);
            delete_btn.TabIndex = 13;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(12, 264);
            listView1.Name = "listView1";
            listView1.Size = new Size(714, 384);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Customer Name";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Door Material";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Door Size";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Price";
            columnHeader6.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 660);
            Controls.Add(listView1);
            Controls.Add(delete_btn);
            Controls.Add(edit_btn);
            Controls.Add(new_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(customerName_lbl);
            Controls.Add(quoteName_lbl);
            Controls.Add(customerName_txtBox);
            Controls.Add(quoteName_txtBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox quoteName_txtBox;
        private TextBox customerName_txtBox;
        private Label quoteName_lbl;
        private Label customerName_lbl;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Button new_btn;
        private Button edit_btn;
        private Button delete_btn;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}
