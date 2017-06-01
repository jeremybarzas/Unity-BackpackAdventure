using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void Update()
    {
        CharacterMove();
        DropItemFromBackpack();
    }

    private void CharacterMove()
    {
        var speed = 5.0f;
        if (Input.GetKey(KeyCode.LeftShift))
            speed *= 2;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }

    private void DropItemFromBackpack()
    {
        var bp = GetComponent<BackpackBehaviour>();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (bp.backpackRuntime.contents.Count == 0)
            {
                Debug.Log("The backpack is empty.");
                return;
            }
            var item = bp.backpackRuntime.contents[bp.backpackRuntime.contents.Count - 1];
            bp.RemoveItem(item);
        }
    }
}