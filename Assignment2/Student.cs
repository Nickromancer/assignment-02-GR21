namespace Assignment2;

public class Student {
  private static int Idd = 0;
  int Id {get; init;}
  string? GivenName {get; set;}
  string? Surname {get; set;}
  public enum Status {
    New,
    Active,
    Dropout,
    Graduated
  }

  DateTime StartDate {get; set;}
  DateTime EndDate {get; set;}
  DateTime GraduationDate {get; set;}

  Status StudentStatus {
    get {
      DateTime Now = DateTime.Now;
      if (StartDate.CompareTo(Now) <= 0 && EndDate.CompareTo(Now) >= 0) {
        return Status.Active;
      }
      else if (EndDate.CompareTo(Now) < 0) {
        if (EndDate.CompareTo(GraduationDate) < 0 ) {
          return Status.Dropout;
        } else {
          return Status.Graduated;
        }
      } else {
        return Status.New;
      }
    }
  }

  public Student (string givenName, string surname) {
    Id = Idd+1;
    GivenName = givenName;
    Surname = surname;
  }

  public override string ToString() {
    return $"Student: {Surname}, {GivenName}; {StudentStatus} \n Student ID: {Id}";
  }
}

