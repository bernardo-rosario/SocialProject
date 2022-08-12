namespace SocialProject.Persistance.App.Generics
{
    public interface IEntity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}