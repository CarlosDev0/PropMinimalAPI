using PropMinimalAPI.Models;

namespace PropMinimalAPI.Data
{
    public static class PropertyData
    {
        public static List<Property> ListProperties = new List<Property>
        {
            new Property{ IdProperty= 1, Desciption= "House Las delicias", CreationDate= DateTime.Now.AddDays(-5), Active=true, Location="California"},
            new Property{ IdProperty= 1, Desciption= "House Concorde", CreationDate= DateTime.Now.AddDays(-10), Active=true, Location="California"},
            new Property{ IdProperty= 1, Desciption= "House Montainview", CreationDate= DateTime.Now.AddDays(-15), Active=true, Location="California"},
            new Property{ IdProperty= 1, Desciption= "House The sky", CreationDate= DateTime.Now.AddDays(-25), Active=true, Location="Flirida"}
        };
    }
}
