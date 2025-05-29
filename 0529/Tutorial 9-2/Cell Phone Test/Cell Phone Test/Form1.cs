using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 設定表單標題及所有元件的 Text 屬性為繁體中文
            this.Text = "手機測試";
            // 設定建立物件按鈕的文字
            if (createObjectButton != null)
                createObjectButton.Text = "建立物件";
            // 設定離開按鈕的文字
            if (exitButton != null)
                exitButton.Text = "離開";
            // 設定品牌標籤的文字
            if (brandLabel != null)
                brandLabel.Text = "";
            // 設定型號標籤的文字
            if (modelLabel != null)
                modelLabel.Text = "";
            // 設定價格標籤的文字
            if (priceLabel != null)
                priceLabel.Text = "";
            // 清空品牌輸入框
            if (brandTextBox != null)
                brandTextBox.Text = "";
            // 清空型號輸入框
            if (modelTextBox != null)
                modelTextBox.Text = "";
            // 清空價格輸入框
            if (priceTextBox != null)
                priceTextBox.Text = "";
        }

        /// <summary>
        /// GetPhoneData 方法會接收一個 CellPhone 物件作為參數，
        /// 並將使用者在表單上輸入的資料指派給該物件的屬性。
        /// </summary>
        /// <param name="phone">要指派資料的 CellPhone 物件</param>
        private void GetPhoneData(CellPhone phone)
        {
            decimal price;

            phone.Brand = brandTextBox.Text; // 從品牌輸入框取得品牌
            phone.Model = modelTextBox.Text; // 從型號輸入框取得型號

            // 從價格輸入框取得價格，並嘗試將其轉換為 decimal
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price.ToString("C"); // 格式化為貨幣字串
            }
            else
            {
                MessageBox.Show("請輸入有效的價格。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                priceTextBox.Clear(); // 清空價格輸入框
            }
        }

        /// <summary>
        /// 當使用者按下「建立物件」按鈕時執行此事件處理函式。
        /// 此方法會建立一個新的 CellPhone 物件。
        /// </summary>
        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone();

            // 呼叫 GetPhoneData 方法來指派使用者輸入的資料到 myPhone 物件
            GetPhoneData(myPhone);

            // 顯示手機資訊
            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price;

        }

        /// <summary>
        /// 當使用者按下「離開」按鈕時執行此事件處理函式。
        /// 此方法會關閉目前的表單。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
