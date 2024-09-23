namespace ActorsClassLibrary
{
    public class Actor
    {
        

        private string name;

        private int birthYear;
        public int Id { get; set; }

        public Actor(string name, int id, int birthYear)
        {
            Name = name;
            Id = id;
            BirthYear = birthYear;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value.Length < 4) {
                    throw new ArgumentException("Name må ikke være null og skal være mindst fire tegn langt");
                }
                name = value;
            }
        }

       

        public int BirthYear
        {
            get
            {
                return birthYear;
            }

            set
            {
                if (value < 1820)
                    throw new ArgumentException("BirthYear skal være >= 1820");
                birthYear = value;
            }
        }

       

    }
}
