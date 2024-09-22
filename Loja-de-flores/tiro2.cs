ShootRaycast();

void ShootRaycast(){

    RaycastHit hitInfor;
    if(Physiscs.Raycast(camera.Transform.position, camera.GetForwardDirection(), out hitInfor, Mathf.infinity,layerMask.GetMask("hittable"))) {

        IShotHit hitted = hitInfor.transform.GatComponet<ShootHit>();
        if(hitted != null) {
            hitted.Hit(camera.GatForwardDirection());
        }
    }
}