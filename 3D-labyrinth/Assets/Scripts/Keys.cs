using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour
{
    [SerializeField] GameObject particles;
    public static int keysQuantity;
    public Text keysText;

    private void Awake()
    {
        keysText = GameObject.Find("KeysText").GetComponent<Text>();
        keysQuantity = 0;
    }

    private void UpdateKeysText()
    {
        if (keysText != null)
            keysText.text = "Keys: " + keysQuantity + "/3"; 
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent <Player>() != null)
        {
            keysQuantity++;
            UpdateKeysText();
            Instantiate(particles, gameObject.transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
