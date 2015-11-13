using UnityEngine;
using System.Collections;

public class IA : MonoBehaviour {

    public float speed;
    public Transform FPSController;
    public float minDis;
    public float maxDis;
    private bool mostrar = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if ((Vector3.Distance(transform.position,FPSController.position) < maxDis) && (Vector3.Distance(transform.position, FPSController.position) > minDis))
        transform.position = Vector3.Lerp(transform.position, FPSController.position, Time.deltaTime * speed);

        if (Vector3.Distance(transform.position, FPSController.position) <= (minDis + 1))
            mostrar = true;
           
	
	}

    void OnGUI()
    {
        if (mostrar)
            if (GUI.Button(new Rect(10, 10, 150, 100), "Morreu"))
                mostrar = false; ;
    }
}
