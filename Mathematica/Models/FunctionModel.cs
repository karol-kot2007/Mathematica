namespace Mathematica.Models
{
  public abstract class FunctionModel
  {

    public enum FunctionKind { Unset, Linear, Quadratic }
    public int MinX = 0;
    public int MaxX = 100;
    public List<Point> Points { get; set; }
    Dictionary<int, int> Values_dic;// key of dict is x, value is y
    public List<int> AxisYValues { get; set; } = new();
    public FunctionKind Kind { get; set; }
    public abstract void CalculateY();
   
    public abstract int GetY(int x);
   
    
   
  }
}
