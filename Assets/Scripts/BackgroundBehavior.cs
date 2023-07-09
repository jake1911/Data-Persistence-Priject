using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class BackgroundBehavior : MonoBehaviour
{
    public GameObject background;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(BackgroundFloat());
        float y = transform.position.y;
        if (y > 10f)
        {
            MovementUp();
        }
        else if (y < -10f)
        {
            MovementDown();
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*float y = transform.position.y;
        if (y > 10f)
        {
            MovementUp();
        }
        else if (y < -10f)
        {
            MovementDown();
        }*/
    }
    IEnumerator BackgroundFloat()
    {
        while (true)
        {
            MovementUp();
            yield return new WaitForSeconds(3f);
            MovementDown();
            yield return new WaitForSeconds(3f);
        }
    }
    public void MovementUp()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.up);
    }
    public void MovementDown()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.down);
    }
        
}
