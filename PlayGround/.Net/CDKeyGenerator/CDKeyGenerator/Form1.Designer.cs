
namespace CDKeyGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.unusedTab = new System.Windows.Forms.TabPage();
            this.createDataGridView = new System.Windows.Forms.DataGridView();
            this.createGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.limitUpDown = new System.Windows.Forms.NumericUpDown();
            this.boundCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itemAmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.itemNametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usedTab = new System.Windows.Forms.TabPage();
            this.usedDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.remainingTimesUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabControl.SuspendLayout();
            this.unusedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createDataGridView)).BeginInit();
            this.createGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemAmountUpDown)).BeginInit();
            this.usedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainingTimesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.unusedTab);
            this.tabControl.Controls.Add(this.usedTab);
            this.tabControl.Location = new System.Drawing.Point(12, 74);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 364);
            this.tabControl.TabIndex = 0;
            // 
            // unusedTab
            // 
            this.unusedTab.Controls.Add(this.createDataGridView);
            this.unusedTab.Controls.Add(this.createGroupBox);
            this.unusedTab.Location = new System.Drawing.Point(4, 22);
            this.unusedTab.Name = "unusedTab";
            this.unusedTab.Padding = new System.Windows.Forms.Padding(3);
            this.unusedTab.Size = new System.Drawing.Size(768, 338);
            this.unusedTab.TabIndex = 0;
            this.unusedTab.Text = "未使用";
            this.unusedTab.UseVisualStyleBackColor = true;
            // 
            // createDataGridView
            // 
            this.createDataGridView.AllowUserToAddRows = false;
            this.createDataGridView.AllowUserToDeleteRows = false;
            this.createDataGridView.AllowUserToOrderColumns = true;
            this.createDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.createDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.createDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createDataGridView.Location = new System.Drawing.Point(6, 87);
            this.createDataGridView.Name = "createDataGridView";
            this.createDataGridView.ReadOnly = true;
            this.createDataGridView.RowTemplate.Height = 23;
            this.createDataGridView.Size = new System.Drawing.Size(756, 243);
            this.createDataGridView.TabIndex = 1;
            // 
            // createGroupBox
            // 
            this.createGroupBox.Controls.Add(this.remainingTimesUpDown);
            this.createGroupBox.Controls.Add(this.label7);
            this.createGroupBox.Controls.Add(this.label6);
            this.createGroupBox.Controls.Add(this.label4);
            this.createGroupBox.Controls.Add(this.addButton);
            this.createGroupBox.Controls.Add(this.limitUpDown);
            this.createGroupBox.Controls.Add(this.boundCheckBox);
            this.createGroupBox.Controls.Add(this.label5);
            this.createGroupBox.Controls.Add(this.itemAmountUpDown);
            this.createGroupBox.Controls.Add(this.itemNametextBox);
            this.createGroupBox.Controls.Add(this.label3);
            this.createGroupBox.Controls.Add(this.label2);
            this.createGroupBox.Location = new System.Drawing.Point(6, 6);
            this.createGroupBox.Name = "createGroupBox";
            this.createGroupBox.Size = new System.Drawing.Size(756, 75);
            this.createGroupBox.TabIndex = 0;
            this.createGroupBox.TabStop = false;
            this.createGroupBox.Text = "新建";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(613, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "0为无限制";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(60, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "只能填写一个物品";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(678, 15);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(66, 45);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "添加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // limitUpDown
            // 
            this.limitUpDown.Location = new System.Drawing.Point(520, 42);
            this.limitUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.limitUpDown.Name = "limitUpDown";
            this.limitUpDown.Size = new System.Drawing.Size(87, 21);
            this.limitUpDown.TabIndex = 8;
            // 
            // boundCheckBox
            // 
            this.boundCheckBox.AutoSize = true;
            this.boundCheckBox.Location = new System.Drawing.Point(318, 30);
            this.boundCheckBox.Name = "boundCheckBox";
            this.boundCheckBox.Size = new System.Drawing.Size(60, 16);
            this.boundCheckBox.TabIndex = 7;
            this.boundCheckBox.Text = "不绑定";
            this.boundCheckBox.UseVisualStyleBackColor = true;
            this.boundCheckBox.CheckedChanged += new System.EventHandler(this.boundCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "单账号最大使用次数:";
            // 
            // itemAmountUpDown
            // 
            this.itemAmountUpDown.Location = new System.Drawing.Point(242, 29);
            this.itemAmountUpDown.Maximum = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.itemAmountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemAmountUpDown.Name = "itemAmountUpDown";
            this.itemAmountUpDown.Size = new System.Drawing.Size(59, 21);
            this.itemAmountUpDown.TabIndex = 4;
            this.itemAmountUpDown.ThousandsSeparator = true;
            this.itemAmountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // itemNametextBox
            // 
            this.itemNametextBox.Location = new System.Drawing.Point(62, 29);
            this.itemNametextBox.Name = "itemNametextBox";
            this.itemNametextBox.Size = new System.Drawing.Size(109, 21);
            this.itemNametextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "物品数量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "物品名:";
            // 
            // usedTab
            // 
            this.usedTab.Controls.Add(this.usedDataGridView);
            this.usedTab.Location = new System.Drawing.Point(4, 22);
            this.usedTab.Name = "usedTab";
            this.usedTab.Padding = new System.Windows.Forms.Padding(3);
            this.usedTab.Size = new System.Drawing.Size(768, 338);
            this.usedTab.TabIndex = 1;
            this.usedTab.Text = "已使用";
            this.usedTab.UseVisualStyleBackColor = true;
            // 
            // usedDataGridView
            // 
            this.usedDataGridView.AllowUserToAddRows = false;
            this.usedDataGridView.AllowUserToDeleteRows = false;
            this.usedDataGridView.AllowUserToOrderColumns = true;
            this.usedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usedDataGridView.Location = new System.Drawing.Point(6, 6);
            this.usedDataGridView.Name = "usedDataGridView";
            this.usedDataGridView.ReadOnly = true;
            this.usedDataGridView.RowTemplate.Height = 23;
            this.usedDataGridView.Size = new System.Drawing.Size(756, 326);
            this.usedDataGridView.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择充值码数据库文件:";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(619, 29);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "打开数据库";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(709, 29);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "关闭数据库";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "cdkey.db";
            this.openFileDialog1.Filter = "SQLite 数据库文件|*.db;*.sqlite";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(706, 438);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "删除选中";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(619, 59);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(165, 31);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "刷新";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "帮助";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "剩余兑换次数:";
            // 
            // remainingTimesUpDown
            // 
            this.remainingTimesUpDown.Location = new System.Drawing.Point(520, 15);
            this.remainingTimesUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.remainingTimesUpDown.Name = "remainingTimesUpDown";
            this.remainingTimesUpDown.Size = new System.Drawing.Size(87, 21);
            this.remainingTimesUpDown.TabIndex = 13;
            this.remainingTimesUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "充值码管理器 v1.0 作者：奥利奥";
            this.tabControl.ResumeLayout(false);
            this.unusedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.createDataGridView)).EndInit();
            this.createGroupBox.ResumeLayout(false);
            this.createGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemAmountUpDown)).EndInit();
            this.usedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainingTimesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage unusedTab;
        private System.Windows.Forms.TabPage usedTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView createDataGridView;
        private System.Windows.Forms.GroupBox createGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown limitUpDown;
        private System.Windows.Forms.CheckBox boundCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown itemAmountUpDown;
        private System.Windows.Forms.TextBox itemNametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView usedDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown remainingTimesUpDown;
        private System.Windows.Forms.Label label7;
    }
}

