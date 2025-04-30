using BambuMan.Shared;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BambuMan
{
    public partial class InventoryModel : ObservableObject
    {
        public InventoryModel() { }

        public InventoryModel(string? material, string tag)
        {
            Material = material;
            Color = material?.DarkHex();
            Tags.Add(tag);
        }

        [ObservableProperty] private string? material;

        [ObservableProperty] private string? color;

        [ObservableProperty] private int quantity = 1;

        [ObservableProperty] private List<string> tags = new();
    }
}
