using UnityEngine;

public class UIFollowPlayer : MonoBehaviour
{
    public Transform playerHead; // Set this to your XR Camera
    public Vector3 offset = new Vector3(0, 0, 2f);

    void Update()
    {
        if (playerHead != null)
        {
            // Follow the head with an offset in front
            Vector3 followPosition = playerHead.position + playerHead.forward * offset.z;
            followPosition.y = playerHead.position.y + offset.y;
            transform.position = followPosition;

            // Look at player (optional for readability)
            transform.LookAt(playerHead);
            transform.Rotate(0, 180f, 0); // Flip to face the player
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
    }
}
