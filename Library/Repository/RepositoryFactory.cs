namespace Library.Repository
{
    public class RepositoryFactory
    {
        public IRepository GiveThisManARepository()
        {
            return new FileRepository();
        }
    }
}
