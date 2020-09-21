
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StringPerformance
{
    public class DoSomeStuff
    {
        public object TimeOfDay { get => DateTime.Now.TimeOfDay; }
        public object DayOfMonth { get => DateTime.Now.Day; }
        public object DayOfYear { get => DateTime.Now.DayOfYear; }
        public float[] MovingAverage3h { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] MovingAverage6h { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] MovingAverage1d { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] MovingAverage6d { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] MovingAverage12d { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] MovingAverage24d { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] MovingAverage48d { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] MovingAverage96d { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] RSI3h { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] RSI6h { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] RSI1d { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] RSI6d { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] RSI12d { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] Momentum1h { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] SpotPrices1h { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] BuyPrices1h { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }
        public float[] SellPrices1h { get => new float[] { 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, 0.1F, 0.2F, 0.3F, 0.4F, 0.5F, 0.6F, 0.7F, 0.8F, 0.9F, 0.10F, }; }

        [Benchmark]
        public string GenerateSaveStringOptimizedEx()
        {
            StringBuilder saveString = new StringBuilder();
            saveString.Append($"{this.TimeOfDay},{this.DayOfMonth},{this.DayOfYear},");            
            saveString.Append(this.MovingAverage3h.FloatToString());
            saveString.Append(this.MovingAverage6h.FloatToString());
            saveString.Append(this.MovingAverage1d.FloatToString());
            saveString.Append(this.MovingAverage6d.FloatToString());
            saveString.Append(this.MovingAverage24d.FloatToString());
            saveString.Append(this.MovingAverage48d.FloatToString());
            saveString.Append(this.MovingAverage96d.FloatToString());
            saveString.Append(this.RSI3h.FloatToString());
            saveString.Append(this.RSI6h.FloatToString());
            saveString.Append(this.RSI1d.FloatToString());
            saveString.Append(this.RSI6d.FloatToString());
            saveString.Append(this.RSI12d.FloatToString());
            saveString.Append(this.Momentum1h.FloatToString());
            saveString.Append(this.SpotPrices1h.FloatToString());
            saveString.Append(this.BuyPrices1h.FloatToString());
            saveString.Append(this.SellPrices1h.FloatToString());
            saveString.Append($"{"Some label"}");
            return saveString.ToString();
        }

        [Benchmark]
        public string GenerateSaveStringOptimized()
        {
            StringBuilder saveString = new StringBuilder();
            saveString.Append($"{this.TimeOfDay},{this.DayOfMonth},{this.DayOfYear},");
            foreach (float value in this.MovingAverage3h) saveString.Append($"{value},");
            foreach (float value in this.MovingAverage6h) saveString.Append($"{value},");
            foreach (float value in this.MovingAverage1d) saveString.Append($"{value},");
            foreach (float value in this.MovingAverage6d) saveString.Append($"{value},");
            foreach (float value in this.MovingAverage12d) saveString.Append($"{value},");
            foreach (float value in this.MovingAverage24d) saveString.Append($"{value},");
            foreach (float value in this.MovingAverage48d) saveString.Append($"{value},");
            foreach (float value in this.MovingAverage96d) saveString.Append($"{value},");
            foreach (float value in this.RSI3h) saveString.Append($"{value},");
            foreach (float value in this.RSI6h) saveString.Append($"{value},");
            foreach (float value in this.RSI1d) saveString.Append($"{value},");
            foreach (float value in this.RSI6d) saveString.Append($"{value},");
            foreach (float value in this.RSI12d) saveString.Append($"{value},");
            foreach (float value in this.Momentum1h) saveString.Append($"{value},");
            foreach (float value in this.SpotPrices1h) saveString.Append($"{value},");
            foreach (float value in this.BuyPrices1h) saveString.Append($"{value},");
            foreach (float value in this.SellPrices1h) saveString.Append($"{value},");
            saveString.Append($"{"Some label"}");
            return saveString.ToString();
        }

        [Benchmark]
        public string GenerateSaveStringOptimizedFast()
        {
            //https://www.meziantou.net/stringbuilder-performance-pitfalls.htm

            StringBuilder saveString = new StringBuilder(100000);
            saveString.Append(this.TimeOfDay).Append(',').Append(this.DayOfMonth).Append(',').Append(this.DayOfYear).Append(',');
            foreach (float value in this.MovingAverage3h) saveString.Append(value).Append(',');
            foreach (float value in this.MovingAverage6h) saveString.Append(value).Append(',');
            foreach (float value in this.MovingAverage1d) saveString.Append(value).Append(',');
            foreach (float value in this.MovingAverage6d) saveString.Append(value).Append(',');
            foreach (float value in this.MovingAverage12d) saveString.Append(value).Append(',');
            foreach (float value in this.MovingAverage24d) saveString.Append(value).Append(',');
            foreach (float value in this.MovingAverage48d) saveString.Append(value).Append(',');
            foreach (float value in this.MovingAverage96d) saveString.Append(value).Append(',');
            foreach (float value in this.RSI3h) saveString.Append(value).Append(',');
            foreach (float value in this.RSI6h) saveString.Append(value).Append(',');
            foreach (float value in this.RSI1d) saveString.Append(value).Append(',');
            foreach (float value in this.RSI6d) saveString.Append(value).Append(',');
            foreach (float value in this.RSI12d) saveString.Append(value).Append(',');
            foreach (float value in this.Momentum1h) saveString.Append(value).Append(',');
            foreach (float value in this.SpotPrices1h) saveString.Append(value).Append(',');
            foreach (float value in this.BuyPrices1h) saveString.Append(value).Append(',');
            foreach (float value in this.SellPrices1h) saveString.Append(value).Append(',');
            saveString.Append("Some label");
            return saveString.ToString();
        }


    }
    public static class FloatExtension
    {
        public static string FloatToString(this float[] floatArray)
        {            
            StringBuilder sb = new StringBuilder();
            foreach (float fl in floatArray)
            {
                sb.AppendFormat("{0},", fl);
            }
            return sb.ToString();
        }
    }
}
