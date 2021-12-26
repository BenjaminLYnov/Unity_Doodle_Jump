using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            GameObject.Find("DeadZoneAndDestroyPlat").transform.position = other.gameObject.transform.position;
    }
}
