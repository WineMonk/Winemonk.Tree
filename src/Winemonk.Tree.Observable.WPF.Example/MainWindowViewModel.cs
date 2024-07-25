using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Winemonk.Tree.Observable.WPF.Example
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<DataCatalog> _treeNodes;
        [ObservableProperty]
        private string _searchText;

        public MainWindowViewModel()
        {
            _treeNodes = new ObservableCollection<DataCatalog>
            {
                new DataCatalog
                {
                    Name = "资源目录",
                    Children = new ObservableCollection<DataCatalog>
                    {
                        new DataCatalog
                        {
                            Name = "矢量",
                            Children = new ObservableCollection<DataCatalog>
                            {
                                new DataCatalog
                                {
                                    Name = "行政区划",
                                    Children = new ObservableCollection<DataCatalog>
                                    {
                                        new DataCatalog
                                        {
                                            Name = "北京行政区划"
                                        },
                                        new DataCatalog
                                        {
                                            Name = "天津行政区划"
                                        },
                                        new DataCatalog
                                        {
                                            Name = "河北行政区划"
                                        },
                                    }
                                },
                                new DataCatalog
                                {
                                    Name = "管线",
                                }
                            }
                        },
                        new DataCatalog
                        {
                            Name = "栅格",
                            Children = new ObservableCollection<DataCatalog>
                            {
                                new DataCatalog
                                {
                                    Name = "正射影像",
                                    Children = new ObservableCollection<DataCatalog>
                                    {
                                        new DataCatalog
                                        {
                                            Name = "北京遥感影像"
                                        },
                                        new DataCatalog
                                        {
                                            Name = "天津遥感影像"
                                        },
                                        new DataCatalog
                                        {
                                            Name = "河北遥感影像"
                                        },
                                    }
                                },
                                new DataCatalog
                                {
                                    Name = "DEM"
                                }
                            }
                        }
                    }
                },
            };
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
