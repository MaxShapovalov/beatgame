using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNote : MonoBehaviour
{
    public AudioSource bass;
    public AudioSource hat;
    public AudioSource snare;
    public AudioSource perc;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.transform.Find("beatFace").gameObject.activeInHierarchy)
        {
            if (collision.gameObject.transform.parent.name == "Bass")
            {
                bass.Play();
            }
            if (collision.gameObject.transform.parent.name == "Snare")
            {
                snare.Play();
            }
            if (collision.gameObject.transform.parent.name == "Hat")
            {
                hat.Play();
            }
            if (collision.gameObject.transform.parent.name == "Perc")
            {
                perc.Play();
            }
        }
            
        
    }
}
