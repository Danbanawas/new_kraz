using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource source;
    public float ClipTime;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        ClipTime = source.time;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("blocks"))
        {
            source.Play();
            Debug.Log($"Clip: {source.clip.name}");
        }
    }
}
