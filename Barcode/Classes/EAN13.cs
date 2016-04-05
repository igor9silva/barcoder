using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace BarcodeGenerator
{
    class EAN13
    {
        private string[] EAN_CodeA = { "0001101", "0011001", "0010011", "0111101", "0100011", "0110001", "0101111", "0111011", "0110111", "0001011" };
        private string[] EAN_CodeB = { "0100111", "0110011", "0011011", "0100001", "0011101", "0111001", "0000101", "0010001", "0001001", "0010111" };
        private string[] EAN_CodeC = { "1110010", "1100110", "1101100", "1000010", "1011100", "1001110", "1010000", "1000100", "1001000", "1110100" };
        private string[] EAN_Pattern = { "aaaaaa", "aababb", "aabbab", "aabbba", "abaabb", "abbaab", "abbbaa", "ababab", "ababba", "abbaba" };

        private string Raw_Data;
        public string RawData
        {
            get { return this.Raw_Data; }
            set { this.Raw_Data = value; }
        }        

        public EAN13(string input)
        {
            Raw_Data = input;
        }

        #region Encode
        private string Encode_EAN13()
        {
            string patterncode = EAN_Pattern[Int32.Parse(Raw_Data[0].ToString())];
            string result = "101";

            int pos = 0;
            while (pos < 6)
            {
                if (patterncode[pos] == 'a')
                    result += EAN_CodeA[Int32.Parse(Raw_Data[pos + 1].ToString())];
                if (patterncode[pos] == 'b')
                    result += EAN_CodeB[Int32.Parse(Raw_Data[pos + 1].ToString())];
                pos++;
            }

            //add divider bars
            result += "01010";

            pos = 1;
            while (pos < 6)
                result += EAN_CodeC[Int32.Parse(Raw_Data[(pos++) + 6].ToString())];

            //add checksum
            result += EAN_CodeC[Int32.Parse(Raw_Data[Raw_Data.Length - 1].ToString())];

            //add ending bars
            result += "101";

            return result;
        }
        #endregion

        public string Encoded_Value
        {
            get { return this.Encode_EAN13(); }
        }
    }
}
