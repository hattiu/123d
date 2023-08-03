using System.Text.RegularExpressions;

namespace FirstWebMVC.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateCode(string strInput)
        {
            string strResult ="", numPart = "", strPart = "";
            //tach phan so tu stdInput
            //vd: strInput = "STD001" => numPart = "001"
            numPart = Regex.Match(strInput,@"\d+").Value;
            //tach phan chu tu strInput
            //vd: strInput = "STD001" => strPart = "STD"
            strPart = Regex.Match(strInput,@"\D+").Value;

            //TANG PHAN tu so len 1 down vi
            int intPart = (Convert.ToInt32(numPart)+1);

            for (int i = 0; i < numPart.Length - intPart.ToString().Length;i++)
            {
                strPart += "0";
            }
            strResult = strPart + intPart;
            return strResult;
        }
    }
}