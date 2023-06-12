using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour
{
    private const float yDie = -30.0f;

    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yDie)
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    void OnMouseDown()
    {
        if (gameObject.tag == "Point")
        {
            GameManager.currentNumberDestroyedStones++;
        }
        else if (gameObject.tag == "Bomba")
        {
            GameManager.currentNumberDestroyedStones--;
        }
        else
        {
            GameManager.currentNumberDestroyedStones = GameManager.currentNumberDestroyedStones - 2;
        }
        Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 2.0f);

        Destroy(gameObject);

    }
}
