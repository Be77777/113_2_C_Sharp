using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        // 用來儲存 CellPhone 物件的清單
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        // GetPhoneData 方法接受一個 CellPhone 物件作為參數。
        // 它會將使用者輸入的資料指派給物件的屬性。
        private void GetPhoneData(CellPhone phone)
        {
            // 暫存價格的變數
            decimal price;

            // 取得手機品牌
            phone.Brand = brandTextBox.Text;

            // 取得手機型號
            phone.Model = modelTextBox.Text;

            // 取得手機價格
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // 顯示錯誤訊息
                MessageBox.Show("價格無效");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone();

            GetPhoneData(myPhone);

            // 將新的手機物件加入到清單中
            phoneList.Add(myPhone);

            // 將手機物件的資訊加入到 ListBox 中
            phoneListBox.Items.Add(myPhone.Brand + " " + myPhone.Model );

            // 清空輸入欄位
            brandTextBox.Text = "";
            modelTextBox.Text = "";
            priceTextBox.Text = "";
            // 將焦點設回品牌輸入欄位
            brandTextBox.Focus();
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = phoneListBox.SelectedIndex; //取得手機在清單中的索引
            
            MessageBox.Show(phoneList[index].Price.ToString("c"));// 顯示選中手機的價格，格式化為貨幣格式
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
