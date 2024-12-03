using UnityEngine;

public class TightLeftScript : MonoBehaviour
{
    public CarScript carScript;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            carScript.tightLeft = true;
            audioSource.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        carScript.tightLeft = false;
    }
}
