using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DataContainers
{
    class Tree
    {
        delegate void PerfomanceCheck(Tree tree);
        public class Element
        {
            public int Data { get; set; }
            public Element pLeft { get; set; }
            public Element pRight { get; set; }
            public Element(int data, Element pLeft = null, Element pRight = null)
            {
                this.Data = data;
                this.pLeft = pLeft;
                this.pRight = pRight;
                Console.WriteLine($"EConstructor:\t{GetHashCode()}");
            }
            ~Element()
            {
                Console.WriteLine($"EDestructor:\t{GetHashCode()}");
            }
        }
        public Element Root { get; set; }
        public Tree()
        {
            Root = null;
            Console.WriteLine($"TConstructor:\t{GetHashCode()}");
        }
        ~Tree()
        {
            Console.WriteLine($"TDestructor:\t{GetHashCode()}");
        }
        public void Insert(int Data)
        {
            Insert(Data, Root);
        }
        private void Insert(int Data, Element Root)
        {
            if (this.Root == null) this.Root = new Element(Data);
            if (Root == null) return;
            if (Data < Root.Data)
            {
                if (Root.pLeft == null) Root.pLeft = new Element(Data);
                else Insert(Data, Root.pLeft);
            }
            else
            {
                if (Root.pRight == null) Root.pRight = new Element(Data);
                else Insert(Data, Root.pRight);
            }
        }
        public int MinValue()
        {
            return MinValue(Root);
        }
        int MinValue(Element Root)
        {
            if (Root == null) throw new Exception("Tree is empty");
            return Root.pLeft == null ? Root.Data : MinValue(Root.pLeft);
        }
        public int MaxValue()
        {
            return MaxValue(Root);
        }
        int MaxValue(Element Root)
        {
            if (Root == null) throw new Exception("Tree is empty");
            return Root.pRight == null ? Root.Data : MaxValue(Root.pRight);
        }
        public int Sum()
        {
            return Sum(Root);
        }
        int Sum(Element Root)
        {
            if (Root == null) return 0;
            else return Sum(Root.pLeft) + Sum(Root.pRight) + Root.Data;
        }
        public int Count()
        {
            return Count(Root);
        }
        int Count(Element Root)
        {
            return Root == null ? 0 : Count(Root.pLeft) + Count(Root.pRight) + 1;
        }
        public double Avarage()
        {
            return (double)Sum(Root) / Count(Root);
        }
        public void Print()
        {
            Print(Root);
            Console.WriteLine();
        }
        void Print(Element Root)
        {
            if (Root == null) return;
            Print(Root.pLeft);
            Console.Write(Root.Data + "\t");
            Print(Root.pRight);
        }

        public void erase(int Data)
        {
            erase(Data, Root);
        }
        public void delete()
        {
            delete(Root);
        }
        Element erase(int Data, Element Root)
        {
            if (Root == null) return Root;

            if (Data < Root.Data)
                Root.pLeft = erase(Data, Root.pLeft);
            else if (Data > Root.Data)
                Root.pRight = erase(Data, Root.pRight);
            else
            {
                if (Root.pLeft == null)
                {
                    return Root.pRight;
                }
                else if (Root.pRight == null)
                {
                    return Root.pLeft;
                }

                Root.Data = MinValue(Root.pRight);

                Root.pRight = erase(Root.Data, Root.pRight);
            }

            return Root;
        }
        void delete(Element Root)
        {
            Root = null;
            Root = new Element(0);
        }

        public int depth()
        {
            return depth(Root);
        }
        int depth(Element Root)
        {
            return (Root != null) ? Math.Max(depth(Root.pLeft), depth(Root.pRight)) + 1 : 0;
        }

        public void DepthPrint(int Depth)
        {
            DepthPrint(Depth, Root);
        }
        void DepthPrint(int Depth, Element Root)
        {
            if (Root == null) return;
            if (Depth != 0)
            {
                DepthPrint(Depth - 1, Root.pRight);
                DepthPrint(Depth - 1, Root.pLeft);
                Console.Write(Root.Data + "\t");
            }
        }

        PerfomanceCheck CheckPerfomanceFunction = (tree) =>
        {
            Timer timer = new Timer();
            timer.Start();
            //CheckPerfomanceFunction(tree);
            timer.Stop();
            Console.WriteLine("Функция была выполнена за " + timer.Interval + " сек.");
        };
    }
}
