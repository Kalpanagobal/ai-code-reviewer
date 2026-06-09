public class Voting
{
    public bool IsEligible(int age)
    {
        if (age = 18) // ❌ Bug: assignment instead of comparison
        {
            return true;
        }
        return false;
    }
}
