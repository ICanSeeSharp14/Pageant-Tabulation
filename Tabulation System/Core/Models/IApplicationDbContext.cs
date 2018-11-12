namespace Tabulation_System.Core.Models
{
    public interface IApplicationDbContext
    {
        ApplicationDbContext DatabaseContext { get; }
    }
}