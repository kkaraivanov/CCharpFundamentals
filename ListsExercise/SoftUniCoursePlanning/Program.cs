using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> scheduleOfLessons = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string commandsLine = string.Empty;
            string lessonTitle = string.Empty;
            string swapLessonTitle = string.Empty;

            while ((commandsLine = Console.ReadLine()) != "course start")
            {
                string[] commands = commandsLine.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commands[0])
                {
                    case "Add":
                        lessonTitle = commands[1];
                        if (!scheduleOfLessons.Contains(lessonTitle))
                            scheduleOfLessons.Add(lessonTitle);
                        break;
                    case "Insert":
                        lessonTitle = commands[1];
                        int index = int.Parse(commands[2]);
                        if (!scheduleOfLessons.Contains(lessonTitle))
                            scheduleOfLessons.Insert(index, lessonTitle);
                        break;
                    case "Remove":
                        lessonTitle = commands[1];
                        if (scheduleOfLessons.Contains(lessonTitle))
                            scheduleOfLessons.Remove(lessonTitle);
                        break;
                    case "Swap":
                        lessonTitle = commands[1];
                        swapLessonTitle = commands[2];
                        if (scheduleOfLessons.Contains(lessonTitle) && scheduleOfLessons.Contains(swapLessonTitle))
                        {
                            int ferstLessonIndex = scheduleOfLessons.FindIndex(l => l == lessonTitle);
                            int swapLessonIndex = scheduleOfLessons.FindIndex(sl => sl == swapLessonTitle);
                            string lessonExercise = $"{lessonTitle}-Exercise";
                            string swapExercise = $"{swapLessonTitle}-Exercise";
                            string temp = scheduleOfLessons[ferstLessonIndex];
                            scheduleOfLessons[ferstLessonIndex] = scheduleOfLessons[swapLessonIndex];
                            scheduleOfLessons[swapLessonIndex] = temp;

                            if(LessonExerciseExist(scheduleOfLessons, lessonExercise))
                                PasteLessnoExercise(scheduleOfLessons, lessonTitle);
                            if (LessonExerciseExist(scheduleOfLessons, swapExercise))
                                PasteLessnoExercise(scheduleOfLessons, swapLessonTitle);
                        }
                        break;
                    case "Exercise":
                        lessonTitle = commands[1];
                        if (!scheduleOfLessons.Contains(lessonTitle))
                        {
                            scheduleOfLessons.Add(lessonTitle);
                            PasteLessnoExercise(scheduleOfLessons, lessonTitle);
                        }
                        else
                            PasteLessnoExercise(scheduleOfLessons, lessonTitle);

                        break;
                }
            }

            for (int i = 0; i < scheduleOfLessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{scheduleOfLessons[i]}");
            }
        }

        private static void PasteLessnoExercise(List<string> scheduleOfLessons, string lessonTitle)
        {
            string exercise = $"{lessonTitle}-Exercise";
            int lessonIndex = scheduleOfLessons.FindIndex(l => l == lessonTitle);
            if (LessonExerciseExist(scheduleOfLessons, exercise))
                scheduleOfLessons.Remove(exercise);
            if (scheduleOfLessons.Contains(lessonTitle) )
                scheduleOfLessons.Insert(lessonIndex + 1, exercise);
        }

        private static bool LessonExerciseExist(List<string> scheduleOfLessons, string exercise)
        {
            if (scheduleOfLessons.Contains(exercise))
                return true;
            else
                return false;
        }
    }
}
