using System.Text.Json;

namespace Vizor.ECharts.Tests.TestFixtures;

internal sealed class TestChart : EChartBase
{
    public TestChart()
    {
        Options = new ChartOptions();
    }

    public JsonSerializerOptions GetSerializerOptions()
    {
        return CreateSerializerOptions();
    }

    public JsonSerializerOptions GetSerializerOptions(bool writeIndented)
    {
        if (!writeIndented)
            return CreateSerializerOptions();

        var options = CreateSerializerOptions();
        var testOptions = new JsonSerializerOptions(options)
        {
            WriteIndented = true
        };

        return testOptions;
    }

    public override Task UpdateAsync(bool executeDataLoader = true)
    {
        return Task.CompletedTask;
    }
}
