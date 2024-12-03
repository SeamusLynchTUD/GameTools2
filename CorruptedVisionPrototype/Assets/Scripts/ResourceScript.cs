using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;

public class ResourceScript : MonoBehaviour
{
    public int stress = 1;
    public int publicOpinion = 5;
    public int money = 1;
    private int day = 0;
    public Text stressText;
    public Text publicOpinionText;
    public Text moneyText;
    public Text dayText;
    public GameObject loseScreen;
    public GameObject loseTextObject;
    public Text loseText;
    public List<GameObject> decisionPointList = new List<GameObject>();
    public List<GameObject> easyDecisionList = new List<GameObject>();
    public List<GameObject> mediumDecisionList = new List<GameObject>();
    public List<GameObject> hardDecisionList = new List<GameObject>();
    public List<GameObject> easyBribeDecisionList = new List<GameObject>();
    public List<GameObject> mediumBribeDecisionList = new List<GameObject>();
    public List<GameObject> hardBribeDecisionList = new List<GameObject>();
    public List<List<GameObject>> decisionListsList = new List<List<GameObject>>();
    void Start()
    {
        stress = 1;
        publicOpinion = 5;
        money = 1;
        day = 0;
        decisionListsList.Add(easyDecisionList);
        decisionListsList.Add(mediumDecisionList);
        decisionListsList.Add(hardDecisionList);
        decisionListsList.Add(easyBribeDecisionList);
        decisionListsList.Add(mediumBribeDecisionList);
        decisionListsList.Add(hardBribeDecisionList);
        NewDecisions();
    }

    // Update is called once per frame
    void Update()
    {
        stressText.text = ("Stress: " + stress + "/10");
        publicOpinionText.text = ("Public Opinion: " + publicOpinion + "/10");
        moneyText.text = ("Money: " + money + "/10");
    }

    public void NewDecisions()
    {
        if (stress > 9 || publicOpinion < 2)
        {
            loseScreen.SetActive(true);
            loseTextObject.SetActive(true);
            loseText.text = ("You lose. You lasted " + day + " days.");

        }
        day++;
        dayText.text = ("Day: " + day);
        for(int i = 0; i < 3; i++)
        {
            foreach(Transform child in decisionPointList[i].transform)
            {
                Object.Destroy(decisionPointList[i].transform.GetChild(0).gameObject);
                //decisionPointList[i].transform.GetChild(0).gameObject.SetActive(false);
            }
            var ranNum1 = Random.Range(0, 6);
            var ranNum2 = Random.Range(0, decisionListsList[ranNum1].Count);
            GameObject newObject = Instantiate(decisionListsList[ranNum1][ranNum2], transform.position, Quaternion.identity, decisionPointList[i].transform);
            newObject.transform.localPosition = new Vector3(0, 0, 0);
            //decisionListsList[ranNum1].RemoveAt(ranNum2);
        }
    }
    public void ReduceStress()
    {
        if (money > 0)
        {
            money--;
            moneyText.text = ("Money: " + money + "/10");
            stress--;
            stressText.text = ("Stress: " + stress + "/10");
        }
    }
}
