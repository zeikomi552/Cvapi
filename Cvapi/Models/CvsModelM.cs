﻿using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using static Cvapi.Models.Civitai.Models.CvsModelM.CvsModelVersions;

namespace Cvapi.Models.Civitai.Models
{
    public class CvsModelM : CvBaseModel
    {
        #region Inner Class

        #region CvsCreator
        /// <summary>
        /// Creator
        /// </summary>
        public class CvsCreator : CvBaseModel
        {
            #region The name of the creator[Username]プロパティ
            /// <summary>
            /// The name of the creator[Username]プロパティ用変数
            /// </summary>
            string _Username = string.Empty;
            /// <summary>
            /// The name of the creator[Username]プロパティ
            /// </summary>
            [JsonPropertyName("username")]
            public string Username
            {
                get
                {
                    return _Username;
                }
                set
                {
                    if (_Username == null || !_Username.Equals(value))
                    {
                        _Username = value;
                        RaisePropertyChanged("Username");
                    }
                }
            }
            #endregion

            #region The url of the creators avatar[Image]プロパティ
            /// <summary>
            /// The url of the creators avatar[Image]プロパティ用変数
            /// </summary>
            string? _Image = null;
            /// <summary>
            /// The url of the creators avatar[Image]プロパティ
            /// </summary>
            [JsonPropertyName("image")]
            public string? Image
            {
                get
                {
                    return _Image;
                }
                set
                {
                    if (_Image == null || !_Image.Equals(value))
                    {
                        _Image = value;
                        RaisePropertyChanged("Image");
                    }
                }
            }
            #endregion
        }
        #endregion

        #region Stats
        /// <summary>
        /// Stats
        /// </summary>
        public class CvsStats1 : CvBaseModel
        {
            #region The number of downloads the model has[DownloadCount]プロパティ
            /// <summary>
            /// The number of downloads the model has[DownloadCount]プロパティ用変数
            /// </summary>
            int _DownloadCount = 0;
            /// <summary>
            /// The number of downloads the model has[DownloadCount]プロパティ
            /// </summary>
            [JsonPropertyName("downloadCount")]
            public int DownloadCount
            {
                get
                {
                    return _DownloadCount;
                }
                set
                {
                    if (!_DownloadCount.Equals(value))
                    {
                        _DownloadCount = value;
                        RaisePropertyChanged("DownloadCount");
                    }
                }
            }
            #endregion

            #region The number of favorites the model has[FavoriteCount]プロパティ
            /// <summary>
            /// The number of favorites the model has[FavoriteCount]プロパティ用変数
            /// </summary>
            int _FavoriteCount = 0;
            /// <summary>
            /// The number of favorites the model has[FavoriteCount]プロパティ
            /// </summary>
            [JsonPropertyName("favoriteCount")]
            public int FavoriteCount
            {
                get
                {
                    return _FavoriteCount;
                }
                set
                {
                    if (!_FavoriteCount.Equals(value))
                    {
                        _FavoriteCount = value;
                        RaisePropertyChanged("FavoriteCount");
                    }
                }
            }
            #endregion

            #region The number of comments the model has[CommentCount]プロパティ
            /// <summary>
            /// The number of comments the model has[CommentCount]プロパティ用変数
            /// </summary>
            int _CommentCount = 0;
            /// <summary>
            /// The number of comments the model has[CommentCount]プロパティ
            /// </summary>
            [JsonPropertyName("commentCount")]
            public int CommentCount
            {
                get
                {
                    return _CommentCount;
                }
                set
                {
                    if (!_CommentCount.Equals(value))
                    {
                        _CommentCount = value;
                        RaisePropertyChanged("CommentCount");
                    }
                }
            }
            #endregion

            #region The number of ratings the model has[RatingCount]プロパティ
            /// <summary>
            /// The number of ratings the model has[RatingCount]プロパティ用変数
            /// </summary>
            int _RatingCount = 0;
            /// <summary>
            /// The number of ratings the model has[RatingCount]プロパティ
            /// </summary>
            [JsonPropertyName("ratingCount")]
            public int RatingCount
            {
                get
                {
                    return _RatingCount;
                }
                set
                {
                    if (!_RatingCount.Equals(value))
                    {
                        _RatingCount = value;
                        RaisePropertyChanged("RatingCount");
                    }
                }
            }
            #endregion

            #region The average rating of the model[Rating]プロパティ
            /// <summary>
            /// The average rating of the model[Rating]プロパティ用変数
            /// </summary>
            double _Rating = 0.0;
            /// <summary>
            /// The average rating of the model[Rating]プロパティ
            /// </summary>
            [JsonPropertyName("rating")]
            public double Rating
            {
                get
                {
                    return _Rating;
                }
                set
                {
                    if (!_Rating.Equals(value))
                    {
                        _Rating = value;
                        RaisePropertyChanged("Rating");
                    }
                }
            }
            #endregion
            #region thumbsUpCount
            /// <summary>
            /// thumbsUpCount
            /// </summary>
            int _ThumbsUpCount = 0;
            /// <summary>
            /// thumbsUpCount
            /// </summary>
            [JsonPropertyName("thumbsUpCount")]
            public int ThumbsUpCount
            {
                get
                {
                    return _ThumbsUpCount;
                }
                set
                {
                    if (!_ThumbsUpCount.Equals(value))
                    {
                        _ThumbsUpCount = value;
                        RaisePropertyChanged("ThumbsUpCount");
                    }
                }
            }
            #endregion

            #region thumbsUpCount
            /// <summary>
            /// thumbsUpCount
            /// </summary>
            int _ThumbsDownCount = 0;
            /// <summary>
            /// thumbsUpCount
            /// </summary>
            [JsonPropertyName("thumbsDownCount")]
            public int ThumbsDownCount
            {
                get
                {
                    return _ThumbsDownCount;
                }
                set
                {
                    if (!_ThumbsDownCount.Equals(value))
                    {
                        _ThumbsDownCount = value;
                        RaisePropertyChanged("ThumbsDownCount");
                    }
                }
            }
            #endregion

            #region tippedAmountCount
            /// <summary>
            /// tippedAmountCount
            /// </summary>
            int _TippedAmountCount = 0;
            /// <summary>
            /// tippedAmountCount
            /// </summary>
            [JsonPropertyName("tippedAmountCount")]
            public int TippedAmountCount
            {
                get
                {
                    return _TippedAmountCount;
                }
                set
                {
                    if (!_TippedAmountCount.Equals(value))
                    {
                        _TippedAmountCount = value;
                        RaisePropertyChanged("TippedAmountCount");
                    }
                }
            }
            #endregion


        }
        #endregion

