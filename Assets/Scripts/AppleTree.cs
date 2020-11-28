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
        // TODO: Простое перемещение и изменение направления.
    }
}