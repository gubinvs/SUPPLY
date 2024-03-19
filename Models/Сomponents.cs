using System.Collections.Specialized;
using SUPPLY;

/// <summary>
/// Структура описывающая параметры комплектующиего
/// </summary>
/// vendorСode - арикул
/// nameComponent - наименование
/// manufacturer - производитель
public struct Components {

    // public string nameComponent;
    private string vendorСode;
    
    // public string manufacturer;

    public Components (string vendorСode)
    {
        this.vendorСode = vendorСode;
    }

}