        #region ModelVersions
        /// <summary>
        /// ModelVersions
        /// </summary>
        public class CvsModelVersions : CvBaseModel
        {
            #region Inner Class
            #region Files
            /// <summary>
            /// Files
            /// </summary>
            public class CvsFiles : CvBaseModel
            {
                #region inner class
                #region Metadata
                /// <summary>
                /// Metadata
                /// </summary>
                public class CvsMetadata : CvBaseModel
                {

                    #region The specified floating point for the file[Fp]プロパティ
                    /// <summary>
                    /// The specified floating point for the file[Fp]プロパティ用変数
                    /// </summary>
                    string _Fp = string.Empty;
                    /// <summary>
                    /// The specified floating point for the file[Fp]プロパティ
                    /// </summary>
                    [JsonPropertyName("fp")]
                    public string Fp
                    {
                        get
                        {
                            return _Fp;
                        }
                        set
                        {
                            if (_Fp == null || !_Fp.Equals(value))
                            {
                                _Fp = value;
                                RaisePropertyChanged("Fp");
                            }
                        }
                    }
                    #endregion

                    #region The specified model size for the file[Size]プロパティ
                    /// <summary>
                    /// The specified model size for the file[Size]プロパティ用変数
                    /// </summary>
                    string _Size = string.Empty;
                    /// <summary>
                    /// The specified model size for the file[Size]プロパティ
                    /// </summary>
                    [JsonPropertyName("size")]
                    public string Size
                    {
                        get
                        {
                            return _Size;
                        }
                        set
                        {
                            if (_Size == null || !_Size.Equals(value))
                            {
                                _Size = value;
                                RaisePropertyChanged("Size");
                            }
                        }
                    }
                    #endregion

                    #region The specified model format for the file[Format]プロパティ
                    /// <summary>
                    /// The specified model format for the file[Format]プロパティ用変数
                    /// </summary>
                    string _Format = string.Empty;
                    /// <summary>
                    /// The specified model format for the file[Format]プロパティ
                    /// </summary>
                    [JsonPropertyName("format")]
                    public string Format
                    {
                        get
                        {
                            return _Format;
                        }
                        set
                        {
                            if (_Format == null || !_Format.Equals(value))
                            {
                                _Format = value;
                                RaisePropertyChanged("Format");
                            }
                        }
                    }
                    #endregion
                }
                #endregion
                #endregion

                #region The size of the model file[SizeKb]プロパティ
                /// <summary>
                /// The size of the model file[SizeKb]プロパティ用変数
                /// </summary>
                int _SizeKb = 0;
                /// <summary>
                /// The size of the model file[SizeKb]プロパティ
                /// </summary>
                [JsonPropertyName("sizeKb")]
                public int SizeKb
                {
                    get
                    {
                        return _SizeKb;
                    }
                    set
                    {
                        if (!_SizeKb.Equals(value))
                        {
                            _SizeKb = value;
                            RaisePropertyChanged("SizeKb");
                        }
                    }
                }
                #endregion

                #region Status of the pickle scan ('Pending', 'Success', 'Danger', 'Error')[PickleScanResult]プロパティ
                /// <summary>
                /// Status of the pickle scan ('Pending', 'Success', 'Danger', 'Error')[PickleScanResult]プロパティ用変数
                /// </summary>
                string _PickleScanResult = string.Empty;
                /// <summary>
                /// Status of the pickle scan ('Pending', 'Success', 'Danger', 'Error')[PickleScanResult]プロパティ
                /// </summary>
                [JsonPropertyName("pickleScanResult")]
                public string PickleScanResult
                {
                    get
                    {
                        return _PickleScanResult;
                    }
                    set
                    {
                        if (_PickleScanResult == null || !_PickleScanResult.Equals(value))
                        {
                            _PickleScanResult = value;
                            RaisePropertyChanged("PickleScanResult");
                        }
                    }
                }
                #endregion

                #region Status of the virus scan ('Pending', 'Success', 'Danger', 'Error')[VirusScanResult]プロパティ
                /// <summary>
                /// Status of the virus scan ('Pending', 'Success', 'Danger', 'Error')[VirusScanResult]プロパティ用変数
                /// </summary>
                string _VirusScanResult = string.Empty;
                /// <summary>
                /// Status of the virus scan ('Pending', 'Success', 'Danger', 'Error')[VirusScanResult]プロパティ
                /// </summary>
                [JsonPropertyName("virusScanResult")]
                public string VirusScanResult
                {
                    get
                    {
                        return _VirusScanResult;
                    }
                    set
                    {
                        if (_VirusScanResult == null || !_VirusScanResult.Equals(value))
                        {
                            _VirusScanResult = value;
                            RaisePropertyChanged("VirusScanResult");
                        }
                    }
                }
                #endregion

                #region The date in which the file was scanned[ScannedAt]プロパティ
                /// <summary>
                /// The date in which the file was scanned[ScannedAt]プロパティ用変数
                /// </summary>
                DateTime? _ScannedAt = null;
                /// <summary>
                /// The date in which the file was scanned[ScannedAt]プロパティ
                /// </summary>
                [JsonPropertyName("scannedAt")]
                public DateTime? ScannedAt
                {
                    get
                    {
                        return _ScannedAt;
                    }
                    set
                    {
                        if (_ScannedAt == null || !_ScannedAt.Equals(value))
                        {
                            _ScannedAt = value;
                            RaisePropertyChanged("ScannedAt");
                        }
                    }
                }
                #endregion

                #region If the file is the primary file for the model version[Primary]プロパティ
                /// <summary>
                /// If the file is the primary file for the model version[Primary]プロパティ用変数
                /// </summary>
                bool? _Primary = null;
                /// <summary>
                /// If the file is the primary file for the model version[Primary]プロパティ
                /// </summary>
                [JsonPropertyName("primary")]
                public bool? Primary
                {
                    get
                    {
                        return _Primary;
                    }
                    set
                    {
                        if (_Primary == null || !_Primary.Equals(value))
                        {
                            _Primary = value;
                            RaisePropertyChanged("Primary");
                        }
                    }
                }
                #endregion

