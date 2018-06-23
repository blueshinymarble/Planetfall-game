using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTerrainTile : MonoBehaviour
{
    Animator anim;
	// Use this for initialization
	void Start ()
    {
        if (gameObject.tag == "Hazard")
        {
            gameObject.transform.parent.tag = "Hazard";
        }
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		/*if (transform.parent.childCount > 1)
        {
            anim.Play("Fade out");
        }
        else if (transform.parent.childCount == 1)
        {
            anim.Play("Fade in");
        }*/
	}

}
