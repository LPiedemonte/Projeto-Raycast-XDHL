using UnityEngine;

public class RotacaoMouse1 : MonoBehaviour
{
    public float velocidade = 100f;
    
    float rotacaoX = 0f;
    float rotacaoY = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*float mouseX = Input.GetAxis("mouseX") * velocidade * Time.deltaTime;
        float mouseY = Input.GetAxis("mouseY") * velocidade * Time.deltaTime;

        rotacaoY += mouseX;
        rotacaoX -= mouseY;

        transform.rotation = Quaternion.Euler(rotacaoX, rotacaoY, 0);*/

        var v = Camera.main.ScreenPointToRay(Input.mousePosition).direction;

        this.transform.rotation = Quaternion.LookRotation(v);
    }
}
