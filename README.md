# AsseBundle_3D

This project demonstrates loading of GameObjects from external storage to a unity app. 

## Workflow
- **Build AssetBundles:** Create AssetBundles in the Editor using the Assets in your Scene. 
- **Upload AssetBundles to external storage:** Use an FTP client to upload your AssetBundles to the server of your choice. At run time, the application will load AssetBundles as needed.
- **Download AssetBundles at run time from your application:** This is done from script within a Unity Scene, and AssetBundles are loaded from the server on demand.
- **Load GameObjects from AssetBundles:** Once the AssetBundle is downloaded, you may want to access its individual Assets.
