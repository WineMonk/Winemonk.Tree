<img align="right" height="72px" src="https://raw.githubusercontent.com/WineMonk/images/master/blog/post/202407251043371.png">

# Winemonk.Tree

[![C%23_Tree](https://img.shields.io/badge/C%23-Tree-orange.svg)](https://github.com/WineMonk/Winemonk.Tree) [![License MIT](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/WineMonk/Winemonk.Tree?tab=MIT-1-ov-file) [![CSDN](https://img.shields.io/badge/CSDN-Winemonk-brightgreen.svg)](https://blog.csdn.net/szy13323042191)

## 📖API文档

[API文档 - WineMonk/Winemonk.Tree Wiki](https://github.com/WineMonk/Winemonk.Tree/wiki)

## 🧭Demo

```csharp
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
```

