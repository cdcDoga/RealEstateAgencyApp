namespace Real_Estate_Agency
{
    partial class AddUpdateContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateContract));
            this.gbNewContract = new System.Windows.Forms.GroupBox();
            this.cbEstateNo = new System.Windows.Forms.ComboBox();
            this.lblEstateNo = new System.Windows.Forms.Label();
            this.cbPurchaserID = new System.Windows.Forms.ComboBox();
            this.cbOwnerID = new System.Windows.Forms.ComboBox();
            this.lblPurchaserID = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.dtpContractDate = new System.Windows.Forms.DateTimePicker();
            this.lblContractDate = new System.Windows.Forms.Label();
            this.btnSubmitContract = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHomeContract = new System.Windows.Forms.Button();
            this.btnBackContract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbNewContract.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNewContract
            // 
            this.gbNewContract.Controls.Add(this.cbEstateNo);
            this.gbNewContract.Controls.Add(this.lblEstateNo);
            this.gbNewContract.Controls.Add(this.cbPurchaserID);
            this.gbNewContract.Controls.Add(this.cbOwnerID);
            this.gbNewContract.Controls.Add(this.lblPurchaserID);
            this.gbNewContract.Controls.Add(this.lblOwnerID);
            this.gbNewContract.Controls.Add(this.dtpContractDate);
            this.gbNewContract.Controls.Add(this.lblContractDate);
            this.gbNewContract.Location = new System.Drawing.Point(44, 90);
            this.gbNewContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNewContract.Name = "gbNewContract";
            this.gbNewContract.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNewContract.Size = new System.Drawing.Size(436, 268);
            this.gbNewContract.TabIndex = 0;
            this.gbNewContract.TabStop = false;
            this.gbNewContract.Text = "New Contract";
            // 
            // cbEstateNo
            // 
            this.cbEstateNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstateNo.FormattingEnabled = true;
            this.cbEstateNo.Location = new System.Drawing.Point(164, 222);
            this.cbEstateNo.Name = "cbEstateNo";
            this.cbEstateNo.Size = new System.Drawing.Size(217, 24);
            this.cbEstateNo.TabIndex = 7;
            this.cbEstateNo.SelectedIndexChanged += new System.EventHandler(this.cbEstateNo_SelectedIndexChanged);
            // 
            // lblEstateNo
            // 
            this.lblEstateNo.AutoSize = true;
            this.lblEstateNo.Location = new System.Drawing.Point(31, 225);
            this.lblEstateNo.Name = "lblEstateNo";
            this.lblEstateNo.Size = new System.Drawing.Size(65, 16);
            this.lblEstateNo.TabIndex = 6;
            this.lblEstateNo.Text = "Estate No :";
            // 
            // cbPurchaserID
            // 
            this.cbPurchaserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPurchaserID.FormattingEnabled = true;
            this.cbPurchaserID.Location = new System.Drawing.Point(164, 163);
            this.cbPurchaserID.Name = "cbPurchaserID";
            this.cbPurchaserID.Size = new System.Drawing.Size(217, 24);
            this.cbPurchaserID.TabIndex = 5;
            // 
            // cbOwnerID
            // 
            this.cbOwnerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOwnerID.FormattingEnabled = true;
            this.cbOwnerID.Location = new System.Drawing.Point(164, 102);
            this.cbOwnerID.Name = "cbOwnerID";
            this.cbOwnerID.Size = new System.Drawing.Size(217, 24);
            this.cbOwnerID.TabIndex = 3;
            // 
            // lblPurchaserID
            // 
            this.lblPurchaserID.AutoSize = true;
            this.lblPurchaserID.Location = new System.Drawing.Point(31, 166);
            this.lblPurchaserID.Name = "lblPurchaserID";
            this.lblPurchaserID.Size = new System.Drawing.Size(81, 16);
            this.lblPurchaserID.TabIndex = 4;
            this.lblPurchaserID.Text = "Purchaser ID :";
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(31, 105);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(65, 16);
            this.lblOwnerID.TabIndex = 2;
            this.lblOwnerID.Text = "Owner ID :";
            // 
            // dtpContractDate
            // 
            this.dtpContractDate.Location = new System.Drawing.Point(164, 38);
            this.dtpContractDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpContractDate.Name = "dtpContractDate";
            this.dtpContractDate.Size = new System.Drawing.Size(217, 21);
            this.dtpContractDate.TabIndex = 1;
            // 
            // lblContractDate
            // 
            this.lblContractDate.AutoSize = true;
            this.lblContractDate.Location = new System.Drawing.Point(31, 45);
            this.lblContractDate.Name = "lblContractDate";
            this.lblContractDate.Size = new System.Drawing.Size(93, 16);
            this.lblContractDate.TabIndex = 0;
            this.lblContractDate.Text = "Contract Date :";
            // 
            // btnSubmitContract
            // 
            this.btnSubmitContract.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubmitContract.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSubmitContract.Location = new System.Drawing.Point(749, 398);
            this.btnSubmitContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmitContract.Name = "btnSubmitContract";
            this.btnSubmitContract.Size = new System.Drawing.Size(126, 55);
            this.btnSubmitContract.TabIndex = 12;
            this.btnSubmitContract.Text = "Submit";
            this.btnSubmitContract.UseVisualStyleBackColor = true;
            this.btnSubmitContract.Click += new System.EventHandler(this.btnSubmitContract_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.rtbLocation);
            this.gbInfo.Controls.Add(this.lblLocation);
            this.gbInfo.Controls.Add(this.tbPrice);
            this.gbInfo.Controls.Add(this.tbType);
            this.gbInfo.Controls.Add(this.lblPrice);
            this.gbInfo.Controls.Add(this.lblType);
            this.gbInfo.Location = new System.Drawing.Point(504, 90);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfo.Size = new System.Drawing.Size(371, 268);
            this.gbInfo.TabIndex = 2;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Important Information";
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(171, 160);
            this.rtbLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(151, 70);
            this.rtbLocation.TabIndex = 11;
            this.rtbLocation.Text = "";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(38, 169);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(61, 16);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "Location :";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(171, 105);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(151, 21);
            this.tbPrice.TabIndex = 9;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(171, 49);
            this.tbType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(151, 21);
            this.tbType.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(38, 108);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 16);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(38, 53);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(95, 16);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type(rent/sale) :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(727, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnHomeContract
            // 
            this.btnHomeContract.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHomeContract.BackgroundImage")));
            this.btnHomeContract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHomeContract.Location = new System.Drawing.Point(44, 406);
            this.btnHomeContract.Name = "btnHomeContract";
            this.btnHomeContract.Size = new System.Drawing.Size(42, 40);
            this.btnHomeContract.TabIndex = 14;
            this.btnHomeContract.UseVisualStyleBackColor = true;
            this.btnHomeContract.Click += new System.EventHandler(this.btnHomeContract_Click);
            // 
            // btnBackContract
            // 
            this.btnBackContract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackContract.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackContract.ForeColor = System.Drawing.Color.Firebrick;
            this.btnBackContract.Location = new System.Drawing.Point(102, 406);
            this.btnBackContract.Name = "btnBackContract";
            this.btnBackContract.Size = new System.Drawing.Size(54, 40);
            this.btnBackContract.TabIndex = 15;
            this.btnBackContract.Text = "Back";
            this.btnBackContract.UseVisualStyleBackColor = true;
            this.btnBackContract.Click += new System.EventHandler(this.btnBackContract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "New Contract Information";
            // 
            // AddUpdateContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackContract);
            this.Controls.Add(this.btnHomeContract);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnSubmitContract);
            this.Controls.Add(this.gbNewContract);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddUpdateContract";
            this.Text = "AddUpdateContract";
            this.Load += new System.EventHandler(this.AddUpdateContract_Load);
            this.gbNewContract.ResumeLayout(false);
            this.gbNewContract.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewContract;
        private System.Windows.Forms.Label lblPurchaserID;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.DateTimePicker dtpContractDate;
        private System.Windows.Forms.Label lblContractDate;
        private System.Windows.Forms.Button btnSubmitContract;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHomeContract;
        private System.Windows.Forms.Button btnBackContract;
        private System.Windows.Forms.ComboBox cbPurchaserID;
        private System.Windows.Forms.ComboBox cbOwnerID;
        private System.Windows.Forms.ComboBox cbEstateNo;
        private System.Windows.Forms.Label lblEstateNo;
        private System.Windows.Forms.Label label1;
    }
}