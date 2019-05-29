using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New MorseData", menuName = "MorseData", order = 52)]
public class MorseData : ScriptableObject 
{
    public string[] _animals = { "CHEVREUIL", "SANGLIER", "PERDRIX", "LAPIN", "FAISAN", "CERF" }; 
    public string[] _numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    public string[] _directions = { "GAUCHE", "DROITE", "HAUT", "BAS" };
    public  string _animalWord;
    public  string _numberWord;
    public  string _directionWord;

    public string _animalMorse;
    public  string _numberMorse;
    public  string _directionMorse;


    public string[] animals
    {
        get
        {
            return _animals;
        }

        set { _animals = value; }
    }

    public string[] numbers
    {
        get
        {
            return _numbers;
        }

        set { _numbers = value; }
    }

    public string[] directions
    {
        get
        {
            return _directions;
        }

        set { _directions = value; }

    }

    public string animalMorse
    {
        get
        {
            return _animalMorse;
        }

        set { _animalMorse = value; }
    }

    public string numberMorse
    {
        get
        {
            return _numberMorse;
        }

        set { _numberMorse = value; }
    }

    public string directionMorse
    {
        get
        {
            return _directionMorse;
        }

        set { _directionMorse = value; }
    }

    public string animalWord
    {
        get
        {
            return _animalWord;
        }

        set { _animalWord = value; }
    }

    public string directionWord
    {
        get
        {
            return _directionWord;
        }

        set { _directionWord = value; }
    }

    public string numberWord
    {
        get
        {
            return _numberWord;
        }

        set { _numberWord = value; }
    }
}

