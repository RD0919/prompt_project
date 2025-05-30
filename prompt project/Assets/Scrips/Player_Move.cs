using UnityEngine;
using UnityEngine.EventSystems;

public class Player_Move : MonoBehaviour
{
    //캐릭터 속력
    [SerializeField]
    private float moveSpeed;
    public Camera mainCamera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //교실 -> 복도
        if (collision.gameObject.name == "Door (1)")
        {
            transform.position = new Vector3(12f, 3f, 0f);
            mainCamera.transform.position = new Vector3(20f, 0f, -10f);
        }
        //복도 -> 교실
        else if (collision.gameObject.name == "Door (2)")
        {
            transform.position = new Vector3(7.5f, 3f, 0f);
            mainCamera.transform.position = new Vector3(0f, 0f, -10f);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");
        Vector3 Move = new Vector3(xInput, yInput, 0f);
        transform.position += Move * moveSpeed * Time.deltaTime;
    }

}
