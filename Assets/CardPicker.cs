using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPicker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] cardArr;
    public int index;
    void Start()
    {
        cardArr[0].SetActive(true);
    }

    // Update is called once per frame
    async void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            index = Mathf.Min(index + 1, cardArr.Length - 1); // Increment index, but ensure it stays within bounds
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            index = Mathf.Max(index - 1, 0); // Decrement index, but ensure it stays within bounds
        }

        // Deactivate all elements in cardArr
        foreach (var card in cardArr)
        {
            if (card != null) // Check for null before accessing properties
            {
                card.SetActive(false);
            }
        }

        // Activate the element at the updated index
        if (cardArr[index] != null)
        {
            cardArr[index].SetActive(true);
        }


    }
}
