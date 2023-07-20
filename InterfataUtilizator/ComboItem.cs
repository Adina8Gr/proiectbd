using System;

namespace InterfataUtilizator
{
    public class ComboItem
    {
        

        public string Text { get; set; }
        public int Value { get; set; }
        public string Text1 { get; set; }
        public int Value1 { get; set; }
   

        public ComboItem(string text, int value)
        {
             Text = text;
             Value = value;
           
        }

        public ComboItem(string text, string text1)
        {
            Text = text;
            Text1 = text1;
        }

        public ComboItem(int value, int value1)
        {
            Value = value;
            Value1=value1;
        }

        public override string ToString()
        {
            return Text;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            // verifica daca obiectul primit ca parametru poate fi convertit la un obiect de tip ComboItem
            ComboItem ci = obj as ComboItem;
            if ((System.Object)ci == null)
            {
                return false;
            }

            // returneaza 'true' daca atat textele cat si valorile celor 2 obiecte sunt identice intre ele
            return (this.Text.Equals(ci.Text) && this.Value == ci.Value);
        }
      /*  public static bool Equals(string a, string b)
        {
            if ((object)a == b)
            {
                return true;
            }

            if (a == null || b == null)
            {
                return false;
            }

            if (a.Length != b.Length)
            {
                return false;
            }

            return a.Equals(b);
        }*/
       

        public override int GetHashCode()
        {
            return this.Value;
        }
    }
}

