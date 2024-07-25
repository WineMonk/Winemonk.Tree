using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Winemonk.Tree.Observable.WPF.Example
{
    public partial class DataCatalog : ObservableObject, IObservableTree<DataCatalog>
    {
        [JsonIgnore]
        public DataCatalog Parent { get; set; }

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private ObservableCollection<DataCatalog> _children;
        //public ObservableCollection<TestTreeNode> Children 
        //{
        //    get => _children;
        //    set => SetProperty(ref _children, value);
        //}

        public DataCatalog Clone()
        {
            DataCatalog clone = new DataCatalog
            {
                Name = _name,
            };
            if (Children?.Count > 0)
            {
                clone.Children = new ObservableCollection<DataCatalog>();
                foreach (var child in Children)
                {
                    DataCatalog subClone = child.Clone();
                    subClone.Parent = this;
                    clone.Children.Add(subClone);
                }
            }
            return clone;
        }
    }
}
