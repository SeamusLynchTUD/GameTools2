using UnityEngine;

public class WideRightScript : MonoBehaviour
{
    public CarScript carScript;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            carScript.wideRight = true;
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        carScript.wideRight = false;
    }
}
