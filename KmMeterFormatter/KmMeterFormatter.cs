using System.Runtime.CompilerServices;

namespace KmMeterFormatter
{
    public static class KmMeterFormatter
    {
        public static string ConcatKmMeter(string km, string meter, string separator)
        {
            km = km.PadLeft(3, '0');
            meter = meter.PadLeft(3, '0');

            string concatResult = km + separator + meter;

            return concatResult;
        }
    }
}
