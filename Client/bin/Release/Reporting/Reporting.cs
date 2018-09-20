using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Reporting
{
    public static class Reporting
    {

        public static void GetFaturaByNo (long FaturaNo)
        {
            string path = System.IO.Path.GetFullPath(@"Reporting\GjeneroFaturen.txt");
            XtraReport report = new XtraReport();
            report = XtraReport.FromFile(path, true);
            ReportPrintTool pt = new ReportPrintTool(report);
            PrintingSystemBase ps = pt.PrintingSystem;
            report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters, DevExpress.XtraPrinting.CommandVisibility.None);
            report.DataSource = GetAll.GetFaturaByNr(FaturaNo);
            report.DataMember = "CustomSqlQuery";
            report.DisplayName = "Invoice";
            report.ShowPreview();
        }

        public static void GetSales(DateTime start, DateTime end)
        {
            string path = System.IO.Path.GetFullPath(@"Reporting\Shitjet.txt");
            XtraReport report = new XtraReport();
            report = XtraReport.FromFile(path, true);
            ReportPrintTool pt = new ReportPrintTool(report);
            PrintingSystemBase ps = pt.PrintingSystem;
            report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters, DevExpress.XtraPrinting.CommandVisibility.None);
            report.DataSource = GetAll.GetSales(start, end);
            report.DataMember = "CustomSqlQuery";
            report.DisplayName = "Invoice";
            report.ShowPreview();
        }

        public static void GetShpenzimet(DateTime start, DateTime end)
        {
            string path = System.IO.Path.GetFullPath(@"Reporting\Raport Shpenzimesh.txt");
            XtraReport report = new XtraReport();
            report = XtraReport.FromFile(path, true);
            ReportPrintTool pt = new ReportPrintTool(report);
            PrintingSystemBase ps = pt.PrintingSystem;
            report.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters, DevExpress.XtraPrinting.CommandVisibility.None);
            report.DataSource = GetAll.GetShpenzimet(start, end);
            report.DataMember = "CustomSqlQuery";
            report.DisplayName = "Invoice";
            report.ShowPreview();
        }
    }
}
