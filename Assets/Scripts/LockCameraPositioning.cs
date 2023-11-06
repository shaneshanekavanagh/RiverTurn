using UnityEngine;

public class LockCameraPositioning : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        if (target != null)
        {
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
        }
    }
}
