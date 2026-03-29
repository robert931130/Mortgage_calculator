namespace Mortgage_calculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDownPayUnit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txtDownPay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDownPayAmount = new System.Windows.Forms.RadioButton();
            this.rbDownPayPercent = new System.Windows.Forms.RadioButton();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalHousePrice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResultTotalAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblResultTotalInterest = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblResultFirstPrincipal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblResultFirstInterest = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResultMonthlyPay = new System.Windows.Forms.Label();
            this.lblTextMonthlyPay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultTotalLoan = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtGracePeriod);
            this.groupBox1.Controls.Add(this.txtLoanTerm);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblDownPayUnit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblLoanTerm);
            this.groupBox1.Controls.Add(this.txtInterestRate);
            this.groupBox1.Controls.Add(this.lblInterestRate);
            this.groupBox1.Controls.Add(this.txtDownPay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbDownPayAmount);
            this.groupBox1.Controls.Add(this.rbDownPayPercent);
            this.groupBox1.Controls.Add(this.txtTotalPrice);
            this.groupBox1.Controls.Add(this.lblTotalHousePrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "輸入資訊";
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.Location = new System.Drawing.Point(154, 250);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(100, 25);
            this.txtGracePeriod.TabIndex = 19;
            this.txtGracePeriod.Text = "0";
            this.txtGracePeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.Location = new System.Drawing.Point(154, 204);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(100, 25);
            this.txtLoanTerm.TabIndex = 18;
            this.txtLoanTerm.Text = "30";
            this.txtLoanTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(260, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "元";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "年";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "年";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "%";
            // 
            // lblDownPayUnit
            // 
            this.lblDownPayUnit.AutoSize = true;
            this.lblDownPayUnit.Location = new System.Drawing.Point(260, 126);
            this.lblDownPayUnit.Name = "lblDownPayUnit";
            this.lblDownPayUnit.Size = new System.Drawing.Size(20, 18);
            this.lblDownPayUnit.TabIndex = 13;
            this.lblDownPayUnit.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "寬限期 (年) [選填]:";
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.Location = new System.Drawing.Point(29, 209);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(93, 18);
            this.lblLoanTerm.TabIndex = 9;
            this.lblLoanTerm.Text = "貸款年限 (年):";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(154, 162);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 25);
            this.txtInterestRate.TabIndex = 8;
            this.txtInterestRate.Text = "2.15";
            this.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(29, 165);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(105, 18);
            this.lblInterestRate.TabIndex = 7;
            this.lblInterestRate.Text = "貸款年利率 (%):";
            // 
            // txtDownPay
            // 
            this.txtDownPay.Location = new System.Drawing.Point(154, 123);
            this.txtDownPay.Name = "txtDownPay";
            this.txtDownPay.Size = new System.Drawing.Size(100, 25);
            this.txtDownPay.TabIndex = 6;
            this.txtDownPay.Text = "20";
            this.txtDownPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "自備款:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "自備款方式:";
            // 
            // rbDownPayAmount
            // 
            this.rbDownPayAmount.AutoSize = true;
            this.rbDownPayAmount.Location = new System.Drawing.Point(296, 86);
            this.rbDownPayAmount.Name = "rbDownPayAmount";
            this.rbDownPayAmount.Size = new System.Drawing.Size(122, 22);
            this.rbDownPayAmount.TabIndex = 3;
            this.rbDownPayAmount.TabStop = true;
            this.rbDownPayAmount.Text = "自備款金額 (元)";
            this.rbDownPayAmount.UseVisualStyleBackColor = true;
            this.rbDownPayAmount.CheckedChanged += new System.EventHandler(this.rbDownPayAmount_CheckedChanged);
            // 
            // rbDownPayPercent
            // 
            this.rbDownPayPercent.AutoSize = true;
            this.rbDownPayPercent.Checked = true;
            this.rbDownPayPercent.Location = new System.Drawing.Point(154, 86);
            this.rbDownPayPercent.Name = "rbDownPayPercent";
            this.rbDownPayPercent.Size = new System.Drawing.Size(120, 22);
            this.rbDownPayPercent.TabIndex = 2;
            this.rbDownPayPercent.TabStop = true;
            this.rbDownPayPercent.Text = "自備款比例 (%)";
            this.rbDownPayPercent.UseVisualStyleBackColor = true;
            this.rbDownPayPercent.CheckedChanged += new System.EventHandler(this.rbDownPayPercent_CheckedChanged);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(154, 37);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 25);
            this.txtTotalPrice.TabIndex = 1;
            this.txtTotalPrice.Text = "10000000";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalHousePrice
            // 
            this.lblTotalHousePrice.AutoSize = true;
            this.lblTotalHousePrice.Location = new System.Drawing.Point(29, 40);
            this.lblTotalHousePrice.Name = "lblTotalHousePrice";
            this.lblTotalHousePrice.Size = new System.Drawing.Size(89, 18);
            this.lblTotalHousePrice.TabIndex = 0;
            this.lblTotalHousePrice.Text = "房屋總價(元):";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Silver;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalculate.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 323);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(629, 57);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "開始計算";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Controls.Add(this.lblResultTotalAmount);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblResultTotalInterest);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblResultFirstPrincipal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblResultFirstInterest);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblResultMonthlyPay);
            this.groupBox2.Controls.Add(this.lblTextMonthlyPay);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblResultTotalLoan);
            this.groupBox2.Location = new System.Drawing.Point(12, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 334);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "試算結果";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblResultTotalAmount
            // 
            this.lblResultTotalAmount.Location = new System.Drawing.Point(189, 280);
            this.lblResultTotalAmount.Name = "lblResultTotalAmount";
            this.lblResultTotalAmount.Size = new System.Drawing.Size(164, 18);
            this.lblResultTotalAmount.TabIndex = 13;
            this.lblResultTotalAmount.Text = "NT$ 0.00";
            this.lblResultTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "總還款金額:";
            // 
            // lblResultTotalInterest
            // 
            this.lblResultTotalInterest.Location = new System.Drawing.Point(189, 233);
            this.lblResultTotalInterest.Name = "lblResultTotalInterest";
            this.lblResultTotalInterest.Size = new System.Drawing.Size(164, 18);
            this.lblResultTotalInterest.TabIndex = 11;
            this.lblResultTotalInterest.Text = "NT$ 0.00";
            this.lblResultTotalInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "總利息支出:";
            // 
            // lblResultFirstPrincipal
            // 
            this.lblResultFirstPrincipal.Location = new System.Drawing.Point(190, 182);
            this.lblResultFirstPrincipal.Name = "lblResultFirstPrincipal";
            this.lblResultFirstPrincipal.Size = new System.Drawing.Size(164, 18);
            this.lblResultFirstPrincipal.TabIndex = 9;
            this.lblResultFirstPrincipal.Text = "NT$ 0.00";
            this.lblResultFirstPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "首期本金:";
            // 
            // lblResultFirstInterest
            // 
            this.lblResultFirstInterest.Location = new System.Drawing.Point(189, 135);
            this.lblResultFirstInterest.Name = "lblResultFirstInterest";
            this.lblResultFirstInterest.Size = new System.Drawing.Size(164, 18);
            this.lblResultFirstInterest.TabIndex = 5;
            this.lblResultFirstInterest.Text = "NT$ 0.00";
            this.lblResultFirstInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "首期利息:";
            // 
            // lblResultMonthlyPay
            // 
            this.lblResultMonthlyPay.Location = new System.Drawing.Point(189, 88);
            this.lblResultMonthlyPay.Name = "lblResultMonthlyPay";
            this.lblResultMonthlyPay.Size = new System.Drawing.Size(164, 18);
            this.lblResultMonthlyPay.TabIndex = 3;
            this.lblResultMonthlyPay.Text = "NT$ 0.00";
            this.lblResultMonthlyPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTextMonthlyPay
            // 
            this.lblTextMonthlyPay.Location = new System.Drawing.Point(29, 89);
            this.lblTextMonthlyPay.Name = "lblTextMonthlyPay";
            this.lblTextMonthlyPay.Size = new System.Drawing.Size(181, 18);
            this.lblTextMonthlyPay.TabIndex = 2;
            this.lblTextMonthlyPay.Text = "每月應繳金額:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "貸款總金額:";
            // 
            // lblResultTotalLoan
            // 
            this.lblResultTotalLoan.Location = new System.Drawing.Point(189, 41);
            this.lblResultTotalLoan.Name = "lblResultTotalLoan";
            this.lblResultTotalLoan.Size = new System.Drawing.Size(164, 18);
            this.lblResultTotalLoan.TabIndex = 0;
            this.lblResultTotalLoan.Text = "NT$ 0.00";
            this.lblResultTotalLoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chart1.CausesValidation = false;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(359, 38);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackSecondaryColor = System.Drawing.SystemColors.GradientInactiveCaption;
            series1.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.SystemColors.GradientInactiveCaption;
            series1.LabelBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            series1.LabelBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            series1.MarkerColor = System.Drawing.SystemColors.GradientInactiveCaption;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(289, 260);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 732);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人房貸試算器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalHousePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDownPayAmount;
        private System.Windows.Forms.RadioButton rbDownPayPercent;
        private System.Windows.Forms.TextBox txtDownPay;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResultTotalLoan;
        private System.Windows.Forms.Label lblResultTotalInterest;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblResultFirstPrincipal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblResultFirstInterest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResultMonthlyPay;
        private System.Windows.Forms.Label lblTextMonthlyPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultTotalAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDownPayUnit;
        private System.Windows.Forms.TextBox txtGracePeriod;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

