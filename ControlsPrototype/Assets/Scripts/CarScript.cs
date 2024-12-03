using UnityEngine;

public class CarScript : MonoBehaviour
{
    public Rigidbody body;
    public float speed;
    public bool forward1 = false;
    public bool forward2 = false;
    public bool back1 = false;
    public bool back2 = false;
    public bool tightLeft = false;
    public bool wideLeft = false;
    public bool tightRight = false;
    public bool wideRight = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (forward1 && forward2)
        {
            body.AddRelativeForce(0, 0, (speed - body.linearVelocity.z) * Time.deltaTime);
            //body.linearVelocity = new Vector3(0, 0, speed * Time.deltaTime);
            
        }
        if (back1 && back2)
        {
            body.AddRelativeForce(0, 0, (-speed + body.linearVelocity.z) * Time.deltaTime);
            //body.linearVelocity = new Vector3(0, 0, speed * Time.deltaTime);
        }
        if (wideLeft)
        {
            transform.Rotate(0, -1f, 0);
        }
        if (tightLeft)
        {
            transform.Rotate(0, -2f, 0);
        }
        if (wideRight)
        {
            transform.Rotate(0, 1f, 0);
        }
        if (tightRight)
        {
            transform.Rotate(0, 2f, 0);
        }
    }

    public void backReset()
    {
        back1 = false;
        back2 = false;
    }
    public void forwardReset()
    {
        forward1 = false;
        forward2 = false;
    }
}
