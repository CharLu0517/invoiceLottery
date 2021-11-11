using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoiceLottery
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //comboBox加入可選擇的年份及月份
            string[] years = { "109", "110" , "111"};
            string[] months = { "01~02", "03~04", "05~06" ,"07~08","09~10","11~12"};
            foreach (string year in years)
            {
                yearComboBox.Items.Add(year);
            }
            foreach (string month in months)
            {
                monthComboBox.Items.Add(month);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //將資料新增至list並顯示出來
            invoiceListBox.Items.Add(yearComboBox.Text + "年" + monthComboBox.Text + "月\n發票號碼:" + inputTextBox.Text);
            inputTextBox.Clear();
        }
    }
}
