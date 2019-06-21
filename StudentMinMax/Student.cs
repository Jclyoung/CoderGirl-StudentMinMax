namespace StudentMinMax
{
    public class Student
    {
        public string Name { get; set; }
        public int[] Scores { get; set; }

        public Student(string name, int[] scores)
        {
            Name = name;
            Scores = scores;
        }

        public Student()
        {
            Name = "name";
            Scores = new int[] { };
        }


        public int? GetMaximumScore()
        {
            int max = 0;

            foreach (int score in Scores)
            {
                if (score > max)
                    max = score;
            }
            
            return max;
        }

        public int? GetMinimumScore()
        {
            int min = 1000;
            foreach (int score in Scores)
            {
                if (score < min)
                    min = score;

            }

            return min;
        }
    }
}