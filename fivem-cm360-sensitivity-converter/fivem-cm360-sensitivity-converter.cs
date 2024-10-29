using System;

class Program
{
    const double fivemMagicConstant = 1678106.125; // Updated constant

    // Converts cm/360 to Profile_MouseOnFootScale using the provided formula.
    static double ComputeMouseOnFootScale(double cm360, double dpi)
    {
        return Math.Round((fivemMagicConstant / (dpi * cm360)) - 60.25);
    }

    // Converts Profile_MouseOnFootScale back to cm/360 using reverse calculation.
    static double ComputeCm360(double sens, double dpi)
    {
        return fivemMagicConstant / (dpi * (sens + 60.25));
    }

    static void Main()
    {
        // Example usage:
        double cm360 = 40.0;  // Replace with desired cm/360 value
        double dpi = 800;   // Replace with your DPI

        // Convert cm/360 to FiveM sensitivity
        double fivemSens = ComputeMouseOnFootScale(cm360, dpi);
        Console.WriteLine($"Profile_MouseOnFootScale: {fivemSens:F2}");

        // Convert FiveM sensitivity back to cm/360
        double cm360Result = ComputeCm360(fivemSens, dpi);
        Console.WriteLine($"Cm/360: {cm360Result:F2}");
    }
}
