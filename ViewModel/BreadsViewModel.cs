using Pugon.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.Json;

namespace Pugon.ViewModel
{
    public partial class BreadsViewModel
    {
        public ObservableCollection<BreadDetailModel> Breads { get; set; }

        public BreadsViewModel(string difficulty)
        {
            var all = LoadBreadData(); // your JSON loader

            Breads = new ObservableCollection<BreadDetailModel>(
                all.Where(x => x.Difficulty == difficulty)
            );
        }

        private List<BreadDetailModel> LoadBreadData()
        {
            using var stream = FileSystem.OpenAppPackageFileAsync("breaddata.json").Result;
            using var reader = new StreamReader(stream);
            var json = reader.ReadToEnd();

            var root = JsonSerializer.Deserialize<BreadRoot>(json);

            return root.bread_details;
        }

    }
    public class BreadRoot
    {
        public List<BreadDetailModel>? bread_details { get; set; } 
    }
}
