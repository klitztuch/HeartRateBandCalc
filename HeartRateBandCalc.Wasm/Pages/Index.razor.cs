namespace HeartRateBandCalc.Wasm.Pages;

public partial class Index
{
    private int _minHeartRate = 60;
    private bool useKarvonen = true;

    private int MinHeartRate
    {
        get => _minHeartRate;
        set
        {
            _minHeartRate = value;
            UpdateRange();
        }
    }

    private int _maxHeartRate = 180;

    private int MaxHeartRate
    {
        get => _maxHeartRate;
        set
        {
            _maxHeartRate = value;
            UpdateRange();
        }
    }

    private int _ut2Min;
    private int _ut2Max;
    private int _ut1Min;
    private int _ut1Max;
    private int _atMin;
    private int _atMax;
    private int _trMin;
    private int _trMax;
    private int _anMin;
    private int _anMax;

    private void UpdateRange()
    {
        _ut2Min = HeartService.CalculateKarvonen(_minHeartRate, _maxHeartRate, 0.55);
        _ut2Max = HeartService.CalculateKarvonen(_minHeartRate, _maxHeartRate, 0.7);
        
        _ut1Min = HeartService.CalculateKarvonen(_minHeartRate, _maxHeartRate, 0.7);
        _ut1Max = HeartService.CalculateKarvonen(_minHeartRate, _maxHeartRate, 0.8);
        
        _atMin = HeartService.CalculateKarvonen(_minHeartRate, _maxHeartRate, 0.8);
        _atMax = HeartService.CalculateKarvonen(_minHeartRate, _maxHeartRate, 0.85);
        
        _trMin = HeartService.CalculateKarvonen(_minHeartRate, _maxHeartRate, 0.85);
        _trMax = HeartService.CalculateKarvonen(_minHeartRate, _maxHeartRate, 0.95);
        
        _anMin = HeartService.CalculateKarvonen(_minHeartRate, _maxHeartRate, 0.95);
        _anMax = HeartService.CalculateKarvonen(_minHeartRate, _maxHeartRate, 1);
    }
}