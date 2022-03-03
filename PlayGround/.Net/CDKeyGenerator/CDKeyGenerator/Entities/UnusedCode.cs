using System;

namespace CDKeyGenerator.Entities
{
    public class UnusedCode
    {
        public int 序号 { get; set; }
        public string 充值码 { get; set; }
        public string 物品名 { get; set; }
        public long 物品数量 { get; set; }
        public int 绑定 { get; set; }
        public int 剩余兑换次数 { get; set; }
        public int 单账号最大使用次数 { get; set; }
        public string 添加时间 { get; set; }
    }
}