using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using SUPPLY;
using Microsoft.Office.Interop.Excel;
using SUPPLY.Models;
namespace SUPPLY.Models;



/// <summary>
/// Задачей данного класса является:
/// Открыть файл Excel c номенклатурой (артикулами номенклатуры), по пути к файлу переданному в параметрах;
/// Считать информацию из файла;
/// Вернуть результат чтения файла в виде List
/// </summary>
/// path - путь к файлу
/// 

class ReadingVendorСode
{

    private Application? excelapp;

    string path = "/Users/vladimirgubin/web-developer/SUPPLY/wwwroot/file/component.xlsx";



    public List<ListComponent> ReturnListComponent()
    {
         
        excelapp = new Excel.Application();
        excelapp.Visible = true;
        excelapp.Workbooks.Open(path);
        


        List<ListComponent> component = new List<ListComponent>();
        
        
        return component;
         
    }


}

