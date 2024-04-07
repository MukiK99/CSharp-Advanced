namespace Domain.Interfaces
{
    public  interface IPrintInConsole<T>
    {
        void Print(T item);
        void PrintCollection(List<T> items);
    }
}
