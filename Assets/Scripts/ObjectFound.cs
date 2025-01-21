using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFound : MonoBehaviour
{
    [SerializeField] Counter counter;
    [SerializeField] SFX_Player sfxPlayer;
    
    void OnMouseDown()
    {
        gameObject.SetActive(false);

        
        counter.ErroEncontrado();
        sfxPlayer.PlayRandomPopSFX();
    }
}
