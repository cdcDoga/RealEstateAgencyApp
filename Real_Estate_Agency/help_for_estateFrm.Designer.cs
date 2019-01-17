namespace Real_Estate_Agency
{
    partial class help_for_estateFrm
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
            this.rtbHelp = new System.Windows.Forms.RichTextBox();
            this.btnHelpOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbHelp
            // 
            this.rtbHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbHelp.Enabled = false;
            this.rtbHelp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbHelp.Location = new System.Drawing.Point(33, 43);
            this.rtbHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbHelp.Name = "rtbHelp";
            this.rtbHelp.ReadOnly = true;
            this.rtbHelp.Size = new System.Drawing.Size(333, 323);
            this.rtbHelp.TabIndex = 3;
            this.rtbHelp.Text = "";
            // 
            // btnHelpOK
            // 
            this.btnHelpOK.Location = new System.Drawing.Point(276, 383);
            this.btnHelpOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHelpOK.Name = "btnHelpOK";
            this.btnHelpOK.Size = new System.Drawing.Size(90, 43);
            this.btnHelpOK.TabIndex = 2;
            this.btnHelpOK.Text = "OK";
            this.btnHelpOK.UseVisualStyleBackColor = true;
            this.btnHelpOK.Click += new System.EventHandler(this.btnHelpOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Help Information About Estate";
            // 
            // help_for_estateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbHelp);
            this.Controls.Add(this.btnHelpOK);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "help_for_estateFrm";
            this.Text = "help_for_estateFrm";
            this.Load += new System.EventHandler(this.help_for_estateFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbHelp;
        private System.Windows.Forms.Button btnHelpOK;
        private System.Windows.Forms.Label label1;
    }
}