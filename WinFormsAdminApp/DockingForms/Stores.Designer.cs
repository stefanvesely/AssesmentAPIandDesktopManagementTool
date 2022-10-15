namespace WinFormsAdminApp.DockingForms
{
    partial class Stores
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
            this.dgvStores = new System.Windows.Forms.DataGridView();
            this.clmStoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.tbNewTelephone = new System.Windows.Forms.TextBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.rtbNewAddress = new System.Windows.Forms.RichTextBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cbUpdateActive = new System.Windows.Forms.CheckBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tbUpdateTelephone = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.rtbUpdateAddress = new System.Windows.Forms.RichTextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tbUpdateName = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStores);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 450);
            this.panel1.TabIndex = 0;
            // 
            // dgvStores
            // 
            this.dgvStores.AllowUserToAddRows = false;
            this.dgvStores.AllowUserToDeleteRows = false;
            this.dgvStores.AllowUserToResizeColumns = false;
            this.dgvStores.AllowUserToResizeRows = false;
            this.dgvStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStoreId,
            this.clmStoreName,
            this.clmAddress,
            this.clmTelephone,
            this.clmActive});
            this.dgvStores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStores.Location = new System.Drawing.Point(14, 20);
            this.dgvStores.Name = "dgvStores";
            this.dgvStores.ReadOnly = true;
            this.dgvStores.RowHeadersVisible = false;
            this.dgvStores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStores.Size = new System.Drawing.Size(507, 418);
            this.dgvStores.TabIndex = 5;
            this.dgvStores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStores_CellClick);
            // 
            // clmStoreId
            // 
            this.clmStoreId.HeaderText = "Id";
            this.clmStoreId.Name = "clmStoreId";
            this.clmStoreId.ReadOnly = true;
            this.clmStoreId.Visible = false;
            // 
            // clmStoreName
            // 
            this.clmStoreName.HeaderText = "Name";
            this.clmStoreName.Name = "clmStoreName";
            this.clmStoreName.ReadOnly = true;
            // 
            // clmAddress
            // 
            this.clmAddress.FillWeight = 200F;
            this.clmAddress.HeaderText = "Address";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.ReadOnly = true;
            this.clmAddress.Width = 200;
            // 
            // clmTelephone
            // 
            this.clmTelephone.HeaderText = "Telephone";
            this.clmTelephone.Name = "clmTelephone";
            this.clmTelephone.ReadOnly = true;
            // 
            // clmActive
            // 
            this.clmActive.HeaderText = "Active";
            this.clmActive.Name = "clmActive";
            this.clmActive.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(14, 438);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(507, 12);
            this.panel5.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(521, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 430);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 430);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(535, 20);
            this.panel6.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stores";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel24);
            this.panel4.Controls.Add(this.panel23);
            this.panel4.Controls.Add(this.panel22);
            this.panel4.Controls.Add(this.panel21);
            this.panel4.Controls.Add(this.panel20);
            this.panel4.Controls.Add(this.panel19);
            this.panel4.Controls.Add(this.panel18);
            this.panel4.Controls.Add(this.panel17);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel16);
            this.panel4.Controls.Add(this.panel15);
            this.panel4.Controls.Add(this.panel14);
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(535, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 450);
            this.panel4.TabIndex = 1;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.btnNew);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 407);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(265, 20);
            this.panel24.TabIndex = 18;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(265, 20);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Save New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel23
            // 
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(0, 387);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(265, 20);
            this.panel23.TabIndex = 17;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.tbNewTelephone);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(0, 367);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(265, 20);
            this.panel22.TabIndex = 16;
            // 
            // tbNewTelephone
            // 
            this.tbNewTelephone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNewTelephone.Location = new System.Drawing.Point(0, 0);
            this.tbNewTelephone.Name = "tbNewTelephone";
            this.tbNewTelephone.Size = new System.Drawing.Size(265, 20);
            this.tbNewTelephone.TabIndex = 1;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.label7);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(0, 347);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(265, 20);
            this.panel21.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Telephone";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.rtbNewAddress);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 291);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(265, 56);
            this.panel20.TabIndex = 14;
            // 
            // rtbNewAddress
            // 
            this.rtbNewAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNewAddress.Location = new System.Drawing.Point(0, 0);
            this.rtbNewAddress.Name = "rtbNewAddress";
            this.rtbNewAddress.Size = new System.Drawing.Size(265, 56);
            this.rtbNewAddress.TabIndex = 0;
            this.rtbNewAddress.Text = "";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label6);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 271);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(265, 20);
            this.panel19.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Store Address";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.tbNewName);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 251);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(265, 20);
            this.panel18.TabIndex = 12;
            // 
            // tbNewName
            // 
            this.tbNewName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNewName.Location = new System.Drawing.Point(0, 0);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(265, 20);
            this.tbNewName.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label5);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 231);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(265, 20);
            this.panel17.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Store Name";
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 211);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(265, 20);
            this.panel8.TabIndex = 10;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btnSaveUpdate);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 191);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(265, 20);
            this.panel16.TabIndex = 9;
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveUpdate.Enabled = false;
            this.btnSaveUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(265, 20);
            this.btnSaveUpdate.TabIndex = 0;
            this.btnSaveUpdate.Text = "Save Changes";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.cbUpdateActive);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 171);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(265, 20);
            this.panel15.TabIndex = 8;
            // 
            // cbUpdateActive
            // 
            this.cbUpdateActive.AutoSize = true;
            this.cbUpdateActive.Enabled = false;
            this.cbUpdateActive.Location = new System.Drawing.Point(3, 0);
            this.cbUpdateActive.Name = "cbUpdateActive";
            this.cbUpdateActive.Size = new System.Drawing.Size(56, 17);
            this.cbUpdateActive.TabIndex = 0;
            this.cbUpdateActive.Text = "Active";
            this.cbUpdateActive.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.tbUpdateTelephone);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 151);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(265, 20);
            this.panel14.TabIndex = 7;
            // 
            // tbUpdateTelephone
            // 
            this.tbUpdateTelephone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUpdateTelephone.Enabled = false;
            this.tbUpdateTelephone.Location = new System.Drawing.Point(0, 0);
            this.tbUpdateTelephone.Name = "tbUpdateTelephone";
            this.tbUpdateTelephone.Size = new System.Drawing.Size(265, 20);
            this.tbUpdateTelephone.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label4);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 131);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(265, 20);
            this.panel13.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telephone";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.rtbUpdateAddress);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 80);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(265, 51);
            this.panel12.TabIndex = 5;
            // 
            // rtbUpdateAddress
            // 
            this.rtbUpdateAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbUpdateAddress.Enabled = false;
            this.rtbUpdateAddress.Location = new System.Drawing.Point(0, 0);
            this.rtbUpdateAddress.Name = "rtbUpdateAddress";
            this.rtbUpdateAddress.Size = new System.Drawing.Size(265, 51);
            this.rtbUpdateAddress.TabIndex = 0;
            this.rtbUpdateAddress.Text = "";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label3);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 60);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(265, 20);
            this.panel11.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Store Address";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.tbUpdateName);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 40);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(265, 20);
            this.panel10.TabIndex = 3;
            // 
            // tbUpdateName
            // 
            this.tbUpdateName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUpdateName.Enabled = false;
            this.tbUpdateName.Location = new System.Drawing.Point(0, 0);
            this.tbUpdateName.Name = "tbUpdateName";
            this.tbUpdateName.Size = new System.Drawing.Size(265, 20);
            this.tbUpdateName.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(265, 20);
            this.panel9.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Store Name";
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(265, 20);
            this.panel7.TabIndex = 0;
            // 
            // Stores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stores";
            this.Text = "Stores";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvStores;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelephone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmActive;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox tbNewTelephone;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.RichTextBox rtbNewAddress;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.CheckBox cbUpdateActive;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox tbUpdateTelephone;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.RichTextBox rtbUpdateAddress;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox tbUpdateName;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
    }
}