namespace Tutorial_4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculatbutton_Click(object sender, EventArgs e)
        {
            double distance, gas, average; //宣告區域變數

            if (double.TryParse(distanceTextBox.Text, out distance))
            {
                if (double.TryParse(gasTextBox.Text, out gas))
                {
                    average = distance / gas; //計算平均值
                    averageLabel.Text = "平均油耗" + average.ToString("f2") + "公里/公升";
                    loglistBox.Items.Add(average.ToString("f2") + "公里/公升");
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                    gasTextBox.Focus(); //將游標移到gasTextBox
                    gasTextBox.Text = ""; //清空TextBox
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
                distanceTextBox.Focus(); //將游標移到distanceTextBox
                distanceTextBox.Text = ""; //清空TextBox
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close(); //關閉視窗
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loglistBox.Items.Clear(); //清空ListBox
            loglistBox.Items.Add("平均油耗紀錄 :");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (loglistBox.Items.Count > 1)
            {
                
                for (int i = 1; i < loglistBox.Items.Count; i++)
                {
                    sum += double.Parse(loglistBox.Items[i].ToString().Replace("公里/公升", ""));
                }
                loglistBox.Items.Add("平均油耗 :\n " + (sum / (loglistBox.Items.Count - 1)).ToString("f2") + "公里/公升");
            }
            else
            {
                MessageBox.Show("沒有紀錄");
            }
        }
    }
}
