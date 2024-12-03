using UnityEngine;

public class Forward2Script : MonoBehaviour
{
    public CarScript carScript;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            carScript.forward2 = true;
            audioSource.Play();
        }
        if (carScript.forward1 && carScript.forward2)
        {
            carScript.backReset();
        }
    }
}
