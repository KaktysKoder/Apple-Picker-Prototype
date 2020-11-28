using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    [SerializeField] private GameObject basketPrefab;

    [SerializeField] int numBaskets = 3;

    [SerializeField] private float basketBottomY = -14.0f;
    [SerializeField] private float basketSpacingY = 2.0f;


    private void Start()
    {
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tempBasket = Instantiate(basketPrefab);

            Vector3 tempBasketPosition = Vector3.zero;

            tempBasketPosition.y = basketBottomY + (basketSpacingY * i);

            tempBasket.transform.position = tempBasketPosition;
        }
    }

    private void Update()
    {

    }
}
