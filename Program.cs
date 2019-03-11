using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists
            // Student Exercises:
            // Creating a new list of exercises for each student
            List<Exercise> alfonsosExercises = new List<Exercise>();
            List<Exercise> nicksExercises = new List<Exercise>();
            List<Exercise> jordansExercises = new List <Exercise>();
            List<Exercise> ryansExercises = new List <Exercise>();

            // Student Lists:
            // Creating a new list of students for each cohort
            List <Student> studentsInCohort28 = new List <Student>();
            List <Student> studentsInCohort29 = new List <Student>();
            List <Student> studentsInCohort30 = new List <Student>();


            // Instructor List:
            // Creating a list of instructors for each cohort
            List <Instructor> instructorsInCohort28 = new List <Instructor>();
            List <Instructor> instructorsInCohort29 = new List <Instructor>();
            List <Instructor> instructorsInCohort30 = new List <Instructor>();


            //
            // Creating the 4 exercises
            Exercise myFirstExercise = new Exercise("Planets", "C#");
            Exercise cohort28sExercise = new Exercise("Capstone", "Python");
            Exercise cohort30sExercise = new Exercise("Nutshell", "ReactJS");
            Exercise cohort32sExercise = new Exercise("Prework", "JavaScript");

            // Creating the 3 instructors
            Instructor cohort28Instructor = new Instructor("Joe", "Sheperd", "@joeyShep", "Cohort 28");
            Instructor cohort29Instructor = new Instructor("Andy", "Collins", "@handyAndy", "Cohort 29");
            Instructor cohort30Instructor = new Instructor("Jisie", "David", "@JisieD", "Cohort 30");

            // Creating the 4 students
            Student cohort28Student = new Student ("Alfonso", "Miranda", "@AlfonsoIsTheMan", "Cohort 28",alfonsosExercises);
            Student cohort29Student = new Student ("Nick", "Hansen", "@TrickyNicky", "Cohort 29", nicksExercises);
            Student cohort29StudentNumber2 = new Student ("Jordan", "Rosas", "@JDog", "Cohort 29", jordansExercises);
            Student cohort30Student = new Student ("Ryan", "Dillinger","@RyanD", "Cohort 30",
            ryansExercises);

            // Creating the 3 cohorts
            Cohort cohort28 = new Cohort("Cohort 28", studentsInCohort28, instructorsInCohort28);
            Cohort cohort29 = new Cohort("Cohort 29", studentsInCohort29, instructorsInCohort29);
            Cohort cohort30 = new Cohort("Cohort 30", studentsInCohort30, instructorsInCohort30);

            // Adding the students to the cohort
            studentsInCohort28.Add(cohort28Student);
            studentsInCohort29.Add(cohort29Student);
            studentsInCohort30.Add(cohort30Student);
            studentsInCohort29.Add(cohort29StudentNumber2);

            // Adding the instructor to the cohort
            instructorsInCohort28.Add(cohort28Instructor);
            instructorsInCohort29.Add(cohort29Instructor);
            instructorsInCohort30.Add(cohort30Instructor);

            // Assigning the exercise to the entire cohort
            cohort28Instructor.AssignExercise(cohort28sExercise, cohort28);
            cohort29Instructor.AssignExercise(myFirstExercise, cohort29);
            cohort30Instructor.AssignExercise(cohort30sExercise, cohort30);

            //
            List <string> studentName = new List<string>();
            studentName.Add(cohort28Student.FirstName + " is working on his " + cohort28sExercise.ExerciseName);
            studentName.Add(cohort29Student.FirstName + " is working on his " + myFirstExercise.ExerciseName);
            studentName.Add(cohort30Student.FirstName + " is working on his " +  cohort30sExercise.ExerciseName);
            studentName.Add(cohort29StudentNumber2.FirstName + " is working on his " +  myFirstExercise.ExerciseName);
            foreach (string student in studentName){
                Console.WriteLine(student);
            }

            // List <string> studentExercises = new List<string>();
            // studentExercises.Add(myFirstExercise.ExerciseName);
            // studentExercises.Add(cohort28sExercise.ExerciseName);
            // studentExercises.Add(cohort30sExercise.ExerciseName);
            // studentExercises.Add(cohort32sExercise.ExerciseName);
            // foreach (string exercise in studentExercises){
            //     Console.WriteLine(exercise);
            // }

            // var list = new List<Tuple<string, string>>();
            // list.Add(new Tuple<string, string>(cohort29Student.FirstName,myFirstExercise.ExerciseName));
            // list.Add(new Tuple<string, string>(cohort28Student.FirstName,cohort28sExercise.ExerciseName));
            // list.Add(new Tuple<string, string>(cohort30Student.FirstName,cohort30sExercise.ExerciseName));
            // list.Add(new Tuple<string, string>(cohort29StudentNumber2.FirstName,myFirstExercise.ExerciseName));
        }
    }
}
