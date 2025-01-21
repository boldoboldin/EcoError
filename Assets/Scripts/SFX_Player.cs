using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_Player : MonoBehaviour
{
    [SerializeField] private AudioClip[] popList;
    [SerializeField] private AudioClip[] clickList;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayRandomClickSFX();
        }
    }

    public void PlayRandomClickSFX()
    {
        if (clickList.Length == 0)
        {
            Debug.LogWarning("No audio clips assigned.");
            return;
        }

        int randomIndex = Random.Range(0, clickList.Length);
        AudioClip randomClip = clickList[randomIndex];

        audioSource.PlayOneShot(randomClip);
    }

    public void PlayRandomPopSFX()
    {
        if (popList.Length == 0)
        {
            Debug.LogWarning("No audio clips assigned.");
            return;
        }

        int randomIndex = Random.Range(0, popList.Length);
        AudioClip randomClip = popList[randomIndex];

        audioSource.PlayOneShot(randomClip);
    }
}
