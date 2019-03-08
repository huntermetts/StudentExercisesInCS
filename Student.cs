using System;
using System.Collections.Generic;

namespace Students
    {
        public class Student {
         public Student(string firstName, string lastName, string slack, string cohortName, List<Exercise> exercise) {
                FirstName = firstName;
                LastName = lastName;
                Slack = slack;
                CohortName = cohortName;
                ExerciseList = new List<Exercise>();
            }

            public string FirstName {get; set;}
            public string LastName {get; set;}
            public string Slack {get; set;}
            public string CohortName {get; set;}
            public List<Exercise> ExerciseList {get; set;}
        }
    }