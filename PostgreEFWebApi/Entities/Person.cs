namespace PostgreEFWebApi.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FistName { get; set; } = "Dj Dow";
        public  string? SecondName { get; set; }
        public string? LastName { get; set; } 
        public List<Address> Addresses { get; set; }
    }
}