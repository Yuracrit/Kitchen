using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
    [SerializeField] private Shelf _shelfOne;
    [SerializeField] private Shelf _shelfTwo;

    private void OnEnable()
    {
        // Подписываемся на событие ItemSpawned для каждой полки
        _shelfOne.ItemSpawned += OnItemSpawned;
        _shelfTwo.ItemSpawned += OnItemSpawned;
    }

    private void OnDisable()
    {
        // Отписываемся от события ItemSpawned для каждой полки
        _shelfOne.ItemSpawned -= OnItemSpawned;
        _shelfTwo.ItemSpawned -= OnItemSpawned;
    }

    private void OnItemSpawned()
    {
        CheckAndFall(_shelfOne);
        CheckAndFall(_shelfTwo);
    }

    private void CheckAndFall(Shelf shelf)
    {
        if (shelf.ItemsCount > 3)
        {
            shelf.Fall();
        }
    }
}
