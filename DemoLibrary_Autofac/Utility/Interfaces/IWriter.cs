namespace DemoLibrary.Utility
{
    interface IWriter
    {
        void ConsoleWrite(string masage);
        void FileWrite(string masage);
    }
}