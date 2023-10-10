namespace HeartRateBandCalc.Wasm.Services;

public class HeartService : IHeartService
{
    public int CalculateKarvonen(int restingHeartRate,
        int maxHeartRate,
        double factor)
    {
        return (int)(restingHeartRate + (maxHeartRate - restingHeartRate) * factor);
    }
}