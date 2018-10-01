using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pollo : MonoBehaviour {
    private Rigidbody rb;
    [SerializeField] int fuerza = 400;
    [SerializeField] Transform pospies;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	private void Awake()
    {

    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            Collider[] cols = Physics.OverlapSphere(pospies.position, 0.1f, LayerMask.NameToLayer("Terrain"));

            for(int i=0; i< cols.Length; i++)
            {
                Debug.Log("Estoy tocando con los pies en algo:" + i);
            }
            rb.AddForce(new Vector3 (1, 1, 0) * fuerza);//se mueve delante
            
        }
        else if (Input.GetKeyDown("l"))
        {

            
            rb.AddForce(new Vector3(0, 1, 1) * fuerza);//se mueve lateralIzq
        }
        else if (Input.GetKeyDown("i"))
        {


            rb.AddForce(new Vector3(-1, 1, 0) * fuerza);//se mueve atras
        }
        else if (Input.GetKeyDown("j"))
        {


            rb.AddForce(new Vector3(0, 1, -1) * fuerza);//se mueve lateralDer
        }
    }
}
