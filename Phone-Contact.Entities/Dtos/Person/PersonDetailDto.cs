namespace Phone_Contact.Entities.Dtos.Person
{
    public class PersonDetailDto
    {

        public int Id { get; set; }

        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        //public List<Phone> Phones { get; set; }
    }
}
