namespace PostgreEFWebApi.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip{ get; set; }
        public Person Person { get; set; }


    }
}
