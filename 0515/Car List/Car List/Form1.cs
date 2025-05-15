using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_List
{
    struct Automobile
    {
        public string make;
        public int year;
        public double mileage;
    }

    public partial class Form1 : Form
    {
        // 建立一個 List 作為欄位。
        private List<Automobile> carList = new List<Automobile>();

        public Form1()
        {
            InitializeComponent();
        }

        // GetData 方法取得使用者輸入的資料
        // 並指派給參數物件的欄位。
        private void GetData(ref Automobile auto)
        {
            try
            {
                // 從 TextBox 取得資料。
                auto.make = makeTextBox.Text;
                auto.year = int.Parse(yearTextBox.Text);
                auto.mileage = double.Parse(mileageTextBox.Text);
            }
            catch (Exception ex)
            {
                // 顯示例外訊息。
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // 建立 Automobile 結構的實例。
            Automobile car = new Automobile();

            // 取得使用者輸入的資料。
            GetData(ref car);

            // 將 car 物件加入 List。
            carList.Add(car);

            // 清除 TextBox。
            makeTextBox.Clear();
            yearTextBox.Clear();
            mileageTextBox.Clear();

            // 重設焦點。
            makeTextBox.Focus();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // 宣告一個字串用來存放輸出內容。
            string output;

            // 清除 ListBox 目前的內容。
            carListBox.Items.Clear();

            // 在 ListBox 顯示車輛資訊。
            foreach (Automobile aCar in carList)
            {
                // 組合一行輸出內容。
                output = aCar.year + " " + aCar.make +
                    " with " + aCar.mileage + " miles.";

                // 將輸出內容加入 ListBox。
                carListBox.Items.Add(output);
            }
        }
    }
}
