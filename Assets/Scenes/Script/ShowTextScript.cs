using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoeTextScript : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Uzstartets!");



    }
    public int kadrs = 0;
    // Update is called once per frame
    void Update()
    {
        kadrs++;
        Debug.Log(kadrs);
    }
    */
    string text;
    public GameObject inputField;

    public GameObject displayField;

    // papildinas ar Random
    public void getText()
    {
        text = inputField.GetComponent<Text>().text;
        displayField.GetComponent<Text>().text = "Sveiks "+text.ToLower()+"!";
    }

}
