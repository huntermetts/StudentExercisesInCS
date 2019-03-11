using System;
using System.Collections.Generic;

namespace Students
    {
        public class Instructor
        {
            public Instructor(string firstName, string lastName, string slack, string instructorCohort){
                FirstName = firstName;
                LastName = lastName;
                Slack = slack;
                InstructorCohort = instructorCohort;
            }
            public string FirstName {get; set;}
            public string LastName {get; set;}
            public string Slack {get; set;}
            public string InstructorCohort {get; set;}


    // Method to assign an excercise to a student
            public void AssignExercise(Exercise exerciseObject, Cohort cohortObject){
                foreach (Student student in cohortObject.StudentList){
                    student.ExerciseList.Add(exerciseObject);
                     Console.WriteLine($"{student.FirstName} + test");
                }
            }
        }
    }