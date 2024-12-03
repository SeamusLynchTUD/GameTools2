using UnityEngine;

public class MouseFollowScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x - 490, Input.mousePosition.y - 30, Camera.main.transform.position.z));
    }
}
