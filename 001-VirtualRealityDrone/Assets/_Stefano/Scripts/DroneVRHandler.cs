using UnityEngine;

public class DroneVRHandler : MonoBehaviour
{
    public Transform target;
    private float speed = 1.5f;
    private float step;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        transform.LookAt(target);

        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "barrels" && target != hit.transform)
            {
                target = hit.transform;
            }
        }

        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            speed *= 2;
            if (speed > 6)
                speed = 1.5f;
        }
    }
}
