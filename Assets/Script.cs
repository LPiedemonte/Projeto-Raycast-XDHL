using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Script : MonoBehaviour
{
    /*Ray ray;
    RaycastHit hitData;
    Vector3 point;
    Color color;*/
    public Camera _camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.transform.gameObject.CompareTag("Alvo"))
            {
                
            }
            Debug.DrawRay(transform.position, transform.forward * 9, Color.purple);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.forward * 9, Color.red);
        }
    }
    /*private void Lancar(Ray ray, Color color, int tipo)
    {
        Debug.Log("Origem: " + ray.origin);

        Debug.Log("Direção: " + ray.direction);

        if(Physics.Raycast(ray, out hitData))
        {
            Vector3 hitPosition = hitData.point;
            Debug.Log("hitPosition:" + hitPosition);

            float hitDistance = hitData.distance;
            Debug.Log("Distancia:" + hitDistance);
            string tag = hitData.collider.tag;
            Debug.Log("tag:" + tag);
            GameObject hitObject = hitData.transform.gameObject;
            Debug.DrawRay(ray.origin, hitPosition * hitDistance, Color.purple);
            
            if (tag =="Alvo")
                Destroy(hitObject);
        }
        else
        {
            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.white);
            Debug.Log("errou alvo");
        }
    }*/
}
   