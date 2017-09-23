using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Web.WebSockets;
using System.Web;


namespace Mod13_03.Controllers
{
    //3, WebSocket服務
    // GET: ws://.../api/Chat?username=xxx
    public class ChatController : ApiController
    {
        //4, 收到連線要求
        public HttpResponseMessage Get(string username)
        {
            //5, 建立負責處理連線的WebSocketHandler物件
            HttpContext.Current.AcceptWebSocketRequest(new ChatWebSocketHandler(username));
            return Request.CreateResponse(HttpStatusCode.SwitchingProtocols);
        }
        class ChatWebSocketHandler : WebSocketHandler
        {
            //使用者暱稱
            private string _username;
            //聊天室集合
            private static WebSocketCollection _chatClients = new WebSocketCollection();

            //6, 透過WebSocketHandler的建構函式存放使用者暱稱
            public ChatWebSocketHandler(string username)
            {
                _username = username;
            }

            //7, 連線後把WebSocketHandler物件放入聊天室集合
            public override void OnOpen()
            {
                _chatClients.Add(this);
            }

            //8, 收到進入聊天室的訊息，廣播給整個聊天室集合的人
            //11, 收到聊天室聊天的訊息，廣播給整個聊天室集合的人
            public override void OnMessage(string message)
            {
                _chatClients.Broadcast(_username + ": " + message);
            }
        }

    }
}
