using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [Header("Room Backgrounds (13)")]
    public Sprite[] roomBackgrounds = new Sprite[13];

    [Header("Ending Backgrounds (13)")]
    public Sprite[] endingBackgrounds = new Sprite[13];

    [Header("UI Components")]
    public Image displayImage;
    public Text messageText;

    private int currentRoom = 0;
    private bool showingEnding = false;

    void Start()
    {
        if (displayImage == null)
        {
            Debug.LogError("Display Image not assigned");
            enabled = false;
            return;
        }

        if (roomBackgrounds.Length > 0)
        {
            displayImage.sprite = roomBackgrounds[0];
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Next();
        }
    }

    private void Next()
    {
        if (!showingEnding)
        {
            // Show ending for the current room
            if (currentRoom < endingBackgrounds.Length)
            {
                displayImage.sprite = endingBackgrounds[currentRoom];
            }

            if (messageText != null)
            {
                messageText.text = $"Ending {currentRoom + 1}";
            }

            showingEnding = true;
        }
        else
        {
            currentRoom++;
            if (currentRoom >= roomBackgrounds.Length)
            {
                if (messageText != null)
                {
                    messageText.text = "Thanks for playing!";
                }
                return;
            }

            // Load next room
            if (currentRoom < roomBackgrounds.Length)
            {
                displayImage.sprite = roomBackgrounds[currentRoom];
            }

            if (messageText != null)
            {
                messageText.text = string.Empty;
            }

            showingEnding = false;
        }
    }
}

