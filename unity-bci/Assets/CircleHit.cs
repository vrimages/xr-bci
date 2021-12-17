using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleHit : MonoBehaviour
{
    public AudioSource audio;
    public GameObject ring;
    private Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("CenterEyeAnchor").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider ball){
        audio.Play();
        Vector3 pos = new Vector3(Random.Range(-10.0f, 10.0f), 1.5f, Random.Range(-10.0f, 10.0f));
        GameObject newRing = Instantiate(ring, pos, Quaternion.LookRotation(pos - cam.position, Vector3.forward));
        //newRing.transform.rotation = Quaternion.Euler(0, 0, -90);
        //newRing.transform.Rotate(0,0,-90);
        newRing.transform.eulerAngles = new Vector3(newRing.transform.eulerAngles.x, newRing.transform.eulerAngles.y-90f, -90f);
        //Destroy(this.transform.gameObject);
        this.GetComponent<MeshRenderer>().enabled = false;
    }
}
