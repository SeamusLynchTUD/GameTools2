using UnityEngine;

public class LoseScript : MonoBehaviour
{
    public ResourceScript resourceScript;
    public GameObject tryAgain;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (resourceScript.spellNum == 0)
        {
            tryAgain.SetActive(true);
            resourceScript.AudioSource4();
        }
    }
}
