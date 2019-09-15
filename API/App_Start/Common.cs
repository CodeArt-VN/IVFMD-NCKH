using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace iData.Common
{
    public class StringUtil
    {
        private static readonly string[] VietnameseSigns = new string[] { "aAeEoOuUiIdDyY", "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ", "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ", "ÍÌỊỈĨ", "đ", "Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ" };
        public static string RemoveSign4VietnameseString(string str)
        {
            if (str==null)
            {
                return null;
            }
            for (int i = 1; i < VietnameseSigns.Length; i++)
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                    
                        str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
                    
                    
            return str;
        }
        public static string RemoveSpecialCharacters(string input)
        {
            Regex r = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return r.Replace(input, String.Empty);
        }
        public static string RemoveVietSignAndSpecialChar(string input)
        {
            return RemoveSpecialCharacters(RemoveSign4VietnameseString(input));
        }
        public static string RemoveVietSignSpecialCharAndSpaceChar(string input)
        {
            input = input.Replace(".", "iiidauchamiii").Replace("-/-","iiidaugachcheoiii");

            return RemoveSpecialCharacters(RemoveSign4VietnameseString(input)).Trim().Replace("iiidauchamiii", ".").Replace(".", "-").Replace(" ", "-").Replace("--", "-").Replace("iiidaugachcheoiii","/");
        }
        public static string GS1CheckSum(string pInput)
        {
            if (!(pInput.Length == 7 || pInput.Length == 11 || pInput.Length == 12 || pInput.Length == 13 || pInput.Length == 17))
            {
                return "N/A";
            }
            for (int i = 0; i < pInput.Length; i++)
            {
                try
                {
                    int.Parse(pInput.Substring(i, 1));
                }
                catch (Exception)
                {
                    return "N/A";
                }
            }

            while (pInput.Length < 17)
            {
                pInput = "0" + pInput;
            }
            int TongChan = 0;
            int TongLex3 = 0;
            for (int i = 1; i <= 17; i++)
            {
                if (i % 2 == 0)
                {
                    TongChan += int.Parse(pInput.Substring(i - 1, 1));
                }
                else
                {
                    TongLex3 += 3 * int.Parse(pInput.Substring(i - 1, 1));
                }
            }
            int Tong = TongChan + TongLex3;
            int TempNo = int.Parse(Tong.ToString().Substring(Tong.ToString().Length));
            int returnValue = 0;
            if (TempNo == 0)
            {
                return returnValue.ToString();
            }
            else
            {
                return (10 - TempNo).ToString();
            }
        }
        public static string GS1Complete(string pInput)
        {
            return pInput + GS1CheckSum(pInput);
        }
        public string TrimLeftText(string input, int length, string ReadMoreText)
        {
            if (input.Length <= ReadMoreText.Length + length)
                return input;
            else
                return input.Substring(0, length) + ReadMoreText;
        }
        public string TrimWords(string input, int length, string ReadMoreText)
        {
            System.Text.RegularExpressions.MatchCollection wordColl = System.Text.RegularExpressions.Regex.Matches(input, @"[\S]+");

            if (wordColl.Count > length)
            {
                var words = input.Split(' ');
                var index = 0;
                input = "";
                while (index < length)
                {
                    input += words[index] + " ";
                    index++;
                }

                input += ReadMoreText;
            }

            return input;
        }
        public static string file_get_contents(string fileName)
        {
            string sContents = string.Empty;
            try
            {
                if (fileName.ToLower().IndexOf("http:") > -1 || fileName.ToLower().IndexOf("https:") > -1)
                { // URL 
                    System.Net.WebClient wc = new System.Net.WebClient();
                    byte[] response = wc.DownloadData(fileName);
                    sContents = System.Text.Encoding.UTF8.GetString(response);
                }
                else
                {
                    // Regular Filename 
                    System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
                    sContents = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {

                sContents = "Mục tin này đang cập nhật, vui lòng quay lại sau. <br/> Xin chân thành cảm ơn! " + ex.Message;
            }

            return sContents;
        }
    }
}