                #region This file metadata[Metadata]プロパティ
                /// <summary>
                /// This file metadata[Metadata]プロパティ用変数
                /// </summary>
                CvsMetadata _Metadata = new CvsMetadata();
                /// <summary>
                /// This file metadata[Metadata]プロパティ
                /// </summary>
                [JsonPropertyName("metadata")]
                public CvsMetadata Metadata
                {
                    get
                    {
                        return _Metadata;
                    }
                    set
                    {
                        if (_Metadata == null || !_Metadata.Equals(value))
                        {
                            _Metadata = value;
                            RaisePropertyChanged("Metadata");
                        }
                    }
                }
                #endregion
            }
            #endregion

            #region Images
            /// <summary>
            /// Images
            /// </summary>
            public class CvsImages : CvBaseModel
            {
                #region Inner Class
                public class CvsMeta : CvBaseModel
                {
                    #region image size[Size]プロパティ
                    /// <summary>
                    /// image size[Size]プロパティ用変数
                    /// </summary>
                    string _Size = string.Empty;
                    /// <summary>
                    /// image size[Size]プロパティ
                    /// </summary>
                    [JsonPropertyName("Size")]
                    public string Size
                    {
                        get
                        {
                            return _Size;
                        }
                        set
                        {
                            if (_Size == null || !_Size.Equals(value))
                            {
                                _Size = value;
                                RaisePropertyChanged("Size");
                            }
                        }
                    }
                    #endregion


                    #region promt[Prompt]プロパティ
                    /// <summary>
                    /// promt[Prompt]プロパティ用変数
                    /// </summary>
                    string _Prompt = string.Empty;
                    /// <summary>
                    /// promt[Prompt]プロパティ
                    /// </summary>
                    [JsonPropertyName("prompt")]
                    public string Prompt
                    {
                        get
                        {
                            return _Prompt;
                        }
                        set
                        {
                            if (_Prompt == null || !_Prompt.Equals(value))
                            {
                                _Prompt = value;
                                RaisePropertyChanged("Prompt");
                            }
                        }
                    }
                    #endregion

                    #region image negative prompt[NegativPrompt]プロパティ
                    /// <summary>
                    /// image negative prompt[NegativPrompt]プロパティ用変数
                    /// </summary>
                    string _NegativPrompt = string.Empty;
                    /// <summary>
                    /// image negative prompt[NegativPrompt]プロパティ
                    /// </summary>
                    [JsonPropertyName("negativePrompt")]
                    public string NegativPrompt
                    {
                        get
                        {
                            return _NegativPrompt;
                        }
                        set
                        {
                            if (_NegativPrompt == null || !_NegativPrompt.Equals(value))
                            {
                                _NegativPrompt = value;
                                RaisePropertyChanged("NegativPrompt");
                            }
                        }
                    }
                    #endregion

                    #region image sampler[Sampler]プロパティ
                    /// <summary>
                    /// image sampler[Sampler]プロパティ用変数
                    /// </summary>
                    string _Sampler = string.Empty;
                    /// <summary>
                    /// image sampler[Sampler]プロパティ
                    /// </summary>
                    [JsonPropertyName("sampler")]
                    public string Sampler
                    {
                        get
                        {
                            return _Sampler;
                        }
                        set
                        {
                            if (_Sampler == null || !_Sampler.Equals(value))
                            {
                                _Sampler = value;
                                RaisePropertyChanged("Sampler");
                            }
                        }
                    }
                    #endregion

                    #region checkpoint name[Model]プロパティ
                    /// <summary>
                    /// checkpoint name[Model]プロパティ用変数
                    /// </summary>
                    string _Model = string.Empty;
                    /// <summary>
                    /// checkpoint name[Model]プロパティ
                    /// </summary>
                    [JsonPropertyName("Model")]
                    public string Model
                    {
                        get
                        {
                            return _Model;
                        }
                        set
                        {
                            if (_Model == null || !_Model.Equals(value))
                            {
                                _Model = value;
                                RaisePropertyChanged("Model");
                            }
                        }
                    }
                    #endregion

                    #region image ENSD[ENSD]プロパティ
                    /// <summary>
                    /// image ENSD[ENSD]プロパティ用変数
                    /// </summary>
                    string _ENSD = string.Empty;
                    /// <summary>
                    /// image ENSD[ENSD]プロパティ
                    /// </summary>
                    [JsonPropertyName("ENSD")]
                    public string ENSD
                    {
                        get
                        {
                            return _ENSD;
                        }
                        set
                        {
                            if (_ENSD == null || !_ENSD.Equals(value))
                            {
                                _ENSD = value;
                                RaisePropertyChanged("ENSD");
                            }
                        }
                    }
                    #endregion

                    #region image sample seed[Seed]プロパティ
                    /// <summary>
                    /// image sample seed[Seed]プロパティ用変数
                    /// </summary>
                    object _Seed = new long();
                    /// <summary>
                    /// image sample seed[Seed]プロパティ
                    /// </summary>
                    [JsonPropertyName("seed")]
                    public object Seed
                    {
                        get
                        {
                            return _Seed;
                        }
                        set
                        {
                            if (!_Seed.Equals(value))
                            {
                                _Seed = value;
                                RaisePropertyChanged("Seed");
                            }
                        }
                    }
                    #endregion


                    #region image Eta DDIM[EtaDDIM]プロパティ
                    /// <summary>
                    /// image Eta DDIM[EtaDDIM]プロパティ用変数
                    /// </summary>
                    object _EtaDDIM = 0.0;
                    /// <summary>
                    /// image Eta DDIM[EtaDDIM]プロパティ
                    /// </summary>
                    [JsonPropertyName("Eta DDIM")]
                    public object EtaDDIM
                    {
                        get
                        {
                            return _EtaDDIM;
                        }
                        set
                        {
                            if (!_EtaDDIM.Equals(value))
                            {
                                _EtaDDIM = value;
                                RaisePropertyChanged("EtaDDIM");
                            }
                        }
                    }
                    #endregion

                    #region image Cfg Scale[CfgScale]プロパティ
                    /// <summary>
                    /// image Cfg Scale[CfgScale]プロパティ用変数
                    /// </summary>
                    double _CfgScale = 0.0;
                    /// <summary>
                    /// image Cfg Scale[CfgScale]プロパティ
                    /// </summary>
                    [JsonPropertyName("cfgScale")]
                    public double CfgScale
                    {
                        get
                        {
                            return _CfgScale;
                        }
                        set
                        {
                            if (!_CfgScale.Equals(value))
                            {
                                _CfgScale = value;
                                RaisePropertyChanged("CfgScale");
                            }
                        }
                    }
                    #endregion

