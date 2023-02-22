 namespace server.Models
{
    public class Demo
    {
        public string name { get; set; }
        public string msg { get; set; }
    }
    public class StoredJson:Demo
    {
        public int id { get; set; }
    }
}
