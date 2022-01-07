using System;
using System.Collections.Generic;

/**
 *
 * @author Svetlana Komarova
 */

namespace ShapesListsLINQ
{
    class Lists
    {
        private List<Student> students = new List<Student>();
        private int count = 5; // number of subjects

        public Lists()
        {
            Student s1 = new Student();
            s1.StudentId = 1001;
            s1.FirstName = "Mark";
            s1.LastName = "Buffon";
            s1.Scores = new int[] { 78, 80, 72, 84, 88 };

            Student s2 = new Student();
            s2.StudentId = 1002;
            s2.FirstName = "Julia";
            s2.LastName = "Roberts";
            s2.Scores = new int[] { 74, 81, 56, 83, 90 };

            Student s3 = new Student();
            s3.StudentId = 1003;
            s3.FirstName = "Maria";
            s3.LastName = "Randolph";
            s3.Scores = new int[] { 80, 77, 65, 91, 93 };

            Student s4 = new Student();
            s4.StudentId = 1004;
            s4.FirstName = "John";
            s4.LastName = "Bain";
            s4.Scores = new int[] { 73, 71, 67, 55, 81 };

            Student s5 = new Student();
            s5.StudentId = 1005;
            s5.FirstName = "Mark";
            s5.LastName = "Buffon";
            s5.Scores = new int[] { 90, 89, 82, 74, 83 };

            // populate an array of the Student objects
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
        }

        // Display student names and averages scores,
        // sorted in ascending average scores order
        public void displayStudent_AVG()
        {       
            Console.WriteLine("\nStudent Averages:");
                   
            double[] avg_array = new double[students.Count]; // to store average scores
            string[] studentNames = new string[students.Count]; // to store student names

            // calculate average scores for each student
            for (int j = 0;  j < students.Count; j++)
            {
                double sum = 0.0;
                for (int i = 0; i < count; i++)
                {
                    sum += students[j].Scores[i];
                } 
                
                double avg = sum / count;

                // store student names and corresponding average scores in arrays
                avg_array[j] = avg;
                studentNames[j] = students[j].FirstName;
            }

            // sort avg_array in ascending order
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = i + 1; j < students.Count; j++)
                {                  
                    if (avg_array[i] > avg_array[j])
                    {
                        double tempAVG = avg_array[i];
                        avg_array[i] = avg_array[j];
                        avg_array[j] = tempAVG;
                        string tempStudent = studentNames[i];
                        studentNames[i] = studentNames[j];
                        studentNames[j] = tempStudent;
                    }                 
                }
                Console.Write($"{studentNames[i]} - {avg_array[i].ToString("#.##")}; ");
            }
        } // end of displayStudent_AVG

        //Display the subject name and average score for each subject
        public void displaySubject_AVG()
        {
            Console.WriteLine("\n\nSubject Averages:");

                for (int i = 0; i < count; i++)
                {
                    double sum = 0.0;
                    for (int j = 0; j < count; j++)
                    {
                        sum += students[j].Scores[i];
                    }
                    double avg = sum / count;
                    Console.Write($"{students[i].Subjects[i]} - {avg.ToString("#.##")}; ");
                }
        } // end of displaySubject_AVG

        //Display student names and averages scores for
        //the student with the highest and lowest average
        public void displayStudent_High_Low_AVG()
        {          
            double high = 0.0;
            double low = 0.0;
            string h_student = "";
            string l_student = "";
        
            foreach (Student s in students)
            {
                // calculate the average for each student
                double sum = 0.0;
                for (int i = 0; i < count; i++)
                {
                    sum += s.Scores[i];
                }
                double avg = sum / count;

                 // get the student with lower average
                if (low > avg || low == 0.0)
                {
                    low = avg;
                    l_student = s.FirstName;
                }
                // get the student with higher average
                if (high < avg )
                {
                    high = avg;
                    h_student = s.FirstName;
                }
            }
            Console.WriteLine($"\n\nLowest Score: {l_student} - {low.ToString("#.##")} ");
            Console.WriteLine($"Highest Score: {h_student} - {high.ToString("#.##")} ");
        } // end of displayStudent_High_Low_AVG

        // For each subject display the student name and score
        // for the student with the highest and lowest score in that subject.
        public void displaySubject_High_Low_forStudent()
        {        
            Console.WriteLine("\nHighest/Lowest Subject Scores:");
            for ( int i = 0; i < count; i++)
            {
                double h_score = 0.0;
                double l_score = 0.0;
                string h_student = "";
                string l_student = "";

                foreach ( Student s in students)
                {
                    // get the highest score and student name
                    if (h_score < s.Scores[i])
                    {
                        h_score = s.Scores[i];
                        h_student = s.FirstName;
                    }
                    // get the lowest score and student name
                    if (l_score > s.Scores[i] || l_score == 0.0)
                    {
                        l_score = s.Scores[i];
                        l_student = s.FirstName;
                    }
                }
                string sub = students[0].Subjects[i];
                Console.WriteLine($"{sub}: Highest Score - {h_student}({h_score})");
                Console.WriteLine($"{sub}: Lowest Score - {l_student}({l_score})");
            }
        } // end of displaySubject_High_Low_forStudent
    } // end of class
}
