using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aplikacija
{
    class LineChart
    {
        private int p1;
        private int p2;

        public LineChart(int p1, int p2)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
        }
        internal void AddAxis(ChartAxis chartAxis)
        {
            throw new NotImplementedException();
        }

        internal void SetData(List<int[]> dataset)
        {
            throw new NotImplementedException();
        }

        internal void SetTitle(string p1, string p2, int p3)
        {
            throw new NotImplementedException();
        }

        internal void SetDatasetColors(string[] p)
        {
            throw new NotImplementedException();
        }

        internal void SetLegend(string[] p)
        {
            throw new NotImplementedException();
        }

        internal void GetUrl()
        {
            throw new NotImplementedException();
        }
    }
}
