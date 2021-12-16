using UnityEngine;

public class FollowPlayerY : MonoBehaviour
{
    public GameObject player;


    void Start()
    {
        transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
    }
}
