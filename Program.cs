using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        public static void Func17(LinkedList<int> list)
        {
            list.Print();
            if (list.lenght > 0)
            {
                int mnog = list.GetT(0);
                int compar = 0;
                if (list.GetT(0) < 0)
                    compar = 1;
                else
                    compar = -1;
                for (int i = 1; i < list.lenght; i++)
                {
                    if (list.GetT(i).CompareTo(mnog) == compar)
                        mnog = list.GetT(i);
                }
                mnog *= mnog;
                for (int i = 0; i < list.lenght; i++)
                {
                    list.SetT(i, list.GetT(i) * mnog);
                }
                list.Print();
            }
        }
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(-1);
            list.Add(-2);
            list.Add(7);
            list.Add(9);
            list.Add(10);
            list.Add(0);
            list.Add(2);
            Func17(list);
        }
    }
}
