using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace titanZPL{
    public static class printer_render {
        //public  static string printer_uri="http://10.24.106.183/";
        public  static string printer_uri="http://192.168.1.3/";
        public static string post(string ZPL,bool print){
            StringBuilder postData = new StringBuilder();
            postData.Append("data="  + WebUtility.UrlEncode(ZPL)        + "&");
            postData.Append("dev="   + WebUtility.UrlEncode("R")        + "&");
            postData.Append("oname=" + WebUtility.UrlEncode("UNKNOWN")  + "&");
            postData.Append("otype=" + WebUtility.UrlEncode("ZPL")      + "&");
            if(print) {
                postData.Append("print=" + WebUtility.UrlEncode("Print Label"));
            } else {
                postData.Append("prev="  + WebUtility.UrlEncode("Preview Label"));
            }
            byte[] postBytes = (new ASCIIEncoding()).GetBytes(postData.ToString());

            HttpWebRequest request = (HttpWebRequest) HttpWebRequest.Create(printer_uri+"zpl");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postBytes.Length;

            Stream postStream = request.GetRequestStream();
            postStream.Write(postBytes, 0, postBytes.Length);
            postStream.Flush();
            postStream.Close();

            var response = request.GetResponse().GetResponseStream();
            var sr = new StreamReader(response);
            var content = sr.ReadToEnd();
            System.Threading.Thread.Sleep(1000);

            return content;
        }
    }
}
