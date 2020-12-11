using Domain.Enums;

namespace Domain.EnitityInterfaces
{
    public interface IBike
    {
        int Id { get; set; }
        string Title { get; set; }
        Type Type { get; set; }
        decimal Price { get; set; }
        Status Status { get; set; }
    }
}