using UnityEngine;

public class AnimationTrigger : MonoBehaviour {
	
	public static bool startTrip = false;
	public Transform starter;

	void Start ()
    {
		startTrip = false;
	}
	
	void Update ()
    {
		if(startTrip == true)
        {
			if (!GetComponent<Animation>().isPlaying)
            {
				GetComponent<Animation>().Play("path");
				Invoke("TheEndOf", 120.0f);
			}
			startTrip = false;
		}
	}

	void TheEndOf()
    {
        Application.LoadLevel(0);
		/*Transform start;
			start = Instantiate(starter, transform.position, transform.rotation) as Transform;
	
		startTrip = false;
		leafoffset.start = false;
		LightColour.startBool = false;
		FogColour.startBool = false;
		AmbColour.startBool = false;
        */
	}
}


