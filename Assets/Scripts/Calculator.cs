using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField] private Text Field;
    public int Number1;
    public int Number2;

    void Start()
    {
        Update_formula();
    }
    public void Update_formula()
    {
        Number1 = Random.Range(0, 50);
        Number2 = Random.Range(0, 50);
        Field.text = Number1.ToString() + "+" + Number2.ToString() + "=";
    }

}
