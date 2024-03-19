using Microsoft.AspNetCore.SignalR;
using SUPPLY;


namespace SUPPLY {
    /// <summary>
    /// Структура с параметрами компании поставщика комплектующих
    /// </summary>
    /// yorCompany - Юридический статус компании (ИП, НПД, ООО, АО)
    /// nameCompany - Название компании
    /// innCompany - ИНН компании
    /// legalAddress - Юридический адрес компании
    struct Company {

    public string yorCompany;

    public string nameCompany; 

    public int innCompany;

    public string legalAddress;

    }    
}
 
