using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Word.Application;

namespace ConvertDocxToPdf
{
    public partial class Convert : Form
    {
        public Convert()
        {
            InitializeComponent();
        }

        private void btnChooseIn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath, "*.docx");
                    if (files.Length > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Tìm Thấy : " + files.Length.ToString() + " file .docx", "Thông Báo");
                        txtInput.Text = fbd.SelectedPath;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Tìm Thấy : " + files.Length.ToString() + " file .docx cần chọn lại thư mục chứa file", "Thông Báo");
                    }
                }
            }
        }

        private void btnChooseOut_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtOutPut.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            if(txtInput.Text != "" && txtOutPut.Text !="")
            {
                btnConvert.Enabled = false;
                CreatePDF(txtInput.Text, txtOutPut.Text);
                btnConvert.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thư mục chứa file docx hoặc lưu file","Thông Báo");
            }

        }

        private bool CreatePDF(string path, string exportDir)
        {
            Application app = new Application();
            app.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            app.Visible = false;

            string[] files = System.IO.Directory.GetFiles(path, "*.docx");

            foreach (var file in files)
            {
                var objPresSet = app.Documents;
                var objPres = objPresSet.Open(file, MsoTriState.msoTrue, MsoTriState.msoTrue, MsoTriState.msoFalse);

                var pdfFileName = Path.ChangeExtension(file, ".pdf");

                var pdfPath = Path.Combine(pdfFileName, exportDir + "\\" + Path.GetFileName(pdfFileName));

                try
                {
                    objPres.ExportAsFixedFormat(
                        pdfPath,
                        WdExportFormat.wdExportFormatPDF,
                        false,
                        WdExportOptimizeFor.wdExportOptimizeForPrint,
                        WdExportRange.wdExportAllDocument
                    );
                }
                catch
                {
                    return false;
                }
                finally
                {
                    objPres.Close();
                }
            }

            return true;
        }
    }
}
