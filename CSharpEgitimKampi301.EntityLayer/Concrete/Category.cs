using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }//Code first:vs da tabloları oluşturup db'a yollama yaklaşımı'nda ID'nın birincil anahtar ve oto. artan oldugunu bildirmek için sınıf adıyla birebir aynı yazılıp sonuna Id getirilmeli
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}
/* Field - Variable - Property */
//eğer değişken direkt olarak sınıfın içerisinde tanımlanıyorsa public class Category { int x ; } gibi bu bir FİELD dir
//Eğer değişken get set ile tanımlanırsa bu bir PROPERTY dir ilgili tabloya ait sütunları tutar
//Eğer bir değişken oluşturulan bir metot içerisinde tanımlanırsa bu bir VARİABLE dir