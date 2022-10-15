namespace WinFormsAdminApp.DockingForms
{
    partial class Products
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.tbNewPrice = new System.Windows.Forms.TextBox();
            this.panel27 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProducts);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 450);
            this.panel1.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.proActive});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(10, 20);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(305, 410);
            this.dgvProducts.TabIndex = 3;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "Id";
            this.ProdId.Name = "ProdId";
            this.ProdId.ReadOnly = true;
            this.ProdId.Visible = false;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "Name";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "Price";
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.ReadOnly = true;
            // 
            // proActive
            // 
            this.proActive.HeaderText = "Active";
            this.proActive.Name = "proActive";
            this.proActive.ReadOnly = true;
            this.proActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.proActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 430);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(305, 20);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 430);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(315, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 430);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 20);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel30);
            this.panel6.Controls.Add(this.panel29);
            this.panel6.Controls.Add(this.panel28);
            this.panel6.Controls.Add(this.panel27);
            this.panel6.Controls.Add(this.panel26);
            this.panel6.Controls.Add(this.panel25);
            this.panel6.Controls.Add(this.panel24);
            this.panel6.Controls.Add(this.panel18);
            this.panel6.Controls.Add(this.panel17);
            this.panel6.Controls.Add(this.panel16);
            this.panel6.Controls.Add(this.panel15);
            this.panel6.Controls.Add(this.panel14);
            this.panel6.Controls.Add(this.panel13);
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(325, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 450);
            this.panel6.TabIndex = 1;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.btnNew);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel30.Location = new System.Drawing.Point(10, 300);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(226, 20);
            this.panel30.TabIndex = 22;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(226, 20);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel29
            // 
            this.panel29.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel29.Location = new System.Drawing.Point(10, 280);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(226, 20);
            this.panel29.TabIndex = 21;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.tbNewPrice);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel28.Location = new System.Drawing.Point(10, 260);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(226, 20);
            this.panel28.TabIndex = 20;
            // 
            // tbNewPrice
            // 
            this.tbNewPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNewPrice.Location = new System.Drawing.Point(0, 0);
            this.tbNewPrice.Name = "tbNewPrice";
            this.tbNewPrice.Size = new System.Drawing.Size(226, 20);
            this.tbNewPrice.TabIndex = 2;
            this.tbNewPrice.TextChanged += new System.EventHandler(this.tbNumberValidator);
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.label5);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel27.Location = new System.Drawing.Point(10, 240);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(226, 20);
            this.panel27.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "New Product Price";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.tbNewName);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel26.Location = new System.Drawing.Point(10, 220);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(226, 20);
            this.panel26.TabIndex = 18;
            // 
            // tbNewName
            // 
            this.tbNewName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNewName.Location = new System.Drawing.Point(0, 0);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(226, 20);
            this.tbNewName.TabIndex = 1;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.label4);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel25.Location = new System.Drawing.Point(10, 200);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(226, 20);
            this.panel25.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "New Product Name";
            // 
            // panel24
            // 
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(10, 180);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(226, 20);
            this.panel24.TabIndex = 16;
            // 
            // panel18
            // 
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(10, 160);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(226, 20);
            this.panel18.TabIndex = 10;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btnSave);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(10, 140);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(226, 20);
            this.panel17.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(226, 20);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.cbActive);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(10, 120);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(226, 20);
            this.panel16.TabIndex = 8;
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Enabled = false;
            this.cbActive.Location = new System.Drawing.Point(0, 0);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(15, 14);
            this.cbActive.TabIndex = 0;
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label3);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(10, 100);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(226, 20);
            this.panel15.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Active";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.tbPrice);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(10, 80);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(226, 20);
            this.panel14.TabIndex = 6;
            // 
            // tbPrice
            // 
            this.tbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPrice.Enabled = false;
            this.tbPrice.Location = new System.Drawing.Point(0, 0);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(226, 20);
            this.tbPrice.TabIndex = 1;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbNumberValidator);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label2);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(10, 60);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(226, 20);
            this.panel13.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.tbName);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(10, 40);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(226, 20);
            this.panel12.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(0, 0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(226, 20);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lbl1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(10, 20);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(226, 20);
            this.panel11.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl1.Location = new System.Drawing.Point(0, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Name";
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(10, 430);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(226, 20);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 430);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(236, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 430);
            this.panel9.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(246, 20);
            this.panel10.TabIndex = 0;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.ShowIcon = false;
            this.Text = "Products";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn proActive;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.TextBox tbNewPrice;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel24;
    }
}