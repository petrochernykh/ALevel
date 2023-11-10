using ALevel9Lesson9.Exceptions;
using ALevel9Lesson9.Models;
using ALevel9Lesson9.Services;
using ALevel9Lesson9.Services.Abstractions;

namespace ALevel9Lesson9
{
    public class App
    {
        private readonly IShoeService _shoeService;

        public App(IShoeService shoeService)
        {
            _shoeService= shoeService;
        }

        public void Run()
        {
            Shoe[] shoes;
            try
            {
                var ids = _shoeService.AddShoes(GetMockShoes());

                shoes = _shoeService.GetShoeByText("spIrit");

            }
            catch (ShoeNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private List<Shoe> GetMockShoes()
        {
            var shoes = new List<Shoe>();

            shoes.Add(new Shoe()
            {
                Name = "Jordans",
                Style = Common.StyleType.Snikers,
                Size = 45,
                Description = "The spirit of the legend"
            });

            shoes.Add(new Shoe()
            {
                Name = "AstomMartins",
                Style = Common.StyleType.Oxford,
                Size = 42,
                Description = "Be proud of yourself"
            });

            shoes.Add(new Shoe()
            {
                Name = "Spirit",
                Style = Common.StyleType.Runners,
                Size = 43,
                Description = "Never give up"
            });

            return shoes;
        }
    }
}
