using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjConsole
{
    public class permutation
    {
        public permutation(List<int> list, List<int> resultlist)
        {
            this.List = list;
            this.Resultlist = resultlist;
        }
        public List<int> List { get; set; }
        public List<int> Resultlist { get; set; }

        public void permutate()
        {
            for (int i = 0; i < this.List.Count; i++)
            {
                this.permutate(i);
                this.permutate();
            }
        }

        public void permutate(int i)
        {
            this.Resultlist.Add(List[i]);
            this.List.RemoveAt(i);
        }
    }
}
