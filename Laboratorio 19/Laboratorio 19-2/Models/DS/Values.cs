using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Laboratorio_19_2.Models.DS
{
    public class Values
    {
        private static void Main(string[] args)
        {

            GetItems();
        }

        public static void GetItems()
        {
            var url = $"https://localhost:44375/items";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "aplicattion/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            //Do something wirh responseBody
                            Console.WriteLine(responseBody);
                        }
                    }

                }
                       
            }
            catch (WebException ex)
            {
                //Handle error
            }
        }

    }
}