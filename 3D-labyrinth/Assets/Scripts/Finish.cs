using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;

    private void Start()
    {
        winPanel.SetActive(false);
        Time.timeScale = 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Player>() != null && Keys.keysQuantity >= 3)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            winPanel.SetActive(true);
        }

    }
}
