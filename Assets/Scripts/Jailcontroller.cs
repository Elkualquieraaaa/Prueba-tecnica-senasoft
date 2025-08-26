using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Jailcontroller : MonoBehaviour
{
    Transform jail;
    [SerializeField] GameObject obj;
    Collider[] list;
    float radius;
    public bool isinposition;
    [SerializeField] LayerMask layer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jail = GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {

        list = Physics.OverlapSphere(jail.position, radius, layer);
        if (jail.position.y >=17)
        {
            obj.SetActive(true);
            isinposition = true;
        }
    }

    public void Falljail()
    {
        obj.SetActive(false);
    }

    public void Resetjail()
    {
            jail.transform.Translate(jail.up);
    }
}
