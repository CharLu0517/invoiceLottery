using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace invoiceLottery
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        List<Invoice> invoices;
        Dictionary<string, Prize> prizeDictionary;
        string qrcodeResult;
        private void Form1_Load(object sender, EventArgs e)
        {
            invoices = new List<Invoice>();
            
            //comboBox加入可選擇的年份及月份
            string[] years = {  "110", "111", "112" };
            string[] months = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            foreach (string year in years)
                yearComboBox.Items.Add(year);
            yearComboBox.SelectedIndex = 1;
            foreach (string month in months)
                monthComboBox.Items.Add(month);
            monthComboBox.SelectedIndex = 0;

            //載入發票開獎號碼
            prizeDictionary = new Dictionary<string, Prize>();

            prizeDictionary.Add("11008", new Prize("11008", "52604932",
                new string[] { "20102509" },
                new string[] { "39173725", "34997398", "98953723" },
                new string[] { "634" },
                new int[] { 10000000, 2000000, 200000, 40000, 10000, 4000, 1000, 200 }));

            prizeDictionary.Add("11006", new Prize("11006", "51118051",
               new string[] { "37385202" },
               new string[] { "27461411", "99831976", "10229515" },
               new string[] { "747" },
               new int[] { 10000000, 2000000, 200000, 40000, 10000, 4000, 1000, 200 }));
            prizeDictionary.Add("11004", new Prize("11004", "59518250",
               new string[] { "81016847" },
               new string[] { "22884739", "80660537", "62637675" },
               new string[] { "187" },
               new int[] { 10000000, 2000000, 200000, 40000, 10000, 4000, 1000, 200 }));
            prizeDictionary.Add("11002", new Prize("11002", "80325690",
              new string[] { "95201943" },
              new string[] { "64613291", "00581856", "63105417" },
              new string[] { "295" },
              new int[] { 10000000, 2000000, 200000, 40000, 10000, 4000, 1000, 200 }));
            //讀取可用的webcam
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (filterInfoCollection != null)
            {
                foreach (FilterInfo filter in filterInfoCollection)
                    cameraComboBox.Items.Add(filter.Name);
                cameraComboBox.SelectedIndex = 0;
                cameraComboBox.Enabled = true;
                cameraStartButton.Enabled = true;
            }
            else
            {
                cameraComboBox.Text = "無視訊鏡頭";
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string inputTxt = inputTextBox.Text;
            if (inputTxt.Count() == 8 && inputTxt.All(char.IsDigit))
            {
                Invoice invoice = new Invoice(yearComboBox.Text, monthComboBox.Text, inputTextBox.Text);
                if (!invoicesHasDuplicate(invoice))
                {
                    //手動將資料新增至list並顯示出來
                    string time = invoice.Year + invoice.Mounth.Substring(3, 2);
                    if (prizeDictionary.TryGetValue(time,out Prize prize))
                        invoice = prize.prizeCheck(invoice);
                    invoices.Add(invoice);
                    invoiceListViewShow();
                    inputTextBox.Clear();
                }
            }


        }

        private void cameraStartButton_Click(object sender, EventArgs e)
        {
            //開始或結束偵測按鈕
            if (videoCaptureDevice == null)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraComboBox.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                timer1.Start();
                cameraStartButton.Text = "結束偵測";
                noSignalLabel.Visible = false;
            }
            else
            {
                videoCaptureDevice.Stop();
                videoCaptureDevice = null;
                timer1.Stop();
                cameraStartButton.Text = "開始偵測";
                cameraPictureBox.Image = null;
                noSignalLabel.Visible = true;
            }

        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //更新畫面
            cameraPictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //離開時把相機跟timer關掉
            if (videoCaptureDevice != null)
            {
                videoCaptureDevice.Stop();
                videoCaptureDevice = null;
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //偵測QRCode
            if (cameraPictureBox.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)cameraPictureBox.Image);
                if (result != null && result.ToString() != qrcodeResult)
                {
                   
                    qrcodeResult = result.ToString();
                    if (qrcodeResult.Count() > 15)
                    {
                        string resulttxt = qrcodeResult.Substring(2, 13);
                        if (resulttxt.All(char.IsDigit))
                        {
                            Invoice invoice = new Invoice(resulttxt.Substring(8, 3), resulttxt.Substring(11, 2), resulttxt.Substring(0, 8));
                            if (!invoicesHasDuplicate(invoice))
                            {
                                string time = invoice.Year + invoice.Mounth.Substring(3, 2);
                                //對獎
                                if (prizeDictionary.TryGetValue(time, out Prize prize))
                                    invoice = prize.prizeCheck(invoice);
                                //把結果更新到invoices裡
                                invoices.Add(invoice);
                                //顯示結果
                                invoiceListViewShow();
                            }
                        }
                    }
     
                }
            }
        }

        private void invoiceListViewShow()
        {
            invoiceListView.Items.Clear();
            noPrizeListView.Items.Clear();
            prizeListView.Items.Clear();
            foreach (Invoice invoice in invoices)
            {
                string[] st = { invoice.Year, invoice.Mounth, invoice.Number, invoice.Prize, invoice.PrizeAmt.ToString() };
                var item = new ListViewItem(st);
                invoiceListView.Items.Add(item);
                if(invoice.PrizeAmt == 0)
                {
                    var item1 = new ListViewItem(st);
                    noPrizeListView.Items.Add(item1);
                }
                else
                {
                    var item1 = new ListViewItem(st);
                    prizeListView.Items.Add(item1);
                }
            }
            totalLabel.Text = "共"+invoices.Count()+"張發票";
            totalAmtLabel.Text = "獎金:" + invoices.Sum(item => item.PrizeAmt);
        }
        private bool invoicesHasDuplicate(Invoice invoice)
        {
            foreach (Invoice inv in invoices)
            {
                if (inv.Number == invoice.Number && inv.Year == invoice.Year && inv.Mounth == invoice.Mounth)
                    return true;
            }
            return false;
        }
    }
}
