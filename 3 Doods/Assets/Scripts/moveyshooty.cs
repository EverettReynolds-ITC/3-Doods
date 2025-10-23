using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class moveyshooty : MonoBehaviour
{
    public bool shootable = false;
    public LogicScript logic;
    public GameObject exploderPrefab;
    private GameObject tokill = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse position in world space
        Vector3 crosshairPos = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
        crosshairPos.z = -1;
        transform.position = crosshairPos;
        if (UnityEngine.Input.GetMouseButtonDown(0) && shootable)
        {
            Instantiate(exploderPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            Destroy(tokill);
            logic.addScore(1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Evil Bird")
        {
            shootable = true;
            tokill = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Evil Bird")
        {
            shootable = false;
            tokill = null;
        }
    }



}
