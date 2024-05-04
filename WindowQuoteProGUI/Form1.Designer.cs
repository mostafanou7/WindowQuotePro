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
            doorMaterial_cb = new ComboBox();
            doorSize_cb = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            create_btn = new Button();
            update_btn = new Button();
            delete_btn = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            ID_txtbox = new TextBox();
            price_txtbox = new TextBox();
            label3 = new Label();
            label4 = new Label();
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
            // doorMaterial_cb
            // 
            doorMaterial_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            doorMaterial_cb.FormattingEnabled = true;
            doorMaterial_cb.Location = new Point(112, 102);
            doorMaterial_cb.Name = "doorMaterial_cb";
            doorMaterial_cb.Size = new Size(121, 23);
            doorMaterial_cb.TabIndex = 7;
            // 
            // doorSize_cb
            // 
            doorSize_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            doorSize_cb.FormattingEnabled = true;
            doorSize_cb.Location = new Point(112, 134);
            doorSize_cb.Name = "doorSize_cb";
            doorSize_cb.Size = new Size(121, 23);
            doorSize_cb.TabIndex = 8;
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
            // create_btn
            // 
            create_btn.Location = new Point(112, 191);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(168, 36);
            create_btn.TabIndex = 11;
            create_btn.Text = "Create";
            create_btn.UseVisualStyleBackColor = true;
            create_btn.Click += create_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(286, 191);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(168, 36);
            update_btn.TabIndex = 12;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
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
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            // ID_txtbox
            // 
            ID_txtbox.Enabled = false;
            ID_txtbox.Location = new Point(425, 43);
            ID_txtbox.Name = "ID_txtbox";
            ID_txtbox.Size = new Size(77, 23);
            ID_txtbox.TabIndex = 15;
            // 
            // price_txtbox
            // 
            price_txtbox.Enabled = false;
            price_txtbox.Location = new Point(425, 74);
            price_txtbox.Name = "price_txtbox";
            price_txtbox.Size = new Size(77, 23);
            price_txtbox.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 46);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 17;
            label3.Text = "Quote ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 77);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 18;
            label4.Text = "Price";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 660);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(price_txtbox);
            Controls.Add(ID_txtbox);
            Controls.Add(listView1);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(create_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(doorSize_cb);
            Controls.Add(doorMaterial_cb);
            Controls.Add(customerName_lbl);
            Controls.Add(quoteName_lbl);
            Controls.Add(customerName_txtBox);
            Controls.Add(quoteName_txtBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Window Quote Pro";
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
        private ComboBox doorMaterial_cb;
        private ComboBox doorSize_cb;
        private Label label1;
        private Label label2;
        private Button create_btn;
        private Button update_btn;
        private Button delete_btn;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox ID_txtbox;
        private TextBox price_txtbox;
        private Label label3;
        private Label label4;
    }
}
