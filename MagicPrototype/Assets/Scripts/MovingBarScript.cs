using UnityEngine;

public class MovingBarScript : MonoBehaviour
{
    public float speed;
    public int iterations;
    private int move;
    private void Start()
    {
        move = iterations;
    }
    public void Movement()
    {
        move = 0;
        speed = 0.1f;
        transform.position = new Vector2(-5, -3.78f);
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed);
        move++;
        if (move >= iterations)
        {
            speed = 0;
        }
    }
}
