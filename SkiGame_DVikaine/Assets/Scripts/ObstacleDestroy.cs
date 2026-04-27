using UnityEngine;

public class ObstacleDestroy : Obstacle
{
 internal override void onCollision(Collision collision)
  {
   base. onCollision(collision);
   Destroy(gameObject);
  }
}
