﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WX_Tools
{

    /// <summary>
    /// 订阅与取消订阅事件（关注 取消关注 ）
    /// </summary>
   public class subscribe_unsubscribe
    {

        /*
         * 推送XML数据包示例：

            <xml>
            <ToUserName><![CDATA[toUser]]></ToUserName>
            <FromUserName><![CDATA[FromUser]]></FromUserName>
            <CreateTime>123456789</CreateTime>
            <MsgType><![CDATA[event]]></MsgType>
            <Event><![CDATA[subscribe]]></Event>
            </xml>

         * 
         * 
         * 参数 	描述
        ToUserName 	开发者微信号
        FromUserName 	发送方帐号（一个OpenID）
        CreateTime 	消息创建时间 （整型）
        MsgType 	消息类型，event
        Event 	事件类型，subscribe(订阅)、unsubscribe(取消订阅) 
         */




    }
}
