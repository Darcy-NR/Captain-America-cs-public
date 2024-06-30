namespace CaptainAmerica.Models
{
    public class Role
    {

        public String Company { get; set; }

        public String Position { get; set; }

        public String Location { get; set; }

        // public bool plural { get; set; }

        public Role(String Company,
                    String Position,
                    String Location)
        {
            this.Company = Company;
            this.Position = Position;
            this.Location = Location;


        }

    }
}
