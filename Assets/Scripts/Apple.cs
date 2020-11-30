using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float BottomY = -20.0f;

    private void Update()
    {
        if (transform.position.y < BottomY)
        {
            Destroy(this.gameObject);

            ApplePicker appleScript = Camera.main.GetComponent<ApplePicker>();

            appleScript.AppleDestroyed();
        }
    }
}
