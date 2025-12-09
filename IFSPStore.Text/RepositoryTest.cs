using IFSPStore.Domain;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using System.Text.Json;
namespace IFSPStore.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        [TestMethod]
        public void TestCategory()
        {
            using (var context = new MySqlContext())
            {
                Console.WriteLine("Connected");

                var category1 = new Category("Carnes", "");
                var category2 = new Category("Bebidas", "");
                var category3 = new Category("Doces", "");

                context.Categories.Add(category1);
                context.Categories.Add(category2);
                context.Categories.Add(category3);
                context.SaveChanges();
                Console.WriteLine("Insert Done!");
            }

            using (var context = new MySqlContext())
            {
                foreach (var cat in context.Categories)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));
                }
                Console.WriteLine("List Done!");
            }
        }
        [TestMethod]
        public void TestProduct()
        {
            var context = new MySqlContext();
            var _categoryRepository = new BaseRepository<Category>(context);
            var _ProductRepository = new BaseRepository<Product>(context);

            var category1 = new Category();
            category1.Name = "Enlatados";
            _categoryRepository.Insert(category1);
            var category2 = new Category();
            category2.Name = "Saudaveis";
            _categoryRepository.Insert(category2);

            var prod1 = new Product();
            prod1.Name = "Sardinha";
            prod1.Price = 10.55M;
            prod1.Quantity = 55;
            prod1.SalesUnit = "Lata";
            prod1.PurchaseDate = DateTime.Now;
            prod1.Category = category1;
            _ProductRepository.Insert(prod1);
            var prod2 = new Product();
            prod2.Name = "Whey Protein";
            prod2.Price = 155.55M;
            prod2.Quantity = 61;
            prod2.SalesUnit = "Pote";
            prod2.PurchaseDate = DateTime.Now;
            prod2.Category = category1;
            _ProductRepository.Insert(prod2);
        }
    }
}
