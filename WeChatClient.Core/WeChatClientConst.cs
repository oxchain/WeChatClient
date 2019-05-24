﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChatClient
{
    public static class WeChatClientConst
    {
        #region Modules
        /// <summary>
        /// 登录模块
        /// </summary>
        //public const string LoginModuleName = "LoginModule";
        /// <summary>
        /// 主模块
        /// </summary>
        public const string MainModuleName = "MainModule";
        /// <summary>
        /// 聊天列表模块
        /// </summary>
        public const string ChatListModuleName = "ChatListModule";
        /// <summary>
        /// 联系人列表模块
        /// </summary>
        public const string ContactListModuleName = "ContactListModule";
        /// <summary>
        /// 聊天内容模块
        /// </summary>
        public const string ChatContentModuleName = "ChatContentModule";
        #endregion

        #region Regions
        /// <summary>
        /// 主程序区域
        /// </summary>
        public const string MainRegionName = "MainRegion";      
        /// <summary>
        /// 导航区域
        /// </summary>
        public const string NavRegionName = "NavRegion";
        /// <summary>
        /// 内容区域
        /// </summary>
        public const string ContentRegionName = "ContentRegion";
        #endregion
    }
}