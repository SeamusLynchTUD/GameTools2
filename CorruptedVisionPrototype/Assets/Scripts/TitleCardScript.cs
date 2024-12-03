using UnityEngine;

public class TitleCardScript : MonoBehaviour
{
    private int timer = 0;
    public int delete;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer > delete)
        {
            Object.Destroy(gameObject);
        }
    }
}
