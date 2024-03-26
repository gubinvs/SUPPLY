using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using SUPPLY.Models;
using Microsoft.Office.Interop.Excel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ClosedXML.Excel;


namespace SUPPLY.Models;
/// <summary>
/// Задачей данного класса является:
/// Открыть файл Excel c номенклатурой (артикулами номенклатуры), по пути к файлу переданному в параметрах;
/// Считать информацию из файла;
/// Вернуть результат чтения файла в виде List
/// </summary>
/// path - путь к файлу
/// 

class ReadingComponentExcel
{
    // Путь к файлу Excel с данными компонентов
    private string path = "/Users/vladimirgubin/web-developer/SUPPLY/wwwroot/file/component.xlsx";

   public List<Components> ListReturn() 
   {    
        // var rows = worksheet.RangeUsed().RowsUsed(); // Получаем все заполненные строки в файле
        // var row2 = worksheet.Row(2); // Получаем указанную строку
        var workbook = new XLWorkbook(this.path);  // Открыли книгу Excel
        var worksheet = workbook.Worksheet(1); // Выбрали Лист_1 книги Excel
        var count = worksheet.RangeUsed().RowCount(); // Получаем количество заполненных строк
        var range = worksheet.Rows(2, count); // Получаем диапазон строк от второй до последней заполненной

        List<Components> components = new List<Components>();
        int number; // числовая переменная для третьего аргумента в списке
        foreach (var row in @range)
        {   
            try // Проверка на ошибку преобразования в int
                {
                    number = Int32.Parse(row.Cell(3).Value.ToString()); // Преобразовали в строку, потом в число
                }
                catch (FormatException)
                {
                number = -1;
                }
            components.Add(new Components(
                row.Cell(1).Value.ToString(), // Преобразовали в строку
                row.Cell(2).Value.ToString(), // Преобразовали в строку
                number // Преобразованное число или -1 если ошибка
                ));
        };
        return components;
   } 
}