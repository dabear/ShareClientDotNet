using System;
using System.Linq;
using System.Text;

namespace ShareClientDotNet
{
    internal class DebuggableShareClient : ShareClient
    {
        private Action<string> debugger;

        public DebuggableShareClient(Action<string> handler = null)
        {
            this.enableDebug = true;
            if (handler != null)
            {
                this.debugger = handler;
            }
        }

        public DebuggableShareClient(string username, string password, ShareServer shareServer = ShareServer.ShareServerUS, Action<string> handler = null) : base(username, password, shareServer)
        {
            this.enableDebug = true;
            if (handler != null)
            {
                this.debugger = handler;
            }
        }

        public DebuggableShareClient(string username, string password, string url, Action<string> handler = null) : base(username, password, url)
        {
            this.enableDebug = true;
            if (handler != null)
            {
                this.debugger = handler;
            }
        }

        public DebuggableShareClient(string url, Action<string> handler = null) : base(url)
        {
            this.enableDebug = true;
            if (handler != null)
            {
                this.debugger = handler;
            }
        }

        protected override void WriteDebug(string msg)
        {
            if (this.debugger == null || !this.enableDebug)
            {
                base.WriteDebug(msg);
            }
            else
            {
                this.debugger(msg);
            }
        }
    }
}