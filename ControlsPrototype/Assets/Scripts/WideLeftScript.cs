using UnityEngine;

public class WideLeftScript : MonoBehaviour
{
    public CarScript carScript;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            carScript.wideLeft = true;
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        carScript.wideLeft = false;
    }
}
