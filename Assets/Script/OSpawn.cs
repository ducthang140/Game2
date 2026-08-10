using UnityEngine;

public class OSpawn : MonoBehaviour
{
    public GameObject obstacle;
    public float SpawnTime;
    private float timer = 0;
    public float HOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnObstacle();
            timer = 0;
        }
    }

    void SpawnObstacle()
    {
        float Left = transform.position.x - HOffset;
        float Right = transform.position.x + HOffset;
        Instantiate(obstacle, new Vector3(Random.Range(Left,Right), transform.position.y, 0), transform.rotation);
    }
}
