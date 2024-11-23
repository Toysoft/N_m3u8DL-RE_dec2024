﻿namespace N_m3u8DL_RE.Common.Resource;

public class ResString
{
    public static string CurrentLoc = "en-US";

    public static readonly string ReLiveTs = "<RE_LIVE_TS>";
    public static string singleFileRealtimeDecryptWarn => GetText("singleFileRealtimeDecryptWarn");
    public static string singleFileSplitWarn => GetText("singleFileSplitWarn");
    public static string customRangeWarn => GetText("customRangeWarn");
    public static string customRangeFound => GetText("customRangeFound");
    public static string customAdKeywordsFound => GetText("customAdKeywordsFound");
    public static string customRangeInvalid => GetText("customRangeInvalid");
    public static string consoleRedirected => GetText("consoleRedirected");
    public static string autoBinaryMerge => GetText("autoBinaryMerge");
    public static string autoBinaryMerge2 => GetText("autoBinaryMerge2");
    public static string autoBinaryMerge3 => GetText("autoBinaryMerge3");
    public static string autoBinaryMerge4 => GetText("autoBinaryMerge4");
    public static string autoBinaryMerge5 => GetText("autoBinaryMerge5");
    public static string autoBinaryMerge6 => GetText("autoBinaryMerge6");
    public static string badM3u8 => GetText("badM3u8");
    public static string binaryMerge => GetText("binaryMerge");
    public static string checkingLast => GetText("checkingLast");
    public static string cmd_appendUrlParams => GetText("cmd_appendUrlParams");
    public static string cmd_autoSelect => GetText("cmd_autoSelect");
    public static string cmd_disableUpdateCheck => GetText("cmd_disableUpdateCheck");
    public static string cmd_binaryMerge => GetText("cmd_binaryMerge");
    public static string cmd_useFFmpegConcatDemuxer => GetText("cmd_useFFmpegConcatDemuxer");
    public static string cmd_checkSegmentsCount => GetText("cmd_checkSegmentsCount");
    public static string cmd_decryptionBinaryPath => GetText("cmd_decryptionBinaryPath");
    public static string cmd_delAfterDone => GetText("cmd_delAfterDone");
    public static string cmd_ffmpegBinaryPath => GetText("cmd_ffmpegBinaryPath");
    public static string cmd_mkvmergeBinaryPath => GetText("cmd_mkvmergeBinaryPath");
    public static string cmd_baseUrl => GetText("cmd_baseUrl");
    public static string cmd_maxSpeed => GetText("cmd_maxSpeed");
    public static string cmd_adKeyword => GetText("cmd_adKeyword");
    public static string cmd_moreHelp => GetText("cmd_moreHelp");
    public static string cmd_header => GetText("cmd_header");
    public static string cmd_muxImport => GetText("cmd_muxImport");
    public static string cmd_muxImport_more => GetText("cmd_muxImport_more");
    public static string cmd_selectVideo => GetText("cmd_selectVideo");
    public static string cmd_dropVideo => GetText("cmd_dropVideo");
    public static string cmd_selectVideo_more => GetText("cmd_selectVideo_more");
    public static string cmd_selectAudio => GetText("cmd_selectAudio");
    public static string cmd_dropAudio => GetText("cmd_dropAudio");
    public static string cmd_selectAudio_more => GetText("cmd_selectAudio_more");
    public static string cmd_selectSubtitle => GetText("cmd_selectSubtitle");
    public static string cmd_dropSubtitle => GetText("cmd_dropSubtitle");
    public static string cmd_selectSubtitle_more => GetText("cmd_selectSubtitle_more");
    public static string cmd_custom_range => GetText("cmd_custom_range");
    public static string cmd_customHLSMethod => GetText("cmd_customHLSMethod");
    public static string cmd_customHLSKey => GetText("cmd_customHLSKey");
    public static string cmd_customHLSIv => GetText("cmd_customHLSIv");
    public static string cmd_Input => GetText("cmd_Input");
    public static string cmd_forceAnsiConsole => GetText("cmd_forceAnsiConsole");
    public static string cmd_noAnsiColor => GetText("cmd_noAnsiColor");
    public static string cmd_keys => GetText("cmd_keys");
    public static string cmd_keyText => GetText("cmd_keyText");
    public static string cmd_loadKeyFailed => GetText("cmd_loadKeyFailed");
    public static string cmd_logLevel => GetText("cmd_logLevel");
    public static string cmd_MP4RealTimeDecryption => GetText("cmd_MP4RealTimeDecryption");
    public static string cmd_saveDir => GetText("cmd_saveDir");
    public static string cmd_saveName => GetText("cmd_saveName");
    public static string cmd_savePattern => GetText("cmd_savePattern");
    public static string cmd_skipDownload => GetText("cmd_skipDownload");
    public static string cmd_noDateInfo => GetText("cmd_noDateInfo");
    public static string cmd_noLog => GetText("cmd_noLog");
    public static string cmd_allowHlsMultiExtMap => GetText("cmd_allowHlsMultiExtMap");
    public static string cmd_skipMerge => GetText("cmd_skipMerge");
    public static string cmd_subFormat => GetText("cmd_subFormat");
    public static string cmd_subOnly => GetText("cmd_subOnly");
    public static string cmd_subtitleFix => GetText("cmd_subtitleFix");
    public static string cmd_threadCount => GetText("cmd_threadCount");
    public static string cmd_downloadRetryCount => GetText("cmd_downloadRetryCount");
    public static string cmd_httpRequestTimeout => GetText("cmd_httpRequestTimeout");
    public static string cmd_tmpDir => GetText("cmd_tmpDir");
    public static string cmd_uiLanguage => GetText("cmd_uiLanguage");
    public static string cmd_urlProcessorArgs => GetText("cmd_urlProcessorArgs");
    public static string cmd_useShakaPackager => GetText("cmd_useShakaPackager");
    public static string cmd_useMp4decrypt => GetText("cmd_useMp4decrypt");
    public static string cmd_concurrentDownload => GetText("cmd_concurrentDownload");
    public static string cmd_useSystemProxy => GetText("cmd_useSystemProxy");
    public static string cmd_customProxy => GetText("cmd_customProxy");
    public static string cmd_customRange => GetText("cmd_customRange");
    public static string cmd_liveKeepSegments => GetText("cmd_liveKeepSegments");
    public static string cmd_livePipeMux => GetText("cmd_livePipeMux");
    public static string cmd_liveRecordLimit => GetText("cmd_liveRecordLimit");
    public static string cmd_taskStartAt => GetText("cmd_taskStartAt");
    public static string cmd_liveWaitTime => GetText("cmd_liveWaitTime");
    public static string cmd_liveTakeCount => GetText("cmd_liveTakeCount");
    public static string cmd_liveFixVttByAudio => GetText("cmd_liveFixVttByAudio");
    public static string cmd_liveRealTimeMerge => GetText("cmd_liveRealTimeMerge");
    public static string cmd_livePerformAsVod => GetText("cmd_livePerformAsVod");
    public static string cmd_muxAfterDone => GetText("cmd_muxAfterDone");
    public static string cmd_muxAfterDone_more => GetText("cmd_muxAfterDone_more");
    public static string cmd_writeMetaJson => GetText("cmd_writeMetaJson");
    public static string liveLimit => GetText("liveLimit");
    public static string realTimeDecMessage => GetText("realTimeDecMessage");
    public static string liveLimitReached => GetText("liveLimitReached");
    public static string saveName => GetText("saveName");
    public static string taskStartAt => GetText("taskStartAt");
    public static string namedPipeCreated => GetText("namedPipeCreated");
    public static string namedPipeMux => GetText("namedPipeMux");
    public static string partMerge => GetText("partMerge");
    public static string fetch => GetText("fetch");
    public static string ffmpegMerge => GetText("ffmpegMerge");
    public static string ffmpegNotFound => GetText("ffmpegNotFound");
    public static string fixingTTML => GetText("fixingTTML");
    public static string fixingTTMLmp4 => GetText("fixingTTMLmp4");
    public static string fixingVTT => GetText("fixingVTT");
    public static string fixingVTTmp4 => GetText("fixingVTTmp4");
    public static string keyProcessorNotFound => GetText("keyProcessorNotFound");
    public static string liveFound => GetText("liveFound");
    public static string loadingUrl => GetText("loadingUrl");
    public static string masterM3u8Found => GetText("masterM3u8Found");
    public static string allowHlsMultiExtMap => GetText("allowHlsMultiExtMap");
    public static string matchDASH => GetText("matchDASH");
    public static string matchMSS => GetText("matchMSS");
    public static string matchTS => GetText("matchTS");
    public static string matchHLS => GetText("matchHLS");
    public static string notSupported => GetText("notSupported");
    public static string parsingStream => GetText("parsingStream");
    public static string promptChoiceText => GetText("promptChoiceText");
    public static string promptInfo => GetText("promptInfo");
    public static string promptTitle => GetText("promptTitle");
    public static string readingInfo => GetText("readingInfo");
    public static string searchKey => GetText("searchKey");
    public static string segmentCountCheckNotPass => GetText("segmentCountCheckNotPass");
    public static string selectedStream => GetText("selectedStream");
    public static string startDownloading => GetText("startDownloading");
    public static string streamsInfo => GetText("streamsInfo");
    public static string writeJson => GetText("writeJson");
    public static string noStreamsToDownload => GetText("noStreamsToDownload");
    public static string newVersionFound => GetText("newVersionFound");
    public static string processImageSub => GetText("processImageSub");
    public static string onlyInit => GetText("onlyInit")

    private static string GetText(string key)
    {
        if (!StaticText.LANG_DIC.ContainsKey(key))
            return "<...LANG TEXT MISSING...>";

        if (CurrentLoc == "zh-CN" || CurrentLoc == "zh-SG" || CurrentLoc == "zh-Hans")
            return StaticText.LANG_DIC[key].ZH_CN;
        if (CurrentLoc.StartsWith("zh-"))
            return StaticText.LANG_DIC[key].ZH_TW;
        return StaticText.LANG_DIC[key].EN_US;
    }
}