namespace Entities
{
    public interface IPersonDatabase
    {
        bool Save(string firstName, string lastName, int age);
    }
}