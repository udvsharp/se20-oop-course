using System;

namespace Model
{
    public struct Grades
    {
        public Grades(int exam1, int exam2, int exam3, int certificate)
        {
            Exam1 = exam1;
            Exam2 = exam2;
            Exam3 = exam3;
            Certificate = certificate;
        }

        public int Exam1;
        public int Exam2;
        public int Exam3;
        public int Certificate;
    }

    public struct EntrantInfo
    {
        public EntrantInfo(string name, string middleName, string surname, DateTime birthDate)
        {
            Name = name;
            MiddleName = middleName;
            Surname = surname;
            BirthDate = birthDate;
        }

        public string Name;
        public string MiddleName;
        public string Surname;
        public DateTime BirthDate;
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