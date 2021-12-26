using UnityEngine;

public class DestroyPlateform : MonoBehaviour
{
    public GameObject player;
    public GameObject[] elementToDestroy;
    public GameObject gameOver;

    private Vector2 oldPosition;

    private void Update()
    {
        oldPosition = transform.position;
        transform.position = new Vector2(transform.position.x, player.transform.position.y - 25);
        if (oldPosition.y > transform.position.y)
            transform.position = oldPosition;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Plateform")
            destroyPlateform(other.gameObject);

        else if (other.gameObject.tag == "Player")
        {
            gameOver.SetActive(true);

            Destroy(other.gameObject);

            foreach (GameObject gameObject in elementToDestroy)
                Destroy(gameObject);
                
            foreach (GameObject plateform in GameObject.FindGameObjectsWithTag("Plateform"))
                Destroy(plateform);

            foreach (GameObject wayPoint in GameObject.FindGameObjectsWithTag("WayPoint"))
                Destroy(wayPoint);

        }
    }

    private void destroyPlateform(GameObject plateform)
    {
        Destroy(plateform);
    }
}
