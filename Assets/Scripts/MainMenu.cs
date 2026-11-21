using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private InputSystemUIInputModule InputUI;

    [Header("Visilibity list")]
    [SerializeField] private GameObject gameObjectHide;
    [Tooltip("Show")]
    [SerializeField] private GameObject[] gameObjectsShow;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        gameObjectHide.SetActive(true);

        foreach (var item in gameObjectsShow)
        {
            item.SetActive(false);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (InputUI.leftClick.action.IsPressed())
        {
            gameObjectHide.SetActive(false) ;
            foreach (var item in gameObjectsShow)
            {
                item.SetActive(true);
            }
        }
    }


}
