using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace ProjectBroker
{
    public partial class Form1 : Form
    {
        /* Networking and Security Variables/ Redirect to SecurityHandler*/
        //string password = "KeyMustBe16ByteOR24ByteOR32Byte!";
        //private SecurityHandler _security;
        string SensorIP = "";
        Int32 SensorPort;
        IPAddress Addr;          //LAN IP address in my environment = 10.2.1.82 
        Int32 CloudPort;
        WebServer ws;

        /*Logistical initializers: humidity, button action, and wait handle created*/
        string sensorhum = null;
        private Button currentButton;
        static EventWaitHandle _waitHandle = new AutoResetEvent(false);

        public class SensorData                                //Sensor Data Object for JSON notation.
        {
            public string Humidity { get; set; }

        }

        public Form1()
        {
            InitializeComponent();                             
            gui = this;
            //_security = new SecurityHandler();//SECURITY HANDLER REDIRECT COMMENTED


        }

        public static Form1 gui;                   //public static handler for printing to log

        public void WriteLog(string log)
        {
            this.Invoke(new Action(() => { textLog.AppendText(Environment.NewLine + log); }));

        }
        public void CheckBox(int number, bool on)
        {
            this.Invoke(new Action(() => { checkedListBox1.SetItemChecked(number, on); }));

        }




        /*
         *       THE FOLLOWING IS THE METHOD FOR COMMUNICATING VIA TCP TO THE SENSOR AND RETURNING 
         *       VALUES FROM IT. IT IS THE RESPONSE HANDLER FROM THE REQUEST TO API. 
         * 
         */
        public string SendResponse(HttpListenerRequest request)
        {
            //IF THE RESPONSE IS VALID, IT WILL RETURN JSON OBJECT WITH HUMIDITY, OTHERWISE, INVALID AUTH
            bool validResponse = false;
            SensorIP = textBoxSensorIP.Text;
            SensorPort = Convert.ToInt32(textBoxSensorPort.Text);

            if (request.RawUrl.ToString() == "/")
            {
                /* Not authorized to view the root resource.*/
                return ("You do not have permission to view this resource.");
            }
            else if (request.RawUrl.ToString() == "/api/humidity")
            {
                return GetHum();
            }
            else
                return ("Page doesn't exist.");


            string GetHum ()
            {
                try
                {
                    //SENDS KEYWORD MESSAGE OVER TCP TO THE PUBLISHER. SecKey MESSAGE IS CONFIGURABLE IN CONFIG 
                    //PAGE. IT THEN RECEIVES THE RESPONSE FROM THE PUBLISHER AND VERIFIES IF THE KEY WAS ACCEPTED
                    //OR NOT. 
                    string message = textBoxSecKey.Text;
                    //string encryptedMessage = _security.Encrypt(message, password);
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                    TcpClient loginclient = new TcpClient(SensorIP, SensorPort);
                    NetworkStream stream = loginclient.GetStream();
                    stream.Write(data, 0, data.Length);
                    Form1.gui.WriteLog("Sent Request To Publisher: ");
                    data = new Byte[256];
                    String responseData = String.Empty;
                    Int32 bytes = stream.Read(data, 0, data.Length);
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    Console.WriteLine(responseData);

                    if (responseData == "INVALID")
                    {
                        validResponse = false;
                        Form1.gui.WriteLog(Environment.NewLine + "!FROM PUBLISHER: INVALID REQUEST AUTH!");
                    }
                    else
                    {
                        validResponse = true;
                        sensorhum = responseData;
                        Form1.gui.WriteLog(Environment.NewLine + "!FROM PUBLISHER: " + responseData);
                    }
                    stream.Close();
                    loginclient.Close();
                }

                catch (ArgumentNullException ee)
                {
                    Console.WriteLine("ArgumentNullException: {0}", ee);
                }
                catch (SocketException ee)
                {
                    Console.WriteLine(ee.ToString());
                }


                //IF THE SecKey IS VALID, THE PUBLISHER WILL RETURN THE DESIRED VALUE, OTHERWISE, 
                //THE MESSAGE RESPONSE WILL BE INVALID AUTH
                if (validResponse == true)
                {
                    SensorData sensordata = new SensorData();
                    sensordata.Humidity = sensorhum + " %";
                    var settings = new JsonSerializerSettings { Converters = { new ReplacingStringWritingConverter("\n", "") } };
                    string jsonresponse = JsonConvert.SerializeObject(sensordata, Formatting.Indented, settings);
                    return jsonresponse;
                }
                else
                {
                    SensorData sensordata = new SensorData();
                    sensordata.Humidity = "INVALID AUTH";
                    string jsonresponse = JsonConvert.SerializeObject(sensordata, Formatting.Indented);
                    return jsonresponse;
                }
            }

        }


        /****************************************************************
         * THE FOLLOWING ARE BUTTON CONFIGS FOR THE UI OF THE APPLICATION. 
         * THIS INCLUDES WHAT IS RAN IF EACH BUTTON IS CLICKED AS WELL AS 
         * THE GRAPHICAL CHANGES OF THE BUTTON.
         * ***************************************************************/
        private void buttonStart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            StartServer();
            buttonStop.Enabled = true;
            buttonRestart.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            StopServer();
            buttonRestart.Enabled = false;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        { 
            StopServer();
            new Thread(Waiter).Start();
            Thread.Sleep(1000);                  // Pause for a second...
            _waitHandle.Set();                    // Wake up the Waiter.
            StartServer();
            DisableButton();
        }
        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (textLog.Visible == false)
            {
                textLog.Visible = true;
                Color color = Color.FromArgb(0, 150, 136);
                buttonLog.BackColor = color;
                buttonLog.ForeColor = Color.White;
                buttonLog.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

            else if (textLog.Visible == true)
            {
                textLog.Visible = false;
                buttonLog.BackColor = Color.FromArgb(51, 51, 76);
                buttonLog.ForeColor = Color.Gainsboro;
                buttonLog.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panelConfig.Visible = true;
            buttonConfig.Enabled = false;
        }
        private void buttonExitConfig_Click(object sender, EventArgs e)
        {
            panelConfig.Visible = false;
            buttonConfig.Enabled = true;
            DisableButton();
        }
        /*******************************************************************/


        /*******************************************************************
         * THE FOLLOWING IS THE START SERVER FUNCTION WHICH INITIALIZES THE 
         * WEBSERVER INSTANCES FOR THE API AS WELL AS UPDATES THE UI AND LOG
         * ACCORDINGLY.
         * ******************************************************************/
        public void StartServer()
        {
            Addr = IPAddress.Parse(textBoxCloudIP.Text.ToString());          //LAN IP address in my house = 10.2.1.82 
            CloudPort = Convert.ToInt32(textBoxCloudPort.Text); 
            ws = new WebServer(SendResponse, "http://" + Addr + ":" + CloudPort + "/api/humidity/");

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            checkedListBox1.SetItemChecked(0, true);
            checkedListBox1.SetItemChecked(1, true);
            ws.Run();
            textLog.AppendText(Environment.NewLine + "!Broker is Running!");
        }

        /*******************************************************************
         * THE FOLLOWING IS THE STOP SERVER FUNCTION WHICH CLOSES THE 
         * WEBSERVER INSTANCES FOR THE API AS WELL AS UPDATES THE UI AND LOG
         * ACCORDINGLY.
         * ******************************************************************/
        public void StopServer()
        {

            checkedListBox1.SetItemChecked(0, false);
            checkedListBox1.SetItemChecked(1, false);
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            ws.Stop();
            textLog.AppendText(Environment.NewLine + "!Broker Stopped!");
        }


        /*******************************************************************
         * THE FOLLOWING IS CONFIGURATION SETTINGS FOR THE NEWTONSOFT JSON 
         * AS WE ARE USING JSON.NET. WE WERE HAVING THE ISSUE OF "/n" SHOWING 
         * UP IN OUR JSON OBJECT WHEN SERIALIZING THE OBJECT AND THESES ARE 
         * SETTINGS REFERENCED ABOVE IN JSON SERIALIZER WHICH  CORRECT ISSUE.
         * ******************************************************************/
        public class ReplacingStringWritingConverter : JsonConverter
        {
            readonly string oldValue;
            readonly string newValue;

            public ReplacingStringWritingConverter(string oldValue, string newValue)
            {
                if (string.IsNullOrEmpty(oldValue))
                    throw new ArgumentException("string.IsNullOrEmpty(oldValue)");
                this.oldValue = oldValue;
                this.newValue = newValue ?? throw new ArgumentNullException("newValue");
            }

            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(string);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }

            public override bool CanRead { get { return false; } }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                var s = ((string)value).Replace(oldValue, newValue);
                writer.WriteValue(s);
            }
        }


        /*******************************************************************
         * THE FOLLOWING IS THE WEBSERVER CLASS WHICH IS USED TO CREATE THE 
         * WEBSERVER FACILITATING THE API. IT IS INITIATED WHENEVER A NEW 
         * WEBSERVER CALL IS CALLED UPON FROM THE ESTABLISHED WEBSERVERS NAMED
         * ABOVE AND INITIALUIZED IN THE START BUTTON FUNCTION. CODE SOURCED 
         * FROM WINDOWS C# ONLINE LIBRARIES. 
         * ******************************************************************/
        public class WebServer
        {
            private readonly HttpListener _listener = new HttpListener();
            private readonly Func<HttpListenerRequest, string> _responderMethod;

            public WebServer(IReadOnlyCollection<string> prefixes, Func<HttpListenerRequest, string> method)
            {
                if (!HttpListener.IsSupported)
                {
                    throw new NotSupportedException("Needs Windows XP SP2, Server 2003 or later.");
                }

                // URI prefixes are required eg: "http://localhost:8080/test/"
                if (prefixes == null || prefixes.Count == 0)
                {
                    throw new ArgumentException("URI prefixes are required");
                }

                if (method == null)
                {
                    throw new ArgumentException("responder method required");
                }

                foreach (var s in prefixes)
                {
                    _listener.Prefixes.Add(s);
                }

                _responderMethod = method;
                _listener.Start();
            }

            public WebServer(Func<HttpListenerRequest, string> method, params string[] prefixes)
               : this(prefixes, method)
            {
            }

            //RUNS THE WEBSERVER
            public void Run()
            {
                ThreadPool.QueueUserWorkItem(o =>
                {
                    Console.WriteLine("Webserver running...");
                    try
                    {
                        while (_listener.IsListening)
                        {
                            ThreadPool.QueueUserWorkItem(c =>
                            {
                                var ctx = c as HttpListenerContext;
                                try
                                {
                                    if (ctx == null)
                                    {
                                        return;
                                    }
                                    /* WHEN THE API IS CALLED, IT  POSTS IN LOG WHAT THE SUBSCRIBER REQUESTED,
                                     * OBTAINS RESOURCE AND RESPONDS WITH RESOURCE REQUESTED.*/
                                    Form1.gui.WriteLog("Subscriber Connected From: " + ctx.Request.RemoteEndPoint.ToString());
                                    Form1.gui.WriteLog("Subscriber Requested: " + ctx.Request.RawUrl);
                                    var rstr = _responderMethod(ctx.Request);
                                    Form1.gui.WriteLog("Sent to Subscriber: " + rstr);
                                    var buf = Encoding.UTF8.GetBytes(rstr);
                                    ctx.Response.ContentLength64 = buf.Length;
                                    ctx.Response.OutputStream.Write(buf, 0, buf.Length);
                                    Form1.gui.CheckBox(2, true);
                                    Form1.gui.CheckBox(3, true);
                                }
                                catch
                                {
                                    // ignored
                                }
                                finally
                                {
                                    // always close the stream
                                    if (ctx != null)
                                    {
                                        ctx.Response.OutputStream.Close();
                                    }
                                }
                            }, _listener.GetContext());
                        }
                    }
                    catch (Exception ex)
                    {
                        // ignored
                    }
                });
            }

            //Stop function for Stop Button Handler
            public void Stop()
            {
                _listener.Stop();
                _listener.Close();
            }

        }

        //Wait function which safely sleep thread for when restarting broker.
        static void Waiter()
        {
            Console.WriteLine("Waiting...");
            _waitHandle.WaitOne();                // Wait for notification
            Console.WriteLine("Notified");
        }

        /*******************************************************************
         * THE FOLLOWING ARE MY UI METHODS FOR CHANGING THE COLORS OF THE 
         * BUTTONS WHEN PRESSED. (ACTIVATE WHEN PRESSED AND DISABLE WHEN 
         * ANOTHER BUTTON IS PRESSED AND CURRENT BUTTON IS NOT ACTIVE. 
         * EXCEPTION FOR LOG BUTTON WHICH HAS ITS OWN UI CHANGES WITHIN THE 
         * BUTTON CLICK HANDLE.
         * ******************************************************************/
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(0, 150, 136);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls) 
            {
                if (previousBtn == buttonLog) continue;
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

    }

}
