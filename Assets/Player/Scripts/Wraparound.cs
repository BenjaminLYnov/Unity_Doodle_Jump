using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wraparound : MonoBehaviour
{
    public GameObject side;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            other.transform.position = new Vector2(side.transform.position.x, other.transform.position.y);
    }
}