                    #region image model hash[ModelHash]プロパティ
                    /// <summary>
                    /// image model hash[ModelHash]プロパティ用変数
                    /// </summary>
                    string _ModelHash = string.Empty;
                    /// <summary>
                    /// image model hash[ModelHash]プロパティ
                    /// </summary>
                    [JsonPropertyName("Model hash")]
                    public string ModelHash
                    {
                        get
                        {
                            return _ModelHash;
                        }
                        set
                        {
                            if (_ModelHash == null || !_ModelHash.Equals(value))
                            {
                                _ModelHash = value;
                                RaisePropertyChanged("ModelHash");
                            }
                        }
                    }
                    #endregion

                    #region image hires upscale[HiresUpscale]プロパティ
                    /// <summary>
                    /// image hires upscale[HiresUpscale]プロパティ用変数
                    /// </summary>
                    object _HiresUpscale = 0.0;
                    /// <summary>
                    /// image hires upscale[HiresUpscale]プロパティ
                    /// </summary>
                    [JsonPropertyName("Hires upscale")]
                    public object HiresUpscale
                    {
                        get
                        {
                            return _HiresUpscale;
                        }
                        set
                        {
                            if (_HiresUpscale == null || !_HiresUpscale.Equals(value))
                            {
                                _HiresUpscale = value;
                                RaisePropertyChanged("HiresUpscale");
                            }
                        }
                    }
                    #endregion

                    #region image hires upscaler[HiresUpscaler]プロパティ
                    /// <summary>
                    /// image hires upscaler[HiresUpscaler]プロパティ用変数
                    /// </summary>
                    string _HiresUpscaler = string.Empty;
                    /// <summary>
                    /// image hires upscaler[HiresUpscaler]プロパティ
                    /// </summary>
                    [JsonPropertyName("Hires upscaler")]
                    public string HiresUpscaler
                    {
                        get
                        {
                            return _HiresUpscaler;
                        }
                        set
                        {
                            if (_HiresUpscaler == null || !_HiresUpscaler.Equals(value))
                            {
                                _HiresUpscaler = value;
                                RaisePropertyChanged("HiresUpscaler");
                            }
                        }
                    }
                    #endregion

                    #region image denoising strength[DenoisingStrength]プロパティ
                    /// <summary>
                    /// image denoising strength[DenoisingStrength]プロパティ用変数
                    /// </summary>
                    object _DenoisingStrength = 0.0;
                    /// <summary>
                    /// image denoising strength[DenoisingStrength]プロパティ
                    /// </summary>
                    [JsonPropertyName("Denoising strength")]
                    public object DenoisingStrength
                    {
                        get
                        {
                            return _DenoisingStrength;
                        }
                        set
                        {
                            if (_DenoisingStrength == null || !_DenoisingStrength.Equals(value))
                            {
                                _DenoisingStrength = value;
                                RaisePropertyChanged("DenoisingStrength");
                            }
                        }
                    }
                    #endregion
                }
                #endregion

                #region The url for the image[Url]プロパティ
                /// <summary>
                /// The url for the image[Url]プロパティ用変数
                /// </summary>
                string _Url = string.Empty;
                /// <summary>
                /// The url for the image[Url]プロパティ
                /// </summary>
                [JsonPropertyName("url")]
                public string Url
                {
                    get
                    {
                        return _Url;
                    }
                    set
                    {
                        if (_Url == null || !_Url.Equals(value))
                        {
                            _Url = value;
                            RaisePropertyChanged("Url");
                        }
                    }
                }
                #endregion

                #region Whether or not the image is NSFW (note: if the model is NSFW, treat all images on the model as NSFW)[Nsfw]プロパティ
                /// <summary>
                /// Whether or not the image is NSFW (note: if the model is NSFW, treat all images on the model as NSFW)[Nsfw]プロパティ用変数
                /// </summary>
                bool _Nsfw = false;
                /// <summary>
                /// Whether or not the image is NSFW (note: if the model is NSFW, treat all images on the model as NSFW)[Nsfw]プロパティ
                /// </summary>
                [JsonPropertyName("nsfw")]
                public bool Nsfw
                {
                    get
                    {
                        return _Nsfw;
                    }
                    set
                    {
                        if (!_Nsfw.Equals(value))
                        {
                            _Nsfw = value;
                            RaisePropertyChanged("Nsfw");
                        }
                    }
                }
                #endregion
                #region Whether or not the image is NSFW (note: if the model is NSFW, treat all images on the model as NSFW)[Nsfw]プロパティ
                /// <summary>
                /// Whether or not the image is NSFW (note: if the model is NSFW, treat all images on the model as NSFW)[Nsfw]プロパティ用変数
                /// </summary>
                int _NsfwLevel = 0;
                /// <summary>
                /// Whether or not the image is NSFW (note: if the model is NSFW, treat all images on the model as NSFW)[Nsfw]プロパティ
                /// </summary>
                [JsonPropertyName("nsfwLevel")]
                public int NsfwLevel
                {
                    get
                    {
                        return _NsfwLevel;
                    }
                    set
                    {
                        if (!_NsfwLevel.Equals(value))
                        {
                            _NsfwLevel = value;
                            RaisePropertyChanged("NsfwLevel");
                        }
                    }
                }
                #endregion
                #region The original width of the image[Width]プロパティ
                /// <summary>
                /// The original width of the image[Width]プロパティ用変数
                /// </summary>
                int _Width = 0;
                /// <summary>
                /// The original width of the image[Width]プロパティ
                /// </summary>
                [JsonPropertyName("width")]
                public int Width
                {
                    get
                    {
                        return _Width;
                    }
                    set
                    {
                        if (!_Width.Equals(value))
                        {
                            _Width = value;
                            RaisePropertyChanged("Width");
                        }
                    }
                }
                #endregion

                #region The original height of the image[Height]プロパティ
                /// <summary>
                /// The original height of the image[Height]プロパティ用変数
                /// </summary>
                int _Height = 0;
                /// <summary>
                /// The original height of the image[Height]プロパティ
                /// </summary>
                [JsonPropertyName("height")]
                public int Height
                {
                    get
                    {
                        return _Height;
                    }
                    set
                    {
                        if (!_Height.Equals(value))
                        {
                            _Height = value;
                            RaisePropertyChanged("Height");
                        }
                    }
                }
                #endregion

                #region The blurhash of the image[Hash]プロパティ
                /// <summary>
                /// The blurhash of the image[Hash]プロパティ用変数
                /// </summary>
                string _Hash = string.Empty;
                /// <summary>
                /// The blurhash of the image[Hash]プロパティ
                /// </summary>
                [JsonPropertyName("hash")]
                public string Hash
                {
                    get
                    {
                        return _Hash;
                    }
                    set
                    {
                        if (_Hash == null || !_Hash.Equals(value))
                        {
                            _Hash = value;
                            RaisePropertyChanged("Hash");
                        }
                    }
                }
                #endregion

