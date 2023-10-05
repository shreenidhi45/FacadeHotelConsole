using FacadeHotelLibrary.Model;
namespace FacadeHotelConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelReception reception = new HotelReception();
            reception.getIndianMenu();
            reception.getItalianMenu();
        }
    }
}