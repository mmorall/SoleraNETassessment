namespace Solera_NetC_Assessment.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateOnly Date { get; set; }
        public int Vehicle_Id { get; set; }
        public Claim()
        {
            Id = -1;
            Description = "Nothing yet";
            Status = "Nothing";
            Date = new DateOnly();
            Vehicle_Id = -1;
        }

        public Claim(int id, string description, string status, DateOnly date, int vehicle_Id)
        {
            Id = id;
            Description = description;
            Status = status;
            Date = date;
            Vehicle_Id = vehicle_Id;
        }
    }
}
