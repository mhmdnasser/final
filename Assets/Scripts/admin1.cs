using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class admin1 : MonoBehaviour {
    public GameObject In;
    public GameObject l1;
    public GameObject l2;
    public GameObject l3;
    public GameObject l4;
    public GameObject l5;
    public Text txt1;
    public Text txt2;
    public Text txt3;
    public Text txt4;
    public Text txt5;

    public void LoginButton()
    {

        if (In.GetComponent<InputField>().text != "")
        {
            string x = In.GetComponent<InputField>().text;
            if (txt1.text == "")
            {
                txt1.text = x;
                l1.SetActive(true);
            }
            else if(txt2.text == "")
            {
                txt2.text = x;
                l2.SetActive(true);
            }
            else if (txt3.text == "")
            {
                txt3.text = x;
                l3.SetActive(true);
            }
            else if (txt4.text == "")
            {
                txt4.text = x;
                l4.SetActive(true);
            }
            else
            {
                txt5.text = x;
                l5.SetActive(true);
            }
        }
        else
        {
            Debug.LogWarning("Invaild text");
        }
    }
}
