using CsvHelper.Configuration.Attributes;

namespace PhotoMatch
{
    public class Student
    {
        [Index(0)]
        public string Paizhao { get; set; }
        [Index(1)]
        public string Xueji { get; set; }
        [Index(2)]
        public string Xingming { get; set; }
        [Index(3)]
        public string Banji { get; set; }
        [Index(4)]
        public string Shenfenzheng { get; set; }
        [Index(5)]
        public string Zhunkaozheng { get; set; }
    }
}