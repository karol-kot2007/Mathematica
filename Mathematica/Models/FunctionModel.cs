namespace Mathematica.Models
{
  public class FunctionModel
  {
    public enum FunctionKind { Unset, Linear, Quadratic }
    int MinX = 100;
    int MaxX = 100;
    Dictionary<int, int> Values_dic;// key of dict is x, value is y
    public List<int> Values { get; set; }
    public FunctionKind Kind { get; set; }
  }
}
