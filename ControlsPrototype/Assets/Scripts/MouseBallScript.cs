using UnityEngine;

public class MouseBallScript : MonoBehaviour
{
    public Rigidbody body;
    public Camera ballCamera;
    public GameObject MouseFollow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballCamera = Camera.main;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.x > 515 && Input.mousePosition.x < 975 && Input.mousePosition.y > 60 && Input.mousePosition.y < 260)
        {
            Debug.Log("Here1");
            if (body.transform.position != Input.mousePosition)
            {
                Debug.Log("Here2");
                //body.position = Vector3.MoveTowards(body.transform.position, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x - 490, Input.mousePosition.y - 30, ballCamera.transform.position.z)), 1f);
                transform.LookAt(MouseFollow.transform.position);
            }
            //body.transform.LookAt(Input.mousePosition);
            //Debug.Log(body.transform.rotation.z);
            //body.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x - 490, Input.mousePosition.y - 30, ballCamera.transform.position.z));
            //Debug.Log("Mouse x, " + Input.mousePosition.x);
            //Debug.Log("Mouse y, " + Input.mousePosition.y);
            //body.position = new Vector3(Input.mousePosition.x, 0.5f, Input.mousePosition.y);
        }
    }
}
