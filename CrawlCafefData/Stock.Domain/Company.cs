using DotNetCore.Domain;
using Stock.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Stock.Domain
{
    /// <summary>
    /// Thông tin cơ bản công ty
    /// </summary>
    public class Company : Entity<int>
    {
        public Company() { }

        public string Code { get; set; }

        public string Name { get; set; }

        public int SectorLevel1 { get; set; }

        public Sector Sector1 { get; set; }

        public int? SectorLevel2 { get; set; }

        public Sector? Sector2 { get; set; }

        public int? SectorLevel3 { get; set; }

        public Sector? Sector3 { get; set; }

        public float CurrentPrice { get; set; }

        public virtual List<FinancialReport> FinancialReports { get; set; }

        /// <summary>
        /// True: Đang bị cảnh báo có vấn đề bởi ủy ban chứng khoán nhà nhước
        /// </summary>
        public bool IsAlert { get; set; }

        public StockExchange StockExchange { get; set; }

    }
}
