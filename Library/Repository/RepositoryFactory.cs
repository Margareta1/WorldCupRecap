namespace Library.Repository
{
    public static class RepositoryFactory
    {
        public static IRepository GiveThisManARepository()
        {
            return new FileRepository();
        }
    }
}
