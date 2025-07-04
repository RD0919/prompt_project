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
        //장소 : 교실1

        //교실 -> 복도1
        if (collision.gameObject.name == "Door (복도1)")
        {
            transform.position = new Vector3(13f, 0f, 0f);
            mainCamera.transform.position = new Vector3(20f, 0f, -10f);
        }
        //장소 : 복도1

        //복도1 -> 교실
        else if (collision.gameObject.name == "Door (2-2)")
        {
            transform.position = new Vector3(7f, 2f, 0f);
            mainCamera.transform.position = new Vector3(0f, 0f, -10f);
        }
        //복도1 -> 복도2
        else if (collision.gameObject.name == "Door (복도2)")
        {
            transform.position = new Vector3(33f, 2f, 0f);
            mainCamera.transform.position = new Vector3(40f, 0f, -10f);
        }
        //복도1 -> 교무실
        else if (collision.gameObject.name == "Door (교무실)")
        {
            transform.position = new Vector3(5f, 18f, 0f);
            mainCamera.transform.position = new Vector3(0f, 15f, -10f);
        }
        //장소 : 복도2

        //복도2 -> 복도1
        else if (collision.gameObject.name == "Door (복도1) 1")
        {
            transform.position = new Vector3(27f, 0f, 0f);
            mainCamera.transform.position = new Vector3(20f, 0f, -10f);
        }
        //복도2 -> 복도3
        else if (collision.gameObject.name == "Door (복도3)")
        {
            transform.position = new Vector3(26f, -15f, 0f);
            mainCamera.transform.position = new Vector3(20f, -15f, -10f);
        }
        //복도2 -> 2 - 3 교실
        else if (collision.gameObject.name == "Door (7)")
        {
            transform.position = new Vector3(27f, 16f, 0f);
            mainCamera.transform.position = new Vector3(20f, 15f, -10f);
        }
        // 장소 : 교무실

        //교무실 -> 복도1
        else if (collision.gameObject.name == "Door (복도1) 2")
        {
            transform.position = new Vector3(14f, 1.5f, 0f);
            mainCamera.transform.position = new Vector3(20f, 0f, -10f);
        }
        //장소 : 2 - 3 교실

        //복도2 -> 복도3
        else if (collision.gameObject.name == "Door (2-3) 1")
        {
            transform.position = new Vector3(27f, 16f, 0f);
            mainCamera.transform.position = new Vector3(20f, 15f, -10f);
        }
        //장소 : 복도3

        //복도3 -> 운동장
        else if (collision.gameObject.name == "Door (운동장)")
        {
            transform.position = new Vector3(6.5f, -15f, 0f);
            mainCamera.transform.position = new Vector3(0f, -15f, -10f);
        }
        //복도3 -> 2-4교실
        else if (collision.gameObject.name == "Door (2-4)")
        {
            transform.position = new Vector3(6.5f, -15f, 0f);
            mainCamera.transform.position = new Vector3(0f, -15f, -10f);
        }

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //플레이어 x 이동
        float xInput = Input.GetAxisRaw("Horizontal");
        //플레이어 y 이동
        float yInput = Input.GetAxisRaw("Vertical");
        Vector3 Move = new Vector3(xInput, yInput, 0f);
        transform.position += Move * moveSpeed * Time.deltaTime;
    }

}
