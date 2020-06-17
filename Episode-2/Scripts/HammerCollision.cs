using UnityEngine;

public class HammerCollision : MonoBehaviour
{
    #region Variables
    #endregion

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Mole"))
        {
            Destroy(other.gameObject);
        }
    }
}
