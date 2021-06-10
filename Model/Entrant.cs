using System;

namespace Model
{
    public struct Grades
    {
        public Grades(int exam1, int exam2, int exam3, double certificate)
        {
            Exam1 = exam1;
            Exam2 = exam2;
            Exam3 = exam3;
            Certificate = certificate;
        }

        public int Exam1 { get; set; }
        public int Exam2 { get; set; }
        public int Exam3 { get; set; }
        public double Certificate { get; set; }

        public double Apply(double e1, double e2, double e3, double c)
        {
            return Exam1 * e1 + Exam2 * e2 + Exam3 * e3 + Certificate * c;
        }
    }

    public struct EntrantInfo
    {
        public EntrantInfo(string name, string middleName, string surname, DateTime birthDate, string phoneNumber)
        {
            Name = name;
            MiddleName = middleName;
            Surname = surname;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{Name} {MiddleName} {Surname}";
        }
    }

    public class Entrant
    {
        public EntrantInfo Info { get; }
        public Grades Grades { get; }

        public bool AgreesToContract { get; }

        public Entrant(EntrantInfo info, Grades grades, bool agreesToContract)
        {
            Info = info;
            Grades = grades;
            AgreesToContract = agreesToContract;
        }
    }
}