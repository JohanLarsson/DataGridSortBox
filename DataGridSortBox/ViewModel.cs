using System.Collections.ObjectModel;

namespace DataGridSortBox
{
    public class ViewModel
    {
        public ObservableCollection<DataItem> DataItems { get; } = new ObservableCollection<DataItem>
        {
            new DataItem("2", "meh"),
            new DataItem("10", "meh"),
            new DataItem("10A", "meh"),
            new DataItem("11", "meh"),
            new DataItem("20", "meh"),
        };
    }
}
