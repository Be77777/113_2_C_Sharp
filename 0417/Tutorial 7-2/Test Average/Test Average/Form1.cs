using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Average 方法接受一個整數清單作為參數
        // 並返回該清單中數值的平均值。
        private double Average(List<int> scores)
        {
            if (scores == null || scores.Count == 0)
                return 0;

            return scores.Average();
        }

        // Highest 方法接受一個整數清單作為參數
        // 並返回該清單中的最高值。
        private int Highest(List<int> scores)
        {
            if (scores == null || scores.Count == 0)
                return 0;

            return scores.Max();
        }

        // Lowest 方法接受一個整數清單作為參數
        // 並返回該清單中的最低值。
        private int Lowest(List<int> scores)
        {
            if (scores == null || scores.Count == 0)
                return 0;

            return scores.Min();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 假設分數是從 TextBox 輸入，並以逗號分隔
                string input = scoresTextBox.Text; // 假設有一個名為 scoresTextBox 的 TextBox
                List<int> scores = input.Split(',')
                                        .Select(s => int.Parse(s.Trim()))
                                        .ToList();

                // 計算平均值、最高分和最低分
                double average = Average(scores);
                int highest = Highest(scores);
                int lowest = Lowest(scores);

                // 顯示結果
                MessageBox.Show($"平均分數: {average:F2}\n最高分: {highest}\n最低分: {lowest}", "結果");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤: {ex.Message}", "錯誤");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