                #region The generation params of the image[Meta]プロパティ
                /// <summary>
                /// The generation params of the image[Meta]プロパティ用変数
                /// </summary>
                CvsMeta _Meta = new();
                /// <summary>
                /// The generation params of the image[Meta]プロパティ
                /// </summary>
                [JsonPropertyName("meta")]
                public CvsMeta Meta
                {
                    get
                    {
                        return _Meta;
                    }
                    set
                    {
                        if (_Meta == null || !_Meta.Equals(value))
                        {
                            _Meta = value;
                            RaisePropertyChanged("Meta");
                        }
                    }
                }
                #endregion


            }
            #endregion

            #region Stats
            /// <summary>
            /// Stats
            /// </summary>
            public class CvsStats : CvBaseModel
            {
                #region The number of downloads the model has[DownloadCount]プロパティ
                /// <summary>
                /// The number of downloads the model has[DownloadCount]プロパティ用変数
                /// </summary>
                int _DownloadCount = 0;
                /// <summary>
                /// The number of downloads the model has[DownloadCount]プロパティ
                /// </summary>
                [JsonPropertyName("downloadCount")]
                public int DownloadCount
                {
                    get
                    {
                        return _DownloadCount;
                    }
                    set
                    {
                        if (!_DownloadCount.Equals(value))
                        {
                            _DownloadCount = value;
                            RaisePropertyChanged("DownloadCount");
                        }
                    }
                }
                #endregion

                #region The number of ratings the model has[RatingCount]プロパティ
                /// <summary>
                /// The number of ratings the model has[RatingCount]プロパティ用変数
                /// </summary>
                int _RatingCount = 0;
                /// <summary>
                /// The number of ratings the model has[RatingCount]プロパティ
                /// </summary>
                [JsonPropertyName("ratingCount")]
                public int RatingCount
                {
                    get
                    {
                        return _RatingCount;
                    }
                    set
                    {
                        if (!_RatingCount.Equals(value))
                        {
                            _RatingCount = value;
                            RaisePropertyChanged("RatingCount");
                        }
                    }
                }
                #endregion

                #region The average rating of the model[Rating]プロパティ
                /// <summary>
                /// The average rating of the model[Rating]プロパティ用変数
                /// </summary>
                double _Rating = 0;
                /// <summary>
                /// The average rating of the model[Rating]プロパティ
                /// </summary>
                [JsonPropertyName("rating")]
                public double Rating
                {
                    get
                    {
                        return _Rating;
                    }
                    set
                    {
                        if (!_Rating.Equals(value))
                        {
                            _Rating = value;
                            RaisePropertyChanged("Rating");
                        }
                    }
                }
                #endregion

                #region thumbsUpCount
                /// <summary>
                /// thumbsUpCount
                /// </summary>
                int _ThumbsUpCount = 0;
                /// <summary>
                /// thumbsUpCount
                /// </summary>
                [JsonPropertyName("thumbsUpCount")]
                public int ThumbsUpCount
                {
                    get
                    {
                        return _ThumbsUpCount;
                    }
                    set
                    {
                        if (!_ThumbsUpCount.Equals(value))
                        {
                            _ThumbsUpCount = value;
                            RaisePropertyChanged("ThumbsUpCount");
                        }
                    }
                }
                #endregion

                #region thumbsUpCount
                /// <summary>
                /// thumbsUpCount
                /// </summary>
                int _ThumbsDownCount = 0;
                /// <summary>
                /// thumbsUpCount
                /// </summary>
                [JsonPropertyName("thumbsDownCount")]
                public int ThumbsDownCount
                {
                    get
                    {
                        return _ThumbsDownCount;
                    }
                    set
                    {
                        if (!_ThumbsDownCount.Equals(value))
                        {
                            _ThumbsDownCount = value;
                            RaisePropertyChanged("ThumbsDownCount");
                        }
                    }
                }
                #endregion
            }
            #endregion
            #endregion

            #region The identifier for the model version[Id]プロパティ
            /// <summary>
            /// The identifier for the model version[Id]プロパティ用変数
            /// </summary>
            int _Id = 0;
            /// <summary>
            /// The identifier for the model version[Id]プロパティ
            /// </summary>
            [JsonPropertyName("id")]
            public int Id
            {
                get
                {
                    return _Id;
                }
                set
                {
                    if (!_Id.Equals(value))
                    {
                        _Id = value;
                        RaisePropertyChanged("Id");
                    }
                }
            }
            #endregion

            #region The name of the model version[Name]プロパティ
            /// <summary>
            /// The name of the model version[Name]プロパティ用変数
            /// </summary>
            string _Name = string.Empty;
            /// <summary>
            /// The name of the model version[Name]プロパティ
            /// </summary>
            [JsonPropertyName("name")]
            public string Name
            {
                get
                {
                    return _Name;
                }
                set
                {
                    if (_Name == null || !_Name.Equals(value))
                    {
                        _Name = value;
                        RaisePropertyChanged("Name");
                    }
                }
            }
            #endregion

            #region The description of the model version (usually a changelog)[Description]プロパティ
            /// <summary>
            /// The description of the model version (usually a changelog)[Description]プロパティ用変数
            /// </summary>
            string _Description = string.Empty;
            /// <summary>
            /// The description of the model version (usually a changelog)[Description]プロパティ
            /// </summary>
            [JsonPropertyName("description")]
            public string Description
            {
                get
                {
                    return _Description;
                }
                set
                {
                    if (_Description == null || !_Description.Equals(value))
                    {
                        _Description = value;
                        RaisePropertyChanged("Description");
                    }
                }
            }
            #endregion

            #region PublishedAt
            /// <summary>
            /// PublishedAt
            /// </summary>
            DateTime? _PublishedAt = null;
            /// <summary>
            /// PublishedAt
            /// </summary>
            [JsonPropertyName("publishedAt")]
            public DateTime? PublishedAt
            {
                get
                {
                    return _PublishedAt;
                }
                set
                {
                    if (!_PublishedAt.Equals(value))
                    {
                        _PublishedAt = value;
                        RaisePropertyChanged("PublishedAt");
                    }
                }
            }
            #endregion

