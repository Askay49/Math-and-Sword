using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject Field;
    [SerializeField] private string Number;
    private string FormulaString;
    private int Answer;
    private int LengthString;

    void Start()
    {
        
    }
    public void On_Click()
    {
        Field.GetComponent<Text>().text += Number;
    }
    
    public void Check_formula()
    {
        FormulaString = Field.GetComponent<Text>().text;
        Answer = int.Parse(FormulaString.Substring(FormulaString.IndexOf('=')+1));
        if(Field.GetComponent<Calculator>().Number1 + Field.GetComponent<Calculator>().Number2 == Answer){
            Field.GetComponent<Calculator>().Update_formula();
        }
    }
    public void RemoveSymbol()
    {
        FormulaString = Field.GetComponent<Text>().text;
        LengthString = FormulaString.Length - 1;
        if(FormulaString[LengthString] != '=')
        {
            Field.GetComponent<Text>().text = FormulaString.Remove(LengthString);
        }   
        else
        {
            
        }
            
    }
}
