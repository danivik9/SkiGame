using UnityEngine;

public class Obstacle : MonoBehaviour
{
   public delegate void playerHitAction();
   public static event playerHitAction onPlayerHit;
   private void OnCollisionEnter(Collision collision)
   {
      onCollision(collision);
   }
   internal virtual void onCollision(Collision collision)
   {
      if (collision.collider.tag.Equals("Player"))
      {
         Debug.Log("player collided with" + name);
      }
   }
}
