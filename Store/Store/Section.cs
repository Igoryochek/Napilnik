using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Section
    {
        public int GoodsCount { get; private set; }
        public string Name { get; private set; }

        public Section(string name, int count)
        {
            Name = name;
            GoodsCount = count;
        }

        public void AddProduct(int count)
        {
            GoodsCount += count;
        }
        public void DeleteProduct(int count)
        {
            if (count <= GoodsCount)
            {
                GoodsCount -= count;
            }
        }
    }
}
