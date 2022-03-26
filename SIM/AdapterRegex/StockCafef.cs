using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

namespace AdapterRegex
{
    public class StockCafef
    {
        readonly string url = @"https://s.cafef.vn/hose/FPT-cong-ty-co-phan-fpt.chn";

        public void Process()
        {
            string html = CrawlDataFromURL();

            // Replace table inside the "Ket quả kinh doanh & Tài sản" tab
            var replaceText = Regex.Matches(html, @"<table class='BaoCaoTaiChinh_Chart'(.*?)</table>", RegexOptions.Singleline);

            foreach (var item in replaceText)
            {
                html = html.Replace(item.ToString(), "");
            }
            // Chỉ mục giá hiện tại
            var giaHienTai = Regex.Match(html, @"<div class=""dl-thongtin clearfix""(.*?)<!-- // left -->", RegexOptions.Singleline);
            
            // Kế hoạch kinh doanh năm
            var keHoachKinhDoanh = Regex.Match(html, @"<div class=""kehoachkd"">(.*?)<div class=""xemtiep"">", RegexOptions.Singleline);
            
            // Các chỉ số cơ bản
            var chiSoCoBan = Regex.Match(html, @"<div class=""dlt-left-half"">(.*?)</ul>", RegexOptions.Singleline);

            // Khối lượng lệnh, Vốn hóa
            var khoiLuong = Regex.Match(html, @"<div class=""dlt-right-half"">(.*?)</ul>", RegexOptions.Singleline);

            // Kết quả kinh doanh - Tài sản
            var thongTinCongTy = Regex.Match(html, @"<div id=""divHoSoCongTyAjax"">(.*?)</table>", RegexOptions.Singleline);

            // Chỉ số tài chính
            var chiSoTaiChinh = Regex.Match(html, @"<div class=""financial"">(.*?)</table>", RegexOptions.Singleline);

        }

        private string CrawlDataFromURL()
        {
            //CookieContainer cookie = new CookieContainer();
            //HttpClientHandler handler = new HttpClientHandler
            //{
            //    CookieContainer = cookie,
            //    ClientCertificateOptions = ClientCertificateOption.Automatic,
            //    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            //    AllowAutoRedirect = true,
            //    UseDefaultCredentials = false
            //};
            //HttpClient httpClient = new HttpClient(handler);

            HttpClient httpClient = new HttpClient();

            //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/63.4.154 Chrome/57.4.2987.154 Safari/537.36");
            /*
             * Header:
             * - Origin
             * - Host
             * - Referer
             * - :scheme
             * - accept
             * - Accept-Encoding
             * - Accept-Language
             * - User-Argent
             */

            httpClient.BaseAddress = new Uri(url);
            string html = "";

            html = httpClient.GetStringAsync(url).Result;
            // If url is post method
            //html = httpClient.PostAsync(url,new StringContent("")).Result.Content.ReadAsStringAsync().Result;

            return html;
        }
    }
}
