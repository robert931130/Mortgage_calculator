using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortgage_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 當點選「自備款比例」時
        private void rbDownPayPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDownPayPercent.Checked)
            {
                lblDownPayUnit.Text = "%";
            }
        }

        // 當點選「自備款金額」時
        private void rbDownPayAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDownPayAmount.Checked)
            {
                lblDownPayUnit.Text = "元";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // ================= 1. 防呆驗證與範圍檢查 =================
            if (!double.TryParse(txtTotalPrice.Text, out double housePrice) ||
                !double.TryParse(txtDownPay.Text, out double downPayInput) ||
                !double.TryParse(txtInterestRate.Text, out double annualRate) ||
                !int.TryParse(txtLoanTerm.Text, out int loanYears) ||
                !int.TryParse(txtGracePeriod.Text, out int graceYears))
            {
                MessageBox.Show("請確保所有輸入欄位皆為有效的數字！", "輸入格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (housePrice <= 0 || downPayInput < 0 || annualRate <= 0 || loanYears <= 0 || graceYears < 0)
            {
                MessageBox.Show("數值不合邏輯！房屋總價、年利率與貸款年限必須大於 0。", "數值範圍錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (graceYears >= loanYears)
            {
                MessageBox.Show("寬限期必須小於貸款總年限！", "邏輯錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ================= 2. 貸款總額計算 =================
            // 判斷自備款是比例還是金額
            double downPayAmount = rbDownPayPercent.Checked ? housePrice * (downPayInput / 100.0) : downPayInput;
            double totalLoan = housePrice - downPayAmount;

            if (totalLoan <= 0)
            {
                MessageBox.Show("自備款大於或等於房屋總價，無需貸款！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ================= 3. 房貸公式核心邏輯 =================
            double monthlyRate = annualRate / 100.0 / 12.0; // 月利率
            int totalMonths = loanYears * 12;               // 總期數
            int graceMonths = graceYears * 12;              // 寬限期數
            int amortizeMonths = totalMonths - graceMonths; // 攤還期數

            double firstMonthInterest = totalLoan * monthlyRate; // 首期利息
            double monthlyPayment = 0;                           // 每月應繳本息
            double firstMonthPrincipal = 0;                      // 首期本金

            if (monthlyRate == 0)
            {
                monthlyPayment = totalLoan / amortizeMonths;
            }
            else
            {
                double temp = Math.Pow(1 + monthlyRate, amortizeMonths);
                monthlyPayment = totalLoan * (monthlyRate * temp) / (temp - 1);
            }

            // 首期本金判斷 (有寬限期則為 0)
            firstMonthPrincipal = graceMonths > 0 ? 0 : monthlyPayment - firstMonthInterest;

            // 計算總支出
            double totalRepayment = (graceMonths * firstMonthInterest) + (amortizeMonths * monthlyPayment);
            double totalInterest = totalRepayment - totalLoan;

            // ================= 4. UI 輸出與排版優化 =================
            lblResultTotalLoan.Text = $"NT$ {totalLoan:N2}";
            lblResultFirstInterest.Text = $"NT$ {firstMonthInterest:N2}";
            lblResultFirstPrincipal.Text = $"NT$ {firstMonthPrincipal:N2}";
            lblResultTotalInterest.Text = $"NT$ {totalInterest:N2}";
            lblResultTotalAmount.Text = $"NT$ {totalRepayment:N2}";

            // 動態修改左側標題，確保右側數字完美對齊
            if (graceMonths > 0)
            {
                lblTextMonthlyPay.Text = "每月應繳金額 (寬限期後):";
                lblResultMonthlyPay.Text = $"NT$ {monthlyPayment:N2}";
            }
            else
            {
                lblTextMonthlyPay.Text = "每月應繳金額:";
                lblResultMonthlyPay.Text = $"NT$ {monthlyPayment:N2}";
            }

            // ================= 5. 繪製圓餅圖 (Chart) =================
            // 確保圖表類型是圓餅圖
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Series[0].Points.Clear(); // 清除上次計算的舊資料

            // 1. 加入資料點，並取得該點的「索引位置」
            int indexPrincipal = chart1.Series[0].Points.AddXY("貸款本金", totalLoan);
            int indexInterest = chart1.Series[0].Points.AddXY("總利息", totalInterest);

            // 2. 強制設定第一個點 (貸款本金) 的顯示文字
            // LegendText 是右上角小方塊旁邊的字，Label 是圓餅圖上面的字 (\n 可以換行)
            chart1.Series[0].Points[indexPrincipal].LegendText = "貸款本金";
            chart1.Series[0].Points[indexPrincipal].Label = "貸款本金\n#PERCENT{P0}";

             //3. 強制設定第二個點 (總利息) 的顯示文字
            chart1.Series[0].Points[indexInterest].LegendText = "總利息";
            chart1.Series[0].Points[indexInterest].Label = "總利息#PERCENT{P0}";

            // 4. 維持背景透明
            chart1.BackColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas[0].BackColor = System.Drawing.Color.Transparent;
            chart1.Legends[0].BackColor = System.Drawing.Color.Transparent;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
