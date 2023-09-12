using AuPointsCalc.Model;
using static System.Net.WebRequestMethods;
using System.Net.Http.Json;

namespace AuPointsCalc
{
    public interface ICategoryLoader
    {
        List<Category> LoadCategories();
    }

    public class CategoryLoader : ICategoryLoader
    {
        public List<Category> LoadCategories()
        {
            return new List<Category>
            {
               new Category
               {
                   Description = "Visa Subclass",
                   HeadlineQuestion = "",
                   Options = new List<Option>
                   {
                        new Option { Description = "Test", Points = 1 },
                        new Option { Description = "Test 2", Points = 2 }
                   }
               },
               new Category
               {
                   Description = "Age",
                   HeadlineQuestion = "",
                   Options = new List<Option>
                   {
                        new Option { Description = "Age", Points = 3 },
                        new Option { Description = "Age 2", Points = 4 }
                   }
               },
               new Category
               {
                   Description = "Age 2",
                   HeadlineQuestion = "",
                   Options = new List<Option>
                   {
                        new Option { Description = "Age 3", Points = 5 },
                        new Option { Description = "Age 4", Points = 6 }
                   }
               }
            };
        }

        public Task<List<Category>> LoadCategoriesAsync()
        {
            throw new NotImplementedException();
        }
    }

    public class CategoryLoaderFromConfig : ICategoryLoader
    {
        private readonly AppData appData;

        public CategoryLoaderFromConfig(AppData appData)
        {
            this.appData = appData;
        }

        public List<Category> LoadCategories()
        {
            return appData.Categories;
        }
    }
}
