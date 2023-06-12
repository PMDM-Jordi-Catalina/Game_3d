using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class InterfaceFinal : MonoBehaviour
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
        textThrown.text = "Número total de Frutas: " + GameManager.currentNumberStonesThrow;
        textDestroyed.text = "Puntuación: " + GameManager.currentNumberDestroyedStones;
        textBombs.text = "Número total de Bombas :" + GameManager.currentNumberBombs;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Awake");
    }
}
