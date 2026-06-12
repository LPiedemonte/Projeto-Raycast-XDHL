using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Script : MonoBehaviour
{
    Ray ray;
    RaycastHit hitData;
    Vector3 point;
    Color color;
    public LayerMask hitMask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetMouseButton(0)){
            Targetray();
        }
    }

    void Targetray(){
        Ray ray = amera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.foward, out hit)){
            if(hit.transform.gameObject.CompareTag("Alvo")){
                Debug.DrawRay(transform.position, transform.foward * 9, Color.yellow, 0.5f);
                Debug.Log(hit.transform.gameObject.name);
            }
            else{
                Debug.DrawRay(transform.position, transform.foward * 9, Color.blue, 0.5f);
                Debug.Log(hit.transform.gameObject.name);
            }
        }
        else{
            Debug.DrawRay(transform.position, transform.foward * 9, Color.purple, 0.5f);
        }
    }
    
}
   