using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using YooAsset;
using Object = UnityEngine.Object;

namespace GameFrameX.Runtime
{
    /// <summary>
    /// 资源组件。
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Game Framework/Asset")]
    public sealed class AssetComponent : GameFrameworkComponent
    {
        public EPlayMode GamePlayMode;
        private AssetsPackage buildinPackage;
        public const string BuildInPackageName = "DefaultPackage";


        private InitializationOperation initializationOperation;
        private string _hostServer;
        public string StaticVersion { get; private set; }
        private IAssetManager _assetManager;

        protected override void Awake()
        {
            base.Awake();
            new AssetManager();
            _assetManager = GameFrameworkEntry.GetModule<IAssetManager>();
            if (_assetManager == null)
            {
                Log.Fatal("Asset manager is invalid.");
                return;
            }

            _assetManager.SetPlayMode(GamePlayMode);
        }

        public void UpdateStaticVersion(string version)
        {
            StaticVersion = version;
        }

        public async void Initialize(string host)
        {
            _hostServer = host;

            await _assetManager.Initialize(host);
        }


        #region 异步加载子资源对象

        /// <summary>
        /// 异步加载子资源对象
        /// </summary>
        /// <param name="assetInfo">资源信息</param>
        /// <returns></returns>
        public UniTask<SubAssetsOperationHandle> LoadSubAssetsAsync(AssetInfo assetInfo)
        {
            return _assetManager.LoadSubAssetsAsync(assetInfo);
        }

        /// <summary>
        /// 异步加载子资源对象
        /// </summary>
        /// <param name="path">资源路径</param>
        /// <param name="type"></param>
        /// <returns></returns>
        public UniTask<SubAssetsOperationHandle> LoadSubAssetsAsync(string path, Type type)
        {
            return _assetManager.LoadSubAssetsAsync(path, type);
        }

        /// <summary>
        /// 异步加载子资源对象
        /// </summary>
        /// <param name="path">资源路径</param>
        /// <returns></returns>
        public UniTask<SubAssetsOperationHandle> LoadSubAssetsAsync<T>(string path) where T : Object
        {
            return _assetManager.LoadSubAssetsAsync<T>(path);
        }

        #endregion

        #region 异步加载子资源对象

        /// <summary>
        /// 同步加载子资源对象
        /// </summary>
        /// <param name="assetInfo">资源信息</param>
        /// <returns></returns>
        public UniTask<SubAssetsOperationHandle> LoadSubAssetsSync(AssetInfo assetInfo)
        {
            return _assetManager.LoadSubAssetsAsync(assetInfo);
        }

        /// <summary>
        /// 同步加载子资源对象
        /// </summary>
        /// <param name="path">资源路径</param>
        /// <param name="type"></param>
        /// <returns></returns>
        public UniTask<SubAssetsOperationHandle> LoadSubAssetsSync(string path, Type type)
        {
            return _assetManager.LoadSubAssetsAsync(path, type);
        }

        /// <summary>
        /// 同步加载子资源对象
        /// </summary>
        /// <param name="path">资源路径</param>
        /// <returns></returns>
        public UniTask<SubAssetsOperationHandle> LoadSubAssetsSync<T>(string path) where T : Object
        {
            return _assetManager.LoadSubAssetsAsync<T>(path);
        }

        #endregion

        #region 异步加载原生文件

        /// <summary>
        /// 异步加载原生文件
        /// </summary>
        /// <param name="assetInfo">资源信息</param>
        /// <returns></returns>
        public UniTask<RawFileOperationHandle> LoadRawFileAsync(AssetInfo assetInfo)
        {
            return _assetManager.LoadRawFileAsync(assetInfo);
        }

        /// <summary>
        /// 异步加载原生文件
        /// </summary>
        /// <param name="path">资源路径</param>
        /// <returns></returns>
        public UniTask<RawFileOperationHandle> LoadRawFileAsync(string path)
        {
            return _assetManager.LoadRawFileAsync(path);
        }

        #endregion

        #region 同步加载原生文件

        /// <summary>
        /// 同步加载原生文件
        /// </summary>
        /// <param name="assetInfo">资源信息</param>
        /// <returns></returns>
        public RawFileOperationHandle LoadRawFileSync(AssetInfo assetInfo)
        {
            return _assetManager.LoadRawFileSync(assetInfo);
        }

        /// <summary>
        /// 同步加载原生文件
        /// </summary>
        /// <param name="path">资源路径</param>
        /// <returns></returns>
        public RawFileOperationHandle LoadRawFileSync(string path)
        {
            return _assetManager.LoadRawFileSync(path);
        }

        #endregion


        #region 异步加载资源

        /// <summary>
        /// 异步加载资源
        /// </summary>
        /// <param name="assetInfo">资源信息</param>
        /// <returns></returns>
        public UniTask<AssetOperationHandle> LoadAssetAsync(AssetInfo assetInfo)
        {
            return _assetManager.LoadAssetAsync(assetInfo);
        }

        /// <summary>
        /// 异步加载资源
        /// </summary>
        /// <param name="path">资源路径</param>
        /// <param name="type">资源类型</param>
        /// <returns></returns>
        public UniTask<AssetOperationHandle> LoadAssetAsync(string path, Type type)
        {
            return _assetManager.LoadAssetAsync(path, type);
        }

        /// <summary>
        /// 异步加载资源
        /// </summary>
        /// <param name="path">资源路径</param>
        /// <typeparam name="T">资源类型</typeparam>
        /// <returns></returns>
        public UniTask<AssetOperationHandle> LoadAssetAsync<T>(string path) where T : Object
        {
            return _assetManager.LoadAssetAsync<T>(path);
        }

