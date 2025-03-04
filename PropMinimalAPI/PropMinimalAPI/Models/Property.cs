namespace PropMinimalAPI.Models
{
    public class Property
    {
        public int IdProperty { get; set; }
        public string NameProperty { get; set; }
        public string Desciption { get; set; }
        public string Location { get; set; }
        public bool Active { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
