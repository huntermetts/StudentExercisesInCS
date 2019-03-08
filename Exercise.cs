using System;
using System.Collections.Generic;

namespace Students
    {
        public class Exercise{
            public Exercise(string exerciseName, string exerciseLanguage){
                ExerciseName = exerciseName;
                ExerciseLanguage = exerciseLanguage;
            }

            public string ExerciseName {get; set;}
            public string ExerciseLanguage {get; set;}
        }
    }