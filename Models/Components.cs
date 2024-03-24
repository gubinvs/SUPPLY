using System.Collections.Specialized;
using System.Data;
using SUPPLY;

namespace SUPPLY.Models; 

/// <summary>
/// Структура описывающая параметры комплектующиего
/// </summary>
/// vendorСode - арикул компонента
/// nameComponent - наименование компонента

public class Components {
    // Поля класса
    public string nameComponent;

    public string vendorСode;

    public int quantity;


    // Конструктор класса
    public Components(string nameComponent, string vendorСode)
    {
        this.nameComponent = nameComponent;
        this.vendorСode = vendorСode;
    }

    public Components(string nameComponent, string vendorСode, int quantity)
    {
        this.nameComponent = nameComponent;
        this.vendorСode = vendorСode;
        this.quantity = quantity;
    }
}   

