using System.Collections.Specialized;
using SUPPLY;

/// <summary>
/// Структура описывающая параметры комплектующиего
/// </summary>
/// vendorСode - арикул
/// nameComponent - наименование
/// manufacturer - производитель
public struct Components {

    private string nameComponent;
    private string vendorСode;

    public Components (string nameComponent, string vendorСode)
    {
        this.nameComponent = nameComponent;
        this.vendorСode = vendorСode;
    }

}