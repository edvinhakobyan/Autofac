namespace DemoLibrary.Utility
{
    public interface IDataAccess
    {
        void Load();
        void SaveData(string name);
    }
}