namespace Oefening2
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
            this.cbKoe = new System.Windows.Forms.CheckBox();
            this.cbSlang = new System.Windows.Forms.CheckBox();
            this.cbVarken = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKoe
            // 
            this.cbKoe.AutoSize = true;
            this.cbKoe.Location = new System.Drawing.Point(102, 92);
            this.cbKoe.Name = "cbKoe";
            this.cbKoe.Size = new System.Drawing.Size(68, 29);
            this.cbKoe.TabIndex = 0;
            this.cbKoe.Text = "Koe";
            this.cbKoe.UseVisualStyleBackColor = true;
            // 
            // cbSlang
            // 
            this.cbSlang.AutoSize = true;
            this.cbSlang.Location = new System.Drawing.Point(102, 186);
            this.cbSlang.Name = "cbSlang";
            this.cbSlang.Size = new System.Drawing.Size(82, 29);
            this.cbSlang.TabIndex = 1;
            this.cbSlang.Text = "Slang";
            this.cbSlang.UseVisualStyleBackColor = true;
            // 
            // cbVarken
            // 
            this.cbVarken.AutoSize = true;
            this.cbVarken.Location = new System.Drawing.Point(102, 282);
            this.cbVarken.Name = "cbVarken";
            this.cbVarken.Size = new System.Drawing.Size(91, 29);
            this.cbVarken.TabIndex = 2;
            this.cbVarken.Text = "Varken";
            this.cbVarken.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Laat Horen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbVarken);
            this.Controls.Add(this.cbSlang);
            this.Controls.Add(this.cbKoe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cbKoe;
        private CheckBox cbSlang;
        private CheckBox cbVarken;
        private Button button1;
    }
}