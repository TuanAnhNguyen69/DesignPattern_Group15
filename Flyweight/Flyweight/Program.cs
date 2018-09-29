using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = { "TREE", "GRASS", "TREE", "TREE", "FLOWER", "FLOWER", "FLOWER" };
            CongVien cv = new CongVien();
            Random rd = new Random();
            foreach (string l in list)
            {
                Plant plant = cv.GetPlant(l);
                plant.SetYearOld(rd.Next(1, 9));
                plant.Info();
            }

            Console.WriteLine($"\nTong so loai cay trong cong vien la {CongVien.objectCount}");

            Console.ReadKey();
        }
    }

    
    class Tree : Plant
    {
        

        public Tree()
        {
            type = "TREE";
            //SetYearOld(_yearOld);
        }

        public override void Info()
        {
            Console.WriteLine($"Cay co {yearOld} nam tuoi");
        }
    }

    class Flower : Plant
    {
        public Flower()
        {
            type = "FLOWER";
            //SetYearOld(_yearOld);
        }

        public override void Info()
        {
            Console.WriteLine($"Hoa co {yearOld} nam tuoi");
        }
    }

    class Grass : Plant
    {
        public Grass()
        {
            type = "Grass";
            //SetYearOld(_yearOld);
        }

        public override void Info()
        {
            Console.WriteLine($"Co co {yearOld} nam tuoi");
        }
    }

    abstract class Plant
    {
        protected string type;
        protected int yearOld;
        public void SetYearOld(int _yearOld)
        {
            yearOld = _yearOld;
        }

        public virtual void Info()
        {

        }
    }

    class CongVien
    {
        public static int objectCount = 0;
        private Dictionary<string, Plant> dicPlant = new Dictionary<string, Plant>();

        public Plant GetPlant(string _type)
        {
            Plant plant = null;
            if(dicPlant.ContainsKey(_type))
            {
                plant = dicPlant[_type];
            }
            else
            {
                if (String.Compare(_type, "TREE") == 0)
                {
                    plant = new Tree();
                    objectCount++;
                }                   
                else if (String.Compare(_type, "FLOWER") == 0)
                {
                    plant = new Flower();
                    objectCount++;
                }                    
                else if (String.Compare(_type, "GRASS") == 0)
                {
                    plant = new Grass();
                    objectCount++;
                }               
                dicPlant.Add(_type, plant);
            }
            return plant;
        }
    }
}
