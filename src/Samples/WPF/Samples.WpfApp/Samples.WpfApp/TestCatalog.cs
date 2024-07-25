using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Winemonk.Tree.Observable;

namespace Samples.WpfApp
{
    public partial class TestCatalog : ObservableObject, IObservableTree<TestCatalog>
    {
        [JsonIgnore]
        public TestCatalog Parent { get; set; }

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private ObservableCollection<TestCatalog> _children;
        //public ObservableCollection<TestTreeNode> Children 
        //{
        //    get => _children;
        //    set => SetProperty(ref _children, value);
        //}

        public TestCatalog Clone()
        {
            TestCatalog clone = new TestCatalog
            {
                Name = _name,
            };
            if (Children?.Count > 0)
            {
                clone.Children = new ObservableCollection<TestCatalog>();
                foreach (var child in Children)
                {
                    TestCatalog subClone = child.Clone();
                    subClone.Parent = this;
                    clone.Children.Add(subClone);
                }
            }
            return clone;
        }
    }
}
