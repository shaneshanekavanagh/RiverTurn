using UnityEngine;

public class splash2 : MonoBehaviour {

    //public GUISkin customSkin;
	public static bool startTrip = false;
	
	void Start ()
    {	
		startTrip = false;
	}
	
	void Update ()
    {
		if (Input.GetKey("space"))
        {
		    Application.LoadLevel(1);
		}		
	}

	/*void OnGUI ()
    {
	    GUI.skin = customSkin;
	    GUI.Label (new Rect (200, 400,200,200), "Space to start.");
	    GUI.Label (new Rect (750, 400,200,200), "Space to start.");
	}*/
}