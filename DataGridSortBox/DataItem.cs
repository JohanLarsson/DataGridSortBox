namespace DataGridSortBox
{
    public class DataItem
    {
        public DataItem(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; }

        public string Value { get;  }
    }
}