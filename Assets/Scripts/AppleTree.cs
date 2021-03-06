﻿using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    [SerializeField] private GameObject applePrefab;

    [SerializeField] private float appleTreeSpeed = 1.0f;
    [SerializeField] private float leftAndRightEdge = 10.0f;
    [SerializeField] private float chanceToChangeDirections = 0.1f;
    [SerializeField] private float secondBetweenAppleDrops = 1.0f;

    private void Start() => Invoke("DropApple", 2.0f);

    private void FixedUpdate()
    {
        // Случайное направление движения яблони.
        if (Random.value < chanceToChangeDirections)
        {
            appleTreeSpeed *= -1; // Change direction.
        }
    }

    private void Update()
    {
        // Простое перемещение.
        Vector3 tempPositionTree = transform.position;

        tempPositionTree.x += appleTreeSpeed * Time.deltaTime;

        transform.position = tempPositionTree;


        // Изменение направления.
        if (tempPositionTree.x < -leftAndRightEdge)
        {
            appleTreeSpeed = Mathf.Abs(appleTreeSpeed);
        }
        else if (tempPositionTree.x > leftAndRightEdge)
        {
            appleTreeSpeed = -Mathf.Abs(appleTreeSpeed);
        }
    }

    /// <summary>
    /// Метод спавна яблок на позиции яблони каждые secondBetweenAppleDrops секунд.
    /// </summary>
    private void DropApple()
    {
        GameObject apple = Instantiate(applePrefab);

        apple.transform.position = transform.position;

        Invoke("DropApple", secondBetweenAppleDrops);
    }
}