namespace ConsoleApp2;
/// <summary>
/// The <c>Distance</c> class provide methods 
/// for converting kms to and from miles.
/// </summary>

public class Distance
{
    /// <summary>
    /// Convert kms to miles.
    /// </summary>
    /// <param name="kms">
    /// Used to indicate kms.
    /// A <see cref="double"/> type represanting the value.
    /// </param>
    /// <returns>
    /// Returns the distance in miles.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// if <paramref name="kms"/> is negative.
    /// </exception>
    public static double KmsToMiles(double kms)
    {
        if (kms < 0)
            throw new ArgumentException("The value must be positive");

        return kms * 0.62;
    }

    /// <summary>
    /// Convert miles to kms.
    /// </summary>
    /// <param name="miles">
    /// User to indicate miles.
    /// A <see cref="double"/> type represanting the value.
    /// </param>
    /// <returns>
    /// Returns the distance in kms.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// if <paramref name="miles"/> is negative.
    /// </exception>
    public static double MilesToKms(double miles)
    {
        if (miles < 0)
            throw new ArgumentException("The value must be positive");

        return miles * 1.62;
    }
}
