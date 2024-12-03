using UnityEngine;

public class ResourceBarScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.localScale += new Vector3(0.01f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x < 3)
        {
            transform.localScale += new Vector3(0.005f, 0, 0);
        }
        else
        {
            transform.localScale = new Vector3(3, 1, 1);
        }
    }

    public void resourceBar()
    {
        transform.localScale = new Vector3(0.01f, 1, 1);
    }
}