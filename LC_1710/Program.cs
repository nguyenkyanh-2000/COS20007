namespace LC_1710;

public class Program
{
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        Array.Sort(boxTypes, (a, b) => b[1].CompareTo(a[1]));
        int res = 0;
        foreach (var box in boxTypes)
        {
            if (truckSize >= box[0])
            {
                res += box[0] * box[1];
                truckSize -= box[0];
            }
            else
            {
                res += truckSize * box[1];
                break;
            }
        }
        return res;
    }
    
    static void Main()
    {
       
    }
}