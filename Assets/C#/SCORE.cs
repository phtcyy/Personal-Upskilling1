using UnityEngine;
using TMPro;

public class SCORE : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        // Calculate the distance between the GameManager and the player
        float distance = Mathf.Abs(player.position.z - transform.position.z);

        // Convert the distance to a string and update the text
        scoreText.text = distance.ToString("0");
    }
}