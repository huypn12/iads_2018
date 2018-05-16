using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class new1 : MonoBehaviour {
    float mspeed;
	// Use this for initialization
	void Start () {
        mspeed = 1f;
	}
	
	// Update is called once per frame
	void Update () {

        /* if (Input.GetKey(KeyCode.UpArrow))
         {
             transform.Translate(Vector3.forward * Time.deltaTime*100);

         }
         */
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }
    }
}
public class CubeManager : MonoBehaviour, IInputClickHandler, IInputHandler
{
    public void OnInputClicked(InputClickedEventData eventData)
    {
         Debug.Log("Hello", gameObject);
    }
    public void OnInputDown(InputEventData eventData)
    {
        Debug.Log("Hello", gameObject);
    }
    public void OnInputUp(InputEventData eventData)
    {
        Debug.Log("Hello", gameObject);
    }
}

public class CubeAirtapActions : MonoBehaviour, IInputClickHandler
{
    #region IInputClickHandler
    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("Hello", gameObject);
    }
    #endregion IInputClickHandler
}


