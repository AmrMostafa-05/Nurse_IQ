using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Text.Json;

namespace Nurse_IQ.Data.Config
{
    public static class ValueConverters
    {
        public static ValueConverter<List<string>, string> StringListConverter =
                new ValueConverter<List<string>, string>(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null));

        public static ValueComparer<List<string>> StringListComparer =
            new ValueComparer<List<string>>(
                (c1, c2) =>
                    ReferenceEquals(c1, c2) ? true :
                    c1 == null || c2 == null ? false :
                    c1.SequenceEqual(c2),
                c => c == null ? 0 : c.Aggregate(0, (a, v) => HashCode.Combine(a, v == null ? 0 : v.GetHashCode())),
                c => c == null ? new List<string>() : c.ToList()
            );
    }

}
