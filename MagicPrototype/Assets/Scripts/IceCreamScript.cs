using UnityEngine;

public class IceCreamScript : MonoBehaviour
{
    Animator animator;
    public ResourceScript resourceScript;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (resourceScript.spellNum == 1)
        {
            animator.SetInteger("animCount", 1);
        }
        if (resourceScript.spellNum == 2)
        {
            animator.SetInteger("animCount", 2);
        }
        if (resourceScript.spellNum == 3)
        {
            animator.SetInteger("animCount", 3);
        }
    }
}
