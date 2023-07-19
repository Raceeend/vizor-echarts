// AUTO GENERATED - DO NOT EDIT - All changes will be lost
// http://www.datahint.eu/


using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Vizor.ECharts;

public partial class AngleAxis
{
	/// <summary>
	/// Component ID, not specified by default.
	/// If specified, it can be used to refer the component in option or API.
	/// </summary>
	[JsonPropertyName("id")]
	public string? Id { get; set; } 

	/// <summary>
	/// The index of angle axis in Polar Coordinate.
	/// The first axis is used by default.
	/// </summary>
	[JsonPropertyName("polarIndex")]
	[DefaultValue(0)]
	public int? PolarIndex { get; set; } 

	/// <summary>
	/// Starting angle of axis.
	/// 90 degrees by default, standing for top position of center.
	/// 0 degree stands for right position of center.
	///  
	/// The following shows an example with startAngle of 45 deg.
	/// </summary>
	[JsonPropertyName("startAngle")]
	[DefaultValue("90")]
	public double? StartAngle { get; set; } 

	/// <summary>
	/// Whether the positive position of axis is clockwise.
	/// True for clockwise by default.
	///  
	/// The following shows an example with clockwise as false .
	/// </summary>
	[JsonPropertyName("clockwise")]
	[DefaultValue("true")]
	public bool? Clockwise { get; set; } 

	/// <summary>
	/// Type of axis.
	///  
	/// Option:   
	/// 'value' Numerical axis, suitable for continuous data.
	///   
	/// 'category' Category axis, suitable for discrete category data.
	/// Category data can be auto retrieved from series.data or dataset.source , or can be specified via angleAxis.data .
	///   
	/// 'time' Time axis, suitable for continuous time series data.
	/// As compared to value axis, it has a better formatting for time and a different tick calculation method.
	/// For example, it decides to use month, week, day or hour for tick based on the range of span.
	///   
	/// 'log' Log axis, suitable for log data.
	/// </summary>
	[JsonPropertyName("type")]
	[DefaultValue("category")]
	public string? Type { get; set; } 

	//TODO: BoundaryGap
	/// <summary>
	/// The minimun value of axis.
	///  
	/// It can be set to a special value 'dataMin' so that the minimum value on this axis is set to be the minimum label.
	///  
	/// It will be automatically computed to make sure axis tick is equally distributed when not set.
	///  
	/// In category axis, it can also be set as the ordinal number.
	/// For example, if a catergory axis has data: ['categoryA', 'categoryB', 'categoryC'] , and the ordinal 2 represents 'categoryC' .
	/// Moreover, it can be set as negative number, like -3 .
	///  
	/// If min is specified as a function, it should return a min value, like:  min: function (value) {
	///     return value.min - 20;
	/// }  
	/// value is an object, containing the min value and max value of the data.
	/// This function should return the min value of axis, or return null / undefined to make echarts use the auto calculated min value ( null / undefined return is only supported since v4.8.0 ).
	/// </summary>
	[JsonPropertyName("min")]
	public NumberOrStringOrFunction? Min { get; set; } 

	/// <summary>
	/// The maximum value of axis.
	///  
	/// It can be set to a special value 'dataMax' so that the minimum value on this axis is set to be the maximum label.
	///  
	/// It will be automatically computed to make sure axis tick is equally distributed when not set.
	///  
	/// In category axis, it can also be set as the ordinal number.
	/// For example, if a catergory axis has data: ['categoryA', 'categoryB', 'categoryC'] , and the ordinal 2 represents 'categoryC' .
	/// Moreover, it can be set as negative number, like -3 .
	///  
	/// If max is specified as a function, it should return a max value, like:  max: function (value) {
	///     return value.max - 20;
	/// }  
	/// value is an object, containing the min value and max value of the data.
	/// This function should return the max value of axis, or return null / undefined to make echarts use the auto calculated max value ( null / undefined return is only supported since v4.8.0 ).
	/// </summary>
	[JsonPropertyName("max")]
	public NumberOrStringOrFunction? Max { get; set; } 

	/// <summary>
	/// It is available only in numerical axis, i.e., type : 'value'.
	///  
	/// It specifies whether not to contain zero position of axis compulsively.
	/// When it is set to be true , the axis may not contain zero position, which is useful in the scatter chart for both value axes.
	///  
	/// This configuration item is unavailable when the min and max are set.
	/// </summary>
	[JsonPropertyName("scale")]
	[DefaultValue(false)]
	public bool? Scale { get; set; } 

