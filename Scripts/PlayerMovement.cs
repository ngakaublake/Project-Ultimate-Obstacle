using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        #region movement
        if (Input.GetKey("w"))
        {            
            rb.AddForce(-1000 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(1000 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, 1000 * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -1000 * Time.deltaTime);
        }
        #endregion
    
    if (rb.position.y < -1f)
    {
        FindObjectOfType<GameManager>().EndGame();
    }
    }
}
