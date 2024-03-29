using UnityEngine;
using UnityEngine.UI; 

public class GameControl : MonoBehaviour
{
    private static GameObject whoWinsText1, whoWinsText2, player1MoveText, player2MoveText;
    private static GameObject player1, player2;
    private static GameObject Ak, AkA, A, En, EnA, Bi, BiA, Na, NaA, Sk, SkA, Ec, EcA, Gs, GsA;
    

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;
    

    public static bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        whoWinsText1 = GameObject.Find("whoWinsText1");
        whoWinsText2 = GameObject.Find("whoWinsText2");
        player1MoveText = GameObject.Find("Player1MoveText");
        player2MoveText = GameObject.Find("Player2MoveText");

        Ak = GameObject.Find("Ak");
        AkA = GameObject.Find("AkA");
        A = GameObject.Find("A");
        En = GameObject.Find("En");
        EnA = GameObject.Find("EnA");
        Bi = GameObject.Find("Bi");
        BiA = GameObject.Find("BiA");
        Na = GameObject.Find("Na");
        NaA = GameObject.Find("NaA");
        Sk = GameObject.Find("Sk");
        SkA = GameObject.Find("SkA");
        Ec = GameObject.Find("Ec");
        EcA = GameObject.Find("EcA");
        Gs = GameObject.Find("Gs");
        GsA = GameObject.Find("GsA");

        Ak.gameObject.SetActive(false);
        AkA.gameObject.SetActive(false);
        A.gameObject.SetActive(false);
        En.gameObject.SetActive(false);
        EnA.gameObject.SetActive(false);
        Bi.gameObject.SetActive(false);
        BiA.gameObject.SetActive(false);
        Na.gameObject.SetActive(false);
        NaA.gameObject.SetActive(false);
        Sk.gameObject.SetActive(false);
        SkA.gameObject.SetActive(false);
        Ec.gameObject.SetActive(false);
        EcA.gameObject.SetActive(false);
        Gs.gameObject.SetActive(false);
        GsA.gameObject.SetActive(false);

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;

        whoWinsText1.gameObject.SetActive(false);
        whoWinsText2.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (player1.GetComponent<FollowThePath>().waypointIndex > player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex > player2StartWaypoint + diceSideThrown)
        {
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsText1.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);

            gameOver = true;

        }

        if (player2.GetComponent<FollowThePath>().waypointIndex == player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsText2.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);

            gameOver = true;

        }

        if (player1StartWaypoint == 9)
        {
            En.gameObject.SetActive(true);
            EnA.gameObject.SetActive(true);
            A.gameObject.SetActive(true);

        }

        if (player2StartWaypoint == 9)
        {
            En.gameObject.SetActive(true);
            EnA.gameObject.SetActive(true);
            A.gameObject.SetActive(true);
        }

        if (player1StartWaypoint == 11)
        {
            Bi.gameObject.SetActive(true);
            BiA.gameObject.SetActive(true);
            A.gameObject.SetActive(true);
        }

        if (player2StartWaypoint == 11)
        {
            Bi.gameObject.SetActive(true);
            BiA.gameObject.SetActive(true);
            A.gameObject.SetActive(true);
        }

        if (player1StartWaypoint == 14)
        {
            Na.gameObject.SetActive(true);
            NaA.gameObject.SetActive(true);
            A.gameObject.SetActive(true);
        }

        if (player2StartWaypoint == 14)
        {
            Na.gameObject.SetActive(true);
            NaA.gameObject.SetActive(true);
            A.gameObject.SetActive(true);
        }

        if (player1StartWaypoint == 4)
        {
            Ak.gameObject.SetActive(true);
            AkA.gameObject.SetActive(true);
            A.gameObject.SetActive(true);

        }

        if (player2StartWaypoint == 4)
        {
            Ak.gameObject.SetActive(true);
            AkA.gameObject.SetActive(true);
            A.gameObject.SetActive(true);
        }

        if (player1StartWaypoint == 21)
        {
            Ec.gameObject.SetActive(true);
            EcA.gameObject.SetActive(true);
            A.gameObject.SetActive(true);

        }

        if (player2StartWaypoint == 21)
        {
            Ec.gameObject.SetActive(true);
            EcA.gameObject.SetActive(true);
            A.gameObject.SetActive(true);
        }

        if (player1StartWaypoint == 12)
        {
            Sk.gameObject.SetActive(true);
            SkA.gameObject.SetActive(true);
            A.gameObject.SetActive(true);

        }

        if (player2StartWaypoint == 12)
        {
            Sk.gameObject.SetActive(true);
            SkA.gameObject.SetActive(true);
            A.gameObject.SetActive(true);
        }
    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove)
        {
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }
}
