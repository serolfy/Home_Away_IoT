# Home_Away_IoT
CPE 4020 Device Networks Final Project, developing a mock company and use case. 
See video of working system: https://youtu.be/ANFcwgPOi4w 

This was developed in Microsoft Visual Studio in C# .NET (4.6.1)
See Form1.cs for main code

**Summary of System:**

**Use-Case:** 
We manufacture and sell an end-to-end humidity sensor product. Any device can access our humidity sensor using our public Cloud API. Our main use-case is to sense the humidity in-doors. Any device can see the humidity of the room it is in by simply requesting our API. See Figure 1:

![Screen Shot 2020-10-25 at 2 57 25 AM](https://user-images.githubusercontent.com/63037678/97100805-db371a80-166d-11eb-9350-f75d9bbf2cee.png)

                  
Our server is running a C# Windows Forms application. In the app we have an interactive GUI with buttons along the side to start the broker, view the broker log (on/off), Option to Restart broker once it has started, stop broker once it has started, and configure the various settings of the broker such as IP addresses and Ports. Here is an example screenshot of the app running with View Log on:
 
![Screen Shot 2020-10-25 at 3 04 26 AM](https://user-images.githubusercontent.com/63037678/97100889-cdce6000-166e-11eb-9552-4fed0494c6e8.png)

Then partnering with other group companies we can provide value to our customers. 

With this ecosystem we implement our business logic is as follows:

Our business will be an away-from-home automation system. A subscriber can now request to be cooled off if the temperature is too high or it is too humid as well as turn off the fan. The subscriber can request an automation threshold to be satisfied for humidity and temperature. If the temperature or/and the humidity pass the threshold, the pressure will be logged and monitored to check for abnormalities as well as the fan will turn on to cool. If the door bell is rang, the ring will be logged and monitored. If motion is detected around the house or inside, the fan will kick on to circulate air as well as rid off any intruders. If the smoke detector goes off, the fan kicks in, the temperature and pressure are checked and emergency responders are called. And if there are vibrations detected, the fan is turned off, and all electronics are turned off. See connected ecosystem:

![Screen Shot 2020-10-25 at 3 07 02 AM](https://user-images.githubusercontent.com/63037678/97100929-2998e900-166f-11eb-8ec1-0a2bafc3781a.png)


**Pub/Sub Protocol:**

Our pub/sub RESTful API protocol is very simple by simply receiving subscriber API requests and processing them by asking the publisher over TCP to publish then reporting back the data to the API call, shown by Figure 4.

![Screen Shot 2020-10-25 at 3 10 57 AM](https://user-images.githubusercontent.com/63037678/97100977-b774d400-166f-11eb-8771-700f7d670016.png)


Implementing automation and polling all of the sensors at a rate of 1 Hz, the automation checks the sensors in comparison to the thresholds set forth by the user. As well, if the user desires to turn the fan on or off, they can request that.

![Screen Shot 2020-10-25 at 3 12 43 AM](https://user-images.githubusercontent.com/63037678/97101299-a1b4de00-1672-11eb-9f01-19d3522b6e77.png)


The following demonstrates the use case as an away-from-home monitoring system. It displays all reactive actions to environmental changes.

![Screen Shot 2020-10-25 at 3 19 03 AM](https://user-images.githubusercontent.com/63037678/97101165-72ea3800-1671-11eb-882e-f276fc981bdc.png)




**API Documentation:**


_API Reference_

The Humid Cloud API is organized around REST. Our API has predictable resource-oriented URLs, accepts form-encoded request bodies, returns JSON-encoded responses, and uses standard HTTP response codes, authentication, and verbs.
The Humid Cloud API differs for every account as we release new versions and tailor functionality. Log in to see data customized to your version of the API, with your API GET and POST calls.
Subscribe to Humid Cloud's API mailing list for updates.
  
_API Request Reference_

The following details the request manners to begin integrating Humid Cloud.
To Request Data:
/api/humidity - Reads humidity value.
Returns Humidity as:
{
humidity: "XX.XX %"
}
	/api/humidity/notjson - Reads humidity value.
Returns Humidity as:
Humidity:XX.XX

_To Send Requests:_

/api/humidity?humidity_thresh=XX&temp_thresh=YY
- Sets an automatic humidity & temperature control with compatible IoT temperature sensor, IoT pressure sensor, and IoT fan. If temperature > XX or/and humidity > YY, then fan is turned on until temperature < XX and/or humidity < YY.

/api/humidity/fanon
- Sends request to turn on IoT fan when automation is in place.

/api/humidity/fanoff
- Sends request to turn off IoT fan when automation is in place.




**Security Measures:**

Our system includes very little security measures. Our sensor only works with our proprietary broker as the sensor awaits the keyword “return” which is customizable in the configuration settings. If any other word or number is sent to the sensor, it will return a value of “INVALID AUTH”. This keyword however, is completely exposed over a raw TCP connection and anybody could see the keyword over the air and it is even susceptible to replay attacks.

 However, we leave our API completely exposed because we assume that the user is behind their own Wi-Fi network. We assume confidentiality is maintained by the over the air traffic being encrypted by Wi-Fi. There isn't any authentication, and any device on our network can access the humidity sensor, or outside with port forwarding and the correct public IP/Port. 

Message integrity is not upheld, because the humidity is sent as a plaintext indent notation JSON string. The humidity could be altered, or the user defined threshold could be spoofed/changed from any device on the Wi-Fi network or even outside the network (given correct port forwarding is used). The network does however support mitigation to DoS attacks, as well the router secured with WPA3 SAE or WPAWPA2-PSK (TKIP/AES). Every process is single-threaded and accepts as many sockets as memory allows. 

However, given the connecting and sharing with other groups our data, many could not even parse through JSON, much less decrypt if we were to encrypt the information. In order to collaborate with them and be on the same page it is necessary for them to be able to see our data: upholding access and availability.






