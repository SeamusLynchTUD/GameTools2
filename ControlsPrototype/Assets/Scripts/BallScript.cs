using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody body;
    public int speed;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //body.AddForce(0, 0, (speed - body.linearVelocity.z), ForceMode.Acceleration);
            body.linearVelocity = new Vector3(0, 0, speed);
            print(body.linearVelocity);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //body.AddForce(0, 0, (-speed - body.linearVelocity.z), ForceMode.Acceleration);
            body.linearVelocity = new Vector3(0, 0, -speed);
            print(body.linearVelocity);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //body.AddForce((-speed - body.linearVelocity.x), 0, 0, ForceMode.Acceleration);
            body.linearVelocity = new Vector3(-speed, 0, 0);
            print(body.linearVelocity);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //body.AddForce((speed - body.linearVelocity.x), 0, 0, ForceMode.Acceleration);
            body.linearVelocity = new Vector3(speed, 0, 0);
            print(body.linearVelocity);
        }
        else
        {
            body.linearVelocity = new Vector3(0, 0, 0);
        }
    }
}
