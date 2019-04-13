using System;
using Microsoft.Office.Interop.Word;
using abit = System.Windows.Forms;
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
            //app.ShowAnimation = false;
            app.Visible = false;
            document = app.Documents.Add(ref missing,
                                ref missing, ref missing, ref missing);
        }

        public void AddHeader()
        {
            var pText1 = document.Paragraphs.Add();
            pText1.Range.Text = "Звіт";
            pText1.Range.Bold = 1;
            pText1.Range.Font.Size = 20;
            pText1.Format.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            pText1.Range.InsertParagraphAfter();
        }

        public void AddParagraphs(String text)
        {
            var pText = document.Paragraphs.Add();
            pText.Range.Text = text;
            pText.Range.Bold = 0;
            pText.Range.Font.Size = 14;
            pText.Range.Font.Name = "Times New Roman";
            pText.Format.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            pText.Range.InsertParagraphAfter();
        }

        private void AddStringToColmn(Cell cell, String text)
        {
            cell.Range.Text = text;
            cell.Range.Font.Bold = 1;
            //other format properties goes here  
            cell.Range.Font.Name = "verdana";
            cell.Range.Font.Size = 14;
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

        public void Save()
        {
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
