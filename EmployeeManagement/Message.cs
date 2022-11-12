using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    public class Message
    {
        public String content;
        public String owner;
        public String shortinfo;
        public String state;
        public String messageID;

        public Message(String content,String owner,String shortinfo,String state,String messageID)
        {
            this.owner = owner;
            this.shortinfo = shortinfo;
            this.state = state;
            this.messageID = messageID;
            this.content = content;
        }

        public void setState(String state)
        {
            this.state = state;
        }

    }
}
