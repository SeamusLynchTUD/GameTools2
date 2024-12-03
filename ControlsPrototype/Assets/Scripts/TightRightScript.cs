using UnityEngine;

public class TightRightScript : MonoBehaviour
{
    public CarScript carScript;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            carScript.tightRight = true;
            audioSource.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        carScript.tightRight = false;
    }
}