            #region CvBaseModel
            /// <summary>
            /// CvBaseModel
            /// </summary>
            string _CvBaseModel = string.Empty;
            /// <summary>
            /// CvBaseModel
            /// </summary>
            [JsonPropertyName("CvBaseModel")]
            public string CvBaseModel
            {
                get
                {
                    return _CvBaseModel;
                }
                set
                {
                    if (_CvBaseModel == null || !_CvBaseModel.Equals(value))
                    {
                        _CvBaseModel = value;
                        RaisePropertyChanged("CvBaseModel");
                    }
                }
            }
            #endregion

            #region CvBaseModelType
            /// <summary>
            /// CvBaseModelType
            /// </summary>
            string _CvBaseModelType = string.Empty;
            /// <summary>
            /// CvBaseModelType
            /// </summary>
            [JsonPropertyName("CvBaseModelType")]
            public string CvBaseModelType
            {
                get
                {
                    return _CvBaseModelType;
                }
                set
                {
                    if (_CvBaseModelType == null || !_CvBaseModelType.Equals(value))
                    {
                        _CvBaseModelType = value;
                        RaisePropertyChanged("CvBaseModelType");
                    }
                }
            }
            #endregion

            #region Availability
            /// <summary>
            /// Availability
            /// </summary>
            string _Availability = string.Empty;
            /// <summary>
            /// Availability
            /// </summary>
            [JsonPropertyName("availability")]
            public string Availability
            {
                get
                {
                    return _Availability;
                }
                set
                {
                    if (_Availability == null || !_Availability.Equals(value))
                    {
                        _Availability = value;
                        RaisePropertyChanged("Availability");
                    }
                }
            }
            #endregion



            #region The download url to get the model file for this specific version[DownloadUrl]プロパティ
            /// <summary>
            /// The download url to get the model file for this specific version[DownloadUrl]プロパティ用変数
            /// </summary>
            string _DownloadUrl = string.Empty;
            /// <summary>
            /// The download url to get the model file for this specific version[DownloadUrl]プロパティ
            /// </summary>
            [JsonPropertyName("downloadUrl")]
            public string DownloadUrl
            {
                get
                {
                    return _DownloadUrl;
                }
                set
                {
                    if (_DownloadUrl == null || !_DownloadUrl.Equals(value))
                    {
                        _DownloadUrl = value;
                        RaisePropertyChanged("DownloadUrl");
                    }
                }
            }
            #endregion

            #region The words used to trigger the model[TrainedWords]プロパティ
            /// <summary>
            /// The words used to trigger the model[TrainedWords]プロパティ用変数
            /// </summary>
            ObservableCollection<string> _TrainedWords = new ObservableCollection<string>();
            /// <summary>
            /// The words used to trigger the model[TrainedWords]プロパティ
            /// </summary>
            [JsonPropertyName("trainedWords")]
            public ObservableCollection<string> TrainedWords
            {
                get
                {
                    return _TrainedWords;
                }
                set
                {
                    if (_TrainedWords == null || !_TrainedWords.Equals(value))
                    {
                        _TrainedWords = value;
                        RaisePropertyChanged("TrainedWords");
                    }
                }
            }
            #endregion

            #region The files of modelversion[Files]プロパティ
            /// <summary>
            /// The files of modelversion[Files]プロパティ用変数
            /// </summary>
            ObservableCollection<CvsFiles> _Files = new ObservableCollection<CvsFiles>();
            /// <summary>
            /// The files of modelversion[Files]プロパティ
            /// </summary>
            [JsonPropertyName("files")]
            public ObservableCollection<CvsFiles> Files
            {
                get
                {
                    return _Files;
                }
                set
                {
                    if (_Files == null || !_Files.Equals(value))
                    {
                        _Files = value;
                        RaisePropertyChanged("Files");
                    }
                }
            }
            #endregion

            #region This model images[Images]プロパティ
            /// <summary>
            /// This model images[Images]プロパティ用変数
            /// </summary>
            ObservableCollection<CvsImages> _Images = new ObservableCollection<CvsImages>();
            /// <summary>
            /// This model images[Images]プロパティ
            /// </summary>
            [JsonPropertyName("images")]
            public ObservableCollection<CvsImages> Images
            {
                get
                {
                    return _Images;
                }
                set
                {
                    if (_Images == null || !_Images.Equals(value))
                    {
                        _Images = value;
                        RaisePropertyChanged("Images");
                    }
                }
            }
            #endregion

            #region This model stats[Stats]プロパティ
            /// <summary>
            /// This model stats[Stats]プロパティ用変数
            /// </summary>
            CvsStats _Stats = new CvsStats();
            /// <summary>
            /// This model stats[Stats]プロパティ
            /// </summary>
            [JsonPropertyName("stats")]
            public CvsStats Stats
            {
                get
                {
                    return _Stats;
                }
                set
                {
                    if (_Stats == null || !_Stats.Equals(value))
                    {
                        _Stats = value;
                        RaisePropertyChanged("Stats");
                    }
                }
            }
            #endregion
        }
        #endregion

        #region Selected image item[SelectedImage]プロパティ
        /// <summary>
        /// Selected image item[SelectedImage]プロパティ用変数
        /// </summary>
        CvsImages _SelectedImage = new CvsImages();
        /// <summary>
        /// Selected image item[SelectedImage]プロパティ
        /// </summary>
        public CvsImages SelectedImage
        {
            get
            {
                return _SelectedImage;
            }
            set
            {
                if (_SelectedImage == null || !_SelectedImage.Equals(value))
                {
                    _SelectedImage = value;
                    RaisePropertyChanged("SelectedImage");
                }
            }
        }
        #endregion

        #region Items
        /// <summary>
        /// Items
        /// </summary>
        public class CvsItem : CvBaseModel
        {
            #region The identifier for the model[Id]プロパティ
            /// <summary>
            /// The identifier for the model[Id]プロパティ用変数
            /// </summary>
            int _Id = 0;
            /// <summary>
            /// The identifier for the model[Id]プロパティ
            /// </summary>
            [JsonPropertyName("id")]
            public int Id
            {
                get
                {
                    return _Id;
                }
                set
                {
                    if (!_Id.Equals(value))
                    {
                        _Id = value;
                        RaisePropertyChanged("Id");
                    }
                }
            }
            #endregion

            #region The identifier for the model[Name]プロパティ
            /// <summary>
            /// The identifier for the model[Name]プロパティ用変数
            /// </summary>
            string _Name = string.Empty;
            /// <summary>
            /// The identifier for the model[Name]プロパティ
            /// </summary>
            [JsonPropertyName("name")]
            public string Name
            {
                get
                {
                    return _Name;
                }
                set
                {
                    if (_Name == null || !_Name.Equals(value))
                    {
                        _Name = value;
                        RaisePropertyChanged("Name");
                    }
                }
            }
            #endregion

