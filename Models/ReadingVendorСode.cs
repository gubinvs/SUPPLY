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
/// 

namespace SUPPLY {
    class ReadingVendorСode
    {
        public List<Components> components = new List<Components>();
        private Application? excelapp;

        public List<Components> ReturnListComponent()
        {

            // excelapp = new Excel.Application();
            // excelapp.Visible = true;
            // excelapp.Workbooks.Open(@"C:\a.html",
            //     Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            //     Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            //     Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            //     Type.Missing, Type.Missing);

            string nameComponent = "Наименование";
            string vendorСode = "Артикул";

            
            components.Add(
                new Components(nameComponent, vendorСode)
            );

            return components;
            
        }


    }

}

