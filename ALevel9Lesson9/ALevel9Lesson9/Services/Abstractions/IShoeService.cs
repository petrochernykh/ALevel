using ALevel9Lesson9.Entities;
using ALevel9Lesson9.Models;

namespace ALevel9Lesson9.Services.Abstractions
{
    public interface IShoeService
    {
        Shoe GetShoe(string id);
        string AddShoe(Shoe shoe);
        bool DeleteShoe(string id);
        string[] AddShoes(List<Shoe> shoes);
        Shoe[] GetShoeByText(string text);
    }
}