        #endregion

        #region 同步加载资源

        /// <summary>
        /// 同步加载资源
        /// </summary>
        /// <param name="path">资源路径</param>
        /// <param name="type"></param>
        /// <returns></returns>
        public AssetOperationHandle LoadAssetSync(string path, Type type)
        {
            return _assetManager.LoadAssetSync(path, type);
        }

        /// <summary>
        /// 同步加载资源
        /// </summary>
        /// <param name="assetInfo">资源信息</param>
        /// <returns></returns>
        public AssetOperationHandle LoadAssetSync(AssetInfo assetInfo)
        {
            return _assetManager.LoadAssetSync(assetInfo);
        }

        /// <summary>
        /// 同步加载资源
        /// </summary>
        /// <param name="path">资源路径</param>
        /// <returns></returns>
        public AssetOperationHandle LoadAssetSync<T>(string path) where T : Object
        {
            return _assetManager.LoadAssetSync<T>(path);
        }

        #endregion

        #region 加载场景

        /// <summary>
        /// 异步加载场景
        /// </summary>
        /// <param name="path">资源路径</param>
        /// <param name="sceneMode">场景模式</param>
        /// <param name="activateOnLoad">是否加载完成自动激活</param>
        /// <returns></returns>
        public UniTask<SceneOperationHandle> LoadSceneAsync(string path, LoadSceneMode sceneMode, bool activateOnLoad = true)
        {
            return _assetManager.LoadSceneAsync(path, sceneMode, activateOnLoad);
        }

        /// <summary>
        /// 异步加载场景
        /// </summary>
        /// <param name="assetInfo">资源路径</param>
        /// <param name="sceneMode">场景模式</param>
        /// <param name="activateOnLoad">是否加载完成自动激活</param>
        /// <returns></returns>
        public UniTask<SceneOperationHandle> LoadSceneAsync(AssetInfo assetInfo, LoadSceneMode sceneMode, bool activateOnLoad = true)
        {
            return _assetManager.LoadSceneAsync(assetInfo, sceneMode, activateOnLoad);
        }

        #endregion

        #region 资源包

        /// <summary>
        /// 创建资源包
        /// </summary>
        /// <param name="packageName">资源包名称</param>
        /// <returns></returns>
        public AssetsPackage CreateAssetsPackage(string packageName)
        {
            return _assetManager.CreateAssetsPackage(packageName);
        }

        /// <summary>
        /// 尝试获取资源包
        /// </summary>
        /// <param name="packageName">资源包名称</param>
        /// <returns></returns>
        public AssetsPackage TryGetAssetsPackage(string packageName)
        {
            return _assetManager.TryGetAssetsPackage(packageName);
        }

        /// <summary>
        /// 检查资源包是否存在
        /// </summary>
        /// <param name="packageName">资源包名称</param>
        /// <returns></returns>
        public bool HasAssetsPackage(string packageName)
        {
            return _assetManager.HasAssetsPackage(packageName);
        }

        /// <summary>
        /// 获取资源包
        /// </summary>
        /// <param name="packageName">资源包名称</param>
        /// <returns></returns>
        public AssetsPackage GetAssetsPackage(string packageName)
        {
            return _assetManager.GetAssetsPackage(packageName);
        }

        #endregion

        /// <summary>
        /// 是否需要下载
        /// </summary>
        /// <param name="assetInfo">资源信息</param>
        /// <returns></returns>
        public bool IsNeedDownload(AssetInfo assetInfo)
        {
            return _assetManager.IsNeedDownload(assetInfo);
        }

        /// <summary>
        /// 是否需要下载
        /// </summary>
        /// <param name="path">资源地址</param>
        /// <returns></returns>
        public bool IsNeedDownload(string path)
        {
            return _assetManager.IsNeedDownload(path);
        }

        /// <summary>
        /// 获取资源信息
        /// </summary>
        /// <param name="assetTags">资源标签列表</param>
        /// <returns></returns>
        public AssetInfo[] GetAssetInfos(string[] assetTags)
        {
            return _assetManager.GetAssetInfos(assetTags);
        }

        /// <summary>
        /// 获取资源信息
        /// </summary>
        /// <param name="assetTag">资源标签</param>
        /// <returns></returns>
        public AssetInfo[] GetAssetInfos(string assetTag)
        {
            return _assetManager.GetAssetInfos(assetTag);
        }

        /// <summary>
        /// 获取资源信息
        /// </summary>
        public AssetInfo GetAssetInfo(string path)
        {
            return _assetManager.GetAssetInfo(path);
        }

        /// <summary>
        /// 获取缓存目录根路径
        /// </summary>
        /// <returns></returns>
        public string GetCacheRootPath()
        {
            return _assetManager.GetCacheRootPath();
        }

        /// <summary>
        /// 清空缓存
        /// </summary>
        public void ClearCache()
        {
            _assetManager.ClearCache();
        }

        /// <summary>
        /// 设置默认资源包
        /// </summary>
        /// <param name="assetsPackage">资源信息</param>
        /// <returns></returns>
        public void SetDefaultAssetsPackage(AssetsPackage assetsPackage)
        {
            _assetManager.SetDefaultAssetsPackage(assetsPackage);
        }

        /// <summary>
        /// 销毁资源
        /// </summary>
        private void OnDestroy()
        {
            _assetManager.OnDestroy();
        }
    }
}