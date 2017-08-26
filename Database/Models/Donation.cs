namespace GiveAShitBackend.Database.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public User DonatorUser { get; set; }
        public User ReciepientUser { get; set; }
    }
}