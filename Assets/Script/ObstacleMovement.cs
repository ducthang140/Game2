using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float MoveSpeed;
    public float DeadZone = -33;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.down * MoveSpeed) * Time.deltaTime;
        if (transform.position.y < DeadZone)
        {
            Destroy(gameObject);
        }
    }
}

