using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
