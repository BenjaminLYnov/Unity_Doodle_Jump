using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject player, DeadZone;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            DeadZone.transform.position = player.transform.position;
    }
}
