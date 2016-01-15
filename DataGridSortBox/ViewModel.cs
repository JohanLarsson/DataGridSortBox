using System.Collections.ObjectModel;

namespace DataGridSortBox
{
    public class ViewModel
    {
        public ObservableCollection<DataItem> DataItems { get; } = new ObservableCollection<DataItem>
        {
            new DataItem("2"),
            new DataItem("10"),
            new DataItem("10A"),
            new DataItem("11"),
            new DataItem("20"),
        };
    }
}
