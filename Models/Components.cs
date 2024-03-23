using System.Collections.Specialized;
using SUPPLY;

namespace SUPPLY.Models; 

/// <summary>
/// Структура описывающая параметры комплектующиего
/// </summary>
/// vendorСode - арикул
/// nameComponent - наименование
/// manufacturer - производитель
public class Components {

    public string nameComponent;
    public string vendorСode;

    public Components (string nameComponent, string vendorСode)
    {
        this.nameComponent = nameComponent;
        this.vendorСode = vendorСode;
    }

}   

