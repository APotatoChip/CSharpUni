namespace CurrencyConverter
{
    partial class CurrencyConverterForm
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
            this.txt_19118004 = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.comboBox_currency = new System.Windows.Forms.ComboBox();
            this.lbl_currency = new System.Windows.Forms.Label();
            this.groupBox_result = new System.Windows.Forms.GroupBox();
            this.txt_BGN = new System.Windows.Forms.TextBox();
            this.txt_EUR = new System.Windows.Forms.TextBox();
            this.txt_USD = new System.Windows.Forms.TextBox();
            this.txt_GBR = new System.Windows.Forms.TextBox();
            this.lbl_BGN = new System.Windows.Forms.Label();
            this.lbl_EUR = new System.Windows.Forms.Label();
            this.lbl_USD = new System.Windows.Forms.Label();
            this.lbl_GBR = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_19118004
            // 
            this.txt_19118004.Enabled = false;
            this.txt_19118004.Location = new System.Drawing.Point(318, 41);
            this.txt_19118004.Name = "txt_19118004";
            this.txt_19118004.Size = new System.Drawing.Size(100, 20);
            this.txt_19118004.TabIndex = 0;
            this.txt_19118004.Text = "19118004";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(73, 85);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(100, 20);
            this.txt_amount.TabIndex = 1;
            this.txt_amount.Tag = "";
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(34, 88);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(33, 13);
            this.lbl_amount.TabIndex = 2;
            this.lbl_amount.Text = "Сума";
            // 
            // comboBox_currency
            // 
            this.comboBox_currency.FormattingEnabled = true;
            this.comboBox_currency.Items.AddRange(new object[] {
            "BGN",
            "EUR",
            "USD",
            "GBR"});
            this.comboBox_currency.Location = new System.Drawing.Point(297, 78);
            this.comboBox_currency.Name = "comboBox_currency";
            this.comboBox_currency.Size = new System.Drawing.Size(121, 21);
            this.comboBox_currency.TabIndex = 3;
            // 
            // lbl_currency
            // 
            this.lbl_currency.AutoSize = true;
            this.lbl_currency.Location = new System.Drawing.Point(249, 84);
            this.lbl_currency.Name = "lbl_currency";
            this.lbl_currency.Size = new System.Drawing.Size(42, 13);
            this.lbl_currency.TabIndex = 4;
            this.lbl_currency.Text = "Валута";
            this.lbl_currency.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox_result
            // 
            this.groupBox_result.Controls.Add(this.lbl_GBR);
            this.groupBox_result.Controls.Add(this.lbl_USD);
            this.groupBox_result.Controls.Add(this.lbl_EUR);
            this.groupBox_result.Controls.Add(this.lbl_BGN);
            this.groupBox_result.Controls.Add(this.txt_GBR);
            this.groupBox_result.Controls.Add(this.txt_USD);
            this.groupBox_result.Controls.Add(this.txt_EUR);
            this.groupBox_result.Controls.Add(this.txt_BGN);
            this.groupBox_result.Location = new System.Drawing.Point(22, 152);
            this.groupBox_result.Name = "groupBox_result";
            this.groupBox_result.Size = new System.Drawing.Size(195, 165);
            this.groupBox_result.TabIndex = 5;
            this.groupBox_result.TabStop = false;
            this.groupBox_result.Text = "Резултат";
            this.groupBox_result.Enter += new System.EventHandler(this.groupBox_result_Enter);
            // 
            // txt_BGN
            // 
            this.txt_BGN.Location = new System.Drawing.Point(72, 33);
            this.txt_BGN.Name = "txt_BGN";
            this.txt_BGN.Size = new System.Drawing.Size(100, 20);
            this.txt_BGN.TabIndex = 0;
            // 
            // txt_EUR
            // 
            this.txt_EUR.Location = new System.Drawing.Point(72, 59);
            this.txt_EUR.Name = "txt_EUR";
            this.txt_EUR.Size = new System.Drawing.Size(100, 20);
            this.txt_EUR.TabIndex = 1;
            // 
            // txt_USD
            // 
            this.txt_USD.Location = new System.Drawing.Point(72, 85);
            this.txt_USD.Name = "txt_USD";
            this.txt_USD.Size = new System.Drawing.Size(100, 20);
            this.txt_USD.TabIndex = 2;
            // 
            // txt_GBR
            // 
            this.txt_GBR.Location = new System.Drawing.Point(72, 111);
            this.txt_GBR.Name = "txt_GBR";
            this.txt_GBR.Size = new System.Drawing.Size(100, 20);
            this.txt_GBR.TabIndex = 3;
            // 
            // lbl_BGN
            // 
            this.lbl_BGN.AutoSize = true;
            this.lbl_BGN.Location = new System.Drawing.Point(18, 40);
            this.lbl_BGN.Name = "lbl_BGN";
            this.lbl_BGN.Size = new System.Drawing.Size(30, 13);
            this.lbl_BGN.TabIndex = 4;
            this.lbl_BGN.Text = "BGN";
            // 
            // lbl_EUR
            // 
            this.lbl_EUR.AutoSize = true;
            this.lbl_EUR.Location = new System.Drawing.Point(18, 66);
            this.lbl_EUR.Name = "lbl_EUR";
            this.lbl_EUR.Size = new System.Drawing.Size(30, 13);
            this.lbl_EUR.TabIndex = 5;
            this.lbl_EUR.Text = "EUR";
            // 
            // lbl_USD
            // 
            this.lbl_USD.AutoSize = true;
            this.lbl_USD.Location = new System.Drawing.Point(18, 92);
            this.lbl_USD.Name = "lbl_USD";
            this.lbl_USD.Size = new System.Drawing.Size(30, 13);
            this.lbl_USD.TabIndex = 6;
            this.lbl_USD.Text = "USD";
            // 
            // lbl_GBR
            // 
            this.lbl_GBR.AutoSize = true;
            this.lbl_GBR.Location = new System.Drawing.Point(18, 118);
            this.lbl_GBR.Name = "lbl_GBR";
            this.lbl_GBR.Size = new System.Drawing.Size(30, 13);
            this.lbl_GBR.TabIndex = 7;
            this.lbl_GBR.Text = "GBR";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(297, 163);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "Изчисли";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(297, 192);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Изчисти";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // CurrencyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 362);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.groupBox_result);
            this.Controls.Add(this.lbl_currency);
            this.Controls.Add(this.comboBox_currency);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_19118004);
            this.Name = "CurrencyConverterForm";
            this.Text = "Конвертор на валути";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_result.ResumeLayout(false);
            this.groupBox_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_19118004;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.ComboBox comboBox_currency;
        private System.Windows.Forms.Label lbl_currency;
        private System.Windows.Forms.GroupBox groupBox_result;
        private System.Windows.Forms.TextBox txt_GBR;
        private System.Windows.Forms.TextBox txt_USD;
        private System.Windows.Forms.TextBox txt_EUR;
        private System.Windows.Forms.TextBox txt_BGN;
        private System.Windows.Forms.Label lbl_GBR;
        private System.Windows.Forms.Label lbl_USD;
        private System.Windows.Forms.Label lbl_EUR;
        private System.Windows.Forms.Label lbl_BGN;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_clear;
    }
}

