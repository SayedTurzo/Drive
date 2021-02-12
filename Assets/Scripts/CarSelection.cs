using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSelection : MonoBehaviour
{
    private int currentCar;
    public Button leftButton;
    public Button rightButton;
    public Text sedanPrice;
    
    private void Awake()
    {
        SelectCar(0);
    }
    private void SelectCar(int index)
    {
        leftButton.interactable = (index != 0);
        rightButton.interactable = (index != transform.childCount - 1);
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == index);
        }
    }
    public void Update()
    {
        if(currentCar == 0)
        {
            sedanPrice.text = "Sedan : $10,000";
        }
        if(currentCar == 1)
        {
            sedanPrice.text = "Hammer : $40,000";
        }
    }
    public void ChangeCar(int change)
    {
        currentCar += change;
        SelectCar(currentCar);
    }
    
}
