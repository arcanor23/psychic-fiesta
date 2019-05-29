using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ANQ_CodageMorseWords : MonoBehaviour
{
    [SerializeField]
    private MorseData CodageData;



   

public void Update() // will display the found words with their morse translation
    {
        Text textResult = GetComponent<Text>();

        if (CodageMorse.word == 1 & CodageMorse.displayResult)
        {
            textResult.text = CodageData.animalWord + " : " +  CodageData.animalMorse;
            CodageMorse.displayResult = false;

        }
        if (CodageMorse.word == 2 & CodageMorse.displayResult)
        {
            textResult.text = textResult.text + Environment.NewLine + CodageData.numberWord + " : " + CodageData.numberMorse;
            CodageMorse.displayResult = false;

        }
        if (CodageMorse.word == 3 & CodageMorse.displayResult)
        {
            textResult.text = textResult.text + Environment.NewLine + CodageData.directionWord + " : " + CodageData.directionMorse;
            CodageMorse.displayResult = false;

        }
    }
}
