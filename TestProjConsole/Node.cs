using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjConsole
{
    public class Node
    {
        public Node()
        {
            Children = new List<Node>();
            if (RemainingList != null)
            {
                AddChildNodes();
            }
        }

        public List<Node> Children { get; set; }

        public int Value { get; set; }
        public List<int> RemainingList { get; set; }
        
        public List<T> T_RemainingList { get; set; }
        public T T_Value { get; set; }


        public List<List<T>> Span(List<T> fromParent)
        {
            var current = fromParent.ToList();
            current.Add(this.T_Value);
        }

        public List<List<int>> Span(List<int> fromParent)
        {
            //create copy of int-List
            var actual = fromParent.ToList();
            //add own value to the copied list
            actual.Add(this.Value);
            //create list of int-list 
            List<List<int>> results = new List<List<int>>();
            //when there are no more children
            //add copied and modified list to results list
            //if not, recurse for each child
            if (this.Children == null || this.Children.Count == 0)
            {
                
                results.Add(actual);
            }
            else
            {
                foreach (var item in this.Children)
                {
                    results.AddRange(item.Span(actual));
                }
            }

            return results;
        }

        public void AddChildNodes()
        {
            foreach (var item in this.RemainingList)
            {
                var newlist = this.RemainingList.ToList();
                newlist.RemoveAt(this.RemainingList.IndexOf(item));
                var newnode = new Node { RemainingList = newlist, Value = item };
                Children.Add(newnode);
                newnode.AddChildNodes();
            }
        }
    }
}
