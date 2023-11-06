using UnityEngine;

public class triggerscript : MonoBehaviour {

    public GameObject StartFairy;

    void OnTriggerStay(Collider other) {
	
		if(other.GetComponent<Collider>().gameObject.tag=="LineOf")
        {
            if (StartFairy != null)
            {
                StartFairy.GetComponent<fairy>().HitStart();
            }

			AnimationTrigger.startTrip = true;
			leafoffset.timerer = Time.timeSinceLevelLoad;
			leafoffset.start = true;
			LightColour.startBool = true;
			FogColour.startBool = true;
			AmbColour.startBool = true;

			Destroy (gameObject);
		
		}
	}
}
