namespace c
{
    public class Student
    {
        public string Id;
        public string Name;
        public double Grade;

        public string GetInfor()
        {
            return $"Id:{Id}, Name:{Name}, Grade:{Grade:F2}";
        }
    }
}
