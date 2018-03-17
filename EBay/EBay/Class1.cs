using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBay
{
    class Helper
    {
        public static void CheckNameWord(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 'z' || (e.KeyChar < 'a' && e.KeyChar > 'Z') || e.KeyChar < 'A') && e.KeyChar != ' ' && e.KeyChar != 8)
            {
                MessageBox.Show("only letters possible");
                e.KeyChar = (char)0;
                
            }
        }
        public static void CheckNumber(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != 8)
            {
                MessageBox.Show("only whole numbers possible");
                e.KeyChar = (char)0;

            }
        }
        public static void CheckNameNumberWord(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 'z' || (e.KeyChar < 'a' && e.KeyChar > 'Z') || e.KeyChar < 'A') && (e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                MessageBox.Show("only numbers and letters possible");
                e.KeyChar = (char)0;

            }
        }
        public static void CheckNameNumberWordMail(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 'z' || (e.KeyChar < 'a' && e.KeyChar > 'Z') || e.KeyChar < 'A') && (e.KeyChar > '9' || e.KeyChar < '0') && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '@' && e.KeyChar != '.')
            {
                MessageBox.Show("only numbers, letters and symbols for mail possible");
                e.KeyChar = (char)0;

            }
        }
        public static bool CheckMail(string s)
        {
            if (s.Substring(s.IndexOf('@')) != "@gmail.com")
                return false;
            if (s.IndexOf('.') != s.LastIndexOf('.'))
                return false;
            return true;
        }
    }
}
