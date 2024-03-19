using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using SUPPLY;



/// <summary>
///  Класс отвечающий за чтение информации из файла
/// </summary>
/// path - путь к файлу
class ReadingExel
{
    public Excel.Application excelapp = new Excel.Application();

    public ReadingExel()
    {    
    }

    public string OpenFileExcel(string path) 
    {
        excelapp.Visible = true;
        excelapp.Workbooks.Open(path,
         Type.Missing, Type.Missing, Type.Missing, Type.Missing,
         Type.Missing, Type.Missing, Type.Missing, Type.Missing,
         Type.Missing, Type.Missing, Type.Missing, Type.Missing,
         Type.Missing, Type.Missing);

         return excelapp;
    }

}


