using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float timeToStart = 3;
    private float timer = 0;

    void Update()
    {
        if (timer < timeToStart)
            timer += Time.deltaTime;
        else if (timer >= timeToStart)
            ReachWayPoint();
    }

    void ReachWayPoint()
    {
        transform.position = GameObject.FindGameObjectsWithTag("WayPoint")[0].transform.position;
        Destroy(GameObject.FindGameObjectsWithTag("WayPoint")[0].gameObject);
    }
}
