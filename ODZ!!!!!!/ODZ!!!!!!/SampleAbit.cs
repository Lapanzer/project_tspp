namespace ODZ______
{
    class SampleAbit : AbitResult
    {
        public int Id { get; set; }
        public string NumberOfSchool { get; set; }

        public SampleAbit() {}
        public SampleAbit(int id, string surname, string name, double mark, string numberOfSchool)
        {
            Id = id;
            Surname = surname;
            Name = name;
            Mark = mark;
            NumberOfSchool = numberOfSchool;
        }
    }
}