            #region The description of the model (HTML)[Description]プロパティ
            /// <summary>
            /// The description of the model (HTML)[Description]プロパティ用変数
            /// </summary>
            string _Description = string.Empty;
            /// <summary>
            /// The description of the model (HTML)[Description]プロパティ
            /// </summary>
            [JsonPropertyName("description")]
            public string Description
            {
                get
                {
                    return _Description;
                }
                set
                {
                    if (_Description == null || !_Description.Equals(value))
                    {
                        _Description = value;
                        RaisePropertyChanged("Description");
                    }
                }
            }
            #endregion

            #region The model type[Type]プロパティ
            /// <summary>
            /// The model type[Type]プロパティ用変数
            /// </summary>
            string _Type = string.Empty;
            /// <summary>
            /// The model type[Type]プロパティ
            /// </summary>
            [JsonPropertyName("type")]
            public string Type
            {
                get
                {
                    return _Type;
                }
                set
                {
                    if (_Type == null || !_Type.Equals(value))
                    {
                        _Type = value;
                        RaisePropertyChanged("Type");
                    }
                }
            }
            #endregion

            #region Whether the model is NSFW or not[Nsfw]プロパティ
            /// <summary>
            /// Whether the model is NSFW or not[Nsfw]プロパティ用変数
            /// </summary>
            bool _Nsfw = false;
            /// <summary>
            /// Whether the model is NSFW or not[Nsfw]プロパティ
            /// </summary>
            [JsonPropertyName("nsfw")]
            public bool Nsfw
            {
                get
                {
                    return _Nsfw;
                }
                set
                {
                    if (!_Nsfw.Equals(value))
                    {
                        _Nsfw = value;
                        RaisePropertyChanged("Nsfw");
                    }
                }
            }
            #endregion

            #region Whether or not the image is NSFW (note: if the model is NSFW, treat all images on the model as NSFW)[Nsfw]プロパティ
            /// <summary>
            /// Whether or not the image is NSFW (note: if the model is NSFW, treat all images on the model as NSFW)[Nsfw]プロパティ用変数
            /// </summary>
            int _NsfwLevel = 0;
            /// <summary>
            /// Whether or not the image is NSFW (note: if the model is NSFW, treat all images on the model as NSFW)[Nsfw]プロパティ
            /// </summary>
            [JsonPropertyName("nsfwLevel")]
            public int NsfwLevel
            {
                get
                {
                    return _NsfwLevel;
                }
                set
                {
                    if (!_NsfwLevel.Equals(value))
                    {
                        _NsfwLevel = value;
                        RaisePropertyChanged("NsfwLevel");
                    }
                }
            }
            #endregion

            #region The tags associated with the model[Tags]プロパティ
            /// <summary>
            /// The tags associated with the model[Tags]プロパティ用変数
            /// </summary>
            List<string> _Tags = new List<string>();
            /// <summary>
            /// The tags associated with the model[Tags]プロパティ
            /// </summary>
            [JsonPropertyName("tags")]
            public List<string> Tags
            {
                get
                {
                    return _Tags;
                }
                set
                {
                    if (_Tags == null || !_Tags.Equals(value))
                    {
                        _Tags = value;
                        RaisePropertyChanged("Tags");
                    }
                }
            }
            #endregion

            #region The mode in which the model is currently on. If Archived, files field will be empty. If TakenDown, images field will be empty[Mode]プロパティ
            /// <summary>
            /// The mode in which the model is currently on. If Archived, files field will be empty. If TakenDown, images field will be empty[Mode]プロパティ用変数
            /// </summary>
            string _Mode = string.Empty;
            /// <summary>
            /// The mode in which the model is currently on. If Archived, files field will be empty. If TakenDown, images field will be empty[Mode]プロパティ
            /// </summary>
            [JsonPropertyName("mode")]
            public string Mode
            {
                get
                {
                    return _Mode;
                }
                set
                {
                    if (!_Mode.Equals(value))
                    {
                        _Mode = value;
                        RaisePropertyChanged("Mode");
                    }
                }
            }
            #endregion

            #region This model creator[Creator]プロパティ
            /// <summary>
            /// This model creator[Creator]プロパティ用変数
            /// </summary>
            CvsCreator _Creator = new CvsCreator();
            /// <summary>
            /// This model creator[Creator]プロパティ
            /// </summary>
            [JsonPropertyName("creator")]
            public CvsCreator Creator
            {
                get
                {
                    return _Creator;
                }
                set
                {
                    if (_Creator == null || !_Creator.Equals(value))
                    {
                        _Creator = value;
                        RaisePropertyChanged("Creator");
                    }
                }
            }
            #endregion

            #region This model stats[Stats]プロパティ
            /// <summary>
            /// This model stats[Stats]プロパティ用変数
            /// </summary>
            CvsStats1 _Stats = new CvsStats1();
            /// <summary>
            /// This model stats[Stats]プロパティ
            /// </summary>
            [JsonPropertyName("stats")]
            public CvsStats1 Stats
            {
                get
                {
                    return _Stats;
                }
                set
                {
                    if (_Stats == null || !_Stats.Equals(value))
                    {
                        _Stats = value;
                        RaisePropertyChanged("Stats");
                    }
                }
            }
            #endregion

            #region Filter to models that require or don't require crediting the creator[AllowNoCredit]プロパティ
            /// <summary>
            /// Filter to models that require or don't require crediting the creator[AllowNoCredit]プロパティ用変数
            /// </summary>
            bool _AllowNoCredit = false;
            /// <summary>
            /// Filter to models that require or don't require crediting the creator[AllowNoCredit]プロパティ
            /// </summary>
            [JsonPropertyName("allowNoCredit")]
            public bool AllowNoCredit
            {
                get
                {
                    return _AllowNoCredit;
                }
                set
                {
                    if (!_AllowNoCredit.Equals(value))
                    {
                        _AllowNoCredit = value;
                        RaisePropertyChanged("AllowNoCredit");
                    }
                }
            }
            #endregion

