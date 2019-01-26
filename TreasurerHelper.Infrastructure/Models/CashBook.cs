using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasurerHelper.Infrastructure.Models
{
    public class CashBook
    {
        public List<string> Categories { get; set; }
        public List<EntryRecord> EntryRecords { get; set; }
    }

    /// <summary>
    /// 記録
    /// </summary>
    public class EntryRecord
    {
        /// <summary>
        /// 日付
        /// </summary>
        public DateTime EntryDate { get; set; }

        /// <summary>
        /// 収入
        /// </summary>
        public decimal Income { get; set; }

        /// <summary>
        /// 支出
        /// </summary>
        public decimal Outgo { get; set; }

        /// <summary>
        /// 科目
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        public string Description { get; set; }

    }

}
