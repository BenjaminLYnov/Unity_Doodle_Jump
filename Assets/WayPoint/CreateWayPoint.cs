using UnityEngine;

public class CreateWayPoint : MonoBehaviour
{
    public GameObject player;
    public GameObject wayPointPrefab;

    // Update is called once per frame
    void FixedUpdate()
    {
        Instantiate(wayPointPrefab, player.transform.position, Quaternion.identity);
    }
}
