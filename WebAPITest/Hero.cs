using WebAPITest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
namespace WebAPITest
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasCape { get; set; }
        public DateTime Created { get; set; }
        public bool IsAlive { get; set; }
        public Category Category { get; set; }
    }

    public enum Category
    {
        Anime,
        Comic,
        History,
        Mythology
    }


}
