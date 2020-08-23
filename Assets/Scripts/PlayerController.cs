using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;

    private int count;

    public GameObject particle;

    Vector3 _initialPos;
    Vector3 _currentPos;
    float _yOffset;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 12;
        SetCountText();
        winText.text = "";
        // Get y-axis offset
        _initialPos = transform.position;
        _yOffset = _initialPos.y - 10;
    }

    void Update()
    {
        // Get current y-axis position
        _currentPos = transform.position;
        // Detect if the Player is off the plane, and respawn Scene
        if (_currentPos.y < _yOffset)
        {
            SceneManager.LoadScene(0);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            GameObject p = Instantiate(particle, other.gameObject.transform.position, Quaternion.identity) as GameObject;

            other.gameObject.SetActive(false);
            count -= 1;
            SetCountText();

            Destroy(p, 1.5f);
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count == 0)
        {
            winText.text = "You win!";
        }
    }
}
