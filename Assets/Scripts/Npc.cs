using UnityEngine;

public class Npc:MonoBehaviour
{
    public GameObject npcUI;


    private void CreateNPC()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            npcUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            npcUI.SetActive(false);
        }
    }
}