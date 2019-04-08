using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ODZ______
{
    class SampleAbit
    {
        public static string[] columns = new string[]{
            "ID",
            "Прізвище",
            "Ім\'я",
            "Бали",
            "Номер школи"
        };

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public double Mark { get; set; }
        public string NumberOfSchool { get; set; }

        public SampleAbit() {}
        public SampleAbit(int id, string surname, string name, double mark, string numberOfSchool)
        {
            this.Id = id;
            this.Surname = surname;
            this.Name = name;
            this.Mark = mark;
            this.NumberOfSchool = numberOfSchool;
        }
    }
}
