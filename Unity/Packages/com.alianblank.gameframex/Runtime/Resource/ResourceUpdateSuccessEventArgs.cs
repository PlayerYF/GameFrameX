﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFrameX;
using GameFrameX.Event;

namespace GameFrameX.Runtime
{
    /// <summary>
    /// 资源更新成功事件。
    /// </summary>
    public sealed class ResourceUpdateSuccessEventArgs : GameEventArgs
    {
        /// <summary>
        /// 资源更新成功事件编号。
        /// </summary>
        public static readonly string EventId = typeof(ResourceUpdateSuccessEventArgs).FullName;

        /// <summary>
        /// 初始化资源更新成功事件的新实例。
        /// </summary>
        public ResourceUpdateSuccessEventArgs()
        {
            Name = null;
            DownloadPath = null;
            DownloadUri = null;
            Length = 0;
            CompressedLength = 0;
        }

        /// <summary>
        /// 获取资源更新成功事件编号。
        /// </summary>
        public override string Id
        {
            get
            {
                return EventId;
            }
        }

        /// <summary>
        /// 获取资源名称。
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取资源下载后存放路径。
        /// </summary>
        public string DownloadPath
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取下载地址。
        /// </summary>
        public string DownloadUri
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取资源大小。
        /// </summary>
        public int Length
        {
            get;
            private set;
        }

        /// <summary>
        /// 获取压缩后大小。
        /// </summary>
        public int CompressedLength
        {
            get;
            private set;
        }

        /// <summary>
        /// 创建资源更新成功事件。
        /// </summary>
        /// <param name="e">内部事件。</param>
        /// <returns>创建的资源更新成功事件。</returns>
        public static ResourceUpdateSuccessEventArgs Create(GameFrameX.Resource.ResourceUpdateSuccessEventArgs e)
        {
            ResourceUpdateSuccessEventArgs resourceUpdateSuccessEventArgs = ReferencePool.Acquire<ResourceUpdateSuccessEventArgs>();
            resourceUpdateSuccessEventArgs.Name = e.Name;
            resourceUpdateSuccessEventArgs.DownloadPath = e.DownloadPath;
            resourceUpdateSuccessEventArgs.DownloadUri = e.DownloadUri;
            resourceUpdateSuccessEventArgs.Length = e.Length;
            resourceUpdateSuccessEventArgs.CompressedLength = e.CompressedLength;
            return resourceUpdateSuccessEventArgs;
        }

        /// <summary>
        /// 清理资源更新成功事件。
        /// </summary>
        public override void Clear()
        {
            Name = null;
            DownloadPath = null;
            DownloadUri = null;
            Length = 0;
            CompressedLength = 0;
        }
    }
}