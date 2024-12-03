using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public ResourceScript resourceScript;
    public ResourceBarScript resourceBarScript;
    public EasyPanelScript easyPanelScript;
    private List<int> resourceList = new List<int>();

    private void Start()
    {
        resourceList.Add(resourceScript.stress);
        resourceList.Add(resourceScript.publicOpinion);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (easyPanelScript.goodDecision == 0)
        {
            resourceScript.stress++;
            Debug.Log(resourceScript.stress);
        }
        else if (easyPanelScript.goodDecision == 1)
        {
            resourceScript.publicOpinion--;
            Debug.Log(resourceScript.publicOpinion);
        }
    }
}
