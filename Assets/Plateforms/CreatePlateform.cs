using UnityEngine;

public class CreatePlateform : MonoBehaviour
{
    // public GameObject player;
    public GameObject plateform;


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 10);
            createPlateforms();
        }
    }

    // Create Plateform if there isn't plateform 20 metters above player
    private void createPlateforms()
    {
        int nbrPlat = Random.Range(2, 3);
        for (int i = 0; i < nbrPlat; i++)
        {
            if (i == 0)
                Instantiate(plateform, new Vector3(Random.Range(-8, 8), transform.position.y - 13, 0), Quaternion.identity);
            Instantiate(plateform, new Vector3(Random.Range(-8, 8), transform.position.y + Random.Range(-7, -4), 0), Quaternion.identity);
        }
    }
}
