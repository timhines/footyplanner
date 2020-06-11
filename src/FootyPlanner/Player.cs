namespace TimHines.FootyPlanner
{
  // Describes a football player and their contact details, plus some attributes about availability
  public class Player
  {
    // private vars
    private string _first_name;
    private string _last_name;
    private string _mobile_number;
    private bool _inactive;
    private bool _injured;

    // public accessors
    public string First_name { get => _first_name; set => _first_name = value; }
    public string Last_name { get => _last_name; set => _last_name = value; }
    public string Mobile_number { get => _mobile_number; set => _mobile_number = value; }
    public bool Inactive { get => _inactive; set => _inactive = value; }
    public bool Injured { get => _injured; set => _injured = value; }

    // constructors

    public Player()
    {
    }
    public Player(string first_name, string last_name)
    {
      _first_name = first_name;
      _last_name = last_name;
    }

    public Player(string first_name, string last_name, string mobile_number)
    {
      _first_name = first_name;
      _last_name = last_name;
      _mobile_number = mobile_number;
    }
  }
}