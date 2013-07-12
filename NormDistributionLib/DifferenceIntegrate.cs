using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NormDistributionLib
{
    public class DifferenceIntegrate
    {
        static double SDRange = 4.0;//1.96, 95%; 2.58, 99%
        //take the left edge value
        public static double GetSpecificAreaSize(int DiffSpanCountTotal, 
            double Mean, double SD, double start, double end)
        {
            double retval = 0;

            double xRangeLen = SDRange * 2 * SD;
            double spanLen = xRangeLen / DiffSpanCountTotal;
            int SpanCountInRange = (int)((end - start) / spanLen);

            double at = start;

            for (int x = 0; x < SpanCountInRange; x++)
            {
                retval += ValueY.GetValue(Mean, SD, at) * spanLen;
                at += spanLen;
            }

            double remain = ((end - start) / spanLen) - SpanCountInRange;
            retval += ValueY.GetValue(Mean, SD, at) * remain * spanLen;
                
            return retval;
        }

        public static double GetWholeAreaSize(int DiffSpanCountTotal,
            double Mean, double SD)
        {
            return GetSpecificAreaSize(DiffSpanCountTotal, Mean, SD,
                Mean - SDRange * SD, Mean + SDRange * SD);
        }

        public static double GetSpecificAreaPercentage(int DiffSpanCountTotal,
            double Mean, double SD, double start, double end)
        {
            return GetSpecificAreaSize(DiffSpanCountTotal, Mean, SD, start, end) /
                GetWholeAreaSize(DiffSpanCountTotal, Mean, SD);
        }
    }
}
