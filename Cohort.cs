using System;
using System.Collections.Generic;

namespace Students
    {
        public class Cohort {
            public Cohort(string cohortName, List<Student> students, List<Instructor> instructors){
                CohortName = cohortName;
                StudentList = new List<Student>();
                InstructorList = new List<Instructor>();
            }

            public string CohortName {get; set;}
            public List<Student> StudentList {get; set;}
            public List<Instructor> InstructorList {get; set;}
        }
    }