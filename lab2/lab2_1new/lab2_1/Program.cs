using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    internal class Tree
    {
        private int branchCount;
        private int leafCount;

        public Branch[] branches;
        public Tree(int branchCount)
        {
            if (branchCount <= 0)
                this.branchCount = 1;
            else
                this.branchCount = branchCount;

            branches = new Branch[branchCount];

            Console.WriteLine("Задайте кiлькiсть листкiв на гiлцi");
            leafCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < branchCount; i++)
            {
                branches[i] = new Branch(leafCount);
            }
        }
        public void Bloom() 
        { 
            Console.WriteLine("Дерево зацвiло"); 
        }
        public void FrostOver() 
        { 
            Console.WriteLine("Дерево покрилось iнеєм"); 
        }
        public void FallDown() 
        { 
            Console.WriteLine("Листя опало"); 
        }
        public void TurnYellowFoliage()
        {
            Console.WriteLine("Листя пожовтiло");
            foreach (var branch in branches)
            {
                foreach (var leaf in branch.leaves)
                {
                    leaf.LeafColor = Color.Yellow;
                }
            }
        }
        public override int GetHashCode()
        {
            return branches[0].leaves[0].LeafColor == Color.Green ? branchCount : branchCount + 1;
        }
        public override string ToString()
        {
            return $"Колiр листя: {branches[0].leaves[0].LeafColor}\nКiлькiсть гiлок: {branchCount}\nКiлькiсть листкiв на гiлцi: {branches[0].LeafCount}\n";
        }
    }
    internal class Branch
    {
        public int LeafCount { get; set; }
        public Leaf[] leaves;
        public Branch(int leafCount)
        {
            if (leafCount < 0)
                LeafCount = 0;
            else
                LeafCount = leafCount;

            leaves = new Leaf[leafCount];

            for (int i = 0; i < leafCount; i++)
            {
                leaves[i] = new Leaf();
            }
        }
    }
    enum Color
    {
        Green,
        Yellow
    }
    internal class Leaf
    {
        private Color leafColor = Color.Green;
        public Color LeafColor
        {
            get { return leafColor; }
            set { leafColor = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте кiлькiсть гiлок");
            Tree tree = new Tree(branchCount: int.Parse(Console.ReadLine()));
            Console.WriteLine($"\n{tree}");
            tree.Bloom();
            tree.TurnYellowFoliage();
            Console.WriteLine($"Колiр листя: {tree.branches[0].leaves[0].LeafColor}");
            tree.FallDown();
            tree.FrostOver();
        }
    }
}
