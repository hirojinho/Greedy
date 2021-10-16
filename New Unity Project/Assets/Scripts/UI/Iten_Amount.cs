using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iten_Amount : MonoBehaviour
{
    float Quantidade = 0f;
    public string resource;

    void Update()
    {
        UI_Resources();
    }

    public void UI_Resources()
    {
        if(resource == "clay") {Quantidade = GameObject.Find("PlayerArmature").GetComponent<resources>().clay;}   
        if(resource == "fish") {Quantidade = GameObject.Find("PlayerArmature").GetComponent<resources>().fish;}   
        if(resource == "wood") {Quantidade = GameObject.Find("PlayerArmature").GetComponent<resources>().wood;}   
        if(resource == "stone") {Quantidade = GameObject.Find("PlayerArmature").GetComponent<resources>().stone;}   
        if(resource == "coal") {Quantidade = GameObject.Find("PlayerArmature").GetComponent<resources>().coal;}   
        if(resource == "iron") {Quantidade = GameObject.Find("PlayerArmature").GetComponent<resources>().iron;}   
        if(resource == "gold") {Quantidade = GameObject.Find("PlayerArmature").GetComponent<resources>().gold;}   
        if(resource == "diamond") {Quantidade = GameObject.Find("PlayerArmature").GetComponent<resources>().diamond;}   
        gameObject.GetComponent<UnityEngine.UI.Text>().text = Quantidade.ToString("F0");
        Quantidade = 0f;
    }
}
