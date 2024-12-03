using Unity.VisualScripting;
using UnityEngine;

public class ResourceScript : MonoBehaviour
{
    public GameObject iceCream;
    public GameObject startButton;
    public GameObject movingBar;
    public GameObject tryAgain;
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    public int spellNum;
    public bool[] pressed;
    public int count = 0;
    private int audioCheck = 0;
    public bool moving = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spellNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && moving)
        {
            count++;
            if (spellNum > audioCheck && spellNum == 3)
            {
                AudioSource3();
                audioCheck = spellNum;
            }
            else if (spellNum > audioCheck)
            {
                AudioSource1();
                audioCheck = spellNum;
            }
            else if (count >= 3 && spellNum == 0)
            {
                Debug.Log("3 misses");
                movingBar.SetActive(false);
                tryAgain.SetActive(true);
                AudioSource4();
            }
            else if (spellNum == audioCheck)
            {
                AudioSource2();
            }
        }
        if (count >= 3)
        {
            startButton.SetActive(true);
            movingBar.SetActive(false);
            count = 0;
            spellNum = 0;
            audioCheck = 0;
        }
    }
    public void Reset()
    {
        iceCream.SetActive(false);
        pressed[0] = false;
        pressed[1] = false;
        pressed[2] = false;
        spellNum = 0;
        count = 0;
        moving = true;
    }

    public void AudioSource1()
    {
        audioSource1.Play();
    }
    public void AudioSource2()
    {
        audioSource2.Play();
    }
    public void AudioSource3()
    {
        audioSource3.Play();
    }
    public void AudioSource4()
    {
        audioSource4.Play();
    }
}
