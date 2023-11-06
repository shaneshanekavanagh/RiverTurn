using UnityEngine;

public class leafoffset : MonoBehaviour {

    public static bool start = false;
	public static float timerer;
	public static bool startTime = false;

    public float scrollSpeed = 0.0084F;

    float offset = 0;

	void Start ()
    {
	    start = false;
		offset = 0;
		GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
	}
	
    void Update()
    {
		if(start == true)
        {
			offset = (Time.timeSinceLevelLoad - timerer) * scrollSpeed;
	        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(offset, 0));		
		}
    }
}