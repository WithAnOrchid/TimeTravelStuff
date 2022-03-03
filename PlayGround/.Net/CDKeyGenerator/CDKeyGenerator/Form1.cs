using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDKeyGenerator.Entities;

namespace CDKeyGenerator
{
    public partial class Form1 : Form
    {
        private const string ConnectionStringPrefix = "Data Source=";
        private readonly BindingList<UnusedCode> _unusedCodes;
        private readonly BindingList<UsedCode> _usedCodes;

        private string _dbLocation = "database.db";
        public Form1()
        {
            InitializeComponent();
            _unusedCodes = new BindingList<UnusedCode>();
            _usedCodes = new BindingList<UsedCode>();
        }

        private void LoadUnusedCodes()
        {
            const string stringSql = "SELECT * FROM UnusedCodes";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringPrefix + _dbLocation))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(stringSql, connection);

                SQLiteDataReader sqlReader = command.ExecuteReader();
                try
                {
                    while (sqlReader.Read())
                    {
                        _unusedCodes.Add(new UnusedCode
                        {
                            序号 = sqlReader.GetInt32(0),
                            充值码 = sqlReader.GetString(1),
                            物品名 = sqlReader.GetString(2),
                            物品数量 = sqlReader.GetInt64(3),
                            绑定 = sqlReader.GetInt32(4),
                            剩余兑换次数 = sqlReader.GetInt32(5),
                            单账号最大使用次数 = sqlReader.GetInt32(6),
                            添加时间 = sqlReader.GetString(7)
                        });
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    sqlReader.Close();
                }
            }
        }

        private void LoadUsedCodes()
        {
            const string stringSql = "SELECT * FROM UsedCodes";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringPrefix + _dbLocation))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(stringSql, connection);

                SQLiteDataReader sqlReader = command.ExecuteReader();
                try
                {
                    while (sqlReader.Read())
                    {
                        _usedCodes.Add(new UsedCode
                        {
                            序号 = sqlReader.GetInt32(0),
                            充值码 = sqlReader.GetString(1),
                            使用账号 = sqlReader.GetString(2),
                            使用时间 = sqlReader.GetString(3)
                        });
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    sqlReader.Close();
                }
            }
        }

        private void ReloadData()
        {
            try
            {
                _unusedCodes?.Clear();
                _usedCodes?.Clear();
                LoadUnusedCodes();
                LoadUsedCodes();
                createDataGridView.DataSource = _unusedCodes;
                usedDataGridView.DataSource = _usedCodes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddUnusedCode(UnusedCode code)
        {
            string queryString = "insert into UnusedCodes(Code, ItemName, Amount, Bound, RemainingUse, MaxUsePerAccount, AddTime) " +
                                 "values(@充值码,@物品名,@物品数量,@绑定,@剩余兑换次数,@单账号最大使用次数,@添加时间);  " +
                                 "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringPrefix + _dbLocation))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(queryString, connection);

                SQLiteParameter 充值码 = new SQLiteParameter("@充值码") {Value = code.充值码};

                SQLiteParameter 物品名 = new SQLiteParameter("@物品名") {Value = code.物品名};

                SQLiteParameter 物品数量 = new SQLiteParameter("@物品数量") {Value = code.物品数量};

                SQLiteParameter 绑定 = new SQLiteParameter("@绑定") {Value = code.绑定};

                SQLiteParameter 剩余兑换次数 = new SQLiteParameter("@剩余兑换次数") { Value = code.剩余兑换次数 };

                SQLiteParameter 单账号最大使用次数 = new SQLiteParameter("@单账号最大使用次数") {Value = code.单账号最大使用次数};

                SQLiteParameter 添加时间 = new SQLiteParameter("@添加时间") {Value = code.添加时间};

                command.Parameters.Add(充值码);
                command.Parameters.Add(物品名);
                command.Parameters.Add(物品数量);
                command.Parameters.Add(绑定);
                command.Parameters.Add(剩余兑换次数);
                command.Parameters.Add(单账号最大使用次数);
                command.Parameters.Add(添加时间);

                var res = command.ExecuteScalar();
                code.序号 = Convert.ToInt32(res);
                _unusedCodes.Add(code);
            }
        }

        private void DeleteUnusedCode(UnusedCode code)
        {
            if (code == null) return;

            string stringSql = "DELETE FROM UnusedCodes WHERE Code=@code";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringPrefix + _dbLocation))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(stringSql, connection);
                SQLiteParameter p = new SQLiteParameter("@code") { Value = code.充值码 };
                command.Parameters.Add(p);
                command.ExecuteNonQuery();
                _unusedCodes.Remove(code);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                _dbLocation = openFileDialog1.FileName;
                ReloadData();
            }
        }

        private void boundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            boundCheckBox.Text = boundCheckBox.Checked ? "绑定" : "不绑定";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            _unusedCodes.Clear();
            _usedCodes.Clear();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string 物品名 = itemNametextBox.Text;
            long 物品数量 = (long) itemAmountUpDown.Value;
            int 绑定 = boundCheckBox.Checked ? 1 : 0;
            int 剩余兑换次数 = (int) remainingTimesUpDown.Value;
            int 单账号最大使用次数 = (int) limitUpDown.Value;

            string 充值码 = RandomUtil.RandomString(12);
            string 添加时间 = DateTime.Now.ToString(CultureInfo.InvariantCulture);

            if (剩余兑换次数 < 1)
            {
                if (MessageBox.Show("剩余次数最少为1, 如果要不限制次数, 请注意指定单账号最大使用次数\n" +
                                    "是否将剩余次数改为999999?", "剩余次数", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    剩余兑换次数 = 999999;
                }
                else
                {
                    剩余兑换次数 = 1;
                }
            }

            UnusedCode code = new UnusedCode
            {
                序号 = 0,
                充值码 = 充值码,
                物品名 = 物品名,
                物品数量 = 物品数量,
                绑定 = 绑定,
                剩余兑换次数 = 剩余兑换次数,
                单账号最大使用次数 = 单账号最大使用次数,
                添加时间 = 添加时间
            };

            try
            {
                AddUnusedCode(code);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (createDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("至少选择一行删除");
                return;
            }
            if (MessageBox.Show($"确认删除{createDataGridView.SelectedRows.Count}条充值码?", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in createDataGridView.SelectedRows)
                    {
                        DeleteUnusedCode(row.DataBoundItem as UnusedCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "游戏内使用充值码需要配合Python脚本\n" +
                             "请确认游戏数据库中存在填写的物品名\n" +
                             "剩余次数为0的充值码无法再使用\n" +
                             "修改后的.db文件, 需要复制到服务端文件夹, 并在Python脚本指定此文件的位置";
            MessageBox.Show(message, "帮助", MessageBoxButtons.OK);
        }
    }
}
