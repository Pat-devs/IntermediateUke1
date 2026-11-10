class CourseController
{
    private Course _course;
    private CourseView _view;    

    public CourseController(Course course, CourseView view)
    {
        _course = course;
        _view = view;
    }

    public void Run()
    {
        while (true)
        {
            string choice = _view.ReadChoice();

            if (choice == "0")
            {
                break;
            }
            if (choice == "1")
            {
                string name = _view.ReadName();
                bool registered = _course.TryRegister(name);
                _view.ShowRegistrationResult(registered);
            } 
            else if (choice == "2")
            {
                _view.ShowParticipants(_course.GetParticipants(), _course.Capacity);
            }
            else 
            { 
                _view.ShowUnkownChoice();
            }
        }
    }
}