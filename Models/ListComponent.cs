using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using SUPPLY.Models;
using System.ComponentModel;

/// <summary>
/// Класс возвращает заполненный список компонентов использую метод ComponentReturn()
/// </summary>


namespace SUPPLY.Models;

public class ListComponent {

    List<Components> list = new List<Components>()
    {
        new Components("Первый элемент_1", "Значение элемента_1"),
        new Components("Первый элемент_2", "Значение элемента_2"),
        new Components("Первый элемент_3", "Значение элемента_3")
    };

    public List<Components> ComponentReturn() {
        return this.list;
    }

}
