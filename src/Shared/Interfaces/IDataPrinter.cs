namespace GameDataParser.Shared.Interfaces;


internal interface IDataPrinter<T>
{
    public void Print(List<T> data);
}