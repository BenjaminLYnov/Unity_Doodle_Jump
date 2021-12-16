using UnityEngine;

public class ScorePlayer : MonoBehaviour
{
    public ScoreManager score;

    private Vector2 oldPosition;

    private void Start()
    {
        oldPosition = transform.position;
    }

    private void Update()
    {
        
        if (oldPosition.y < transform.position.y)
        {
            print(transform.position.y - oldPosition.y);
            score.Up(transform.position.y - oldPosition.y);
            oldPosition = transform.position;
        }
    }
}
