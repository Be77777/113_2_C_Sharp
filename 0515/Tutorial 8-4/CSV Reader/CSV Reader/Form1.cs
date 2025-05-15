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

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFier;
                //顯示檔案選擇對話方塊，讓使用者選擇開啟的CSV檔案
                string line;
                int count = 0;
                int total = 0;
                double average = 0;
                Char[] delim = { ',', ':' };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //開啟CSV檔案
                    inputFier = File.OpenText(openFileDialog1.FileName);
                    //讀取CSV檔案的每一行
                    while (!inputFier.EndOfStream)
                    {
                        line = inputFier.ReadLine();//將每一行的字串分割成陣列
                        line = line.Trim(); //去除行首行尾的空格
                        string[] fields = line.Split(delim);
                        total = 0; //每次讀取一行時，總分數歸零
                        //計算總分數

                        for (int i = 0; i < fields.Length; i++)
                        {
                            total += Convert.ToInt32(fields[i]);
                            count++;
                        }
                        //計算平均分數
                        average = (double)total / count;
                        averagesListBox.Items.Add("第" + (++count + 1) + "每位同學的平均分數為" + average);

                    }

                }
                else
                {
                    MessageBox.Show("No file selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }







        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
