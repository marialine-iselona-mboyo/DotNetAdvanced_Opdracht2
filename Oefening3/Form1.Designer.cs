namespace Oefening3
{
    partial class currencyConvertor
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
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelConvertTo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbConverted = new System.Windows.Forms.TextBox();
            this.cbConvertTo = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.labelConvertFrom = new System.Windows.Forms.Label();
            this.cbConvertFrom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(51, 67);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(151, 25);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "AMOUNT IN USD";
            // 
            // labelConvertTo
            // 
            this.labelConvertTo.AutoSize = true;
            this.labelConvertTo.Location = new System.Drawing.Point(51, 186);
            this.labelConvertTo.Name = "labelConvertTo";
            this.labelConvertTo.Size = new System.Drawing.Size(34, 25);
            this.labelConvertTo.TabIndex = 1;
            this.labelConvertTo.Text = "TO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONVERTED AMOUNT:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(275, 61);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(150, 31);
            this.tbAmount.TabIndex = 3;
            // 
            // tbConverted
            // 
            this.tbConverted.Location = new System.Drawing.Point(275, 354);
            this.tbConverted.Name = "tbConverted";
            this.tbConverted.Size = new System.Drawing.Size(150, 31);
            this.tbConverted.TabIndex = 4;
            // 
            // cbConvertTo
            // 
            this.cbConvertTo.FormattingEnabled = true;
            this.cbConvertTo.Items.AddRange(new object[] {
            "$ - USD"});
            this.cbConvertTo.Location = new System.Drawing.Point(275, 178);
            this.cbConvertTo.Name = "cbConvertTo";
            this.cbConvertTo.Size = new System.Drawing.Size(150, 33);
            this.cbConvertTo.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(176, 268);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(112, 34);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // labelConvertFrom
            // 
            this.labelConvertFrom.AutoSize = true;
            this.labelConvertFrom.Location = new System.Drawing.Point(51, 124);
            this.labelConvertFrom.Name = "labelConvertFrom";
            this.labelConvertFrom.Size = new System.Drawing.Size(62, 25);
            this.labelConvertFrom.TabIndex = 7;
            this.labelConvertFrom.Text = "FROM";
            // 
            // cbConvertFrom
            // 
            this.cbConvertFrom.FormattingEnabled = true;
            this.cbConvertFrom.Items.AddRange(new object[] {
            "€ - EUR",
            "£ - GBP",
            "¥ - JPY",
            "Fr - CHF",
            "₹ - INR"});
            this.cbConvertFrom.Location = new System.Drawing.Point(275, 116);
            this.cbConvertFrom.Name = "cbConvertFrom";
            this.cbConvertFrom.Size = new System.Drawing.Size(150, 33);
            this.cbConvertFrom.TabIndex = 8;
            // 
            // currencyConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.cbConvertFrom);
            this.Controls.Add(this.labelConvertFrom);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cbConvertTo);
            this.Controls.Add(this.tbConverted);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelConvertTo);
            this.Controls.Add(this.labelAmount);
            this.Name = "currencyConvertor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAmount;
        private Label labelConvertTo;
        private Label label3;
        private TextBox tbAmount;
        private TextBox tbConverted;
        private ComboBox cbConvertTo;
        private Button btnConvert;
        private Label labelConvertFrom;
        private ComboBox cbConvertFrom;
    }
}