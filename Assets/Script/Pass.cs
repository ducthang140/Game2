using UnityEngine;

public class Pass : MonoBehaviour
{
    public Logic LogicPass;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LogicPass = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            LogicPass.AddScore(1);
        }
    }
}
