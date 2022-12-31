using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class _205_isomorphic_strings
    {
        public static bool IsIsomorphic(string s, string t)
        {
            Console.WriteLine(s);
            Console.WriteLine(t);
            char[] vs = new char[s.Length];
            bool kq;
            String st = "";
            vs[0] = t[0];
            for (int i = 1; i < s.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (s[i] == s[j])
                    {
                        vs[i] = vs[j];
                        break;
                    }
                    vs[i] = t[i];
                }
            }
            foreach (char c in vs)
            {
                st += c;
            }
            kq = st.Equals(t) ? true : false;
            for (int i=0;i<s.Length-1;i++)
            {
                for (int j=i+1;j<s.Length;j++)
                {
                    if(vs[i] == vs[j] && s[i] != s[j])
                    {
                        kq = false;
                        break;
                    }
                }
            }
            return kq;
        }
    }
}