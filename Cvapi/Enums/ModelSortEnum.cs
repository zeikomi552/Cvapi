﻿using System.ComponentModel;

namespace Cvapi.Models.Civitai.Enums
{
    /// <summary>
    /// モデル検索用
    /// </summary>
    public enum ModelSortEnum
    {
        [Description("")]
        Empty,
        [Description("Highest Rated")]
        Highest_Rated,
        [Description("Most Downloaded")]
        Most_Downloaded,
        [Description("Most Liked")]
        Most_Liked,
        [Description("Most Buzz")]
        Most_Buzz,
        [Description("Most Discussed")]
        Most_Discussed,
        [Description("Most Collected")]
        Most_Collected,
        [Description("Most Images")]
        Most_Images,
        [Description("Newest")]
        Newest,
        [Description("Oldest")]
        Oldest

    }

    /// <summary>
    /// Image検索用
    /// </summary>
    public enum ModelSortEnum2
    {
        [Description("")]
        Empty,
        [Description("Most Reactions")]
        Most_Reactions,
        [Description("Most Comments")]
        Most_Comments,
        [Description("Most Collected")]
        Most_Collected,
        [Description("Oldest")]
        Oldest,
        [Description("Random")]
        Random,
        [Description("Newest")]
        Newest,
        //[Description("Random")]
        //Random
    }
}
