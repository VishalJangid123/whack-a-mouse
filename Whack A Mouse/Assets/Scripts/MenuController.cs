using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform menuContainer;
    private Vector3 desiredMenuPosition,d;
    void Start()
    {
        Debug.Log(Screen.width);
        Debug.Log(Screen.height);
    }

    void NavigateTo(int menuIndex)
    {
        switch (menuIndex)
        {
            default:
            case 0:
                desiredMenuPosition = Vector3.zero; // case 0  for main menu screen
                break;
            case 1:
                desiredMenuPosition = Vector3.right * Screen.width;// case 1 for level selector
                break;
            case 2:
                desiredMenuPosition = Vector3.left * Screen.width;
                break;
        }
        Debug.Log("Desired position" + desiredMenuPosition);
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(menuContainer.transform.position.x);
        d = new Vector3(-1080f, menuContainer.transform.position.y, menuContainer.transform.position.z);
        menuContainer.transform.position = Vector3.Lerp(menuContainer.transform.position, d, 0.1f);
        

        // Debug.Log("anc" + menuContainer.anchoredPosition);
        // enuContainer.anchoredPosition = Vector3.Lerp(menuContainer.anchoredPosition, desiredMenuPosition, 0.1f);
        //Debug.Log("Desired position" + desiredMenuPosition + "menu" + menuContainer.anchoredPosition3D);
        //menuContainer.anchoredPosition3D = Vector3.Lerp(menuContainer.anchoredPosition3D, desiredMenuPosition, 0.1f);
    }

    public void onOptionButtonClicked()
    {
        NavigateTo(1);
        menuContainer.anchorMin = new Vector2(1, 0.5f);
        menuContainer.anchorMax = new Vector2(1, 0.5f);
        menuContainer.pivot = new Vector2(0.5f, 0.5f);
    }

    public void onBackButtonClicked()
    {
        NavigateTo(0);
        menuContainer.anchorMin = new Vector2(0.5f, 0.5f);
        menuContainer.anchorMax = new Vector2(0.5f, 0.5f);
        menuContainer.pivot = new Vector2(0.5f, 0.5f);
    }
    public void onHelpButtonClicked()
    {
        NavigateTo(1);
    }
}
