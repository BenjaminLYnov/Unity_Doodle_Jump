using UnityEngine;

public class CreateWayPoint : MonoBehaviour
{
    public GameObject player;
    public GameObject wayPointPrefab;

    // Update is called once per frame
    void Update()
    {
        Instantiate(wayPointPrefab, player.transform.position, Quaternion.identity);
    }
}
