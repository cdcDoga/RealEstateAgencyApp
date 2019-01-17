namespace Real_Estate_Agency
{
    partial class estatesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estatesFrm));
            this.lvEstates = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEstate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddEstate = new System.Windows.Forms.Button();
            this.btnHelpEstate = new System.Windows.Forms.Button();
            this.btnHomeEstate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvEstates
            // 
            this.lvEstates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvEstates.FullRowSelect = true;
            this.lvEstates.GridLines = true;
            this.lvEstates.Location = new System.Drawing.Point(70, 108);
            this.lvEstates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvEstates.MultiSelect = false;
            this.lvEstates.Name = "lvEstates";
            this.lvEstates.Size = new System.Drawing.Size(1041, 435);
            this.lvEstates.TabIndex = 0;
            this.lvEstates.UseCompatibleStateImageBehavior = false;
            this.lvEstates.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Estate No";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Location";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "m²";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Level";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "# of Rooms";
            this.columnHeader6.Width = 75;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Status";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Year(Construction)";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Heating System";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Extra Information";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Price";
            this.columnHeader11.Width = 90;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Registration Date";
            this.columnHeader12.Width = 120;
            // 
            // lblEstate
            // 
            this.lblEstate.AutoSize = true;
            this.lblEstate.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEstate.Location = new System.Drawing.Point(66, 53);
            this.lblEstate.Name = "lblEstate";
            this.lblEstate.Size = new System.Drawing.Size(106, 19);
            this.lblEstate.TabIndex = 11;
            this.lblEstate.Text = "Estate Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(972, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddEstate
            // 
            this.btnAddEstate.Location = new System.Drawing.Point(847, 574);
            this.btnAddEstate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddEstate.Name = "btnAddEstate";
            this.btnAddEstate.Size = new System.Drawing.Size(112, 53);
            this.btnAddEstate.TabIndex = 14;
            this.btnAddEstate.Text = "Add Estate";
            this.btnAddEstate.UseVisualStyleBackColor = true;
            this.btnAddEstate.Click += new System.EventHandler(this.btnAddEstate_Click);
            // 
            // btnHelpEstate
            // 
            this.btnHelpEstate.Location = new System.Drawing.Point(999, 574);
            this.btnHelpEstate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnHelpEstate.Name = "btnHelpEstate";
            this.btnHelpEstate.Size = new System.Drawing.Size(112, 53);
            this.btnHelpEstate.TabIndex = 15;
            this.btnHelpEstate.Text = "Help";
            this.btnHelpEstate.UseVisualStyleBackColor = true;
            this.btnHelpEstate.Click += new System.EventHandler(this.btnHelpEstate_Click);
            // 
            // btnHomeEstate
            // 
            this.btnHomeEstate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHomeEstate.BackgroundImage")));
            this.btnHomeEstate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHomeEstate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHomeEstate.Location = new System.Drawing.Point(70, 579);
            this.btnHomeEstate.Name = "btnHomeEstate";
            this.btnHomeEstate.Size = new System.Drawing.Size(42, 42);
            this.btnHomeEstate.TabIndex = 16;
            this.btnHomeEstate.UseVisualStyleBackColor = true;
            this.btnHomeEstate.Click += new System.EventHandler(this.btnHomeEstate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(969, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // estatesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHomeEstate);
            this.Controls.Add(this.btnAddEstate);
            this.Controls.Add(this.btnHelpEstate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEstate);
            this.Controls.Add(this.lvEstates);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "estatesFrm";
            this.Text = "estatesFrm";
            this.Load += new System.EventHandler(this.estatesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEstates;
        private System.Windows.Forms.Label lblEstate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddEstate;
        private System.Windows.Forms.Button btnHelpEstate;
        private System.Windows.Forms.Button btnHomeEstate;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label1;
    }
}