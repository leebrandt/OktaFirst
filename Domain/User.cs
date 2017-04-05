namespace OktaFirst.Domain
{
  public class User
  {
        public string Id { get; set; }
    public string Status { get; set; }
    public Profile Profile { get; set; }

    public Credentials Credentials { get; set; }
  }

  public class Credentials
  {
    public Password Password { get; set; }
    public RecoveryQuestion RecoveryQuestion { get; set; }
  }

  public class RecoveryQuestion
  {
    public string Question { get; set; }
  }

  public class Password
  {
    public string Value { get; set; }
  }

  public class Profile
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MobilePhone { get; set; }
    public string Email { get; set; }
    public string SecondEmail { get; set; }
    public string Login { get; set; }
  }
}