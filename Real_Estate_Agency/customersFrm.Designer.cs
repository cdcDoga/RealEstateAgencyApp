namespace Real_Estate_Agency
{
    partial class customersFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customersFrm));
            this.lvOwners = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOwnerLV = new System.Windows.Forms.Label();
            this.lblPurchaserLV = new System.Windows.Forms.Label();
            this.lvPurchasers = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHomeCustomer = new System.Windows.Forms.Button();
            this.btnAddPurchaser = new System.Windows.Forms.Button();
            this.btnHelpCustomer = new System.Windows.Forms.Button();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvOwners
            // 
            this.lvOwners.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader11});
            this.lvOwners.FullRowSelect = true;
            this.lvOwners.GridLines = true;
            this.lvOwners.Location = new System.Drawing.Point(28, 120);
            this.lvOwners.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvOwners.MultiSelect = false;
            this.lvOwners.Name = "lvOwners";
            this.lvOwners.Size = new System.Drawing.Size(556, 435);
            this.lvOwners.TabIndex = 0;
            this.lvOwners.UseCompatibleStateImageBehavior = false;
            this.lvOwners.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Surname";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Address";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Registration Date";
            this.columnHeader11.Width = 110;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1026, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblOwnerLV
            // 
            this.lblOwnerLV.AutoSize = true;
            this.lblOwnerLV.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOwnerLV.Location = new System.Drawing.Point(24, 60);
            this.lblOwnerLV.Name = "lblOwnerLV";
            this.lblOwnerLV.Size = new System.Drawing.Size(114, 19);
            this.lblOwnerLV.TabIndex = 15;
            this.lblOwnerLV.Text = "Owner Details";
            // 
            // lblPurchaserLV
            // 
            this.lblPurchaserLV.AutoSize = true;
            this.lblPurchaserLV.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPurchaserLV.Location = new System.Drawing.Point(610, 60);
            this.lblPurchaserLV.Name = "lblPurchaserLV";
            this.lblPurchaserLV.Size = new System.Drawing.Size(139, 19);
            this.lblPurchaserLV.TabIndex = 16;
            this.lblPurchaserLV.Text = "Purchaser Details";
            // 
            // lvPurchasers
            // 
            this.lvPurchasers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12});
            this.lvPurchasers.FullRowSelect = true;
            this.lvPurchasers.GridLines = true;
            this.lvPurchasers.Location = new System.Drawing.Point(614, 120);
            this.lvPurchasers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvPurchasers.MultiSelect = false;
            this.lvPurchasers.Name = "lvPurchasers";
            this.lvPurchasers.Size = new System.Drawing.Size(551, 435);
            this.lvPurchasers.TabIndex = 17;
            this.lvPurchasers.UseCompatibleStateImageBehavior = false;
            this.lvPurchasers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Surname";
            this.columnHeader8.Width = 75;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Address";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Phone";
            this.columnHeader10.Width = 75;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Registration Date";
            this.columnHeader12.Width = 110;
            // 
            // btnHomeCustomer
            // 
            this.btnHomeCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHomeCustomer.BackgroundImage")));
            this.btnHomeCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHomeCustomer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHomeCustomer.Location = new System.Drawing.Point(28, 589);
            this.btnHomeCustomer.Name = "btnHomeCustomer";
            this.btnHomeCustomer.Size = new System.Drawing.Size(42, 42);
            this.btnHomeCustomer.TabIndex = 20;
            this.btnHomeCustomer.UseVisualStyleBackColor = true;
            this.btnHomeCustomer.Click += new System.EventHandler(this.btnHomeCustomer_Click);
            // 
            // btnAddPurchaser
            // 
            this.btnAddPurchaser.Location = new System.Drawing.Point(924, 584);
            this.btnAddPurchaser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddPurchaser.Name = "btnAddPurchaser";
            this.btnAddPurchaser.Size = new System.Drawing.Size(112, 53);
            this.btnAddPurchaser.TabIndex = 18;
            this.btnAddPurchaser.Text = "Add Purchaser";
            this.btnAddPurchaser.UseVisualStyleBackColor = true;
            this.btnAddPurchaser.Click += new System.EventHandler(this.btnAddPurchaser_Click);
            // 
            // btnHelpCustomer
            // 
            this.btnHelpCustomer.Location = new System.Drawing.Point(1053, 584);
            this.btnHelpCustomer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnHelpCustomer.Name = "btnHelpCustomer";
            this.btnHelpCustomer.Size = new System.Drawing.Size(112, 53);
            this.btnHelpCustomer.TabIndex = 19;
            this.btnHelpCustomer.Text = "Help";
            this.btnHelpCustomer.UseVisualStyleBackColor = true;
            this.btnHelpCustomer.Click += new System.EventHandler(this.btnHelpCustomer_Click);
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(472, 584);
            this.btnAddOwner.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(112, 53);
            this.btnAddOwner.TabIndex = 21;
            this.btnAddOwner.Text = "Add Owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1023, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // customersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.btnHomeCustomer);
            this.Controls.Add(this.btnAddPurchaser);
            this.Controls.Add(this.btnHelpCustomer);
            this.Controls.Add(this.lvPurchasers);
            this.Controls.Add(this.lblPurchaserLV);
            this.Controls.Add(this.lblOwnerLV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvOwners);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "customersFrm";
            this.Text = "customersFrm";
            this.Load += new System.EventHandler(this.customersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvOwners;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblOwnerLV;
        private System.Windows.Forms.Label lblPurchaserLV;
        private System.Windows.Forms.ListView lvPurchasers;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnHomeCustomer;
        private System.Windows.Forms.Button btnAddPurchaser;
        private System.Windows.Forms.Button btnHelpCustomer;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label1;
    }
}