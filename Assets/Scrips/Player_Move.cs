using UnityEngine;
using UnityEngine.EventSystems;

public class Player_Move : MonoBehaviour
{
    //ĳ���� �ӷ�
    [SerializeField]
    private float moveSpeed;
    public Camera mainCamera;
    SpriteRenderer renderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //-------------------------��� : ����1-------------------------

        //���� -> ����1
        if (collision.gameObject.name == "Door (����1)")
        {
            transform.position = new Vector3(13f, 0f, 0f);
            mainCamera.transform.position = new Vector3(20f, 0f, -10f);
        }
        //-------------------------��� : ����1-------------------------

        //����1 -> ����
        if (collision.gameObject.name == "Door (2-2)")
        {
            transform.position = new Vector3(7f, 2f, 0f);
            mainCamera.transform.position = new Vector3(0f, 0f, -10f);
        }
        //����1 -> ����2
        if (collision.gameObject.name == "Door (����2)")
        {
            transform.position = new Vector3(33f, 2f, 0f);
            mainCamera.transform.position = new Vector3(40f, 0f, -10f);
        }
        //����1 -> ������
        if (collision.gameObject.name == "Door (������)")
        {
            transform.position = new Vector3(5f, 18f, 0f);
            mainCamera.transform.position = new Vector3(0f, 15f, -10f);
        }
        //-------------------------��� : ����2-------------------------

        //����2 -> ����1
        if (collision.gameObject.name == "Door (����1) 1")
        {
            transform.position = new Vector3(27f, 0f, 0f);
            mainCamera.transform.position = new Vector3(20f, 0f, -10f);
        }
        //����2 -> ����3
        if (collision.gameObject.name == "Door (����3)")
        {
            transform.position = new Vector3(26f, -15f, 0f);
            mainCamera.transform.position = new Vector3(20f, -15f, -10f);
        }
        //����2 -> 2 - 3 ����
        if (collision.gameObject.name == "Door (2-3)")
        {
            transform.position = new Vector3(27f, 16f, 0f);
            mainCamera.transform.position = new Vector3(20f, 15f, -10f);
        }
        // -------------------------��� : ������-------------------------

        //������ -> ����1
        if (collision.gameObject.name == "Door (����1) 2")
        {
            transform.position = new Vector3(14f, 1.5f, 0f);
            mainCamera.transform.position = new Vector3(20f, 0f, -10f);
        }
        //��� : 2 - 3 ����

        //����2 -> ����3
        if (collision.gameObject.name == "Door (2-3) 1")
        {
            transform.position = new Vector3(21f, 1.5f, 0f);
            mainCamera.transform.position = new Vector3(20f, 0f, -10f);
        }
        // -------------------------��� : ����3-------------------------

        //����3 -> ���
        if (collision.gameObject.name == "Door (���)")
        {
            transform.position = new Vector3(6.5f, -15f, 0f);
            mainCamera.transform.position = new Vector3(0f, -15f, -10f);
        }
        //����3 -> 2-4����
        if (collision.gameObject.name == "Door (2-4)")
        {
            transform.position = new Vector3(27f, -28f, 0f);
            mainCamera.transform.position = new Vector3(20f, -30f, -10f);
        }
        //����3 -> 2-5����
        if (collision.gameObject.name == "Door (2-5)")
        {
            transform.position = new Vector3(7.5f, -28f, 0f);
            mainCamera.transform.position = new Vector3(0f, -30f, -10f);
        }
        //����3 -> ����2
        if (collision.gameObject.name == "Door (����2) 1")
        {
            transform.position = new Vector3(33f, -3f, 0f);
            mainCamera.transform.position = new Vector3(40f, 0f, -10f);
        }
        // -------------------------��� : ���-------------------------

        //��� -> ����3
        if (collision.gameObject.name == "Door (����3) 1")
        {
            transform.position = new Vector3(13f, -15f, 0f);
            mainCamera.transform.position = new Vector3(20f, -15f, -10f);
        }
        //��� -> ����
        if (collision.gameObject.name == "Door (����)")
        {
            transform.position = new Vector3(-13f, -15f, 0f);
            mainCamera.transform.position = new Vector3(-20f, -15f, -10f);
        }
        // -------------------------��� : 2-4����-------------------------

        //2-4���� -> ����3
        if (collision.gameObject.name == "Door (����3) 2")
        {
            transform.position = new Vector3(21f, -14f, 0f);
            mainCamera.transform.position = new Vector3(20f, -15f, -10f);
        }
        // -------------------------��� : 2-5����-------------------------

        //2-5���� -> ����3
        if (collision.gameObject.name == "Door (����3) 3")
        {
            transform.position = new Vector3(14f, -14f, 0f);
            mainCamera.transform.position = new Vector3(20f, -15f, -10f);
        }
        // -------------------------��� : ����-------------------------

        if (collision.gameObject.name == "Door (���) 1")
        {
            transform.position = new Vector3(-6.5f, -15f, 0f);
            mainCamera.transform.position = new Vector3(0f, -15f, -10f);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>(); // ��������Ʈ ������ ������Ʈ �޾ƿ�
    }

    // Update is called once per frame
    void Update()
    {
        //�÷��̾� x �̵�
        float xInput = Input.GetAxisRaw("Horizontal");
        //�÷��̾� y �̵�
        float yInput = Input.GetAxisRaw("Vertical");
        Vector3 Move = new Vector3(xInput, yInput, 0f);
        transform.position += Move * moveSpeed * Time.deltaTime;
        //������ ȭ��ǥ ������ ������ ��
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
