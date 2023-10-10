namespace HeartRateBandCalc.Wasm.Services;

public interface IHeartService
{
    public int CalculateKarvonen(int restingHeartRate,
        int maxHeartRate,
        double factor);
}