using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject basketPrefab;
    public int numBaskets = 4;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    public Text roundGT;
    public Text gameOverGT;
    public string roundTxt = "Round ";
    public int round = 1;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        round = 1;
        GameObject roundGO = GameObject.Find("RoundCounter");

        roundGT = roundGO.GetComponent<Text>();
        roundGT.text = roundTxt + round.ToString();

        basketList = new List<GameObject>();

        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>( basketPrefab );
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + ( basketSpacingY * i );
            tBasketGO.transform.position = pos;
            basketList.Add( tBasketGO );
        }
    }

    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        GameObject[] bAppleArray = GameObject.FindGameObjectsWithTag("BadApple");
        GameObject[] gAppleArray = GameObject.FindGameObjectsWithTag("GoldenApple");

        foreach ( GameObject tGO in tAppleArray )
        {
            Destroy( tGO );
        }

<<<<<<< HEAD
<<<<<<< HEAD

=======
        foreach (GameObject bGO in bAppleArray)
        {
            Destroy(bGO);
        }

        foreach (GameObject gGO in gAppleArray)
        {
            Destroy(gGO);
        }

        
>>>>>>> parent of 45cb953... it won't let me revert till i commit
=======

>>>>>>> parent of 0f4b479... Completed bad apple score
        int basketIndex = basketList.Count - 1;

        if (basketIndex >= 1)
        {
            round += 1;
        }
        
        GameObject tBasketGO = basketList[basketIndex];
        basketList.RemoveAt( basketIndex );
        Destroy( tBasketGO );

        roundGT.text = roundTxt + round.ToString();

        if ( basketList.Count == 0 )
        {
            gameOver = true;
            SceneManager.LoadScene("GameOver");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
