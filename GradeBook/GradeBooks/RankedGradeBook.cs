using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Can't rank less than 5 students");
            }
            switch (averageGrade)
            {
                case double x when x >= 80.0: return 'A';
                case double x when x >= 60.0: return 'B';
                case double x when x >= 40.0: return 'C';
                case double x when x >= 20.0: return 'D';
                default: return 'F';
            }
        }
    }
}
