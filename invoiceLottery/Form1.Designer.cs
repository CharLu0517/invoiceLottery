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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.noSignalLabel = new System.Windows.Forms.Label();
            this.invoiceListView = new System.Windows.Forms.ListView();
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mounth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(340, 424);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "新增";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(182, 424);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(148, 22);
            this.inputTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "手動輸入發票號碼：";
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(182, 398);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(49, 20);
            this.yearComboBox.TabIndex = 5;
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(260, 398);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(59, 20);
            this.monthComboBox.TabIndex = 6;
            // 
            // cameraPictureBox
            // 
            this.cameraPictureBox.BackColor = System.Drawing.Color.Black;
            this.cameraPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cameraPictureBox.Location = new System.Drawing.Point(13, 49);
            this.cameraPictureBox.Name = "cameraPictureBox";
            this.cameraPictureBox.Size = new System.Drawing.Size(501, 343);
            this.cameraPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cameraPictureBox.TabIndex = 7;
            this.cameraPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 26);
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
            this.cameraComboBox.Location = new System.Drawing.Point(117, 23);
            this.cameraComboBox.Name = "cameraComboBox";
            this.cameraComboBox.Size = new System.Drawing.Size(264, 20);
            this.cameraComboBox.TabIndex = 9;
            // 
            // cameraStartButton
            // 
            this.cameraStartButton.Enabled = false;
            this.cameraStartButton.Location = new System.Drawing.Point(405, 21);
            this.cameraStartButton.Name = "cameraStartButton";
            this.cameraStartButton.Size = new System.Drawing.Size(75, 23);
            this.cameraStartButton.TabIndex = 10;
            this.cameraStartButton.Text = "開始偵測";
            this.cameraStartButton.UseVisualStyleBackColor = true;
            this.cameraStartButton.Click += new System.EventHandler(this.cameraStartButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(520, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 22);
            this.textBox1.TabIndex = 11;
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
            this.noSignalLabel.Location = new System.Drawing.Point(202, 205);
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
            this.number});
            this.invoiceListView.HideSelection = false;
            this.invoiceListView.Location = new System.Drawing.Point(520, 48);
            this.invoiceListView.Name = "invoiceListView";
            this.invoiceListView.Size = new System.Drawing.Size(256, 390);
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
            this.number.Width = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "年";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "月";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invoiceListView);
            this.Controls.Add(this.noSignalLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cameraStartButton);
            this.Controls.Add(this.cameraComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cameraPictureBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "發票兌獎";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label noSignalLabel;
        private System.Windows.Forms.ListView invoiceListView;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader mounth;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

