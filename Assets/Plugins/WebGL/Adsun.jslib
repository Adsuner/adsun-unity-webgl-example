mergeInto(LibraryManager.library, {
  AdsunShow: function (blockIdPtr, debug) {
    var blockId = UTF8ToString(blockIdPtr);
    window.Adsun.init({ blockId: blockId, debug: !!debug }).show()
      .then(function () { SendMessage("AdsunManager", "OnAdsunReward", blockId); })
      .catch(function (r) { SendMessage("AdsunManager", "OnAdsunError", (r && r.description) || "error"); });
  }
});
