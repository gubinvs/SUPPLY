using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using SUPPLY;
using Microsoft.Office.Interop.Excel;

/// <summary>
/// Задачей данного класса является:
/// Открыть файл Excel c номенклатурой (артикулами номенклатуры), по пути к файлу переданному в параметрах;
/// Считать информацию из файла;
/// Вернуть результат чтения файла в виде List
/// </summary>
/// path - путь к файлу
class ReadingVendorСode
{
    public ReadingVendorСode()
    {    
    }

    static List<Components> ReadingVendorCode(string path)
    {
        // список артикулов наменклатуры
        List<Components> vendor = new List<Components>();

        // Откываем файл excel
        Excel.Application excelapp = new Excel.Application();
        excelapp.Workbooks.OpenText(path);

        // считываем данные полей файла



        return vendor;
    }

}


