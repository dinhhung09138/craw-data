using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace SIM.Crawl
{
    public static class UrlExtension
    {
        public static async Task<string> ContentFromURLGetMethod(this string url)
        {
            try
            {
                CookieContainer cookie = new CookieContainer();
                HttpClientHandler handler = new HttpClientHandler
                {
                    CookieContainer = cookie,
                    ClientCertificateOptions = ClientCertificateOption.Automatic,
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.All,
                    AllowAutoRedirect = true,
                    UseDefaultCredentials = false,
                    UseProxy = true,
                };
                HttpClient httpClient = new HttpClient(handler);

                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.82 Safari/537.36");
                httpClient.DefaultRequestHeaders.Add("accept", "*/*");
                httpClient.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                httpClient.DefaultRequestHeaders.Add("accept-language", "vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5,ru;q=0.4,de;q=0.3,ja;q=0.2");
                //httpClient.DefaultRequestHeaders.Add("", "");
                //httpClient.DefaultRequestHeaders.Add("", "");
                //httpClient.DefaultRequestHeaders.Add("", "");
                //httpClient.DefaultRequestHeaders.Add("", "");
                //httpClient.DefaultRequestHeaders.Add("", "");
                //httpClient.DefaultRequestHeaders.Add("", "");
                

                httpClient.BaseAddress = new Uri(url);
                string html = "";

                HttpResponseMessage response = httpClient.GetAsync(url).Result;

                response.EnsureSuccessStatusCode();

                html = await response.Content.ReadAsStringAsync();

                return html;
            }
            catch (Exception ex)
            {

            }
            return String.Empty;
        }
        public static string ContentFromURLPostMethod(this string url, Dictionary<string, string> parameters)
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
                var headerParameters = new Dictionary<string, string>();
                foreach (var item in parameters)
                {
                    headerParameters.Add(item.Key, item.Value);
                }
                var encodedContent = new FormUrlEncodedContent(headerParameters);

                //html = httpClient.GetStringAsync(url).Result;
                // If url is post method
                html = httpClient.PostAsync(url, new StringContent("")).Result.Content.ReadAsStringAsync().Result;

                return html;
            }
            catch (Exception ex)
            {

            }
            return String.Empty;
        }


        /// <summary>
        /// TODO
        /// Chưa gọi dc, sau này sẽ tìm cách xử lý sau.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<List<T>> ContentFromURLGetMethod<T>(this string url)
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
                using (var client = new HttpClient(handler))
                {
                    client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.4844.82 Safari/537.36");
                    client.DefaultRequestHeaders.Add("accept", "*/*");
                    client.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                    client.DefaultRequestHeaders.Add("accept-language", "vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5,ru;q=0.4,de;q=0.3,ja;q=0.2");

                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //GET Method
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        Console.WriteLine("Internal server Error");
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
