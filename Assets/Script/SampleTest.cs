using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class SampleTest : MonoBehaviour
{
    public GameObject _gameJbject;
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
     _gameJbject=GetComponent<GameObject>();
     
     
    }

    // Update is called once per frame
    void Update()
    {
        pos = _gameJbject.transform.position;
        Debug.Log(pos);
    }
}
