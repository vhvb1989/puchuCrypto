using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puchuCryptor
{
    public class PuchuCode
    {
        private static char[,] code = {
            {'B','T','W','R','5','2','D','I','A','Y','F','W','H','E','J','V'},
            {'S','H','M','A','V','P','E','P','Y','D','E','Z','W','T','E','V'},
            {'V','1','C','A','N','8','N','M','O','T','C','X','Y','L','S','C'},
            {'A','8','N','N','I','U','V','E','R','D','S','A','U','A','R','Y'},
            {'W','A','F','I','T','6','Q','N','L','S','L','H','G','Q','S','D'},
            {'D','2','G','T','H','E','R','<','3','G','B','R','V','O','W','A'},
            {'O','7','L','D','D','W','I','Q','9','O','F','T','H','V','I','U'},
            {'Z','X','C','M','Y','S','X','L','X','I','M','E','F','X','E','E'},
        };
        public PuchuCode()
        {
        }

        public String encode(String raw)
        {
            return "WIP";
        }

        public String decode(String cryp)
        {
            String result = "";
            // lines
            foreach (string line in cryp.Split('\n'))
            {
                // tokens
                foreach (string token in line.Split(' '))
                {
                    if (token.Length > 2)
                    {
                        // letter
                        string[] c = token.Split(',');
                        int r = int.Parse(c[0].Trim().Replace('c', '0')) - 1;
                        int col = int.Parse(c[1].Trim().Replace('r', '0')) -1;
                        result += code[col, r];
                    }
                    else
                    {
                        // expected space
                        result += " ";
                    }
                }

                // add break
                result += Environment.NewLine;
            }

            return result;
        }
    }
}

