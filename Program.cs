Course course = new Course(3);
CourseView view = new CourseView();

while (true)
{
    string choice = view.ReadChoice();

    if (choice == "0")
    {
        break;
    }
    if (choice == "1")
    {
        string name = view.ReadName();
        bool registered = course.TryRegister(name);
        view.ShowRegistrationResult(registered);
    } 
    else if (choice == "2")
    {
        view.ShowParticipants(course.GetParticipants(), course.Capacity);
    }
    else 
    { 
        view.ShowUnkownChoice();
    }
}
