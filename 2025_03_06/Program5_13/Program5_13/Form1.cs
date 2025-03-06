using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Program5_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTextProperties();
        }

        private void InitializeTextProperties()
        {
            this.Text = "表單標題"; // Form title
            this.Font = new Font(this.Font.FontFamily, 18); // Set form font size

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Text = "按鈕"; // Set text for buttons
                    control.Font = new Font(control.Font.FontFamily, 18); // Set font size for buttons
                    control.Size = new Size(150, 50); // Adjust button size
                }
                else if (control is Label)
                {
                    control.Text = "標籤"; // Set text for labels
                    control.Font = new Font(control.Font.FontFamily, 18); // Set font size for labels
                    control.Size = new Size(150, 50); // Adjust label size
                }
                // 根據需要添加更多的元件類型
            }

            // 調整元件位置
            int yOffset = 50;
            foreach (Control control in this.Controls)
            {
                control.Location = new Point(50, yOffset);
                yOffset += control.Height + 20; // Adjust vertical spacing
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            StreamWriter outputFile;//宣告StreamWriter物件

            try
            {
                if (saveFile.ShowDialog() = DialogResult.OK)
                
                outputFile = File.CreateText("numbers.txt");//開啟檔案,寫入數字
                if (int.TryParse(textBox1.Text, out int count))//判斷是否為數字
                {
                    for (int i = 0; i < count; i++)
                    {
                        outputFile.WriteLine(random.Next(100) +1);//寫入亂數
                    }
                    outputFile.Close();//關閉檔案
                    MessageBox.Show("檔案已建立");//顯示訊息
                }
                else
                {
                    MessageBox.Show("請輸入數字");//顯示訊息
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//顯示錯誤訊息
                
            }
        }
    }
}