	/// <summary>
	/// Number of segments that the axis is split into.
	/// Note that this number serves only as a recommendation, and the true segments may be adjusted based on readability.
	///  
	/// This is unavailable for category axis.
	/// </summary>
	[JsonPropertyName("splitNumber")]
	[DefaultValue("5")]
	public double? SplitNumber { get; set; } 

	/// <summary>
	/// Minimum gap between split lines.
	///  
	/// For example, it can be set to be 1 to make sure axis label is show as integer.
	///  {
	///     minInterval: 1
	/// }  
	/// It is available only for axis of type 'value' or 'time'.
	/// </summary>
	[JsonPropertyName("minInterval")]
	[DefaultValue(0)]
	public double? MinInterval { get; set; } 

	/// <summary>
	/// Maximum gap between split lines.
	///  
	/// For example, in time axis ( type is 'time'), it can be set to be 3600 * 24 * 1000 to make sure that the gap between axis labels is less than or equal to one day.
	///  {
	///     maxInterval: 3600 * 1000 * 24
	/// }  
	/// It is available only for axis of type 'value' or 'time'.
	/// </summary>
	[JsonPropertyName("maxInterval")]
	public double? MaxInterval { get; set; } 

	/// <summary>
	/// Compulsively set segmentation interval for axis.
	///  
	/// As splitNumber is a recommendation value, the calculated tick may not be the same as expected.
	/// In this case, interval should be used along with min and max to compulsively set tickings.
	/// But in most cases, we do not suggest using this, our automatic calculation is enough for most situations.
	///  
	/// This is unavailable for category axis.
	/// Timestamp should be passed for type : 'time' axis.
	/// Logged value should be passed for type : 'log' axis.
	/// </summary>
	[JsonPropertyName("interval")]
	public double? Interval { get; set; } 

	/// <summary>
	/// Base of logarithm, which is valid only for numeric axes with type : 'log'.
	/// </summary>
	[JsonPropertyName("logBase")]
	[DefaultValue("10")]
	public double? LogBase { get; set; } 

	/// <summary>
	/// Set this to true , to prevent interaction with the axis.
	/// </summary>
	[JsonPropertyName("silent")]
	[DefaultValue(false)]
	public bool? Silent { get; set; } 

	/// <summary>
	/// Set this to true to enable triggering events.
	///  
	/// Parameters of the event include:  {
	///     // Component type: xAxis, yAxis, radiusAxis, angleAxis
	///     // Each of which has an attribute for index, e.g., xAxisIndex for xAxis
	///     componentType: string,
	///     // Value on axis before being formatted.
	///     // Click on value label to trigger event.
	///     value: '',
	///     // Name of axis.
	///     // Click on laben name to trigger event.
	///     name: ''
	/// }
	/// </summary>
	[JsonPropertyName("triggerEvent")]
	[DefaultValue(false)]
	public bool? TriggerEvent { get; set; } 

	/// <summary>
	/// Settings related to axis line.
	/// </summary>
	[JsonPropertyName("axisLine")]
	public AxisLine? AxisLine { get; set; } 

	/// <summary>
	/// Settings related to axis tick.
	/// </summary>
	[JsonPropertyName("axisTick")]
	public AxisTick? AxisTick { get; set; } 

	/// <summary>
	/// Since v4.6.0   
	/// Settings related minor ticks.
	///  
	/// Note: minorTick is not available in the category type axis.
	///  
	/// Examples:  
	/// 1) Using minor ticks in function plotting.
	///   
	/// 2) Using minor ticks in log axis.
	/// </summary>
	[JsonPropertyName("minorTick")]
	public MinorTick? MinorTick { get; set; } 

	/// <summary>
	/// Settings related to axis label.
	/// </summary>
	[JsonPropertyName("axisLabel")]
	public AxisLabel? AxisLabel { get; set; } 

	/// <summary>
	/// Split line of axis in grid area.
	/// </summary>
	[JsonPropertyName("splitLine")]
	public SplitLine? SplitLine { get; set; } 

	/// <summary>
	/// Since v4.6.0   
	/// Minor split lines of axis in the grid area。It will align to the minorTick
	/// </summary>
	[JsonPropertyName("minorSplitLine")]
	public MinorSplitLine? MinorSplitLine { get; set; } 

	/// <summary>
	/// Split area of axis in grid area, not shown by default.
	/// </summary>
	[JsonPropertyName("splitArea")]
	public SplitArea? SplitArea { get; set; } 

