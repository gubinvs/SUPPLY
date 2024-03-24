using System.Collections.Specialized;
using SUPPLY;

namespace SUPPLY.Models; 

/// <summary>
/// Структура описывающая параметры комплектующиего
/// </summary>
/// vendorСode - арикул компонента
/// nameComponent - наименование компонента

public class Components {
    public string nameComponent;
    public string vendorСode;

    public Components (string nameComponent, string vendorСode)
    {
        this.nameComponent = nameComponent;
        this.vendorСode = vendorСode;
    }
}   

