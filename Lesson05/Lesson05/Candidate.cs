using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05
{
    internal class Candidate
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Education Education { get; set; }

        public Candidate(string fullName, int age, Gender gender, Education education)
        {
            FullName = fullName;
            Age = age;
            Gender = gender;
            Education = education;
            CheckCandidate();
        }
        public void CheckCandidate()
        {
            if (Age <= 18)
            {
                throw new CandidateAdult();
            }
            if(Gender == Gender.Female)
            {
                throw new CandidateShouldMale();
            }
            if(Education != Education.University && Education != Education.Master)
            {
                throw new ShouldGraduatedUniversity();
            }
        }
    }
    enum Gender
    {
        Male = 1,
        Female
    }
    enum Education
    {
        Master = 1,
        University,
        College,
        School
    }
}
