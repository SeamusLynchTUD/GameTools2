using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Data.SqlTypes;
using JetBrains.Annotations;

public class EasyPanelScript : MonoBehaviour
{
    public bool repeat = false;
    public int difficulty;
    public List<int> numberList = new List<int>();
    public List<GameObject> directionList = new List<GameObject>();
    public List<GameObject> pointsList = new List<GameObject>();
    public ResourceScript resourceScript;
    public ResourceBarScript resourceBarScript;
    private int counter = 0;
    public GameObject thisObject;
    public int goodDecision;
    public GameObject resourceBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resourceBarScript.resourceBar();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            switch (numberList[counter])
            {
                case 1:
                    Object.Destroy(pointsList[counter].transform.GetChild(0).gameObject);
                    counter++;
                    break;
                default:
                    if (resourceBar.transform.localScale.x < 2.75f)
                    {
                        resourceBar.transform.localScale += new Vector3(0.25f, 0, 0);
                    }
                    else
                    {
                        var num = 3 - resourceBar.transform.localScale.x;
                        resourceBar.transform.localScale += new Vector3((num), 0, 0);
                    }
                    break;
            }
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            switch (numberList[counter])
            {
                case 2:
                    Object.Destroy(pointsList[counter].transform.GetChild(0).gameObject);
                    counter++;
                    break;
                default:
                    if (resourceBar.transform.localScale.x < 2.75f)
                    {
                        resourceBar.transform.localScale += new Vector3(0.25f, 0, 0);
                    }
                    else
                    {
                        var num = 3 - resourceBar.transform.localScale.x;
                        resourceBar.transform.localScale += new Vector3((num), 0, 0);
                    }
                    break;
            }
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            switch (numberList[counter])
            {
                case 3:
                    Object.Destroy(pointsList[counter].transform.GetChild(0).gameObject);
                    counter++;
                    break;
                default:
                    if (resourceBar.transform.localScale.x < 2.75f)
                    {
                        resourceBar.transform.localScale += new Vector3(0.25f, 0, 0);
                    }
                    else
                    {
                        var num = 3 - resourceBar.transform.localScale.x;
                        resourceBar.transform.localScale += new Vector3((num), 0, 0);
                    }
                    break;
            }
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            switch (numberList[counter])
            {
                case 4:
                    Object.Destroy(pointsList[counter].transform.GetChild(0).gameObject);
                    counter++;
                    break;
                default:
                    if (resourceBar.transform.localScale.x < 2.75f)
                    {
                        resourceBar.transform.localScale += new Vector3(0.25f, 0, 0);
                    }
                    else
                    {
                        var num = 3 - resourceBar.transform.localScale.x;
                        resourceBar.transform.localScale += new Vector3((num), 0, 0);
                    }
                    break;
            }
        }
        if (counter == difficulty)
        {
            if (repeat)
            {
                resourceScript.publicOpinion--;
            }
            thisObject.SetActive(false);
            counter = 0;
            switch (difficulty, goodDecision)
            {
                case (7, 0):
                    repeat = true;
                    break;

                case (14, 0):
                    resourceScript.publicOpinion += 1;
                    repeat = false;
                    break;

                case (21, 0):
                    resourceScript.publicOpinion += 2;
                    repeat = false;
                    break;

                case (7, 1):
                    resourceScript.money += 1;
                    repeat = false;
                    break;

                case (14, 1):
                    resourceScript.money += 2;
                    repeat = false;
                    break;

                case (21, 1):
                    resourceScript.money += 3;
                    repeat = false;
                    break;
            }

            if (resourceScript.stress == 10 || resourceScript.publicOpinion == 1)
            {

            }
            resourceScript.NewDecisions();
        }
    }

    public void EasyPanel()
    {
        //numberList.Clear();
        for(int i = 0; i < difficulty; i++)
        {
            var ranNum = Random.Range(1, 5);
            numberList[i] = ranNum;
            GameObject newObject = Instantiate(directionList[ranNum - 1], transform.position, Quaternion.identity, pointsList[i].transform);
            newObject.transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}
