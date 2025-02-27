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
            double distance, gas, average; //�ŧi�ϰ��ܼ�

            if (double.TryParse(distanceTextBox.Text, out distance))
            {
                if (double.TryParse(gasTextBox.Text, out gas))
                {
                    average = distance / gas; //�p�⥭����
                    averageLabel.Text = "�����o��" + average.ToString("f2") + "����/����";
                    loglistBox.Items.Add(average.ToString("f2") + "����/����");
                }
                else
                {
                    MessageBox.Show("�п�J�Ʀr");
                    gasTextBox.Focus(); //�N��в���gasTextBox
                    gasTextBox.Text = ""; //�M��TextBox
                }
            }
            else
            {
                MessageBox.Show("�п�J�Ʀr");
                distanceTextBox.Focus(); //�N��в���distanceTextBox
                distanceTextBox.Text = ""; //�M��TextBox
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close(); //��������
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loglistBox.Items.Clear(); //�M��ListBox
            loglistBox.Items.Add("�����o�Ӭ��� :");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (loglistBox.Items.Count > 1)
            {
                
                for (int i = 1; i < loglistBox.Items.Count; i++)
                {
                    sum += double.Parse(loglistBox.Items[i].ToString().Replace("����/����", ""));
                }
                loglistBox.Items.Add("�����o�� :\n " + (sum / (loglistBox.Items.Count - 1)).ToString("f2") + "����/����");
            }
            else
            {
                MessageBox.Show("�S������");
            }
        }
    }
}
