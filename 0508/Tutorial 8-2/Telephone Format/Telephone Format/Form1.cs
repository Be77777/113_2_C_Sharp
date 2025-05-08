using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 設定按鈕的文字屬性為繁體中文
            formatButton.Text = "格式化電話號碼"; // 將按鈕文字設為「格式化電話號碼」
            exitButton.Text = "退出"; // 將按鈕文字設為「退出」
        }

        // IsValidNumber 方法接受一個字串作為參數，
        // 如果該字串包含 10 個數字，則回傳 true；否則回傳 false。
        // 此處應實作檢查字串是否包含 10 個數字的邏輯
        private bool IsValidNumber(string str)
        {
            const int VALID_LENGTH = 10; // 定義有效的電話號碼長度為 10
            // 檢查字串是否為 null 或空白，或長度不等於 10
            if (string.IsNullOrWhiteSpace(str) || str.Length != VALID_LENGTH)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    // 檢查字串中的每個字符是否為數字
                    if (!char.IsDigit(str[i]))
                    {
                        return false; // 如果有非數字字符，則回傳 false
                    }
                }
                return true; // 如果是，則回傳 true
            }
            return false; // 如果字串為 null 或空白，或長度不等於 10，則回傳 false
        }

        // 此方法會將該字串格式化為電話號碼的形式，例如(123) 456-7890。
        private void TelephoneFormat(ref string str)
        {
            //確保字串長度為10，並格式化為(XX) XXXX-XXXX   
            //if (str.Length != 10)
            //{

            //    str = $"({str.Substring(0, 3)}) {str.Substring(3, 3)}-{str.Substring(6, 4)}";
            //}
            str = str.Insert(0, "("); // 在字串的開頭插入左括號
            str = str.Insert(3, ") "); // 在字串的第 3 個位置插入右括號和空格
            str = str.Insert(9, "-"); // 在字串的第 9 個位置插入連字符
        }

        // 當使用者按下 formatButton 時觸發的事件處理方法。
        // 此方法應執行電話號碼格式化的相關邏輯。
        private void formatButton_Click(object sender, EventArgs e)
        {
            string input = numberTextBox.Text; // 取得使用者輸入的電話號碼
            if (IsValidNumber(input))
            {

                TelephoneFormat(ref input); // 格式化電話號碼
                MessageBox.Show("格式化結果：", input); // 顯示格式化後的電話號碼
                numberTextBox.Text = input; // 顯示格式化後的電話號碼
            }
            else
            {
                MessageBox.Show("請輸入有效的 10 位數字電話號碼。"); // 提示使用者輸入有效的電話號碼
            }
        }
        // 當使用者按下 exitButton 時觸發的事件處理方法。
        // 此方法會關閉目前的表單。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單
            this.Close();
        }
    }
}
