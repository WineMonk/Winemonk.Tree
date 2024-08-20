using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using Winemonk.Tree.Observable;

namespace Samples.WpfApp
{
    public class TestCatalog : ObservableObject, IObservableTree<TestCatalog>
    {
        private string _name;
        private ObservableCollection<TestCatalog> _children;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public ObservableCollection<TestCatalog> Children
        {
            get => _children;
            set => SetProperty(ref _children, value);
        }

        [JsonIgnore]
        public TestCatalog Parent { get; set; }

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
