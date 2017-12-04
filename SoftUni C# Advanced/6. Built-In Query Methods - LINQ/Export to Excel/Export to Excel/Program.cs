namespace Export_to_Excel
{
    using OfficeOpenXml;
    using System.IO;
    public class Program
    {
        public static void Main()
        {            
            var xlsPackage = new ExcelPackage();
            var workSheet = xlsPackage.Workbook.Worksheets.Add("StudentData");
            workSheet.Cells[1, 1, 1, 11].Merge = true;
            workSheet.Cells[1, 1, 1, 11].Style.Font.Size = 18;
            workSheet.Cells[1,1].Value= "SoftUni OOP Results";
            using (var reader = new StreamReader("../../StudentData.txt"))
            {
                var line = reader.ReadLine();
                var row = 2;
                while (line!=null)
                {
                    var colums = line.Split('\t');                    
                    for (int i = 0; i < colums.Length; i++)
                    {
                        workSheet.Cells[row, i+1].Value = colums[i];
                    }
                    row++;
                    line = reader.ReadLine();
                }
            }            
            var output = new FileStream("../../ExcelFile.xlsx",FileMode.Create);
            xlsPackage.SaveAs(output);
        }
    }
}
