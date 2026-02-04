using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float speed = 0.01f;

    Vector2 bottomLeft;
    Vector2 topRight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        //move the square
        Vector3 newPosition = transform.position;
        newPosition.x += speed * Time.deltaTime;

        //check if the square is at the edge of the screen
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        
        //test for the left edge
        if (screenPos.x < 0)
        {
            //set our position to be the world space position under pixel 0 in X

            newPosition.x = bottomLeft.x;
            //Y: multiply the speed by -1
            speed = speed * -1;
        }

        //test for the right edge
        if (screenPos.x > Screen.width)
        {
            //set our position to be the world space position under pixel Screen.width in X
            newPosition.x = topRight.x;
            //Y: multiply the speed by -1
            speed = speed * -1;
        }

        transform.position = newPosition;
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
