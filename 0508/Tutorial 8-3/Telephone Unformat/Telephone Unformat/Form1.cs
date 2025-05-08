using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 設定表單和元件的 Text 屬性為繁體中文
            this.Text = "電話號碼去格式化工具"; // 表單標題
            unformatButton.Text = "去格式化"; // 按鈕文字
            exitButton.Text = "退出"; // 按鈕文字
        }

        // IsValidFormat 方法接受一個字串參數，
        // 並判斷該字串是否正確地格式化為
        // 美國電話號碼的格式：(XXX)XXX-XXXX。
        // 如果參數格式正確，方法返回 true，否則返回 false。
        private bool IsValidFormat(string str)
        {
            if (str.Length == 13 &&
                str[0] == '(' &&
                str[4] == ')' &&
                str[8] == '-' &&
                char.IsDigit(str[1]) &&
                char.IsDigit(str[2]) &&
                char.IsDigit(str[3]) &&
                char.IsDigit(str[5]) &&
                char.IsDigit(str[6]) &&
                char.IsDigit(str[7]) &&
                char.IsDigit(str[9]) &&
                char.IsDigit(str[10]) &&
                char.IsDigit(str[11]) &&
                char.IsDigit(str[12]))
            {
                return true;
            }
            return false;
        }

        // Unformat 方法接受一個字串（以參考方式傳遞），
        // 假設該字串包含格式化為 (XXX)XXX-XXXX 的電話號碼。
        // 該方法會移除字串中的括號和連字號。
        private void Unformat(ref string str)
        {
            str = str.Remove(0, 1); // 移除左括號 '('
            str = str.Remove(2, 1); // 移除右括號 ')'
            str = str.Remove(6, 1); // 移除連字符 '-'
        }

        private void unformatButton_Click(object sender, EventArgs e)
        {
            string input = numberTextBox.Text; // 取得使用者輸入的電話號碼

            if (IsValidFormat(input)) // 檢查電話號碼格式是否正確
            {
                Unformat(ref input); // 如果格式正確，則進行去格式化
                MessageBox.Show("去格式化後的電話號碼為：" + input, "結果", MessageBoxButtons.OK, MessageBoxIcon.Information); // 顯示去格式化後的電話號碼
            }
            else
            {
                MessageBox.Show("請輸入正確格式的電話號碼！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error); // 如果格式不正確，顯示錯誤提示
            }

            // 清空輸入框
            numberTextBox.Text = string.Empty;
            // 將焦點設置回輸入框
            numberTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 表單載入時的初始化邏輯
        }
    }
}
