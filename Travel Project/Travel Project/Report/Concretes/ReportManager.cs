using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Project
{
    class ReportManager
    {
        private IReportBuilder reportBuilder;

        public ReportManager(IReportBuilder reportBuilder)
        {
            this.reportBuilder = reportBuilder;
        }

        public string GetResult()
        {
            string result = reportBuilder.BuildResult();
            return result;
        }
    }
}
