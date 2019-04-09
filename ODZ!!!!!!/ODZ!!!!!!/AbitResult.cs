namespace ODZ______
{
    /// <summary>
    /// Class with result data row
    /// </summary>
    class AbitResult
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public double Mark { get; set; }

        public AbitResult() { }
        public AbitResult(string surname, string name, double mark)
        {
            Surname = surname;
            Name = name;
            Mark = mark;
        }
    }
}
