using UnityEngine;
using System.Collections;

public class Dice : MonoBehaviour
{
    private Sprite[] DiceSides;
    private SpriteRenderer rend;
    private int whosTurn = 1;
    private bool coroutineAllowed = true;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        DiceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = DiceSides[5]; // Assuming you have 6 sides, change index if needed
    }

    private void OnMouseDown()
    {
        if (!GameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i < 20; i++) // changed comma to semicolon and corrected condition
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = DiceSides[randomDiceSide];
            yield return new WaitForSeconds(0.1f);
        }

        GameControl.diceSideThrown = randomDiceSide + 1;

        if (whosTurn == 1)
        {
            GameControl.MovePlayer(1);
        }
        else if (whosTurn == -1)
        {
            GameControl.MovePlayer(2);
        }
        whosTurn *= -1;
        coroutineAllowed = true;
    }
}

