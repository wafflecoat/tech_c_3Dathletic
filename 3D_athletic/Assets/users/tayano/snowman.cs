public class snowman : MonoBehaviour
{
    int counter = 0;
    float move = 0.01f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = new Vector3(0, 0, move);
        transform.Translate(p);
        counter++;

        if (counter == 1000)
        {
            counter = 0;
            move *= -1;
        }
    }
}