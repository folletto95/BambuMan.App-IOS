using SpoolMan.Api.Model;

namespace BambuMan.Shared.Models
{
    internal class ExtraFieldModel(bool optional, EntityType entryType, int order, string key, string name, ExtraFieldType fieldType)
    {
        public bool Optional { get; set; } = optional;

        public EntityType EntryType { get; set; } = entryType;
        
        public int Order { get; set; } = order;
        
        public string Key { get; set; } = key;
        
        public string Name { get; set; } = name;
        
        public ExtraFieldType FieldType { get; set; } = fieldType;
        
        public string[]? Choices { get; set; }

        public bool MultiChoice { get; set; } = false;
        
        public string? Unit { get; set; }
        
        public string? DefaultValue { get; set; }
    }
}
