namespace MedievalIO.Domain.Common
{
    public interface INameable
    {
        string Name { get; set; }
        string ShortName { get; set; }
    }
}