namespace FirstWindowsFormsApp_19118004
{
    partial class Form1
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnChangecolor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(150, 58);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "19118004";
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Items.AddRange(new object[] {
            "форма",
            "бутон",
            "текст на бутона"});
            this.listBox.Location = new System.Drawing.Point(150, 117);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 95);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnChangecolor
            // 
            this.btnChangecolor.Location = new System.Drawing.Point(153, 291);
            this.btnChangecolor.Name = "btnChangecolor";
            this.btnChangecolor.Size = new System.Drawing.Size(117, 24);
            this.btnChangecolor.TabIndex = 2;
            this.btnChangecolor.Text = "Change Color";
            this.btnChangecolor.UseVisualStyleBackColor = true;
            this.btnChangecolor.Click += new System.EventHandler(this.btnChangecolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.btnChangecolor);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnChangecolor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

