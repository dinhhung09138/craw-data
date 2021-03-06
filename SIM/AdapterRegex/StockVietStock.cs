using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdapterRegex
{
    public class StockVietStock
    {
        private Dictionary<int, string> vietStockTradingFloor = new Dictionary<int, string>()
        {
            {1, "HOSE" },
            {2, "HNX" },
            {3, "" },
        };

        public void Process()
        {
            IndustryIndex();

        }

        /// <summary>
        /// Thông tin tổng quan chỉ số của 25 ngành.
        /// </summary>
        private void IndustryIndex()
        {
            GetDataUsingPost(@"https://finance.vietstock.vn/data/sectionindex");
            CrawlDataFromURLPost(@"https://finance.vietstock.vn/data/sectionindex");

            string url = @"https://finance.vietstock.vn/chi-so-nganh.htm";
            string html = CrawlDataFromURL(url);

            // Chỉ số tất cả các ngành (25 ngành).
            var industryIndex = Regex.Match(html, @"<div class=""table-responsive scrollbar tradingmargin-content""(.*?)</table>", RegexOptions.Singleline);

            SpecificIndustry(@"https://api.vietstock.vn/finance/sectorinfo?sectorID=1&languageID=1");
        }

        /// <summary>
        /// Lấy thông tin các mã CP có giao dịch theo ngành.
        /// </summary>
        /// <param name="url"></param>
        private void SpecificIndustry(string url)
        {
            string html = CrawlDataFromURL(url);

            var pageContainer = Regex.Match(html, @"<div id=""page-content"" class=""page-content"">(.*?)<div class=""container"">", RegexOptions.Singleline);

            

        }

        private string CrawlDataFromURL(string url)
        {
            try
            {
                CookieContainer cookie = new CookieContainer();
                HttpClientHandler handler = new HttpClientHandler
                {
                    CookieContainer = cookie,
                    ClientCertificateOptions = ClientCertificateOption.Automatic,
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                    AllowAutoRedirect = true,
                    UseDefaultCredentials = false,
                    UseProxy = true
                };
                HttpClient httpClient = new HttpClient(handler);

                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.82 Safari/537.36");


                httpClient.BaseAddress = new Uri(url);
                string html = "";

                html = httpClient.GetStringAsync(url).Result;
                // If url is post method
                //html = httpClient.PostAsync(url,new StringContent("")).Result.Content.ReadAsStringAsync().Result;

                return html;
            }
            catch (Exception ex)
            {

            }
            return String.Empty;
        }

        private async Task<string> GetDataUsingPost(string url)
        {
            CookieContainer cookie = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler
            {
                CookieContainer = cookie,
                ClientCertificateOptions = ClientCertificateOption.Automatic,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                AllowAutoRedirect = true,
                UseDefaultCredentials = false,
                UseProxy = true
            };
            HttpClient httpClient = new HttpClient(handler);

            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/63.4.154 Chrome/57.4.2987.154 Safari/537.36");

            httpClient.BaseAddress = new Uri(url);
            //var url = "http://myserver/method";
            var parameters = new Dictionary<string, string> { { "type", "1" } };
            var encodedContent = new FormUrlEncodedContent(parameters);

            var response = await httpClient.PostAsync(url, encodedContent).ConfigureAwait(true);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                // Do something with response. Example get content:
                 var responseContent = await response.Content.ReadAsStringAsync ().ConfigureAwait (false);
            }
            return "";
        }


        private string CrawlDataFromURLPost(string url)
        {
            try
            {
                CookieContainer cookie = new CookieContainer();
                HttpClientHandler handler = new HttpClientHandler
                {
                    CookieContainer = cookie,
                    ClientCertificateOptions = ClientCertificateOption.Automatic,
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                    AllowAutoRedirect = true,
                    UseDefaultCredentials = false,
                    UseProxy = true
                };
                HttpClient httpClient = new HttpClient(handler);

                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/63.4.154 Chrome/57.4.2987.154 Safari/537.36");


                httpClient.BaseAddress = new Uri(url);
                string html = "";
                var parameters = new Dictionary<string, string> { { "type", "1" } };
                var encodedContent = new FormUrlEncodedContent(parameters);

                //html = httpClient.GetStringAsync(url).Result;
                // If url is post method
                html = httpClient.PostAsync(url,new StringContent("")).Result.Content.ReadAsStringAsync().Result;

                return html;
            }
            catch (Exception ex)
            {

            }
            return String.Empty;
        }

    }
}
