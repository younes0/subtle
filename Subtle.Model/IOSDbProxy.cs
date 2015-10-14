﻿using CookComputing.XmlRpc;
using Subtle.Model.Requests;
using Subtle.Model.Responses;

namespace Subtle.Model
{
    public interface IOSDbProxy : IXmlRpcProxy
    {
        [XmlRpcMethod]
        ServerInfo ServerInfo();

        [XmlRpcMethod("GetSubLanguages")]
        LanguageCollection GetLanguages(string language = "en");

        [XmlRpcMethod]
        SubtitleSearchResultCollection SearchSubtitles(string token, SearchQuery[] query, SearchSettings settings);

        [XmlRpcMethod("SearchMoviesOnIMDB")]
        ImdbSearchResultCollection SearchVideos(string token, string query);

        [XmlRpcMethod]
        Session LogIn(string username, string password, string language, string useragent);

        [XmlRpcMethod]
        SubtitleFileCollection DownloadSubtitles(string token, string[] fileIds);
    }
}