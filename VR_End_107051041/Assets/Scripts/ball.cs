using UnityEngine;

public class ball : MonoBehaviour
{
    AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.name == "球桿")
           {
            audio.Play();
            print("會進球嘛!!!");
           }

    }
}
