namespace NeetCode.Solutions;

internal class Measurement
{
    public void Measure(string name, Action actionToMeasure, int iterations = 100000)
    {
        //HeatUp
        RunMeasurement(actionToMeasure, 10);

        var data = RunMeasurement(actionToMeasure, iterations);

        Console.WriteLine($"{name}:");
        Console.WriteLine($"\tRun Time: {data.RunTime.TotalMilliseconds}ms");
        Console.WriteLine($"\tMemory Usage: {data.MemoryUsage}kb");
    }

    private static MeasurementData RunMeasurement(Action actionToMeasure, int iterations)
    {
        var data = new MeasurementData();

        for (var i = 0; i < iterations; i++)
        {
            data.Start();

            actionToMeasure();

            data.End();
        }

        data.Finish(iterations);
        return data;
    }

    private class MeasurementData
    {
        public TimeSpan RunTime { get; set; }
        public float MemoryUsage { get; set; }

        private TimeSpan _runTimeSum;
        private long _memoryUsageSum;
        private DateTime _startTime;
        private long _startMemoryUsage;

        public MeasurementData()
        {
            GC.GetTotalMemory(true);
        }

        public void Start()
        {
            _startMemoryUsage = GC.GetTotalMemory(false) / 1024;
            _startTime = DateTime.Now;
        }

        public void End()
        {
            var endTime = DateTime.Now;
            var endMemoryUsage = GC.GetTotalMemory(false) / 1024;

            _runTimeSum += endTime - _startTime;
            _memoryUsageSum += endMemoryUsage - _startMemoryUsage;
        }

        public void Finish(int iterations)
        {
            RunTime = _runTimeSum / iterations;
            MemoryUsage = (float)_memoryUsageSum / iterations;
        }
    }
}