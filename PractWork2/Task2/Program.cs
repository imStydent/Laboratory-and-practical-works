using Excel = Microsoft.Office.Interop.Excel;

var excelApp = new Excel.Application();
excelApp.Visible = true;
var workbook = excelApp.Workbooks.Add(Path.Combine(Environment.CurrentDirectory, "Template.xlsx"));

Console.WriteLine("Введите путь к каталогу");
string path = Console.ReadLine();

for (int i = 2; i < 10; i++) ;