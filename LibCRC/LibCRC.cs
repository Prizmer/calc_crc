using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using CRCCalc.Algorithms;

namespace CRCCalc
{
    public class LibCRC
    {
        private const string ALG_NAMESPACE = "CRCCalc.Algorithms";

        public LibCRC() {}
        public bool ConvertInputStringToByteArray(string str, ref byte[] arr)
        {
            string inp_hex_str = str.Replace(" ", String.Empty).Replace("-", String.Empty);
            try
            {
                if (inp_hex_str.Length % 2 != 0 || inp_hex_str == "") return false;

                byte[] tmpArr = new byte[inp_hex_str.Length / 2];

                for (int i = 0; i < inp_hex_str.Length; i += 2)
                    tmpArr[i / 2] = Convert.ToByte(inp_hex_str.Substring(i, 2), 16);

                arr = tmpArr;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
      
        public List<string> GetAlgorithmsList()
        {
            List<string> res = new List<string>();
            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == ALG_NAMESPACE
                    select t;

            q.ToList().ForEach(t => res.Add(t.Name));

            return res;
        }

        public bool GetCRCFromInputString(string str, string algName, ref byte[] crc)
        {
            IAlgorithms algorithm = null;
            byte[] inputArr = null;
            crc = null;

            Type typeAlgorithm = Type.GetType(ALG_NAMESPACE + "." + algName);
            algorithm = (IAlgorithms)Activator.CreateInstance(typeAlgorithm);

            if (!ConvertInputStringToByteArray(str, ref inputArr))
            {
                return false;
            }

            if (!algorithm.GetCRCBytes(inputArr, ref crc))
            {
                return false;
            }

            return true;
        }

    }
}
