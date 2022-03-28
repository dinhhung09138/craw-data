

//using HtmlAgilityPack;

using HtmlAgilityPack;

namespace SIM.Crawl.VietStock
{
    public class CrawlBySector
    {

        private List<Sector> SectorData = new List<Sector>();


        public CrawlBySector()
        {
            SectorData = new List<Sector>()
            {
                new Sector()
                {
                    Id = 1,
                    Name = "Bán buôn",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 2,
                    Name = "Bảo hiểm",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 3,
                    Name = "Bất động sản",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 5,
                    Name = "Chứng khoán",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 6,
                    Name = "Công nghệ và thông tin",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 7,
                    Name = "Bán lẻ",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 8,
                    Name = "Chăm sóc sức khỏe",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 10,
                    Name = "Khai khoáng",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 11,
                    Name = "Ngân hàng",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 12,
                    Name = "Nông - Lâm - Ngư",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 15,
                    Name = "SX Thiết bị, máy móc",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 16,
                    Name = "SX Hàng gia dụng",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 17,
                    Name = "Sản phẩm cao su",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 18,
                    Name = "SX Nhựa - Hóa chất",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 19,
                    Name = "Thực phẩm - Đồ uống",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 20,
                    Name = "Chế biến Thủy sản",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 21,
                    Name = "Vật liệu xây dựng",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 22,
                    Name = "Tiện ích",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 23,
                    Name = "Vận tải - kho bãi",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 24,
                    Name = "Xây dựng",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 25,
                    Name = "Dịch vụ lưu trú, ăn uống, giải trí",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 26,
                    Name = "SX Phụ trợ",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 27,
                    Name = "Thiết bị điện",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 28,
                    Name = "Dịch vụ tư vấn, hỗ trợ",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
                new Sector()
                {
                    Id = 29,
                    Name = "Tài chính khác",
                    Level = 1,
                    SectorDetails = new List<Sector>()
                    {

                    },
                },
            };
        }

        public async Task Process()
        {
            //Data data = await ReadData();
            //ExportDataToExcel(data);
            await ReadDatabyCompany(new CompanyInfo() { Code = "UNI" });
        }

        private async Task<Data> ReadData()
        {
            Data result = new Data();
            result.Sectors = SectorData;

            Console.WriteLine("Start Read Data");
            try
            {

                foreach (var item in SectorData)
                {
                    string url = $"https://api.vietstock.vn/finance/sectorinfo?sectorID={item.Id}&languageID=1";
                    var html = await url.ContentFromURLGetMethod();

                    html = html.Trim().Replace("[", "").Replace("]", "");
                    var rows1 = Regex.Matches(html, @"\{(.*?)}", RegexOptions.Singleline);

                    foreach (var r in rows1)
                    {
                        string companyCode = Regex.Match(r.ToString(), @"""_sc_"":""(.*?)"",", RegexOptions.Singleline).ToString().Replace(@"""_sc_"":""", "").Replace(@""",", "");
                        string companyName = Regex.Match(r.ToString(), @"""stockName"":""(.*?)"",", RegexOptions.Singleline).ToString().Replace(@"""stockName"":""", "").Replace(@""",", "");
                        string stockExchangeId = Regex.Match(r.ToString(), @"""catID"":(.*?),", RegexOptions.Singleline).ToString().Replace(@"""catID"":", "").Replace(@",", "");

                        string sector1 = Regex.Match(r.ToString(), @"""_in_"":""(.*?)"",", RegexOptions.Singleline).ToString().Replace(@"""_in_"":""", "").Replace(@""",", "");
                        string sector3 = Regex.Match(r.ToString(), @"""_sin_"":""(.*?)"",", RegexOptions.Singleline).ToString().Replace(@"""_sin_"":""", "").Replace(@""",", "");

                        result.CompanyInfos.Add(new CompanyInfo()
                        {
                            Code = companyCode,
                            Name = companyName,
                            Sector1Id = item.Id,
                            Sector1Name = sector1,
                            Sector3Name = sector3,
                            StockExchange = stockExchangeId
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when read data");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("complete read data");
            }
            return result;
        }

        private async Task<CompanyInfo> ReadDatabyCompany(CompanyInfo company)
        {
            try
            {
                //Console.WriteLine($"Start Read Data from {company.Code}");

                string url = $"https://finance.vietstock.vn/UNI-ctcp-vien-lien.htm";

                //Dictionary<string, string> param = new Dictionary<string, string>()
                //{
                //    { "Code", company.Code },
                //    { "Page", "1" },
                //    { "PageSize", "4" },
                //    { "ReportTermType", "1" },
                //    { "ReportType", "BCTQ" },
                //    { "Unit", "1000000" }
                //};

                var html = await url.ContentFromURLGetMethod();

                //var currentPrice = Regex.Match(html, @"<div class=""row stock-price-info""(.*?)<small class=pull-right>", RegexOptions.IgnoreCase);

                //var thongKeGiaoDich = Regex.Match(html, @"id=stock-transactions(.*?)</table>", RegexOptions.IgnoreCase);


                //TODO
                //var url = @"https://finance.vietstock.vn/UNI-ctcp-vien-lien.htm";

                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);

                var tableThongTinCoBan = htmlDocument.DocumentNode.Descendants("div")
                                                       .Where(node => node.GetAttributeValue("class", "").Equals("row stock-price-info"))
                                                       .ToList();

                var tableThongKeGiaoDich = htmlDocument.DocumentNode.Descendants("table")
                                                       .Where(node => node.GetAttributeValue("id", "").Equals("stock-transactions"))
                                                       .ToList();


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error when Data from {company.Code}");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine($"complete Data from {company.Code}");
            }
            return company;
        }

        private void ExportDataToExcel(Data data)
        {
            Console.WriteLine("Start export to excel");
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                string filePath = $@"{Directory.GetCurrentDirectory()}\CompanyBySector-{DateTime.Now.ToString("yyyyMMddhhmmss")}.xlsx";
                using (var excel = new ExcelPackage())
                {
                    ExcelWorksheet sectorSheet = excel.Workbook.Worksheets.Add("Sector");

                    sectorSheet.Cells["A1"].Value = "Id 1";
                    sectorSheet.Cells["B1"].Value = "Name 1";
                    sectorSheet.Cells["C1"].Value = "Level 1";

                    sectorSheet.Cells["D1"].Value = "Id 2";
                    sectorSheet.Cells["E1"].Value = "Name 2";
                    sectorSheet.Cells["F1"].Value = "Level 2";

                    sectorSheet.Cells["G1"].Value = "Id 3";
                    sectorSheet.Cells["H1"].Value = "Name 3";
                    sectorSheet.Cells["I1"].Value = "Level 3";

                    int currentRow = 2;
                    foreach (var item in data.Sectors)
                    {
                        sectorSheet.Cells[$"A{currentRow}"].Value = item.Id;
                        sectorSheet.Cells[$"B{currentRow}"].Value = item.Name;
                        sectorSheet.Cells[$"C{currentRow}"].Value = item.Level;

                        sectorSheet.Cells[$"D{currentRow}"].Value = "";
                        sectorSheet.Cells[$"E{currentRow}"].Value = "";
                        sectorSheet.Cells[$"F{currentRow}"].Value = "";

                        sectorSheet.Cells[$"G{currentRow}"].Value = "";
                        sectorSheet.Cells[$"H{currentRow}"].Value = "";
                        sectorSheet.Cells[$"I{currentRow}"].Value = "";
                        currentRow++;
                    }

                    ExcelWorksheet companySheet = excel.Workbook.Worksheets.Add("Company");

                    companySheet.Cells["A1"].Value = "Code";
                    companySheet.Cells["B1"].Value = "Name";
                    companySheet.Cells["C1"].Value = "Sector 1";
                    companySheet.Cells["D1"].Value = "Sector 2";
                    companySheet.Cells["E1"].Value = "Sector 3";
                    companySheet.Cells["F1"].Value = "Stock Exchange";

                    currentRow = 2;
                    foreach (var item in data.CompanyInfos)
                    {
                        companySheet.Cells[$"A{currentRow}"].Value = item.Code;
                        companySheet.Cells[$"B{currentRow}"].Value = item.Name;
                        companySheet.Cells[$"C{currentRow}"].Value = item.Sector1Name;
                        companySheet.Cells[$"D{currentRow}"].Value = item.Sector2Name;
                        companySheet.Cells[$"E{currentRow}"].Value = item.Sector3Name;
                        companySheet.Cells[$"F{currentRow}"].Value = item.StockExchange;
                        currentRow++;
                    }

                    using (var memoryStream = new MemoryStream())
                    {
                        FileStream objFileStrea = File.Create(filePath);
                        objFileStrea.Close();
                        File.WriteAllBytes(filePath, excel.GetAsByteArray());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when export to excel");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Complete export to excel");
            }
        }

        internal class Data
        {
            public List<CompanyInfo> CompanyInfos { get; set; } = new List<CompanyInfo>();
            public List<Sector> Sectors { get; set; } = new List<Sector>();
        }

        internal class CompanyInfo
        {
            public string Code { get; set; }

            public string Name { get; set; }

            public string StockExchange { get; set; }

            public int Sector1Id { get; set; }

            public string Sector1Name { get; set; }

            public int Sector2Id { get; set; }

            public string Sector2Name { get; set; }

            public int Sector3Id { get; set; }

            public string Sector3Name { get; set; }
        }

        internal class Sector
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public int Level { get; set; }

            public List<Sector> SectorDetails { get; set; } = new List<Sector>();
        }
    }
}
