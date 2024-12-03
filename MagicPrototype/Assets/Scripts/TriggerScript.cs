using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject tryAgain;
    public GameObject iceCream;
    public GameObject startButton;
    public GameObject movingBar;
    public ResourceScript resourceScript;
    public int index;
    private bool entered = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        entered = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        entered = false;
        if (index == 2)
        {
            resourceScript.moving = false;
            movingBar.SetActive(false);
            startButton.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !resourceScript.pressed[index] && entered)
        {
            resourceScript.spellNum++;
            iceCream.SetActive(true);
            resourceScript.pressed[index] = true;
            Debug.Log("Detection " + resourceScript.spellNum);
        }
    }
}
