using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        //class oluşturup table a dönüştürme yapıcaz propertyler column olacak
        // access modifiers public private ınternal protected olur
        //ınternal sadece bulunduğu katmandan erişim
        // field variable property class içine tanımlarsak field method içi variable
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; }



    }
}