	/// <summary>
	/// Category data, available in type : 'category' axis.
	///  
	/// If type is not specified, but axis.data is specified, the type is auto set as 'category' .
	///  
	/// If type is specified as 'category' , but axis.data is not specified, axis.data will be auto collected from series.data .
	/// It brings convenience, but we should notice that axis.data provides then value range of the 'category' axis.
	/// If  it is auto collected from series.data , Only the values appearing in series.data can be collected.
	/// For example, if series.data is empty, nothing will be collected.
	///  
	/// Example:  // Name list of all categories
	/// data: ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday']
	/// // Each item could also be a specific configuration item.
	/// // In this case, `value` is used as the category name.
	/// data: [{
	///     value: 'Monday',
	///     // Highlight Monday
	///     textStyle: {
	///         fontSize: 20,
	///         color: 'red'
	///     }
	/// }, 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday']
	/// </summary>
	[JsonPropertyName("data")]
	public List<AngleAxisData>? Data { get; set; } 

	/// <summary>
	/// axisPointer settings on the axis.
	/// </summary>
	[JsonPropertyName("axisPointer")]
	public AxisPointer? AxisPointer { get; set; } 

	/// <summary>
	/// Whether to enable animation.
	/// </summary>
	[JsonPropertyName("animation")]
	[DefaultValue("true")]
	public bool? Animation { get; set; } 

	/// <summary>
	/// Whether to set graphic number threshold to animation.
	/// Animation will be disabled when graphic number is larger than threshold.
	/// </summary>
	[JsonPropertyName("animationThreshold")]
	[DefaultValue(2000)]
	public double? AnimationThreshold { get; set; } 

	/// <summary>
	/// Duration of the first animation, which supports callback function for different data to have different animation effect:  animationDuration: function (idx) {
	///     // delay for later data is larger
	///     return idx * 100;
	/// }
	/// </summary>
	[JsonPropertyName("animationDuration")]
	[DefaultValue("1000")]
	public NumberOrFunction? AnimationDuration { get; set; } 

	/// <summary>
	/// Easing method used for the first animation.
	/// Varied easing effects can be found at easing effect example .
	/// </summary>
	[JsonPropertyName("animationEasing")]
	[DefaultValue("cubicOut")]
	public AnimationEasing? AnimationEasing { get; set; } 

	/// <summary>
	/// Delay before updating the first animation, which supports callback function for different data to have different animation effect.
	///  
	/// For example:  animationDelay: function (idx) {
	///     // delay for later data is larger
	///     return idx * 100;
	/// }  
	/// See this example for more information.
	/// </summary>
	[JsonPropertyName("animationDelay")]
	[DefaultValue(0)]
	public NumberOrFunction? AnimationDelay { get; set; } 

	/// <summary>
	/// Time for animation to complete, which supports callback function for different data to have different animation effect:  animationDurationUpdate: function (idx) {
	///     // delay for later data is larger
	///     return idx * 100;
	/// }
	/// </summary>
	[JsonPropertyName("animationDurationUpdate")]
	[DefaultValue("1000")]
	public NumberOrFunction? AnimationDurationUpdate { get; set; } 

	/// <summary>
	/// Easing method used for animation.
	/// </summary>
	[JsonPropertyName("animationEasingUpdate")]
	[DefaultValue("cubicOut")]
	public AnimationEasing? AnimationEasingUpdate { get; set; } 

	/// <summary>
	/// Delay before updating animation, which supports callback function for different data to have different animation effects.
	///  
	/// For example:  animationDelayUpdate: function (idx) {
	///     // delay for later data is larger
	///     return idx * 100;
	/// }  
	/// See this example for more information.
	/// </summary>
	[JsonPropertyName("animationDelayUpdate")]
	[DefaultValue(0)]
	public NumberOrFunction? AnimationDelayUpdate { get; set; } 

	/// <summary>
	/// zlevel value of all graphical elements in Angle Axis.
	///  
	/// zlevel is used to make layers with Canvas.
	/// Graphical elements with different zlevel values will be placed in different Canvases, which is a common optimization technique.
	/// We can put those frequently changed elements (like those with animations) to a separate zlevel .
	/// Notice that too many Canvases will increase memory cost, and should be used carefully on mobile phones to avoid crash.
	///  
	/// Canvases with bigger zlevel will be placed on Canvases with smaller zlevel .
	/// </summary>
	[JsonPropertyName("zlevel")]
	[DefaultValue(0)]
	public double? Zlevel { get; set; } 

	/// <summary>
	/// z value of all graphical elements in Angle Axis, which controls order of drawing graphical components.
	/// Components with smaller z values may be overwritten by those with larger z values.
	///  
	/// z has a lower priority to zlevel , and will not create new Canvas.
	/// </summary>
	[JsonPropertyName("z")]
	[DefaultValue(0)]
	public double? Z { get; set; } 

}
