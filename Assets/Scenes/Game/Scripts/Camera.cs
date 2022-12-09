using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject _gameObject;
    private float x = 0, z = 0;
    public float xR = 0, zR = 0;
    public float angl = 0;
    public float angll = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_gameObject.transform.position.z != z || _gameObject.transform.position.x != x)
        {
            zR = (_gameObject.transform.position.z - z)*100;
            z = _gameObject.transform.position.z;
            xR = (_gameObject.transform.position.x - x)*100;
            x = _gameObject.transform.position.x;
        }
        angl = (360 / Mathf.PI) * Mathf.Atan2(xR,zR);

        

        if (transform.rotation.y < angl)
        {
             angll = angl - (360 / Mathf.PI) * transform.rotation.y;
        }
        else
        {
            angll =(360 / Mathf.PI) * transform.rotation.y - angl;

        }
        angll = (( 180 ) * transform.rotation.y) - angl;
        //angll = transform.rotation.y;

        transform.RotateAroundLocal(new Vector3(0, 1, 0), -angll * 0.001f);

        transform.position = _gameObject.transform.position;
    }
}
