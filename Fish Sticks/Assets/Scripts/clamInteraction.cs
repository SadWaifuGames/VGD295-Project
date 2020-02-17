using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clamInteraction : MonoBehaviour
{
    public Sprite sp1, sp2;
    public GameObject selectionEffect;

    SpriteRenderer sr;

    private AudioSource source;
    private RandomPatrol rp;

    // Use this for initialization
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        rp = GetComponent<RandomPatrol>();
        source = GetComponent<AudioSource>();
        
}
    void OnMouseDown()
    {
        if (sr.sprite.Equals(sp1))
            sr.sprite = sp2;
        else
            sr.sprite = sp1;

        rp.enabled = false;
        source.Play();
        Instantiate(selectionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject, 0.9f);

    }
}