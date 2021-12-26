using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    private void FixedUpdate()
    {
        ReachWayPoint();
    }

    void ReachWayPoint()
    {
        transform.position = GameObject.FindGameObjectsWithTag("WayPoint")[0].transform.position;
        Destroy(GameObject.FindGameObjectsWithTag("WayPoint")[0].gameObject);
    }
}
