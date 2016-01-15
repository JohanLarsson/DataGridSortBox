namespace DataGridSortBox
{
    public class DataItem
    {
        public DataItem(string key)
        {
            Key = key;
            Value = key;
        }

        public string Key { get; }

        public string Value { get;  }
    }
}