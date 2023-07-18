﻿using System.Xml.Linq;
using Vizor.ECharts.Data;

namespace Vizor.ECharts.Options.Series;

public class SankeySeries<TData> : IChartSeries<TData>
{
	public string Type => "sankey";

	public string? Id { get; set; }
	public string? Name { get; set; }

	public List<TData> Data { get; set; } = new();

	//TODO
}
