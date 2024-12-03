using UnityEngine;

public class Forward1Trigger : MonoBehaviour
{
    public AudioSource audioSource;
    public CarScript carScript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            carScript.forward1 = true;
            audioSource.Play();
        }
        if (carScript.forward1 && carScript.forward2)
        {
            carScript.backReset();
        }
    }
}
