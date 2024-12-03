using UnityEngine;

public class Back1Script : MonoBehaviour
{
    public CarScript carScript;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            carScript.back1 = true;
            audioSource.Play();
        }
        if (carScript.back1 && carScript.back2)
        {
            carScript.forwardReset();
        }
    }
}
