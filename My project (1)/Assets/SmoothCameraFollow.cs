using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
   private Vector3 _offset;
   [SerializerField] private Transform target; 
   [SerializeField] private float smoothTime;

   private void Awake()
   {
    _offset = transform.position - target.position;
   }

   private void LateUpdate()
   {
    Vector3 targetPosition = target.position + _offset;
    transform.position = Vector3.SmoothDamp(current:transform.position, targetPosition, ref _currentVelocity, smoothTime);
   }

}
