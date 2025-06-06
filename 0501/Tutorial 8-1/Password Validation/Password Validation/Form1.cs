﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // NumberUpperCase 方法接受一個字串參數
        // 並回傳其中包含的大寫字母數量。
        private int NumberUpperCase(string str)
        {
            int upperCaseCount = 0; // 計數器，初始值為 0  
            foreach (char c in str)
            {
                if (char.IsUpper(c)) // 如果字元是大寫字母  
                {
                    upperCaseCount++; // 計數器加 1  
                }
            }
            return upperCaseCount; // 回傳大寫字母的數量  
        }

        // NumberLowerCase 方法接受一個字串參數
        // 並回傳其中包含的小寫字母數量。
        private int NumberLowerCase(string str)
        {
            int lowerCaseCount = 0; // 計數器，初始值為 0
            for (int i = 0; i < str.Length; i++) 
            {
                if (char.IsLower(str[i])) // 如果字元是小寫字母
                {
                    lowerCaseCount++; // 計數器加 1
                }
            }
            return lowerCaseCount; // 回傳小寫字母的數量
        }

        // NumberDigits 方法接受一個字串參數
        // 並回傳其中包含的數字字元數量。
        private int NumberDigits(string str)
        {
            int digitCount = 0; // 計數器，初始值為 0
for (int i = 0; i < str.Length; i++)

            {
                if (char.IsDigit(str[i])) // 如果字元是數字
                {
                    digitCount++; // 計數器加 1
                }
            }
            return digitCount; // 回傳數字字元的數量
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8; // 最小密碼長度
            string password = passwordTextBox.Text; // 取得使用者輸入的密碼
            if (password.Length < MIN_LENGTH &&
                NumberUpperCase(password) > 0 &&
                NumberLowerCase(password) > 0 &&
                NumberDigits(password) > 0)
            {
                MessageBox.Show("密碼有效。", "密碼驗證", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("密碼無效。", "密碼驗證", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
