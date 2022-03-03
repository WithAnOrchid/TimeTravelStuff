using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace PhotoMatch
{
    public partial class Form1 : Form
    {

        private string _excelLocation;
        private string _folderPath;

        private List<Student> Students;
        private Dictionary<string, string> Photos = new Dictionary<string, string>();

        private bool _excelReady, _folderReady;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadExcelFile()
        {
            if (string.IsNullOrEmpty(_excelLocation))
            {
                MessageBox.Show("请先选择照片文件夹");
                return;
            }

            try
            {
                using (var reader = new StreamReader(_excelLocation, Encoding.UTF8))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    Students = csv.GetRecords<Student>().ToList();
                }

                if (Students.Count < 1)
                {
                    MessageBox.Show("请确认此文件格式为\n" +
                                    "拍照序号,学籍辅号,姓名,班级,身份证号,准考证号,", "错误");
                    output_text("CSV文件读取失败");
                }
                else
                {
                    _excelReady = true;
                    output_text($"读取到{Students.Count}条信息，处理前请确认数目是否正确");

                    foreach (var student in Students)
                    {
                        if (string.IsNullOrEmpty(student.Shenfenzheng) ||
                            string.IsNullOrEmpty(student.Banji) ||
                            string.IsNullOrEmpty(student.Paizhao) ||
                            string.IsNullOrEmpty(student.Xingming) ||
                            string.IsNullOrEmpty(student.Xueji) ||
                            string.IsNullOrEmpty(student.Zhunkaozheng))
                        {
                            output_text($"条目异常：{student.Shenfenzheng},{student.Banji},{student.Paizhao}," +
                                        $"{student.Xingming},{student.Xueji},{student.Zhunkaozheng}");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("打开Excel文件失败，请先退出使用此文件的程序", "错误");
            }
        }

        private void output_text(string text)
        {
            outputTextbox.AppendText($"\n{DateTime.Now.ToLongTimeString()} {text}");
            outputTextbox.AppendText(Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                _excelLocation = openFileDialog1.FileName;
                LoadExcelFile();
            }
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                var files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                foreach (var f in files)
                {
                    Photos.Add(Path.GetFileNameWithoutExtension(f), f);
                }
                
                MessageBox.Show($"指定目录下有{Photos.Count}个文件, 请在处理前做好备份", "提示");

                textBox2.Text = folderBrowserDialog1.SelectedPath;

                output_text($"读取到{Photos.Count}张照片");

                if (Photos.Count > 0)
                {
                    _folderReady = true;
                }
            }
        }

        private void startProcessingButton_Click(object sender, EventArgs e)
        {
            if (_folderReady && _excelReady)
            {
                int counter = 0;
                foreach (var student in Students)
                {
                    if (Photos.TryGetValue(student.Shenfenzheng, out string pathValue))
                    {
                        string newName = Path.Combine(Directory.GetParent(pathValue).ToString(),
                            $"{student.Xueji}{Path.GetExtension(pathValue)}");
                        File.Move(pathValue, newName);

                        counter++;
                        output_text($"重命名{student.Shenfenzheng}完成, 已完成{counter}");
                    }
                    else
                    {
                        output_text($"未找到{student.Xingming},{student.Shenfenzheng}的照片，跳过");
                    }
                }
            }
            else
            {
                MessageBox.Show($"还没准备好", "提示");
            }
            
        }
    }
}
