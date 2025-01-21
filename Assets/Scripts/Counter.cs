using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField] int errosEncontrados = 0;
    [SerializeField] int totalErros = 7;
    [SerializeField] TMP_Text txtCounter;

    [SerializeField] GameObject gameScr;
    [SerializeField] GameObject gameoverScr;

    public void ErroEncontrado()
    {
        errosEncontrados++;
        txtCounter.text = "" + errosEncontrados;

        if (errosEncontrados >= totalErros)
        {
            gameScr.SetActive(false);
            gameoverScr.SetActive(true);
        }
    }
}
