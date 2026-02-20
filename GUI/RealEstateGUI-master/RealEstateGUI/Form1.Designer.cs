namespace RealEstateGUI
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.eladolabel = new System.Windows.Forms.Label();
            this.eladonevlabel = new System.Windows.Forms.Label();
            this.telelabel = new System.Windows.Forms.Label();
            this.teleszamlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hirdetlabel = new System.Windows.Forms.Label();
            this.hirdblabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 502);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.hirdblabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.eladolabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.eladonevlabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.teleszamlabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.telelabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.hirdetlabel, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(196, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 335);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // eladolabel
            // 
            this.eladolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.eladolabel.AutoSize = true;
            this.eladolabel.Location = new System.Drawing.Point(3, 35);
            this.eladolabel.Name = "eladolabel";
            this.eladolabel.Size = new System.Drawing.Size(99, 13);
            this.eladolabel.TabIndex = 0;
            this.eladolabel.Text = "Eladó neve:";
            // 
            // eladonevlabel
            // 
            this.eladonevlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.eladonevlabel.AutoSize = true;
            this.eladonevlabel.Location = new System.Drawing.Point(108, 35);
            this.eladonevlabel.Name = "eladonevlabel";
            this.eladonevlabel.Size = new System.Drawing.Size(475, 13);
            this.eladonevlabel.TabIndex = 1;
            this.eladonevlabel.Text = "eladonevlabel";
            // 
            // telelabel
            // 
            this.telelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.telelabel.AutoSize = true;
            this.telelabel.Location = new System.Drawing.Point(3, 118);
            this.telelabel.Name = "telelabel";
            this.telelabel.Size = new System.Drawing.Size(99, 13);
            this.telelabel.TabIndex = 4;
            this.telelabel.Text = "Eladó telefonszáma";
            // 
            // teleszamlabel
            // 
            this.teleszamlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.teleszamlabel.AutoSize = true;
            this.teleszamlabel.Location = new System.Drawing.Point(108, 118);
            this.teleszamlabel.Name = "teleszamlabel";
            this.teleszamlabel.Size = new System.Drawing.Size(475, 13);
            this.teleszamlabel.TabIndex = 2;
            this.teleszamlabel.Text = "teleszamlabel";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Location = new System.Drawing.Point(3, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(580, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hírdetések betöltése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // hirdetlabel
            // 
            this.hirdetlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hirdetlabel.AutoSize = true;
            this.hirdetlabel.Location = new System.Drawing.Point(3, 285);
            this.hirdetlabel.Name = "hirdetlabel";
            this.hirdetlabel.Size = new System.Drawing.Size(99, 13);
            this.hirdetlabel.TabIndex = 6;
            this.hirdetlabel.Text = "Hirdetések száma";
            // 
            // hirdblabel
            // 
            this.hirdblabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hirdblabel.AutoSize = true;
            this.hirdblabel.Location = new System.Drawing.Point(108, 285);
            this.hirdblabel.Name = "hirdblabel";
            this.hirdblabel.Size = new System.Drawing.Size(475, 13);
            this.hirdblabel.TabIndex = 7;
            this.hirdblabel.Text = "hirdblabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label eladolabel;
        private System.Windows.Forms.Label eladonevlabel;
        private System.Windows.Forms.Label hirdblabel;
        private System.Windows.Forms.Label teleszamlabel;
        private System.Windows.Forms.Label telelabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label hirdetlabel;
    }
}

