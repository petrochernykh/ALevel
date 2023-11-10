using ALevel9Lesson9.Entities;
using ALevel9Lesson9.Models;

namespace ALevel9Lesson9.Repositories.Abstractions
{
    public interface IShoeRepository
    {
        ShoeEntity GetShoe(string id);
        string AddShoe(Shoe shoe);
        bool DeleteShoe(string id);
    }
}
