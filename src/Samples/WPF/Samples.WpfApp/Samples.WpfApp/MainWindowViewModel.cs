using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Winemonk.Tree.Observable;
using Winemonk.Tree.Observable.WPF;

namespace Samples.WpfApp
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<TestCatalog> _treeNodes;
        [ObservableProperty]
        private string _searchText;

        public MainWindowViewModel()
        {
            TestCatalog? testCatalog = JsonSerializer.Deserialize<TestCatalog>(File.ReadAllText("res/Test.json"));
            if (testCatalog == null)
            {
                return;
            }
            testCatalog.Traversal(c =>
            {
                if (c.Children?.Count > 0)
                {
                    foreach (var cc in c.Children)
                    {
                        cc.Parent = c;
                    }
                }
            });
            TreeNodes = new ObservableCollection<TestCatalog>() { testCatalog };
        }

        [RelayCommand]
        private void Search()
        {
            string jsonText = JsonSerializer.Serialize(TreeNodes[0], new JsonSerializerOptions()
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            foreach (var item in TreeNodes)
            {
                item.ObservableFilter(n => n.Name.Contains(SearchText));
            }
        }
    }
}
