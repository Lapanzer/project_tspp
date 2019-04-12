using System;
using Microsoft.Office.Interop.Word;
using abit = System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using F = System.Windows.Forms;

namespace ODZ______
{
    class WordTable
    {
        private Application app;
        private Document document;
        private object missing = System.Reflection.Missing.Value;
      
        public WordTable()
        {
            app = new Application();
            app.ShowAnimation = false;
            app.Visible = false;
            document = app.Documents.Add(ref missing,
                                ref missing, ref missing, ref missing);

        }

        public void AddHeader() {
            foreach (Section section in document.Sections)
            {
                //Get the header range and add the header details.  
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = WdColorIndex.wdBlue;
                headerRange.Font.Size = 20;
                headerRange.Text = "Звіт";
            }

        }

        public void AddParagraphs(String text)
        {
            var pText = document.Paragraphs.Add();
            pText.Range.Text = text;
            pText.Range.InsertParagraphAfter();

        }

        private void AddStringToColmn(Cell cell, String text) {

            cell.Range.Text = text;
            cell.Range.Font.Bold = 1;
            //other format properties goes here  
            cell.Range.Font.Name = "verdana";
            cell.Range.Font.Size = 10;
            //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
            //Center alignment for the Header cells  
            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

        }

        public void AddTable(abit.BindingSource result)
        {

            Paragraph para = document.Content.Paragraphs.Add(ref missing);
            Table firstTable = document.Tables.Add(para.Range, (int) result.Count + 1 , 3 , ref missing, ref missing);
            String[] Coulmn = new String[] { "Прізвище", "І'мя", "Оцінка" }; 

            firstTable.Borders.Enable = 1;
            foreach (Row row in firstTable.Rows)
            {
                foreach (Cell cell in row.Cells)
                {
                    //Header row  
                    if (cell.RowIndex == 1)
                    {
                        switch (cell.ColumnIndex)
                        {
                            case 1:
                                AddStringToColmn(cell , Coulmn[0]);
                                break;
                            case 2:
                                AddStringToColmn(cell, Coulmn[1]);
                                break;
                            case 3:
                                AddStringToColmn(cell, Coulmn[2]);
                                break;

                        } 
                        
                    }
                    //Data row  
                    else
                    { 

                        switch (cell.ColumnIndex)
                        {
                            case 1:
                                cell.Range.Text = ((AbitResult)result[cell.RowIndex - 2]).Surname;
                                break;
                            case 2:
                                cell.Range.Text = ((AbitResult)result[cell.RowIndex - 2]).Name;
                                break;
                            case 3:
                                cell.Range.Text = ((AbitResult)result[cell.RowIndex - 2]).Mark.ToString();
                                break;

                        }

                    }
                }
            }

        }

        public void Save() {

            F.SaveFileDialog dlg = new F.SaveFileDialog();
            dlg.FileName = "Zvit"; // Default file name
            dlg.DefaultExt = ".doc"; // Default file extension
            dlg.Filter = "Text documents (.doc)|*.doc"; // Filter files by extension
            dlg.ShowDialog();
            if (dlg.FileName != "Zvit")
            {
                document.SaveAs(@dlg.FileName);
                //F.MessageBox.Show(dlg.FileName, "Помилка");
            }
           

        }

        public void Close()
        { 
            document.Close(WdSaveOptions.wdDoNotSaveChanges);
            app.Quit();
        }
    }
}
