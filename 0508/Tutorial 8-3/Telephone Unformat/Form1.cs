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

            // �]�w���M���� Text �ݩʬ��c�餤��
            this.Text = "�q�ܸ��X�h�榡�Ƥu��"; // �����D
            unformatButton.Text = "�h�榡��"; // ���s��r
            exitButton.Text = "�h�X"; // ���s��r
        }

        // IsValidFormat ��k�����@�Ӧr��ѼơA
        // �çP�_�Ӧr��O�_���T�a�榡�Ƭ�
        // ����q�ܸ��X���榡�G(XXX)XXX-XXXX�C
        // �p�G�ѼƮ榡���T�A��k��^ true�A�_�h��^ false�C
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

        // Unformat ��k�����@�Ӧr��]�H�ѦҤ覡�ǻ��^�A
        // ���]�Ӧr��]�t�榡�Ƭ� (XXX)XXX-XXXX ���q�ܸ��X�C
        // �Ӥ�k�|�����r�ꤤ���A���M�s�r���C
        private void Unformat(ref string str)
        {
            str = str.Remove(0, 1); // �������A�� '('
            str = str.Remove(2, 1); // �����k�A�� ')'
            str = str.Remove(6, 1); // �����s�r�� '-'
        }

        private void unformatButton_Click(object sender, EventArgs e)
        {
            string input = numberTextBox.Text; // ���o�ϥΪ̿�J���q�ܸ��X

            if (IsValidFormat(input)) // �ˬd�q�ܸ��X�榡�O�_���T
            {
                Unformat(ref input); // �p�G�榡���T�A�h�i��h�榡��
                MessageBox.Show("�h�榡�ƫ᪺�q�ܸ��X���G" + input, "���G", MessageBoxButtons.OK, MessageBoxIcon.Information); // ��ܥh�榡�ƫ᪺�q�ܸ��X
            }
            else
            {
                MessageBox.Show("�п�J���T�榡���q�ܸ��X�I", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error); // �p�G�榡�����T�A��ܿ��~����
            }

            // �M�ſ�J��
            numberTextBox.Text = string.Empty;
            // �N�J�I�]�m�^��J��
            numberTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // �������
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // �����J�ɪ���l���޿�
        }
    }
}
