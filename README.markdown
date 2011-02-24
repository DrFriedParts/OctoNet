.NET Client library for the Octopart API
Based on [DropNet](https://github.com/dkarzon/DropNet) for the [Dropbox](http://db.tt/4zFPRBA) API originated by Damien Karzon

<a href="http://dkdevelopment.net/">http://dkdevelopment.net/</a> //TODO - Update

Example usage:

	var dropNetclient = new DropNetClient("API_KEY", "API_SECRET");
 
	//call the functions you want from the client
	dropNetclient.Login("test@example.com", "password");

	var rootDetails = dropNetclient.GetMetaData();
	//rootDetails.Contents is a list of the files/folders in the root