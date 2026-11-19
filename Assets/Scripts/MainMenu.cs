using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject newGameButton;
    [SerializeField] private GameObject continueButton;
    [SerializeField] private GameObject otherBabeButton;
    [SerializeField] private GameObject settingButton;
    [SerializeField] private GameObject shopButton;

    [SerializeField] private GameObject pressToStart;
    [SerializeField] private GameObject heart;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        newGameButton.SetActive(false);
        continueButton.SetActive(false);
        otherBabeButton.SetActive(false);
        settingButton.SetActive(false);
        shopButton.SetActive(false);
        heart.SetActive(false);
        pressToStart.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Click(InputAction.CallbackContext context)
    {
    }
}
