namespace UnitTest
{
    internal class FileDataStore
    {
        private string credPath;
        private bool v;

        public FileDataStore(string credPath, bool v)
        {
            this.credPath = credPath;
            this.v = v;
        }
    }
}