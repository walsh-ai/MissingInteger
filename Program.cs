// Top level statements
// Test solution 
int[] arr = {1, 3, 6, 4, 1, 2};
Console.WriteLine($"Result of A = [1, 3, 6, 4, 1, 2]: {MinimumMissingInt(arr).ToString()}"); 

public static partial class Program {
    /// <summary>
    /// Find the smallest positive integer (not 0) that is not
    /// present in the given array.
    /// This solution simply runs a quick sort on the array, and 
    /// increments the smallest non-found integer when it is encountered. 
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int MinimumMissingInt(int[] arr) {
        // Sort the input array (QuickSort)
        Array.Sort(arr); 

        // Find the minimum integer 
        // Maintain the smallest positive integer not found
        // Increment the smallest value when it is encountered 
        int smallest = 1; 
        foreach (int i in arr) {
            if (i == smallest) {
                smallest++; 
            }
        }

        return smallest; 
    }
}