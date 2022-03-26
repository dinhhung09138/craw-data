using DotNetCore.Domain;
using Stock.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Stock.Domain
{
    /// <summary>
    /// Ngành hàng
    /// </summary>
    public class Sector : Entity<int>
    {
        public Sector() { }

        public string SectorName { get; set; }

        public SectorLevel Level { get; set; }

        public int? ParentIndustryId { get; set; }

        public virtual List<Company> CompanyLevel1s { get; set; }

        public virtual List<Company> CompanyLevel2s { get; set; }

        public virtual List<Company> CompanyLevel3s { get; set; }

        /// <summary>
        /// Danh sách các công ty trong ngành dựa trên vietstock
        /// </summary>
        public string UrlVietStockData { get; set; }
    }
}
