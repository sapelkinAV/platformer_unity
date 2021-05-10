using UnityEngine;

namespace DefaultNamespace
{
    public class KillOnEnter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            var player = other.GetComponent<Player>();
            if (player == null)
            {
                return;
            }

            player.ResetToStart();

        }
    }
}