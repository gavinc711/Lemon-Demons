using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{
	void Start()
	{
		
	}
	
    void OnTriggerEnter(Collider other)
    {
		if(other.tag == "Player")
        {
			GameObject.Find("JohnLemon").GetComponent<PlayerMovement>().EarnScore(1);
            Destroy(this.gameObject);
        }
    }
}
