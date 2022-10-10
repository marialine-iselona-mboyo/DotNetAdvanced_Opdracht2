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
            this.button1 = new System.Windows.Forms.Button();
            this.cbKoe = new System.Windows.Forms.CheckBox();
            this.cbSlang = new System.Windows.Forms.CheckBox();
            this.cbVarken = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Laat horen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbKoe
            // 
            this.cbKoe.AutoSize = true;
            this.cbKoe.Location = new System.Drawing.Point(461, 111);
            this.cbKoe.Name = "cbKoe";
            this.cbKoe.Size = new System.Drawing.Size(68, 29);
            this.cbKoe.TabIndex = 1;
            this.cbKoe.Text = "Koe";
            this.cbKoe.UseVisualStyleBackColor = true;
            // 
            // cbSlang
            // 
            this.cbSlang.AutoSize = true;
            this.cbSlang.Location = new System.Drawing.Point(461, 179);
            this.cbSlang.Name = "cbSlang";
            this.cbSlang.Size = new System.Drawing.Size(82, 29);
            this.cbSlang.TabIndex = 2;
            this.cbSlang.Text = "Slang";
            this.cbSlang.UseVisualStyleBackColor = true;
            // 
            // cbVarken
            // 
            this.cbVarken.AutoSize = true;
            this.cbVarken.Location = new System.Drawing.Point(461, 241);
            this.cbVarken.Name = "cbVarken";
            this.cbVarken.Size = new System.Drawing.Size(91, 29);
            this.cbVarken.TabIndex = 3;
            this.cbVarken.Text = "Varken";
            this.cbVarken.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(804, 661);
            this.Controls.Add(this.cbVarken);
            this.Controls.Add(this.cbSlang);
            this.Controls.Add(this.cbKoe);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private CheckBox cbKoe;
        private CheckBox cbSlang;
        private CheckBox cbVarken;
    }
}