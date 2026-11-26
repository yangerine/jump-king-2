using UnityEngine;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    [Header("Setting Button List")]
    [SerializeField] private GameObject[] SettingFucntion;

    [Header("Switch Button")]
    [SerializeField] private GameObject[] checkButton;
    [SerializeField] private GameObject[] uncheckButton;

    private void Start()
    {
        foreach ( GameObject item in uncheckButton)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in checkButton)
        {
            item.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSfxButtonPress()
    {
        if (checkButton[0].activeInHierarchy)
        {
            uncheckButton[0].SetActive(true);
            checkButton[0].SetActive(false);
            Debug.Log("sfx off");
        } else if (!checkButton[0].activeInHierarchy)
        {
            uncheckButton[0].SetActive(false);
            checkButton[0].SetActive(true);
            Debug.Log("sfx on");
        }
    }

    public void OnAmbienceButtonPress()
    {
        if (checkButton[1].activeInHierarchy)
        {
            uncheckButton[1].SetActive(true);
            checkButton[1].SetActive(false);
            Debug.Log("ambi off");
        }
        else if (!checkButton[1].activeInHierarchy)
        {
            uncheckButton[1].SetActive(false);
            checkButton[1].SetActive(true);
            Debug.Log("ambi on");
        }
    }

    public void OnMusicButtonPress()
    {
        if (checkButton[2].activeInHierarchy)
        {
            uncheckButton[2].SetActive(true);
            checkButton[2].SetActive(false);
            Debug.Log("musi off");
        }
        else if (!checkButton[2].activeInHierarchy)
        {
            uncheckButton[2].SetActive(false);
            checkButton[2].SetActive(true);
            Debug.Log("musi on");
        }
    }

    public void OnCreditButtonPress()
    {
        Debug.Log("Credit show.");
    }

    public void OnTermsButtonPress()
    {
        Debug.Log("Terms show.");
    }

    public void OnStatsButtonPress()
    {
        Debug.Log("Stats show.");
    }
}
