using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Project
{
    public partial class FrmReport : Form
    {
        private Travel _travel;
        private JSONReportBuilder _JSONReportBuilder;
        private HTMLReportBuilder _HTMLReportBuilder;
        private XMLReportBuilder _XMLReportBuilder;
        public FrmReport(Travel travel)
        {
            InitializeComponent();
            this._travel = travel;
            _JSONReportBuilder = new JSONReportBuilder(travel);
            _HTMLReportBuilder = new HTMLReportBuilder(travel);
            _XMLReportBuilder = new XMLReportBuilder(travel);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            htmlLabel.Text = _HTMLReportBuilder.BuildResult();
            jsonLabel.Text = _JSONReportBuilder.BuildResult();
            xmlLabel.Text = _XMLReportBuilder.BuildResult();
        }

        private void btnGöster_Click(object sender, EventArgs e)
        {
            _travel = null;
            FrmLogin form1 = new FrmLogin();
            form1.Show();
            this.Hide();
        }
    }
}
