using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private int points = 0; // initial is always zero, duh
    private Rigidbody playerSphere;
    private string baseText = "Boxes Collected: ";
    private const string WIN_TEXT = "YOU WIN!";
    private const int MAX_SCORE = 12;
    private bool playerHasWon = false;

    public float speed;
    public Text pointsText;
    public Text winText;


    // Start is called before the first frame update
    void Start()
    {
        playerSphere = GetComponent<Rigidbody>();
        setPoints();
        winText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape") && playerHasWon)
        {
            Application.Quit();
        }
    }

    // Called just before any PHYSICS calculations
    private void FixedUpdate()
    {
        float displacementX = Input.GetAxis("Horizontal");
        float displacementY = Input.GetAxis("Vertical");

        playerSphere.AddForce(new Vector3(displacementX, 0f, displacementY) * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PICK_UP_FOR_POINTS"))
        {
            other.gameObject.SetActive(false);
            points++;
            setPoints();
        }
    }

    private void setPoints()
    {
        pointsText.text = baseText + points;
        checkScore();
    }

    private void checkScore()
    {
        if (points >= 12) {
            displayWinText();
        }
    }

    private void displayWinText()
    {
        winText.gameObject.SetActive(true);
        pointsText.gameObject.SetActive(false);
        playerHasWon = true;
    }
}
