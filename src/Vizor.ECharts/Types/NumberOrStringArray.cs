using System.Text.Json;
using System.Text.Json.Serialization;

namespace Vizor.ECharts;

[JsonConverter(typeof(NumberOrStringArrayConverter))]
public class NumberOrStringArray
{
    public NumberOrStringArray(params NumberOrString[] values)
    {
        Values = values;
    }

    public NumberOrString[] Values { get; }

    public static implicit operator NumberOrStringArray(string value)
    {
        return new NumberOrStringArray(value);
    }

    public static implicit operator NumberOrStringArray(double value)
    {
        return new NumberOrStringArray(value);
    }

    public static implicit operator NumberOrStringArray(NumberOrString value)
    {
        return new NumberOrStringArray(value);
    }

    public static implicit operator NumberOrStringArray(NumberOrString[] values)
    {
        return new NumberOrStringArray(values);
    }

    public static implicit operator NumberOrStringArray(string[] values)
    {
        return new NumberOrStringArray(values.Select(v => new NumberOrString(v)).ToArray());
    }

    public static implicit operator NumberOrStringArray(double[] values)
    {
        return new NumberOrStringArray(values.Select(v => new NumberOrString(v)).ToArray());
    }
}

public class NumberOrStringArrayConverter : JsonConverter<NumberOrStringArray>
{
	public override NumberOrStringArray Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
        if (reader.TokenType == JsonTokenType.String)
        {
            var str = reader.GetString();
            return new NumberOrString(str ?? string.Empty);
        }
        else if (reader.TokenType == JsonTokenType.Number)
        {
            return new NumberOrString(reader.GetDouble());
        }
        else if (reader.TokenType == JsonTokenType.StartArray)
        {
            var num_string = new List<NumberOrString>();
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                {
                    break;
                }

                if (reader.TokenType == JsonTokenType.Number)
                {
                    num_string.Add(new NumberOrString(reader.GetDouble()));
                }
                else if (reader.TokenType == JsonTokenType.String)
				{
					num_string.Add(new NumberOrString(reader.GetString() ?? string.Empty));
				}
                else
                {
                    throw new JsonException("Expected number or in the array.");
                }
            }
			return new NumberOrStringArray(num_string.ToArray());
		}
		else
		{
			throw new JsonException("Unexpected token type.");
        }
    }

    public override void Write(Utf8JsonWriter writer, NumberOrStringArray value, JsonSerializerOptions options)
    {
        if (value.Values.Length == 1)
        {
            NumberOrStringConverter.Instance.Write(writer, value.Values[0], options);
        }
        else
        {
            writer.WriteStartArray();

            foreach (var val in value.Values)
                NumberOrStringConverter.Instance.Write(writer, val, options);

            writer.WriteEndArray();
        }
    }
}