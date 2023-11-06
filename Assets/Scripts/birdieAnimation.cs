using UnityEngine;

public class birdieAnimation : MonoBehaviour {

    private bool fly = false; 

	void Start ()
    {
	    fly = false;
	}

    void Update ()
    {
		if(fly == true)
        {
	        GetComponent<Animation>().Play("fly");
		}
	}

	void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().gameObject.tag=="LineOf")
        {		
			fly = true;
		}
	}
}
