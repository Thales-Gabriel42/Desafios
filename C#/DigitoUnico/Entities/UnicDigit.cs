namespace DigitoUnico.Entities
{
    class UnicDigit
    {

        public string P {get; set;}

        public int DigitUnic(int num)
        {
            int len = num.ToString().Length;
            string n = num.ToString();
            int soma = 0;
            if (len > 1)
            {
                int[] dig = new int[len];
                for(int i = 0; i < len; i++)
                {
                    dig[i] = int.Parse(n[i].ToString());
                }
                foreach(int c in dig)
                {
                    soma += c;
                }
                return soma;
            }
            else
            {
                return num;
            }      
        }

        public int NKP(int n, int k)
        {
            int soma = 0;
            string nS = n.ToString();
            string p = "";
            for(int i = 0; i < k; i++)
            {
                p += nS;
                P += nS;
                if (i != k-1) {P += "*";}
            }
            foreach(char nu in p)
            {
                soma += int.Parse(nu.ToString());
            }
            return soma;
        }
    }
}