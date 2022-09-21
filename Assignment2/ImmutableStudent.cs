namespace Assignment2
{
  public record ImmutableStudent (
    int Id,
    string GivenName,
    string Surname
  ) {
    DateTime StartDate {get; set;}
    DateTime EndDate {get; set;}
    DateTime GraduationDate {get; set;}
    Student.Status StudentStatus {
      get {
        DateTime Now = DateTime.Now;
        if (StartDate.CompareTo(Now) <= 0 && EndDate.CompareTo(Now) >= 0) {
          return Student.Status.Active;
        }
        else if (EndDate.CompareTo(Now) < 0) {
          if (EndDate.CompareTo(GraduationDate) < 0 ) {
            return Student.Status.Dropout;
          } else {
            return Student.Status.Graduated;
          }
        } else {
          return Student.Status.New;
        }
      }
    }
  }
}