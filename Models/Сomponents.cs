using System.Collections.Specialized;
using SUPPLY;

/// <summary>
/// Структура описывающая параметры комплектующиего
/// </summary>
/// vendorСode - арикул
/// nameComponent - наименование
/// manufacturer - производитель
class Components {

    public string nameComponent;
    public string vendorСode;
    public string manufacturer;

    public Components (string nameComponent, string vendorСode, string manufacturer ) 
    {
        this.nameComponent = nameComponent;
        this.vendorСode = vendorСode;
        this.manufacturer = manufacturer;
    }

}