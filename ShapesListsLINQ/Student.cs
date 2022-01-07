namespace ShapesListsLINQ
{
    class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Scores { get; set; }
        public string[] Subjects { get; set; } = { "Math", "Biology", "Chemistry", "English", "History"};

    }
}
