using System.Collections;
using UnityEngine;

public class InstantiateAlterEgo : MonoBehaviour
{
    public GameObject alterEgoPrefab;
    public float spawnDelay = 3;

    private void Start()
    {
        StartCoroutine(handleInvulnerable());
    }

    public IEnumerator handleInvulnerable()
    {
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(alterEgoPrefab);
    }
}
