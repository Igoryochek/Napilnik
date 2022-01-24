using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Store
    {
        private List<Section> _sections = new List<Section>();
        private bool _found = false;

        public virtual void Add(Product newProduct, int count)
        {
            foreach (var section in _sections)
            {
                string name = newProduct.Name;
                if (section.Name == name)
                {
                    section.AddProduct(count);
                    _found = true;
                    break;
                }
            }
            if (_found == false)
                _sections.Add(new Section(newProduct.Name, count));
            
            _found = false;
        }
        public bool TryGetProduct(Product product, int count)
        {
            string name = product.Name;
            Section foundedSection = _sections.FirstOrDefault(s => s.Name == name);
            if (foundedSection.GoodsCount < count)
                return false;    
            else
                foundedSection.DeleteProduct(count);
                return true;
        }

        public void ShowInfo()
        {
            for (int i = 0; i < _sections.Count; i++)
            {
                int number = i + 1;
                Console.WriteLine(number + ".Product: " + _sections[i].Name + "\n      Quantity: " + _sections[i].GoodsCount);
            }
        }
    }
}
