using System;
using System.Collections.Generic;
using System.Text;

namespace DrillWpfObject
{
    class Result
    {
        private double tid;
        private string namn;
        private int distans;

        public Result(double tid, string namn, int distans)
        {
            this.tid = tid;
            this.namn = namn;
            this.distans = distans;
        }

        public override string ToString()
        {
            string text = "";
            text += "namn: " + namn + Environment.NewLine;
            text += "distans: " + distans + " m" + Environment.NewLine;
            text += "tid: " + tid + " s" + Environment.NewLine + Environment.NewLine;
            return text;

        }
    }
}
