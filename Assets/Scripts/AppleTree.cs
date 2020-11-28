using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    [SerializeField] private GameObject applePrefab;

    [SerializeField] private float appleTreeSpeed = 1.0f;
    [SerializeField] private float leftAndRightEdge = 10.0f;
    [SerializeField] private float chanceToChangeDirections = 0.1f;
    [SerializeField] private float secondBetweenAppleDrops = 1.0f;

    private void Start()
    {
        // TODO: Сбрасывать яблоки раз в секунду.
    }

    private void Update()
    {
        // Простое перемещение.
        Vector3 tempPositionTree = transform.position;

        tempPositionTree.x += appleTreeSpeed * Time.deltaTime;

        transform.position = tempPositionTree;


        // Изменение направления
        if (tempPositionTree.x < -leftAndRightEdge)
        {
            appleTreeSpeed = Mathf.Abs(appleTreeSpeed);
        }
        else if (tempPositionTree.x > leftAndRightEdge)
        {
            appleTreeSpeed = -Mathf.Abs(appleTreeSpeed);
        }
    }
}