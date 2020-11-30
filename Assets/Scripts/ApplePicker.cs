using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    [SerializeField] private GameObject basketPrefab;

    [SerializeField] int numBaskets = 3;

    [SerializeField] private float basketBottomY = -14.0f;
    [SerializeField] private float basketSpacingY = 2.0f;

    public List<GameObject> basketList;

    private void Start()
    {
        basketList = new List<GameObject>();
        
        // Добавление 3-х карзин на сцену по координатам 10, 12, 14.
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tempBasket = Instantiate(basketPrefab);

            Vector3 tempBasketPosition = Vector3.zero;

            tempBasketPosition.y = basketBottomY + (basketSpacingY * i);

            tempBasket.transform.position = tempBasketPosition;

            basketList.Add(tempBasket);
        }
    }

    /// <summary>
    /// Метод уничтожения одной карзинки и всех падающих в момент вызова метода яблок.
    /// </summary>
    public void AppleDestroyed()
    {
        // Поиск всех яблок в момент вызова метода
        GameObject[] tempAppleArray = GameObject.FindGameObjectsWithTag("Apple");

        foreach (var tempApple in tempAppleArray)
        {
            // Удаление всех яблок со сцены.
            Destroy(tempApple);
        }

        // Удалить одну корзину // e
        // Получить индекс последней корзины в basketList
        int basketIndex = basketList.Count - 1;

        // Получить ссылку на этот игровой объект Basket
        GameObject tempBasket = basketList[basketIndex];

        // Исключить корзину из списка и удалить сам игровой объект
        basketList.RemoveAt(basketIndex);

        Destroy(tempBasket);

        if(basketList.Count == 0)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}