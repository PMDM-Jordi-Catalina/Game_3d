using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceStone : MonoBehaviour
{
    public Text textThrown;
    public Text textDestroyed;

    public Text textBombs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textThrown.text = "Numero De Frutas: " + GameManager.currentNumberStonesThrow;
        textBombs.text = "Numero De Bombas: " + GameManager.currentNumberBombs;
        textDestroyed.text = "Puntuación: " + GameManager.currentNumberDestroyedStones;
    }
}
