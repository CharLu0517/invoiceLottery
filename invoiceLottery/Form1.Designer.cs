namespace invoiceLottery
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.cameraPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cameraComboBox = new System.Windows.Forms.ComboBox();
            this.cameraStartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.noSignalLabel = new System.Windows.Forms.Label();
            this.invoiceListView = new System.Windows.Forms.ListView();
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mounth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prizeAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.noPrizeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prizeListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalAmtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(336, 431);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "新增";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(178, 431);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(148, 22);
            this.inputTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(16, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "手動輸入發票號碼：";
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(178, 405);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(49, 20);
            this.yearComboBox.TabIndex = 5;
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(256, 405);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(59, 20);
            this.monthComboBox.TabIndex = 6;
            // 
            // cameraPictureBox
            // 
            this.cameraPictureBox.BackColor = System.Drawing.Color.Black;
            this.cameraPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cameraPictureBox.Location = new System.Drawing.Point(6, 38);
            this.cameraPictureBox.Name = "cameraPictureBox";
            this.cameraPictureBox.Size = new System.Drawing.Size(450, 362);
            this.cameraPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cameraPictureBox.TabIndex = 7;
            this.cameraPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "相機:";
            // 
            // cameraComboBox
            // 
            this.cameraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraComboBox.Enabled = false;
            this.cameraComboBox.FormattingEnabled = true;
            this.cameraComboBox.Location = new System.Drawing.Point(57, 11);
            this.cameraComboBox.Name = "cameraComboBox";
            this.cameraComboBox.Size = new System.Drawing.Size(264, 20);
            this.cameraComboBox.TabIndex = 9;
            // 
            // cameraStartButton
            // 
            this.cameraStartButton.Enabled = false;
            this.cameraStartButton.Location = new System.Drawing.Point(345, 9);
            this.cameraStartButton.Name = "cameraStartButton";
            this.cameraStartButton.Size = new System.Drawing.Size(75, 23);
            this.cameraStartButton.TabIndex = 10;
            this.cameraStartButton.Text = "開始偵測";
            this.cameraStartButton.UseVisualStyleBackColor = true;
            this.cameraStartButton.Click += new System.EventHandler(this.cameraStartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // noSignalLabel
            // 
            this.noSignalLabel.AutoSize = true;
            this.noSignalLabel.BackColor = System.Drawing.Color.Black;
            this.noSignalLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noSignalLabel.ForeColor = System.Drawing.Color.White;
            this.noSignalLabel.Location = new System.Drawing.Point(156, 211);
            this.noSignalLabel.Name = "noSignalLabel";
            this.noSignalLabel.Size = new System.Drawing.Size(140, 35);
            this.noSignalLabel.TabIndex = 12;
            this.noSignalLabel.Text = "No Signal";
            // 
            // invoiceListView
            // 
            this.invoiceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.year,
            this.mounth,
            this.number,
            this.prize,
            this.prizeAmt});
            this.invoiceListView.HideSelection = false;
            this.invoiceListView.Location = new System.Drawing.Point(462, 6);
            this.invoiceListView.Name = "invoiceListView";
            this.invoiceListView.Size = new System.Drawing.Size(339, 447);
            this.invoiceListView.TabIndex = 13;
            this.invoiceListView.UseCompatibleStateImageBehavior = false;
            this.invoiceListView.View = System.Windows.Forms.View.Details;
            // 
            // year
            // 
            this.year.Text = "年份";
            // 
            // mounth
            // 
            this.mounth.Text = "月份";
            // 
            // number
            // 
            this.number.Text = "發票號碼";
            this.number.Width = 91;
            // 
            // prize
            // 
            this.prize.Text = "獎項";
            // 
            // prizeAmt
            // 
            this.prizeAmt.Text = "獎金";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "年";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "月";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 489);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Moccasin;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.inputTextBox);
            this.tabPage1.Controls.Add(this.invoiceListView);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.noSignalLabel);
            this.tabPage1.Controls.Add(this.yearComboBox);
            this.tabPage1.Controls.Add(this.monthComboBox);
            this.tabPage1.Controls.Add(this.cameraStartButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cameraComboBox);
            this.tabPage1.Controls.Add(this.cameraPictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "輸入發票";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPage2.Controls.Add(this.totalAmtLabel);
            this.tabPage2.Controls.Add(this.totalLabel);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.prizeListView);
            this.tabPage2.Controls.Add(this.noPrizeListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(809, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "對獎結果";
            // 
            // noPrizeListView
            // 
            this.noPrizeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.noPrizeListView.HideSelection = false;
            this.noPrizeListView.Location = new System.Drawing.Point(19, 57);
            this.noPrizeListView.Name = "noPrizeListView";
            this.noPrizeListView.Size = new System.Drawing.Size(335, 335);
            this.noPrizeListView.TabIndex = 14;
            this.noPrizeListView.UseCompatibleStateImageBehavior = false;
            this.noPrizeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "年份";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "月份";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "發票號碼";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "獎項";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "獎金";
            // 
            // prizeListView
            // 
            this.prizeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.prizeListView.HideSelection = false;
            this.prizeListView.Location = new System.Drawing.Point(370, 57);
            this.prizeListView.Name = "prizeListView";
            this.prizeListView.Size = new System.Drawing.Size(335, 335);
            this.prizeListView.TabIndex = 14;
            this.prizeListView.UseCompatibleStateImageBehavior = false;
            this.prizeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "年份";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "月份";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "發票號碼";
            this.columnHeader8.Width = 91;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "獎項";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "獎金";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(22, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 40);
            this.label5.TabIndex = 15;
            this.label5.Text = "無中獎";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(363, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 40);
            this.label6.TabIndex = 16;
            this.label6.Text = "中獎";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalLabel.Location = new System.Drawing.Point(22, 408);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(164, 40);
            this.totalLabel.TabIndex = 17;
            this.totalLabel.Text = "共0張發票";
            // 
            // totalAmtLabel
            // 
            this.totalAmtLabel.AutoSize = true;
            this.totalAmtLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalAmtLabel.Location = new System.Drawing.Point(363, 408);
            this.totalAmtLabel.Name = "totalAmtLabel";
            this.totalAmtLabel.Size = new System.Drawing.Size(107, 40);
            this.totalAmtLabel.TabIndex = 17;
            this.totalAmtLabel.Text = "獎金:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 504);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "發票對獎";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.PictureBox cameraPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cameraComboBox;
        private System.Windows.Forms.Button cameraStartButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label noSignalLabel;
        private System.Windows.Forms.ListView invoiceListView;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader mounth;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader prize;
        private System.Windows.Forms.ColumnHeader prizeAmt;
        private System.Windows.Forms.Label totalAmtLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView prizeListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView noPrizeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

