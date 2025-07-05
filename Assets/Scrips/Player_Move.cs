using UnityEngine;
using UnityEngine.EventSystems;

public class Player_Move : MonoBehaviour
{
    //캐릭터 속력
    [SerializeField]
    private float moveSpeed;
    public Camera mainCamera;
    SpriteRenderer renderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //-------------------------장소 : 교실1-------------------------

        //교실 -> 복도1
        if (collision.gameObject.name == "Door (복도1)")
        {
            transform.position = new Vector3(13f, 0f, 0f);
            mainCamera.transform.position = new Vector3(20f, 0f, -10f);
        }
        //-------------------------장소 : 복도1-------------------------

        //복도1 -> 교실
        if (collision.gameObject.name == "Door (2-2)")
        {
            transform.position = new Vector3(7f, 2f, 0f);
            mainCamera.transform.position = new Vector3(0f, 0f, -10f);
        }
        //복도1 -> 복도2
        if (collision.gameObject.name == "Door (복도2)")
        {
            transform.position = new Vector3(33f, 2f, 0f);
            mainCamera.transform.position = new Vector3(40f, 0f, -10f);
        }
        //복도1 -> 교무실
        if (collision.gameObject.name == "Door (교무실)")
        {
            transform.position = new Vector3(5f, 18f, 0f);
            mainCamera.transform.position = new Vector3(0f, 15f, -10f);
        }
        //-------------------------장소 : 복도2-------------------------

        //복도2 -> 복도1
        if (collision.gameObject.name == "Door (복도1) 1")
        {
            transform.position = new Vector3(27f, 0f, 0f);
            mainCamera.transform.position = new Vector3(20f, 0f, -10f);
        }
        //복도2 -> 복도3
        if (collision.gameObject.name == "Door (복도3)")
        {
            transform.position = new Vector3(26f, -15f, 0f);
            mainCamera.transform.position = new Vector3(20f, -15f, -10f);
        }
        //복도2 -> 2 - 3 교실
        if (collision.gameObject.name == "Door (2-3)")
        {
            transform.position = new Vector3(27f, 16f, 0f);
            mainCamera.transform.position = new Vector3(20f, 15f, -10f);
        }
        // -------------------------장소 : 교무실-------------------------

        //교무실 -> 복도1
        if (collision.gameObject.name == "Door (복도1) 2")
        {
            transform.position = new Vector3(14f, 1.5f, 0f);
            mainCamera.transform.position = new Vector3(20f, 0f, -10f);
        }
        //장소 : 2 - 3 교실

        //복도2 -> 복도3
        if (collision.gameObject.name == "Door (2-3) 1")
        {
            transform.position = new Vector3(21f, 1.5f, 0f);
            mainCamera.transform.position = new Vector3(20f, 0f, -10f);
        }
        // -------------------------장소 : 복도3-------------------------

        //복도3 -> 운동장
        if (collision.gameObject.name == "Door (운동장)")
        {
            transform.position = new Vector3(6.5f, -15f, 0f);
            mainCamera.transform.position = new Vector3(0f, -15f, -10f);
        }
        //복도3 -> 2-4교실
        if (collision.gameObject.name == "Door (2-4)")
        {
            transform.position = new Vector3(27f, -28f, 0f);
            mainCamera.transform.position = new Vector3(20f, -30f, -10f);
        }
        //복도3 -> 2-5교실
        if (collision.gameObject.name == "Door (2-5)")
        {
            transform.position = new Vector3(7.5f, -28f, 0f);
            mainCamera.transform.position = new Vector3(0f, -30f, -10f);
        }
        //복도3 -> 복도2
        if (collision.gameObject.name == "Door (복도2) 1")
        {
            transform.position = new Vector3(33f, -3f, 0f);
            mainCamera.transform.position = new Vector3(40f, 0f, -10f);
        }
        // -------------------------장소 : 운동장-------------------------

        //운동장 -> 복도3
        if (collision.gameObject.name == "Door (복도3) 1")
        {
            transform.position = new Vector3(13f, -15f, 0f);
            mainCamera.transform.position = new Vector3(20f, -15f, -10f);
        }
        //운동장 -> 교문
        if (collision.gameObject.name == "Door (교문)")
        {
            transform.position = new Vector3(-13f, -15f, 0f);
            mainCamera.transform.position = new Vector3(-20f, -15f, -10f);
        }
        // -------------------------장소 : 2-4교실-------------------------

        //2-4교실 -> 복도3
        if (collision.gameObject.name == "Door (복도3) 2")
        {
            transform.position = new Vector3(21f, -14f, 0f);
            mainCamera.transform.position = new Vector3(20f, -15f, -10f);
        }
        // -------------------------장소 : 2-5교실-------------------------

        //2-5교실 -> 복도3
        if (collision.gameObject.name == "Door (복도3) 3")
        {
            transform.position = new Vector3(14f, -14f, 0f);
            mainCamera.transform.position = new Vector3(20f, -15f, -10f);
        }
        // -------------------------장소 : 교문-------------------------

        if (collision.gameObject.name == "Door (운동장) 1")
        {
            transform.position = new Vector3(-6.5f, -15f, 0f);
            mainCamera.transform.position = new Vector3(0f, -15f, -10f);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>(); // 스프라이트 렌더러 컴포넌트 받아옴
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
        //오른쪽 화살표 누르면 오른쪽 봄
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            renderer.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            renderer.flipX = false;
        }
    }

}
