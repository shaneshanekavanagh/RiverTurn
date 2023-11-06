using UnityEngine;

public class FogColour : MonoBehaviour {
     
	public static bool startBool = false;

	public Color color0;
    public Color color1;
	public Color color2;
	public Color color3;
	public Color color4;

	private float t1Param = 0.0f;
	private float t2Param = 0.0f;
	private float t3Param = 0.0f;
	private float t4Param = 0.0f;

	private float timer1 = 0.0f;
	private float timer2 = 0.0f;
	private float timer3 = 0.0f;
	private float timer4 = 0.0f;

    private float duration = 0.0333F;

    private bool change1 = false;
	private bool change2 = false;
	private bool change3 = false;
	private bool change4 = false;


	void Start(){
		startBool = false;

		t1Param = 0;
		t2Param = 0;
		t3Param = 0;
		t4Param = 0;

		change1 = false;
		change2 = false;
		change3 = false;
		change4 = false;

		RenderSettings.fogColor = color0;
	}

	void Update()
    {
		if(startBool == true)
        {

			if (t1Param < 1)
            {
				t1Param += Time.deltaTime * duration; //This will increment tParam based on Time.deltaTime multiplied by a speed multiplier
				timer1 = Mathf.Lerp(0, 1, t1Param);
			}
			RenderSettings.fogColor = Color.Lerp(color0, color1, timer1);

			if(RenderSettings.fogColor == color1)
            {
				change1 = true;
				startBool = false;
			}
		}

		if(change1 == true)
        {			
			if (t2Param < 1)
            {				
				t2Param += Time.deltaTime * duration; //This will increment tParam based on Time.deltaTime multiplied by a speed multiplier
				timer2 = Mathf.Lerp(0, 1, t2Param);
			}	
			RenderSettings.fogColor = Color.Lerp(color1, color2, timer2);
				
			if(RenderSettings.fogColor == color2)
            {
				change2 = true;
				change1 = false;
			}
		}

		if(change2 == true)
        {			
			if (t3Param < 1)
            {				
				t3Param += Time.deltaTime * duration; //This will increment tParam based on Time.deltaTime multiplied by a speed multiplier
				timer3 = Mathf.Lerp(0, 1, t3Param);
			}	
			RenderSettings.fogColor = Color.Lerp(color2, color3, timer3);
				
			if(RenderSettings.fogColor == color3)
            {
				change3 = true;
				change2 = false;
			}
		}

		if(change3 == true)
        {			
			if (t4Param < 1)
            {				
				t4Param += Time.deltaTime * duration; //This will increment tParam based on Time.deltaTime multiplied by a speed multiplier
				timer4 = Mathf.Lerp(0, 1, t4Param);
			}
			RenderSettings.fogColor = Color.Lerp(color3, color4, timer4);
				
			if(RenderSettings.fogColor == color4)
            {
				change4 = true;
				change3 = false;
			}
		}
	}
}