            #region Filter to models that allow or don't allow creating derivatives[AllowDerivatives]プロパティ
            /// <summary>
            /// Filter to models that allow or don't allow creating derivatives[AllowDerivatives]プロパティ用変数
            /// </summary>
            bool _AllowDerivatives = false;
            /// <summary>
            /// Filter to models that allow or don't allow creating derivatives[AllowDerivatives]プロパティ
            /// </summary>
            [JsonPropertyName("allowDerivatives")]
            public bool AllowDerivatives
            {
                get
                {
                    return _AllowDerivatives;
                }
                set
                {
                    if (!_AllowDerivatives.Equals(value))
                    {
                        _AllowDerivatives = value;
                        RaisePropertyChanged("AllowDerivatives");
                    }
                }
            }
            #endregion

            #region Filter to models that allow or don't allow derivatives to have a different license[AllowDifferentLicenses]プロパティ
            /// <summary>
            /// Filter to models that allow or don't allow derivatives to have a different license[AllowDifferentLicenses]プロパティ用変数
            /// </summary>
            bool _AllowDifferentLicense = false;
            /// <summary>
            /// Filter to models that allow or don't allow derivatives to have a different license[AllowDifferentLicenses]プロパティ
            /// </summary>
            [JsonPropertyName("allowDifferentLicense")]
            public bool AllowDifferentLicense
            {
                get
                {
                    return _AllowDifferentLicense;
                }
                set
                {
                    if (!_AllowDifferentLicense.Equals(value))
                    {
                        _AllowDifferentLicense = value;
                        RaisePropertyChanged("AllowDifferentLicense");
                    }
                }
            }
            #endregion

            #region Filter to models based on their commercial permissions[AllowCommercialUse]プロパティ
            /// <summary>
            /// Filter to models based on their commercial permissions[AllowCommercialUse]プロパティ用変数
            /// </summary>
            List<string> _AllowCommercialUse = new List<string>();
            /// <summary>
            /// Filter to models based on their commercial permissions[AllowCommercialUse]プロパティ
            /// </summary>
            [JsonPropertyName("allowCommercialUse")]
            public List<string> AllowCommercialUse
            {
                get
                {
                    return _AllowCommercialUse;
                }
                set
                {
                    if (_AllowCommercialUse == null || !_AllowCommercialUse.Equals(value))
                    {
                        _AllowCommercialUse = value;
                        RaisePropertyChanged("AllowCommercialUse");
                    }
                }
            }
            #endregion

            #region Poi
            /// <summary>
            /// Poi[Poi]プロパティ用変数
            /// </summary>
            bool _Poi = false;
            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("poi")]
            public bool Poi
            {
                get
                {
                    return _Poi;
                }
                set
                {
                    if (!_Poi.Equals(value))
                    {
                        _Poi = value;
                        RaisePropertyChanged("Poi");
                    }
                }
            }
            #endregion

            #region minor
            /// <summary>
            /// minor
            /// </summary>
            bool _Minor = false;
            /// <summary>
            /// minor
            /// </summary>
            [JsonPropertyName("minor")]
            public bool Minor
            {
                get
                {
                    return _Minor;
                }
                set
                {
                    if (!_Minor.Equals(value))
                    {
                        _Minor = value;
                        RaisePropertyChanged("Minor");
                    }
                }
            }
            #endregion

            #region model version[ModelVersions]プロパティ
            /// <summary>
            /// model version[ModelVersions]プロパティ用変数
            /// </summary>
            ObservableCollection<CvsModelVersions> _ModelVersions = new ObservableCollection<CvsModelVersions>();
            /// <summary>
            /// model version[ModelVersions]プロパティ
            /// </summary>
            [JsonPropertyName("modelVersions")]
            public ObservableCollection<CvsModelVersions> ModelVersions
            {
                get
                {
                    return _ModelVersions;
                }
                set
                {
                    if (_ModelVersions == null || !_ModelVersions.Equals(value))
                    {
                        _ModelVersions = value;
                        RaisePropertyChanged("ModelVersions");
                    }
                }
            }
            #endregion

            #region Selected model version item[SelectedModelVersion]プロパティ
            /// <summary>
            /// Selected model version item[SelectedModelVersion]プロパティ用変数
            /// </summary>
            CvsModelVersions _SelectedModelVersion = new CvsModelVersions();
            /// <summary>
            /// Selected model version item[SelectedModelVersion]プロパティ
            /// </summary>
            public CvsModelVersions SelectedModelVersion
            {
                get
                {
                    return _SelectedModelVersion;
                }
                set
                {
                    if (_SelectedModelVersion == null || !_SelectedModelVersion.Equals(value))
                    {
                        _SelectedModelVersion = value;
                        RaisePropertyChanged("SelectedModelVersion");
                    }
                }
            }
            #endregion

            #endregion
        }
        #endregion

        #region GET Model Endpoint[Endpoint]プロパティ
        /// <summary>
        /// GET Model Endpoint[Endpoint]プロパティ用変数
        /// </summary>
        public const string Endpoint = "https://civitai.com/api/v1/models";
        #endregion

        #region json row data[Rowdata]プロパティ
        /// <summary>
        /// json row data[Rowdata]プロパティ用変数
        /// </summary>
        string _Rowdata = string.Empty;
        /// <summary>
        /// json row data[Rowdata]プロパティ
        /// </summary>
        public string Rowdata
        {
            get
            {
                return _Rowdata;
            }
            set
            {
                if (_Rowdata == null || !_Rowdata.Equals(value))
                {
                    _Rowdata = value;
                    RaisePropertyChanged("Rowdata");
                }
            }
        }
        #endregion

        #region json result of items[Items]プロパティ
        /// <summary>
        /// json result of items[Items]プロパティ用変数
        /// </summary>
        ObservableCollection<CvsItem> _Items = new ObservableCollection<CvsItem>();
        /// <summary>
        /// json result of items[Items]プロパティ
        /// </summary>
        [JsonPropertyName("items")]
        public ObservableCollection<CvsItem> Items
        {
            get
            {
                return _Items;
            }
            set
            {
                if (_Items == null || !_Items.Equals(value))
                {
                    _Items = value;
                    RaisePropertyChanged("Items");
                }
            }
        }
        #endregion

        #region Metadata[Metadata]プロパティ
        /// <summary>
        /// Metadata[Metadata]プロパティ用変数
        /// </summary>
        CvsMetadataM _Metadata = new CvsMetadataM();
        /// <summary>
        /// Metadata[Metadata]プロパティ
        /// </summary>
        [JsonPropertyName("metadata")]
        public CvsMetadataM Metadata
        {
            get
            {
                return _Metadata;
            }
            set
            {
                if (_Metadata == null || !_Metadata.Equals(value))
                {
                    _Metadata = value;
                    RaisePropertyChanged("Metadata");
                }
            }
        }
        #endregion

    }


}
