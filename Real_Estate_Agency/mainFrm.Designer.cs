namespace Real_Estate_Agency
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnListContracts = new System.Windows.Forms.Button();
            this.btnListEsatates = new System.Windows.Forms.Button();
            this.btnListCustomers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnListContracts
            // 
            this.btnListContracts.Location = new System.Drawing.Point(62, 226);
            this.btnListContracts.Name = "btnListContracts";
            this.btnListContracts.Size = new System.Drawing.Size(95, 46);
            this.btnListContracts.TabIndex = 1;
            this.btnListContracts.Text = "List Contracts";
            this.btnListContracts.UseVisualStyleBackColor = true;
            this.btnListContracts.Click += new System.EventHandler(this.btnListContracts_Click);
            // 
            // btnListEsatates
            // 
            this.btnListEsatates.Location = new System.Drawing.Point(224, 226);
            this.btnListEsatates.Name = "btnListEsatates";
            this.btnListEsatates.Size = new System.Drawing.Size(95, 46);
            this.btnListEsatates.TabIndex = 2;
            this.btnListEsatates.Text = "List Estates";
            this.btnListEsatates.UseVisualStyleBackColor = true;
            this.btnListEsatates.Click += new System.EventHandler(this.btnListEsatates_Click);
            // 
            // btnListCustomers
            // 
            this.btnListCustomers.Location = new System.Drawing.Point(383, 226);
            this.btnListCustomers.Name = "btnListCustomers";
            this.btnListCustomers.Size = new System.Drawing.Size(95, 46);
            this.btnListCustomers.TabIndex = 3;
            this.btnListCustomers.Text = "List Customers ";
            this.btnListCustomers.UseVisualStyleBackColor = true;
            this.btnListCustomers.Click += new System.EventHandler(this.btnListCustomers_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 320);
            this.Controls.Add(this.btnListCustomers);
            this.Controls.Add(this.btnListEsatates);
            this.Controls.Add(this.btnListContracts);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainFrm";
            this.Text = "Real Estate Agency";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnListContracts;
        private System.Windows.Forms.Button btnListEsatates;
        private System.Windows.Forms.Button btnListCustomers;
    }
}

