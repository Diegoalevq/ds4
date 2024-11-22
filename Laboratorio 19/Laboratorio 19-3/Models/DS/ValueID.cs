using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Laboratorio_19_3.Models.DS
{
    public class ValueID
    {
        private static void Main(string[] args)
        {
            GetItem(10);
        }

        private static void GetItem(int id)
        {
            var url = "https://localhost:44375/item/{id}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using(Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader (strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            //Do something with responseBody
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