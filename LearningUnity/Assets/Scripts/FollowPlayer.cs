using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    // initialized inside of Unity
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // camera position since that's where we are
        transform.position = player.position + offset;
    }
}
