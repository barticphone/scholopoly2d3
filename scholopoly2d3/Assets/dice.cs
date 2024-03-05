using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice : MonoBehaviour
{
    private Sprite[] DiceSides;
    private Spriterenderer rend;
    private int whosTurn = 1;
    private bool coroutineAllowed = true;


    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        DiceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = DiceSides[5];
    }

    private void OnMouseDown()
    {
        if (!GameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice")
    }

    private IEnumerato RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20, i++)
        {
            randomDiceSide = randomDiceSide.Range(0, 6);
            rend.sprite = DiceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }
    }

    GameControl.DiceSideThrown = randomDiceSide + 1;
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
